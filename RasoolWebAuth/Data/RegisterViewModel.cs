using System.ComponentModel.DataAnnotations;

namespace RasoolWebAuth.Data
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string? Username { get; set; }

        [Display(Name = "FirstName")]
        public string? FirstName { get; set; }

        [Display(Name = "LastName")]
        public string? LastName { get; set; }
    }
}
