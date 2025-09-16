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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialDal.GetAll();
        }

        public Testimonial GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Testimonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
