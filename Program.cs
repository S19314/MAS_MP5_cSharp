using Microsoft.EntityFrameworkCore;
using MP5.Models;
using System;
using System.Collections.Generic;


namespace MP5
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var dbContext = new ArmyDbContext()) 
            {
                ShowSoilders(dbContext);
                /*
                AddSoilders(dbContext);
                ShowSoilders(dbContext);
                RemoveSoilders(dbContext);
                ShowSoilders(dbContext);
                */
                
                ShowWarehouse(dbContext);
                /* 
                AddWarehouse(dbContext);
                
                ShowWarehouse(dbContext);
                RemoveWarehouse(dbContext);
                ShowWarehouse(dbContext);
                               */

                ShowFirearm(dbContext);

                //                AddFirearm(dbContext);
                /* 
                ShowFirearm(dbContext);
                RemoveFirearm(dbContext);
                ShowFirearm(dbContext);
                               */

                ShowSniperRifle(dbContext);

                //AddSniperRifle(dbContext);
                /* 
                ShowSniperRifle(dbContext);
                RemoveSniperRifle(dbContext);
                ShowSniperRifle(dbContext);
                               */

                ShowAssaultRifle(dbContext);

                //AddAssaultRifle(dbContext);
                /* 
                ShowAssaultRifle(dbContext);
                RemoveAssaultRifle(dbContext);
                ShowAssaultRifle(dbContext);
                               */

                ShowAttachment(dbContext);

                //AddAttachment(dbContext);
                /* 
                ShowAttachment(dbContext);
                RemoveAttachment(dbContext);
                ShowAttachment(dbContext);
                               */


            }

        }

        public static void ShowSoilders(ArmyDbContext dbContext) 
        {
            var soldiers = dbContext.Soldiers.ToListAsync().Result;
            Console.WriteLine("Soldiers");
            foreach (var soilder in soldiers)
            {
                Console.WriteLine(soilder);
            }
        }
        public static void ShowWarehouse(ArmyDbContext dbContext) 
        {
            var warehouses = dbContext.Warehouses.ToListAsync().Result;
            Console.WriteLine("warehouse");
            foreach (var warehouse in warehouses)
            {
                Console.WriteLine(warehouse);
            }
        }
        public static void ShowAttachment(ArmyDbContext dbContext) 
        {
            var attachments = dbContext.Attachments.ToListAsync().Result;
            Console.WriteLine("Attachments");
            foreach (var attachment in attachments)
            {
                Console.WriteLine(attachment);
            }
        }
        public static void ShowFirearm(ArmyDbContext dbContext) 
        {
            var firearms = dbContext.Firearms.ToListAsync().Result;
            Console.WriteLine("Firearms");
            foreach (var firearm in firearms)
            {
                Console.WriteLine(firearm);
            }
        }
        public static void ShowSniperRifle(ArmyDbContext dbContext) 
        {
            var sniperRifles = dbContext.SniperRifles.ToListAsync().Result;
            Console.WriteLine("SniperRifles");
            foreach (var sniperRifle in sniperRifles)
            {
                Console.WriteLine(sniperRifle);
            }
        }
        public static void ShowAssaultRifle(ArmyDbContext dbContext) 
        {
            var assaultRifles = dbContext.AssaultRifles.ToListAsync().Result;
            Console.WriteLine("SniperRifles");
            foreach (var assaultRifle in assaultRifles)
            {
                Console.WriteLine(assaultRifle);
            }
        }

        public static void AddSoilders(ArmyDbContext dbContext) 
        {
            Soldier soldier = new Soldier { FirstName = "John", SecondName = "Weak", Rank = "Silver" };
            Soldier soldier1 = new Soldier { FirstName = "John", SecondName = "Price", Rank = "Captain" };
            dbContext.Soldiers.Add(soldier);
            // dbContext.Soldiers.Add(soldier1);
            dbContext.SaveChanges();
        }

        public static void RemoveSoilders(ArmyDbContext dbContext) 
        {
            var soilder = dbContext.Soldiers
                .FirstOrDefaultAsync(p => p.FirstName.Equals("John"))
                .Result;
            dbContext.Soldiers.Remove(soilder);
            dbContext.SaveChanges();

        }
        public static void AddWarehouse(ArmyDbContext dbContext) 
        {
            Warehouse warehouse = new Warehouse { Name = "Plamia", Address="Moscow", CapacityInBoxes = 1000 };

            dbContext.Warehouses.Add(warehouse);   
            dbContext.SaveChanges();
        }

        public static void RemoveWarehouse(ArmyDbContext dbContext) 
        {
            var warehouse = dbContext.Warehouses
                .FirstOrDefaultAsync(p => p.CapacityInBoxes < 1001)
                .Result;
            dbContext.Warehouses.Remove(warehouse);
            dbContext.SaveChanges();

        }
    
        public static void AddFirearm(ArmyDbContext dbContext) 
        {
            Firearm firearm = new Firearm { Name = "Oden", BulletSpeed=1123.2, FireDistance=999.0, MagazineSize=20, Weight=15.2};

            dbContext.Firearms.Add(firearm);   
            dbContext.SaveChanges();
        }

        public static void RemoveFirearm(ArmyDbContext dbContext) 
        {
            var firearm = dbContext.Firearms
                .FirstOrDefaultAsync(p => p.MagazineSize < 30)
                .Result;
            dbContext.Firearms.Remove(firearm);
            dbContext.SaveChanges();
        }

        public static void AddAssaultRifle(ArmyDbContext dbContext)
        {
            var firearm = new AssaultRifle { Name = "Oden", BulletSpeed = 1123.2, FireDistance = 999.0, MagazineSize = 20, Weight = 15.2, FireMode="2 bullets"};

            dbContext.Firearms.Add(firearm);
            dbContext.SaveChanges();
        }

        public static void RemoveAssaultRifle(ArmyDbContext dbContext)
        {
            var firearm = dbContext.AssaultRifles
                .FirstOrDefaultAsync(p => p.MagazineSize < 30)
                .Result;
            dbContext.Firearms.Remove(firearm);
            dbContext.SaveChanges();
        }
    
        public static void AddSniperRifle(ArmyDbContext dbContext)
        {
            var firearm = new SniperRifle { Name = "AX-50", BulletSpeed = 1323.2, FireDistance = 2999.0, MagazineSize = 5, Weight = 18.2,MinimalScopeMagnification=20, MaximalScopeMagnification=20};

            dbContext.Firearms.Add(firearm);
            dbContext.SaveChanges();
        }

        public static void RemoveSniperRifle(ArmyDbContext dbContext)
        {
            var firearm = dbContext.SniperRifles
                .FirstOrDefaultAsync(p => p.MinimalScopeMagnification < 30)
                .Result;
            dbContext.Firearms.Remove(firearm);
            dbContext.SaveChanges();
        }

        public static void AddAttachment(ArmyDbContext dbContext)
        {
            var bipod = new Attachment { Name = "Bipod", Description = "A bipod is a V-shaped portable attachment." };
            var firearm = new SniperRifle { Name = "AX-50", BulletSpeed = 1323.2, FireDistance = 2999.0, MagazineSize = 5, Weight = 18.2, MinimalScopeMagnification = 20, MaximalScopeMagnification = 20};
            firearm.Attachments.Add(bipod);

            dbContext.Firearms.Add(firearm);
            dbContext.Attachments.Add(bipod);
            dbContext.SaveChanges();
        }

        public static void RemoveAttachment(ArmyDbContext dbContext)
        {
            var attachment = dbContext.Attachments
                .FirstOrDefaultAsync(p => p.Name.Equals("Bipod"))
                .Result;
            dbContext.Attachments.Remove(attachment);
            dbContext.SaveChanges();
        }
    }
}
