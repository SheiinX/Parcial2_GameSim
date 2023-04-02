using NUnit.Framework;
using System.Collections.Generic;
using Parcial2_GameSim;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture]
    public class CharacterTests
    {
        private Character testChar;
        private Weapon testWeapon;
        private Armor testArmor;

        [SetUp]
        public void SetUp()
        {
            testChar = new Character("TestChar", 10, 2, "Human");
            testWeapon = new Weapon("TestWeapon", 2, 10, "Human");
            testArmor = new Armor("TestArmor", 2, 10, "Human");
        }

        [Test]
        public void EquipWeapon_ShouldIncreaseCharacterATK()
        {
            // Arrange
            var character = new Character("Jaime", 100, 10, "Human");
            var weapon = new Weapon("Sword", 10, 10, "Human");

            // Act
            character.EquipWeapon(weapon);

            // Assert
            Assert.AreEqual(20, character.ATK);
        }

        [Test]
        public void EquipArmor_ShouldChangeCharacterArmor()
        {
            // Arrange
            var character = new Character("Jaime", 100, 10, "Human");
            var armor = new Armor("Leather Armor", 5, 5, "Human");

            // Act
            character.EquipArmor(armor);

            // Assert
            Assert.AreEqual(armor, character.armor);
        }

        [Test]
        public void DamageReceive_ShouldReduceCharacterHP()
        {
            // Arrange
            var character1 = new Character("Jaime", 100, 10, "Human");
            var character2 = new Character("Bob", 100, 10, "Human");
            character2.EquipWeapon(new Weapon("Sword", 10, 10,"Human"));

            // Act
            character1.DamageReceive(character2);

            // Assert
            Assert.AreEqual(80, character1.HP);
        }

        [Test]
        public void DamageInflicted_ShouldReduceWeaponDurability()
        {
            // Arrange
            var character1 = new Character("Jaime", 100, 10, "Human");
            var character2 = new Character("Bob", 100, 10, "Human");
            character1.EquipWeapon(new Weapon("Sword", 10, 10, "Human"));

            // Act
            character1.DamageInflicted();

            // Assert
            Assert.AreEqual(9, character1.weapon.Durability);
        }

        [TearDown]
        public void TearDown()
        {
            testChar = null;
            testWeapon = null;
            testArmor = null;
        }
    }
}