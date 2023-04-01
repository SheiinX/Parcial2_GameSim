using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_GameSim;

namespace TestGameSim
{      
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void EquipWeapon_ShouldIncreaseCharacterATK()
        {
            // Arrange
            var character = new Character("Jaime", 100, 10, "Human");
            var weapon = new Weapon("Sword", 10, "Human", 10);

            // Act
            character.EquipWeapon(weapon);

            // Assert
            Assert.AreEqual(20, character.ATK);
        }

        [TestMethod]
        public void EquipArmor_ShouldChangeCharacterArmor()
        {
            // Arrange
            var character = new Character("Jaime", 100, 10, "Human");
            var armor = new Armor("Leather Armor", 5, "Human");

            // Act
            character.EquipArmor(armor);

            // Assert
            Assert.AreEqual(armor, character.Armor);
        }

        [TestMethod]
        public void DamageReceive_ShouldReduceCharacterHP()
        {
            // Arrange
            var character1 = new Character("Jaime", 100, 10, "Human");
            var character2 = new Character("Bob", 100, 10, "Human");
            character2.EquipWeapon(new Weapon("Sword", 10, "Human", 10));

            // Act
            character1.DamageReceive(character2);

            // Assert
            Assert.AreEqual(90, character1.HP);
        }

        [TestMethod]
        public void DamageInflicted_ShouldReduceWeaponDurability()
        {
            // Arrange
            var character1 = new Character("Jaime", 100, 10, "Human");
            var character2 = new Character("Bob", 100, 10, "Human");
            character1.EquipWeapon(new Weapon("Sword", 10, "Human", 10));

            // Act
            character1.Attack(character2);

            // Assert
            Assert.AreEqual(9, character1.Weapon.Durability);
        }
    }
}