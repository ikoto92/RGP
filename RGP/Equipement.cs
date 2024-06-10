using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGP
{
    public abstract class Equipement : IEquipement
    {
        private string nom;
        private int bonusEndurance;
        private int bonusForce;
        private int bonusAgilite;
        private int bonusIntelligence;

        public string Nom { get; set; }
        public int Endurance { get; set; }
        public int Force { get; set; }
        public int Agilite { get; set; }
        public int Intelligence { get; set; }
        public int CoutPA { get; set; }

        public Equipement(string nom, int bonusEndurance, int bonusForce, int bonusAgilite, int bonusIntelligence)
        {
            this.nom = nom;
            this.bonusEndurance = bonusEndurance;
            this.bonusForce = bonusForce;
            this.bonusAgilite = bonusAgilite;
            this.bonusIntelligence = bonusIntelligence;
        }

        public int BonusEndurance
        {
            get { return bonusEndurance; }
        }

        public int BonusForce
        {
            get { return bonusForce; }
        }

        public int BonusAgilite
        {
            get { return bonusAgilite; }
        }

        public int BonusIntelligence
        {
            get { return bonusIntelligence; }
        }
    }
}
