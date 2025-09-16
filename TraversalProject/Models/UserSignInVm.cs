using System.ComponentModel.DataAnnotations;

namespace TraversalProject.Models
{
    public class UserSignInVm
    {
        [Required(ErrorMessage ="Please enter your username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
    }
}
