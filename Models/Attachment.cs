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
        public Firearm firearm;
        public Firearm Firearm
        {
            get { return firearm; }
            set 
            {
                if (value == null) 
                {
                    throw new Exception("Firearm couldn't be null");
                }
                firearm = value; 
                firearm.AddAttachment(this);
            }
        }
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

        public string GetShortInfo()
        {
            string info = string.Format("Attachment:\n\t IdAttachment: {0}, Name: {1}, Description: {2};", Id, Name, Description);

            return info;
        }
        public override string ToString()
        {
            return GetShortInfo() + Firearm.GetShortInfo();
        }
    }
}
