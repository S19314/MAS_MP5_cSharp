using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP5.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? FirearmId { get; set; }
        public Firearm Firearm { get; set; }

        public Attachment()
        {
        }

        public Attachment(int id, string name, string description, int firearmId, Firearm firearm)
        {
            Id = id;
            Name = name;
            Description = description;
            FirearmId = firearmId;
            Firearm = firearm;
        }
        public Attachment(int id, string name, string description, int firearmId)
        {
            Id = id;
            Name = name;
            Description = description;
            FirearmId = firearmId;
        }
    }
}
