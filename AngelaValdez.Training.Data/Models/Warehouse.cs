using System;
using System.Collections.Generic;

namespace AngelaValdez.Training.Data.Models
{
    public class Warehouse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<Item> Items { get; set; }  
    }
}
