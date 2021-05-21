using System;
using System.Collections.Generic;
using System.Text;

namespace PASTRY.DomainEntities
{
    public class Cake
    {
        public int Id { get; set; }
        public int IdImage { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Weight { get; set; }

    }
}
