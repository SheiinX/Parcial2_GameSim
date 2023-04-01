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
        private int power = 1;
        private int durability = 1;
        private string classAr = "";

        public enum EArmorClass
        {
            Human,
            Beast,
            Hybrid,
            Any
        }

        public string Name { get => name; set => name = value; }
        public int Power
        {
            get => power;
            set
            {
                if (value > 0)
                {
                    power = value;
                }
            }

        }
        public int Durability
        {
            get => durability;
            set
            {
                if (value > 0)
                {
                    durability = value;
                }
            }

        }

        public string ClassArmor { get => classAr; set => classAr = value; }

        public Armor(string name, int power, int durability, string classW)
        {
            Name = name;
            Power = power;
            Durability = durability;
            ClassArmor = AssigningClass(classW);
        }

        public string AssigningClass(string armorClass)
        {
            EArmorClass classHuman = EArmorClass.Human;
            EArmorClass classBeast = EArmorClass.Beast;
            EArmorClass classHybrid = EArmorClass.Hybrid;
            EArmorClass classAny = EArmorClass.Any;

            if (armorClass == classHuman.ToString())
            {
                return classHuman.ToString();
            }
            else if (armorClass == classBeast.ToString())
            {
                return classBeast.ToString();
            }
            else if (armorClass == classHybrid.ToString())
            {
                return classHybrid.ToString();
            }
            else if (armorClass == classAny.ToString())
            {
                return classAny.ToString();
            }
            else
            {
                return null;
            }
        }

    }
}
