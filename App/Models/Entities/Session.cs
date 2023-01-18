using System.ComponentModel.DataAnnotations;

namespace App.Models.Entities
{
    internal class Session : Entity
    {
        [Required]
        public string? Registration { get; set; }
        [Required]
        public string PasswordEncrypted { get; set; } = string.Empty;
        [Required]
        public string PasswordDecryptionKey { get; set; } = string.Empty;
    }
}
