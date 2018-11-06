using System.ComponentModel.DataAnnotations;

namespace cositas.Models
{
    public class Usuario
    {
        public int Id{get;set;}
        [Required]
        public string Nombre{get;set;}
        [EmailAddress]
        public string Email{get;set;}
        public int Edad{get;set;}
        [Required]
        public string Password{get;set;}
    }
}