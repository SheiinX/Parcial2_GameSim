using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_GameSim
{
    class Character
    {
        private string name = "";
        private int hp = 0;
        private int atk = 0;
        private int def = 0;

        public enum Clase
        {
            Human,
            Beast,
            Hybrid
        }

        public string Name { get => name; set => name = value; }
        public int HP { get => hp; set => hp = value; }
        public int ATK { get => atk; set => atk = value; }
        public int DEF { get => def; set => def = value; }
    }
}
