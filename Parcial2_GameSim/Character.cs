using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_GameSim
{
    internal class Character
    {
        private string name = "";
        private uint hp = 1;
        private uint atk = 0;
        private uint def = 0;
        Weapon weapon = new Weapon();
        Armor armor = new Armor();

        public enum Class
        {
            Human,
            Beast,
            Hybrid
        }

        public string Name { get => name; set => name = value; }
        public uint HP { get => hp; set => hp = value; }
        public uint ATK { get => atk; set => atk = value; }
        public uint DEF { get => def; set => def = value; }

        public void EquipWeapon(Weapon weaponEq)
        {
            weapon = weaponEq;
        }

        public void EquipArmor(Armor armorEq)
        {
            armor = armorEq;
        }

        public uint DamageReceive(Character character)
        {
            uint TotalDamage = character.weapon.Power;

            if (armor != null)
            {
                armor.Durability -= TotalDamage;

                if(armor.Durability == 0)
                {
                    armor = null;
                    return 0;
                }
                else
                {
                    return armor.Durability;
                }
                
            }
            else
            {
                hp -= TotalDamage;
                bool alive = IsAlive();

                if(alive == true)
                {
                    return hp;
                }
                else
                {
                    return 0;
                }
            }
        }

        public bool IsAlive()
        {
            if(hp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
