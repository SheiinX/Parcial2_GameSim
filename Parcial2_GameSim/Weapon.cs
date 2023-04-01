using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_GameSim
{
    public class Weapon : ICommonFunc
    {

        private string name = "";
        private int power = 1;
        private int durability = 1;
        private string classWeap = "";

        public enum EWeaponClass
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

        public string ClassWeapon { get => classWeap; set => classWeap = value; }

        public Weapon(string name, int power, int durability, string classW)
        {
            Name = name;
            Power = power;
            Durability = durability;
            ClassWeapon = AssigningClass(classW);
        }

        public string AssigningClass(string weaponClass)
        {
            EWeaponClass classHuman = EWeaponClass.Human;
            EWeaponClass classBeast = EWeaponClass.Beast;
            EWeaponClass classHybrid = EWeaponClass.Hybrid;
            EWeaponClass classAny = EWeaponClass.Any;

            if (weaponClass == classHuman.ToString())
            {
                return classHuman.ToString();
            }
            else if (weaponClass == classBeast.ToString())
            {
                return classBeast.ToString();
            }
            else if (weaponClass == classHybrid.ToString())
            {
                return classHybrid.ToString();
            }
            else if (weaponClass == classAny.ToString())
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
