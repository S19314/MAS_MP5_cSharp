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


        public void AddAttachment(Attachment attachment)
        {
            if (attachment == null)
            {
                throw new Exception("Attachment couldn't be null");
            }
            Attachments.Add(attachment);
            attachment.Firearm = this;
        }
        public void RemoveAttachment(Attachment attachment) 
        { 
            if(attachment == null) 
            {
                throw new Exception("Attachment couldn't be null" );
            }
            Attachments.Remove(attachment); 
            attachment.Firearm = null; 
        }



        public virtual string GetShortInfo()
        {
            string info = string.Format("Id: {0}, Name: {1},  MagazineSize{2}, Weight{3}, BulletSpeed{4}, FireDistance{5};", Id, Name, MagazineSize, Weight, BulletSpeed, FireDistance);

            return info;
        }
        public string GetAttachmentsInfo() 
        {
            string attachments = " ";
            if (Attachments == null) 
            {
                return attachments;
            }
            foreach (var attachment in Attachments)
            {
                attachments += attachment.GetShortInfo() + "\n\t";
            }
            return attachments;
        }
        public override string ToString()
        {
            return GetShortInfo() + GetAttachmentsInfo();
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

        public string GetShortInfoAssaultRifle()
        {
            string info = " AssaultRifle: FireMode: " + FireMode + " " + GetShortInfo();
            
            return info;
        }
        public override string ToString()
        {
            return GetShortInfoAssaultRifle() + GetAttachmentsInfo();
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

        public string GetShortInfoSniperRifle()
        {
            // string info = string.Format("SniperRifle:  MinimalScopeMagnification: {0}, MaximalScopeMagnification: {1]", MinimalScopeMagnification, MaximalScopeMagnification);
            string info =  " SniperRifle:  MinimalScopeMagnification: " + MinimalScopeMagnification + ", MaximalScopeMagnification: " + MaximalScopeMagnification + " " + GetShortInfo();

            return info;
        }
        public override string ToString()
        {
            return GetShortInfoSniperRifle() + GetAttachmentsInfo();
        }
    }
}
