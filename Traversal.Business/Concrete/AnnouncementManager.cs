using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Business.Abstract;
using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Abstract;

namespace Traversal.Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Add(Announcement entity)
        {
            _announcementDal.Add(entity);
        }

        public void Delete(Announcement entity)
        {
            _announcementDal.Delete(entity);
        }

        public List<Announcement> GetAll()
        {
            return _announcementDal.GetAll();
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public void Update(Announcement entity)
        {
            _announcementDal.Update(entity);
        }
    }
}
