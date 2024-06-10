using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGP; 

namespace RGP
{
    public class Guerrier : Personnage
    {
        public Guerrier(string nom) : base(nom)
        {
            GenererStats();
        }

        public override void GenererStats()
        {
            endurance = CLS_TiresDes.TiresDes(3, 10, new Random());
            force = CLS_TiresDes.TiresDes(3, 10, new Random());
            agilite = CLS_TiresDes.TiresDes(1, 10, new Random());
            intelligence = CLS_TiresDes.TiresDes(1, 10, new Random());
        }
    }
}
