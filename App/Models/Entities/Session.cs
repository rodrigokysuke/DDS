using System.ComponentModel.DataAnnotations;

namespace App.Models.Entities
{
    internal class Session : Entity
    {
        [Required]
        public string? Registration { get; set; }
        [Required]
        public string? PasswordEncrypted { get; set; }
        [Required]
        public string? PasswordDecryptionKey { get; set; }
    }
}
