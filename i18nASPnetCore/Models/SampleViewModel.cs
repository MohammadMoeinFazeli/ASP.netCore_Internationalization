using System.ComponentModel.DataAnnotations;

namespace i18nASPnetCore.Models
{
    public class SampleViewModel
    {
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
