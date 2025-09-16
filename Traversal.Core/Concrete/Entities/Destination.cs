using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Core.Concrete.Entities
{
    public class Destination
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        public string CoverImage { get; set; }
        public string  FirstContent { get; set; }
        public string SecondContent { get; set; }
        public string Image2 { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
