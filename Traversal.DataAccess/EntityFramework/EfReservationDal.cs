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
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        private readonly AppDbContext _dbContext;
        public EfReservationDal(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = appDbContext;
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _dbContext.Reservations.Include(x => x.Destination).Where(x => x.Status == "Approved" && x.AppUserId == id).ToList();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _dbContext.Reservations.Include(x => x.Destination).Where(x => x.Status == "Past Booking" && x.AppUserId == id).ToList();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _dbContext.Reservations.Include(x=> x.Destination).Where(x => x.Status == "Awaiting Approval" && x.AppUserId == id).ToList();
        }
    }
}
