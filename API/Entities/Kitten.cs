using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Kitten
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {get; set;}
        public string Description { get; set; }
        public long Price { get; set; }
        public string PictureUrl { get; set; }
        public string Breed { get; set; }
        public int QuantityInStock { get; set; }

    }
}