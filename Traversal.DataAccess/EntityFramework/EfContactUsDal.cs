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
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public EfContactUsDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            var values = _appDbContext.ContactUses.Where(x => x.MessageStatus == false).ToList();
            return values;
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            var values = _appDbContext.ContactUses.Where(x => x.MessageStatus == true).ToList();
            return values;
        }
    }
}
