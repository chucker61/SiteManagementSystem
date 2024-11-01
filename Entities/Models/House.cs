using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class House
    {
        public int Id { get; set; }
        public int Num { get; set; }
        public int ApartmentId { get; set; }
        public string AppUserId { get; set; }

        //relation
        public Apartment Apartment { get; set; }
        public AppUser AppUser { get; set; }
    }
}
