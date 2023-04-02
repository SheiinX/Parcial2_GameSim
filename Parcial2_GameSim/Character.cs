using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_GameSim
{
    public class Character : ICommonFunc
    {
        private string name = "";
        private int hp = 1;
        private int atk = 0;
        //private int def = 0;
        //private int classChar = 0;
        private string classChar = "";
        public Weapon weapon;
        public Armor armor;

        internal enum EClass
        {
            Human,
            Beast,
            Hybrid
        }

        public string Name { get => name; set => name = value; }
        public int HP 
        { 
            get => hp;
            set
            {
                if (value > 0)
                {
                    hp = value;
                }
            }
                
        }

        public int ATK { get => atk; set => atk = value; }
        //public int DEF { get => def; set => def = value; }
        public string ClassChar { get => classChar; set => classChar = value; }

        public Character(string name, int hp, int atk, /*int def,*/ string classChar)
        {
            Name = name;
            HP = hp;
            ATK = atk;
            //DEF = def;
            ClassChar = AssigningClass(classChar);
        }

        public string AssigningClass(string eClass)
        {
            EClass classHuman = EClass.Human;
            EClass classBeast = EClass.Beast;
            EClass classHybrid = EClass.Hybrid;

            if (eClass == classHuman.ToString())
            {
                return classHuman.ToString();
            }
            else if(eClass == classBeast.ToString())
            {
                return classBeast.ToString();
            }
            else if (eClass == classHybrid.ToString())
            {
                return classHybrid.ToString();
            }
            else
            {
                return null;
            }
        }

        public void EquipWeapon(Weapon weaponEq)
        {
            do
            {
                if (weaponEq.ClassWeapon == ClassChar)
                {
                    weapon = weaponEq;
                    ATK += weapon.Power;
                }
                else if (weaponEq.ClassWeapon == "Any")
                {
                    weapon = weaponEq;
                    ATK += weapon.Power;
                }
                else
                {
                    break;
                }
            } 
            while (weapon == null);
        }

        public void EquipArmor(Armor armorEq)
        {
            do
            {
                if (armorEq.ClassArmor == ClassChar)
                {
                    armor = armorEq;
                }
                else if (armorEq.ClassArmor == "Any")
                {
                    armor = armorEq;
                }
                else
                {
                    break;
                }
            }
            while (armor == null);
        }

        public int DamageReceive(Character character)
        {
            int totalDamage = character.ATK;
            int temporalHp = HP;

            if (armor != null)
            {
                if(character.weapon != null)
                {
                    armor.Durability = totalDamage / 2;

                    if (armor.Durability <= 0)
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
                    if(totalDamage == 0)
                    {
                        armor.Durability -= 1;

                        if (armor.Durability <= 0)
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
                        armor.Durability = totalDamage / 2;

                        if (armor.Durability <= 0)
                        {
                            armor = null;
                            return 0;
                        }
                        else
                        {
                            return armor.Durability;
                        }
                    }
                    
                }

            }
            else
            {
                temporalHp -= totalDamage;
                
                if(temporalHp < 0)
                {
                    HP = 0;
                    return HP;
                }
                else
                {
                    HP -= totalDamage;
                    return HP;
                }
            }
        }

        public int DamageInflicted()
        {
            if(weapon != null)
            {
                weapon.Durability -= 1;
                if(weapon.Durability <= 0)
                {
                    weapon = null;
                    return 0;
                }
                else
                {
                    return weapon.Durability;
                }
            }
            else
            {
                return 0;
            }
        }
        /*
        public bool IsAlive()
        {
            if(hp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
