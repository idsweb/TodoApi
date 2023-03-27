// Customer.cs

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FieldEngineerApi.Models
{
    public class Customer
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string ContactNumber { get; set; } = null!;

        public virtual ICollection<Appointment> Appointments { get; set; } = null!;
    }
}