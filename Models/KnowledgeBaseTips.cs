// KnowledgeBaseTips.cs

using System.ComponentModel.DataAnnotations;

namespace FieldEngineerApi.Models
{
    public class KnowledgeBaseTip 
    {
        [Key]
        public long Id { get; set; }

        public long KnowledgeBaseBoilerPartId { get; set; }

        public virtual KnowledgeBaseBoilerPart KnowledgeBaseBoilerPart { get; set; } = null!;

        public string KnowledgeBaseEngineerId { get; set; } = null!;

        public virtual KnowledgeBaseEngineer KnowledgeBaseEngineer { get; set; } = null!;

        public string Subject { get; set; } = null!;

        public string Body { get; set; } = null!;
    }
}