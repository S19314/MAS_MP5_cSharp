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
    }
}
