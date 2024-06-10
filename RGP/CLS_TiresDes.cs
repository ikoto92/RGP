using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGP
{
   
    public static class CLS_TiresDes
    {
        public static int TiresDes(int nbDes, int nbFaces, Random rnd)
        {
            int total = 0;

            Dice d = new Dice(nbFaces);

            for (int i = 0; i < nbDes; i++)
            {
                total += d.Roll(rnd);
            }

            return total;
        }
    }
}
