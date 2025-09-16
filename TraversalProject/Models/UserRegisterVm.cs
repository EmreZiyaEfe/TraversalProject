using System.ComponentModel.DataAnnotations;

namespace TraversalProject.Models
{
	public class UserRegisterVm
	{
		[Required(ErrorMessage ="Please enter your name.")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Please enter your surname.")]
		public string SurName { get; set; }

		[Required(ErrorMessage = "Please enter your username.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Please enter your mail.")]
		public string Mail { get; set; }
		
		[Required(ErrorMessage = "Please enter your password.")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Please enter your confirm password.")]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }



	}
}
