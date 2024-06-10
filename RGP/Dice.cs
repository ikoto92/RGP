using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGP
{
    internal class Dice
    {
        public int minValue = 1;
        public int maxValue;

        public Dice(int maxValue)
        {
            this.maxValue = maxValue;
        }

        public Dice(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public int Roll(Random rnd)
        {
            return rnd.Next(minValue, maxValue + 1);
        }
    }
}
