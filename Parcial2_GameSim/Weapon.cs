using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_GameSim
{
    internal class Weapon
    {

        private string name = "";
        private int power = 0;
        private int durability = 0;

        public enum WeaponClass
        {
            Human,
            Beast,
            Hybrid,
            Any
        }

        public string Name { get => name; set => name = value; }
        public int Power { get => power; set => power = value; }
        public int Durability { get => durability; set => durability = value; }

    }
}
