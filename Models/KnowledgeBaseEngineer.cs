// KnowledgeBaseEngineer.cs

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FieldEngineerApi.Models
{
    public class KnowledgeBaseEngineer
    {
        [Key]
        public string Id { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        public string ContactNumber { get; set; } = null!;

        public virtual ICollection<KnowledgeBaseTip> KnowledgeBaseTips { get; set; } = null!;
    }
}