using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_GameSim
{
    internal class Armor
    {
        private string name = "";
        private uint power = 1;
        private uint durability = 1;

        public enum WeaponClass
        {
            Human,
            Beast,
            Hybrid,
            Any
        }

        public string Name { get => name; set => name = value; }
        public uint Power { get => power; set => power = value; }
        public uint Durability { get => durability; set => durability = value; }

    }
}
