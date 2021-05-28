using System;
using System.Collections.Generic;
using System.Text;

namespace PASTRY.DomainEntities
{
    public class Cake
    {
        public Cake(int id, int idImage, string name, decimal price, int weight)
        {
            Id = id;
            IdImage = idImage;
            Name = name;
            Price = price;
            Weight = weight;
        }

        public string Name { get; private set; }

        public int IdImage { get; private set; }

        public int Id { get; private set; }

        public decimal Price { get; private set; }

        public int Weight { get; private set; }
    }
}
