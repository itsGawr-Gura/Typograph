using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Typograph;
using System;


namespace TypographTests
{
    [TestClass]
    public class TypoTests
    {
        [TestMethod]
        public void Typo_SpaceCheck_ReturnString()
        {
            //
            string text = "Hello        World    it's     me  MARIO!!";
            var typograph = new Typo();
            //
            var result = typograph.SpaceCheck(text);
            //
            result.Should().Be("Hello World it's me MARIO!!");
        }
        [TestMethod]
        public void Typo_ForgingReplace_ReturnString()
        {
            //
            string text = "Hello \"World\"";
            var typograph = new Typo();
            //
            var result = typograph.ForgingReplace(text);
            //
            result.Should().Be("Hello «World»");
        }
        [TestMethod]
        public void Typo_PlusMinus_ReturnString()
        {
            //
            string text = "I love Write +-,-+ and (+,−)";
            var typograph = new Typo();
            //
            var result = typograph.PlusMinus(text);
            //
            result.Should().Be("I love Write ±,± and ±");
        }
        [TestMethod]
        public void Typo_DashWithoutSpaces_ReturnString()
        {
            //
            string text = "Арбуз - это ягода";
            var typograph = new Typo();
            //
            var result = typograph.DashWithoutSpaces(text);
            //
            result.Should().Be("Арбуз-это ягода");
        }
        [TestMethod]
        public void Typo_Elipsis_ReturnString()
        {
            //
            string text = "It's elipsis...";
            var typograph = new Typo();
            //
            var result = typograph.Elipsis(text);
            //
            result.Should().Be("It's elipsis…");
        }
        [TestMethod]
        public void Typo_DungeonMaster_ReturnString()
        {
            //
            string text = "It's my master";
            var typograph = new Typo();
            //
            var result = typograph.DungeonMaster(text);
            //
            result.Should().Be("It's my Dungeon Mastеr!");
        }
        [TestMethod]
        public void Typo_FuckingDot_ReturnString()
        {
            //
            string text = "Common text.";
            var typograph = new Typo();
            //
            var result = typograph.FuckingDot(text);
            //
            result.Should().Be("Common text IT'S A FUCKING DOT!!! ");
        }
        [TestMethod]
        public void Typo_Weapon_ReturnString()
        {
            //
            string text = "Gun";
            var typograph = new Typo();
            //
            var result = typograph.Weapon(text);
            //
            result.Should().Be("︻デ═一");
        }
        [TestMethod]
        public void Typo_SpaceCheck_ReturnNotEmptyString()
        {
            //
            string text = "Common    Text";
            var typograph = new Typo();
            //
            var result = typograph.SpaceCheck(text);
            //
            result.Should().NotBeEmpty();
        }
        [TestMethod]
        public void Typo_SpaceCheck_ReturnNotNullString()
        {
            //
            string text = "Common    Text";
            var typograph = new Typo();
            //
            var result = typograph.SpaceCheck(text);
            //
            result.Should().NotBeNull();
        }




    }
}
