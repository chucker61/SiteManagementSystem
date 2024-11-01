using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }

        //relation
        public Site Site { get; set; }
        public ICollection<House> Houses { get; set; }

    }
}
