using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelaValdez.Training.Data.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }

        public Guid WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        public Guid? ContainerId { get; set; }
        public Item Container { get; set; }
        public List<Item> Items { get; set; }
        
    }
}
