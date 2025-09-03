using System.ComponentModel.DataAnnotations;

namespace ClienteAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        
        [Required]
        public string Nombre { get; set; } = string.Empty;
        
        [EmailAddress]
        public string CorreoElectronico { get; set; } = string.Empty;
        
        public string Telefono { get; set; } = string.Empty;
    }
}