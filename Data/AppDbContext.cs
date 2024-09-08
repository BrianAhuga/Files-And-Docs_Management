using DocumentUploader_MVCCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DocumentUploader_MVCCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Document> Documents { get; set; }
    }
}
