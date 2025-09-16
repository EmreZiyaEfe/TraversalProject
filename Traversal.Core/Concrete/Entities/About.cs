using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Core.Concrete.Entities
{
    public class About
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FirstImage { get; set; }
        public string SecondTitle { get; set; }
        public string SecondDescription { get; set; }
        public string SecondImage { get; set; }


        public bool Status { get; set; }

    }
}
