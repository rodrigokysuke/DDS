using App.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models.Entities
{
    internal class Signature : Entity
    {
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        [Required]
        public Employee? Employee { get; set; }

        [ForeignKey(nameof(Event))]
        public int EventId { get; set; }
        [Required]
        public Event? Event { get; set; }

        [Required]
        public Status Status { get; set; }
    }
}
