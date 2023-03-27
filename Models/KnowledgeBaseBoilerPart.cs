// KnowledgeBaseBoilerPart.cs

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FieldEngineerApi.Models
{
    public class KnowledgeBaseBoilerPart
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; } = null!;

        public string Overview { get; set; } = null!;

        public virtual ICollection<KnowledgeBaseTip> KnowledgeBaseTips { get; set; } = null!;
    }
}