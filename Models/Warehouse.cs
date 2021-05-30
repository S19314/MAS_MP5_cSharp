using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP5.Models
{
    public class Warehouse
    {
        public int IdWarehouse { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CapacityInBoxes { get; set; }

        public Warehouse()
        {
        }

        public Warehouse(int idWarehouse, string name, string address, int capacityInBoxes)
        {
            this.IdWarehouse = idWarehouse;
            this.Name = name;
            this.Address = address;
            this.CapacityInBoxes = capacityInBoxes;
        }

        
    }
}
