using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Core.Concrete.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TypeDate { get; set; }
        public string Content { get; set; }
        public bool State { get; set; }

        public int DestinationId { get; set; }
        public Destination Destination { get; set; }

    }
}
