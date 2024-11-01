using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        //relations
        public List<AppUser> AppUser { get; set; }
    }
}
