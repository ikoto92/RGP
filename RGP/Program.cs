using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGP;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quel est le nom de votre personnage ? ");
        string nom = Console.ReadLine();

        Console.WriteLine("Choisissez votre classe :");
        Console.WriteLine("G. Guerrier");
        Console.WriteLine("R. Ranger");
        Console.WriteLine("M. Mage");

        char choixClasse;
        if (!char.TryParse(Console.ReadLine(), out choixClasse) || choixClasse < 'G' || choixClasse > 'M')
        {
            Console.WriteLine("Choix invalide, veuillez réessayer.");
            return;
        }

        Personnage personnage;
        switch (choixClasse)
        {
            case 'G':
                personnage = new Guerrier(nom);
                break;
            case 'R':
                personnage = new Ranger(nom);
                break;
            case 'M':
                personnage = new Mage(nom);
                break;
            default:
                personnage = null;
                break;
        }

        if (personnage != null)
        {
            // Afficher les statistiques du personnage choisi
            Console.WriteLine("\nStatistiques de votre personnage :");
            Console.WriteLine($"Nom : {personnage.Nom}");
            Console.WriteLine($"Endurance : {personnage.Endurance}");
            Console.WriteLine($"Force : {personnage.Force}");
            Console.WriteLine($"Agilité : {personnage.Agilite}");
            Console.WriteLine($"Intelligence : {personnage.Intelligence}");

            // Afficher le statut du personnage choisi
            if (personnage is Mage)
            {
                Console.WriteLine("Statut : Mage");
            }
            else if (personnage is Ranger)
            {
                Console.WriteLine("Statut : Ranger");
            }
            else if (personnage is Guerrier)
            {
                Console.WriteLine("Statut : Guerrier");
            }

            // Créer un deuxième personnage aléatoirement
            Random rand = new Random();
            int choixClasseAdversaire = rand.Next(1, 4);
            Personnage adversaire = null;
            switch (choixClasseAdversaire)
            {
                case 1:
                    adversaire = new Guerrier("Guerrier ennemi");
                    break;
                case 2:
                    adversaire = new Ranger("Ranger ennemi");
                    break;
                case 3:
                    adversaire = new Mage("Mage ennemi");
                    break;
            }

            // Vérifier si l'adversaire a des statistiques supérieures à celles du personnage
            bool adversairePlusFort = adversaire.Endurance > personnage.Endurance &&
                                         adversaire.Force > personnage.Force &&
                                         adversaire.Agilite > personnage.Agilite &&
                                         adversaire.Intelligence > personnage.Intelligence;

            // Afficher les statistiques de l'ennemi
            Console.WriteLine($"Votre ennemi est un {adversaire.GetType().Name} avec les statistiques suivantes :");
            Console.WriteLine($"Endurance : {adversaire.Endurance}");
            Console.WriteLine($"Force : {adversaire.Force}");
            Console.WriteLine($"Agilité : {adversaire.Agilite}");
            Console.WriteLine($"Intelligence : {adversaire.Intelligence}");

            // Demander à l'utilisateur s'il veut attaquer en fonction de la comparaison des statistiques
            if (adversairePlusFort)
            {
                Console.Write("Votre ennemi est plus fort que vous, voulez-vous quand même attaquer ? (o/n) ");
                string reponse = Console.ReadLine().ToLower();
                if (reponse != "o")
                {
                    Console.WriteLine("Vous avez décidé de ne pas attaquer.");
                    return;
                }
            }
            else
            {
                Console.Write("Votre ennemi est plus faible que vous, voulez-vous attaquer ? (o/n) ");
                string reponse = Console.ReadLine().ToLower();
                if (reponse != "o")
                {
                    Console.WriteLine("Vous avez décidé de ne pas attaquer.");
                    return;
                }
            }

            // Équiper le personnage choisi avec une arme
            personnage.EquiperArme(new Arme("Épée", 2, 1, 0, 0));

            // Faire combattre les deux personnages
            int degats = Combattre(personnage, adversaire);

            if (adversaire.Endurance <= 0)
            {
                Console.WriteLine($"{personnage.Nom} a vaincu {adversaire.Nom} !");
            }
            else
            {
                Console.WriteLine($"{personnage.Nom} inflige {degats} points de dégâts à {adversaire.Nom}.");
            }
        }
    }

        public static int Combattre(Personnage attaquant, Personnage defendeur)
        {
        // Calculer les dégâts infligés à l'adversaire en fonction de la force et des bonus de l'arme
        int degats = attaquant.Force + (attaquant.Equipement != null && attaquant.Equipement is Arme ? ((Arme)attaquant.Equipement).BonusForce : 0);

        // Réduire les dégâts en fonction de l'endurance de l'adversaire
        degats = Math.Max(0, degats - defendeur.Endurance);

        // Réduire l'endurance de l'adversaire en fonction des dégâts infligés
        defendeur.Endurance = Math.Max(0, defendeur.Endurance - degats);

        // Vérifier si l'adversaire a été vaincu
        if (defendeur.Endurance <= 0)
        {
            Console.WriteLine($"{attaquant.Nom} a vaincu {defendeur.Nom} !");
        }
        else
        {
            Console.WriteLine($"{attaquant.Nom} inflige {degats} points de dégâts à {defendeur.Nom}.");
        }

        // Renvoie la valeur des dégâts infligés à l'adversaire
        return degats;
    }
}
