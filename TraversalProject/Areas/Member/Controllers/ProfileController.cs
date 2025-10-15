using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.Core.Concrete.Entities;
using TraversalProject.Areas.Member.Models;

namespace TraversalProject.Areas.Member.Controllers
{
	[Area("Member")]
    [Authorize(Roles = "Member")]
    [Route("Member/[controller]/[action]")]
	public class ProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

		[HttpGet]
        public async Task<IActionResult> Index()
		{
			var values =await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditVm vm = new UserEditVm();
			vm.Name = values.Name;
			vm.SurName = values.Surname;
			vm.PhoneNumber = values.PhoneNumber;
			vm.Mail = values.Email;
			return View(vm);
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserEditVm model)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (model.Image != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(model.Image.FileName);
				var imageName = Guid.NewGuid() + extension;
				var saveLocation = resource + "/wwwroot/UserImages/" + imageName;
				var stream = new FileStream(saveLocation, FileMode.Create);
				await model.Image.CopyToAsync(stream);
				user.ImageUrl = imageName;
			}
			user.Name = model.Name;
			user.Surname = model.SurName;
			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
			var result = await _userManager.UpdateAsync(user);
			if (result.Succeeded)
			{
				return RedirectToAction("SignIn", "Login", new {area =""});
			}
			return View();
		}
	}
}
