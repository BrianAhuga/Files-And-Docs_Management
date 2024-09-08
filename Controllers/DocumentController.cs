using DocumentUploader_MVCCore.Data;
using DocumentUploader_MVCCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace DocumentUploader_MVCCore.Controllers
{
    public class DocumentController : Controller
    {
        private readonly AppDbContext _context;

        public DocumentController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var documents = await _context.Documents.ToListAsync();
            return View(documents);
        }


        public async Task<IActionResult> ViewDocument(int id)
        {
            var document = await _context.Documents.FindAsync(id);
            if (document == null)
                return NotFound();

            return File(document.Data, document.ContentType);
        }


        public IActionResult Upload()
        {
            ViewBag.DocumentTypes = GetDocumentTypes(); 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file, string documentType)
        {
            if (file == null || file.Length == 0 || string.IsNullOrEmpty(documentType))
            {
                ViewBag.DocumentTypes = GetDocumentTypes();
                ViewBag.Error = "Please select a file and document type.";
                return View();
            }

            
            if (!IsValidFileType(file, documentType))
            {
                ViewBag.DocumentTypes = GetDocumentTypes();
                ViewBag.Error = "Invalid file type selected.";
                return View();
            }

            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);

                var document = new Document
                {
                    FileName = file.FileName,
                    Data = memoryStream.ToArray(),
                    ContentType = file.ContentType,
                    DocumentType = documentType
                };

                _context.Documents.Add(document);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Download(int id)
        {
            var document = await _context.Documents.FindAsync(id);
            if (document == null)
                return NotFound();

            return File(document.Data, document.ContentType, document.FileName);
        }

        
        private List<string> GetDocumentTypes()
        {
            return new List<string> { "PDF", "Excel", "CSV", "PPT", "Word", "Image", "Text" };
        }

        
        private bool IsValidFileType(IFormFile file, string documentType)
        {
            var allowedExtensions = new Dictionary<string, List<string>>
            {
                { "PDF", new List<string> { ".pdf" } },
                { "Excel", new List<string> { ".xls", ".xlsx" } },
                { "CSV", new List<string> { ".csv" } },
                { "PPT", new List<string> { ".ppt", ".pptx" } },
                { "Word", new List<string> { ".doc", ".docx" } },
                { "Image", new List<string> { ".jpg", ".jpeg", ".png", ".gif" } },
                { "Text", new List<string> { ".txt" } }
            };

            var fileExtension = Path.GetExtension(file.FileName).ToLower();
            return allowedExtensions.ContainsKey(documentType) && allowedExtensions[documentType].Contains(fileExtension);
        }
    }
}
