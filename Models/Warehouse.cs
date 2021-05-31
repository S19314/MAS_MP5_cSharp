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
        public string GetShortInfo()
        {
            string info = string.Format("Warehouse:\n\t IdWarehouse: {0}, Name: {1}, Address: {2}, CapacityInBoxes: {3};", IdWarehouse, Name, Address, CapacityInBoxes);

            return info;
        }
        public override string ToString()
        {
            return GetShortInfo();
        }

    }
}
