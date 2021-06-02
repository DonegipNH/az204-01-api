using System;
using System.Collections.Generic;

namespace AZ204.Demo.Domain.Entities
{
    public class Artist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}