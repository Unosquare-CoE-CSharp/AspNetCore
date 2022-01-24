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
        //TODO: Separate navigation properties
        //TODO: What types do we have? 
        //TODO: What status do we have ?
        //TODO: Guid vs Ids ? 
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }

        public Guid WarehouseId { get; set; }

        public Guid? ContainerId { get; set; }



        //Navigation Properties
        public Item Container { get; set; }
        public List<Item> Items { get; set; }

        public Warehouse Warehouse { get; set; }


    }
}
