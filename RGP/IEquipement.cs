using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGP
{
    public interface IEquipement
    {
        string Nom { get; }
        int Endurance { get; }
        int Force { get; }
        int Agilite { get; }
        int Intelligence { get; }
        int CoutPA { get; }
    }
}
