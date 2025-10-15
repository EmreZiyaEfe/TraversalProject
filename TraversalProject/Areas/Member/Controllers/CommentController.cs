using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Member.Controllers
{
	[Area("Member")]
    [Authorize(Roles = "Member")]
    public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
