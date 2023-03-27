// KnowledgeBaseContext.cs

using Microsoft.EntityFrameworkCore;

namespace FieldEngineerApi.Models
{
    public class KnowledgeBaseContext : DbContext
    {
        public KnowledgeBaseContext(DbContextOptions<KnowledgeBaseContext> options)
            : base(options)
        {

        }   

        public DbSet<KnowledgeBaseBoilerPart> BoilerParts { get; set; } = null!;

        public DbSet<KnowledgeBaseEngineer> Engineers { get; set; } = null!;

        public DbSet<KnowledgeBaseTip> Tips { get; set; } = null!;
    }
}