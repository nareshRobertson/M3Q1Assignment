using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M3Q1.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public virtual MenuItem MenuItems { get; set; }

        //public virtual ICollection<MenuItem> MenuItems { get; set; }
        //public MenuItem MenuItems { get; set; }

    }
}
