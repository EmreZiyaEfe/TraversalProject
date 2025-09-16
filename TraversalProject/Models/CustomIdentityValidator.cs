using Microsoft.AspNetCore.Identity;

namespace TraversalProject.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Password must be {length} characters"
			};
		}
	}
}
