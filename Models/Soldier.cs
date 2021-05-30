using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP5.Models
{
    public class Soldier
    {
        public int IdSoldier { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Rank { get; set; }


        public Soldier()
        {
        }

        public Soldier(int idSoldier, string firstName, string secondName, string rank)
        {
            this.IdSoldier = idSoldier;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Rank = rank;
        }
    }
}
