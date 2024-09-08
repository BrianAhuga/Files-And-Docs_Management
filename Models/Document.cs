using System.ComponentModel.DataAnnotations;

namespace DocumentUploader_MVCCore.Models
{
    public class Document
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        [Required]
        public byte[] Data { get; set; }

        [Required]
        [StringLength(100)]
        public string ContentType { get; set; }

        [Required]
        [StringLength(50)]
        public string DocumentType { get; set; }

        [Required]
        public DateTime UploadedOn { get; set; } = DateTime.Now;
    }
}
