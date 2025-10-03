using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly AppDbContext _appDbContext;
        public EfCommentDal(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Comment> GetListCommentWithDestination()
        {
            return _appDbContext.Comments.Include(c => c.Destination).ToList();
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            return _appDbContext.Comments.Where(c => c.DestinationId == id).Include(x => x.AppUser).ToList();
        }
    }
}
