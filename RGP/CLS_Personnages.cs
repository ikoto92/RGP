using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGP
{
    public abstract class Personnage
    {
        protected string nom;
        protected int endurance;
        protected int force;
        protected int agilite;
        protected int intelligence;
        public Equipement Equipement { get; set; }
        public Arme Arme { get; private set; }

        public Personnage(string nom)
        {
            this.nom = nom;
        }

        public void EquiperArme(Arme arme)
        {
            Arme = arme;
        }

        public string Nom { get => nom; }
        public int Endurance { get => endurance; set => endurance = value; } // ajoute un accesseur set à la propriété Endurance
        public int Force { get => force; }
        public int Agilite { get => agilite; }
        public int Intelligence { get => intelligence; }

        protected int LancerDe(int nbFaces)
        {
            Random rnd = new Random();
            return rnd.Next(1, nbFaces + 1);
        }

        public abstract void GenererStats();
    }
}

