using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ204.Demo.Domain.Entities
{
    public class Item
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LabelName { get; set; }
        public Price Price { get; set; }
        public DateTimeOffset Release { get; set; }
        public int AvailableStock { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public Guid ArtitstId { get; set; }
        public Artist Artitst { get; set; }

    }
}
