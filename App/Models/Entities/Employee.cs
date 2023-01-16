using App.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace App.Models.Entities
{
    internal class Employee : Entity
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Registration { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public Role Role { get; set; }

        [Required]
        public string? Signature { get; set; }
    }
}
