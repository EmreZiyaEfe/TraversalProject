using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Business.Concrete;
using Traversal.DataAccess.Concrete;

namespace TraversalProject.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        private readonly ICommentService _commentService;
        private readonly AppDbContext _appDbContext;

        public _CommentList(ICommentService commentService, AppDbContext appDbContext)
        {
            _commentService = commentService;
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = _appDbContext.Comments.Where(x=> x.DestinationId == id).Count();
            var values = _commentService.TGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
