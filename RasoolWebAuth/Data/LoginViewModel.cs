using System.ComponentModel.DataAnnotations;

namespace RasoolWebAuth.Data
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string? Username { get; set; }
    }
}
