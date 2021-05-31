using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP5.Models
{
    public class Firearm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MagazineSize { get; set; }
        public double Weight { get; set; }
        public double BulletSpeed { get; set; }
        public double FireDistance { get; set; }

        public ICollection<Attachment> Attachments { get; set; }

        public Firearm()
        {
        }
        public Firearm(int id, string name, int magazineSize, double weight, double bulletSpeed, double fireDistance)
        {
            Id = id;
            Name = name;
            MagazineSize = magazineSize;
            Weight = weight;
            BulletSpeed = bulletSpeed;
            FireDistance = fireDistance;
        }


        public virtual string GetShortInfo()
        {
            string info = string.Format("Id: {0}, Name: {1},  MagazineSize{2}, Weight{3}, BulletSpeed{4}, FireDistance{5};", Id, Name, MagazineSize, Weight, BulletSpeed, FireDistance);

            return info;
        }
        public override string ToString()
        {
            return GetShortInfo();
        }


    }

    public class AssaultRifle : Firearm
    {
        public string FireMode { get; set; }

        public AssaultRifle() 
        {
        }
        public AssaultRifle(string fireMode) : base()
        {
            FireMode = fireMode;
        }

        public AssaultRifle(int id, string name, int magazineSize, double weight, double bulletSpeed, double fireDistance, string fireMode) : base(id, name, magazineSize, weight, bulletSpeed, fireDistance)
        {
            FireMode = fireMode;
        }

        public override string GetShortInfo()
        {
            string info = string.Format("AssaultRifle: FireMode: {0}", FireMode);
            // info += base.GetShortInfo();
            return info;
        }
        public override string ToString()
        {
            return GetShortInfo() + base.ToString();
        }
    }

    public class SniperRifle : Firearm
    {
        public double MinimalScopeMagnification { get; set; }
        public double MaximalScopeMagnification { get; set; }
        public SniperRifle()
        {
        }

        public SniperRifle(int id, string name, int magazineSize, double weight, double bulletSpeed, double fireDistance, double maximalScopeMagnification, double minimalScopeMagnification) : base(id, name, magazineSize, weight, bulletSpeed, fireDistance)
        {
            MaximalScopeMagnification = maximalScopeMagnification;
            MinimalScopeMagnification = minimalScopeMagnification;
        }

        public override string GetShortInfo()
        {
            string info = string.Format("SniperRifle:  MinimalScopeMagnification: {0}, MaximalScopeMagnification: {1]", MinimalScopeMagnification, MaximalScopeMagnification);
            // info += base.GetShortInfo();
            return info;
        }
        public override string ToString()
        {
            return GetShortInfo() + base.ToString();
        }
    }
}
