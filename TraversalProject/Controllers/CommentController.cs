using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.Core.Concrete.Entities;

namespace TraversalProject.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.destId = id;
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.TypeDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.State = true;
            _commentService.Add(comment);
            return RedirectToAction("Index", "Destination");
        }
    }
}
