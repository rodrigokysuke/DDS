using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models.Entities
{
    internal class Event : Entity
    {
        [Required]
        public string? Name { get; set; }
        public DateTime? RealizationDate { get; set; }

        [ForeignKey(nameof(Employee))]
        public int SupervisorId { get; set; }
        [Required]
        public Employee? Supervisor { get; set; }
    }
}
