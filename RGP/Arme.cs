using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGP
{
    public class Arme : Equipement
    {
        public Arme(string nom, int bonusEndurance, int bonusForce, int bonusAgilite, int bonusIntelligence)
            : base(nom, bonusEndurance, bonusForce, bonusAgilite, bonusIntelligence)
        {
        }
    }
}
