using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_2;

namespace UnitTest_Lab2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEveningDress()
        {
            var director = new Director();
            var designer = new DressDesigner();
            director.Designer = designer;
            director.MakeEveningDress();
            var actual = designer.GetDress().ListParts();
            var expected = "Info about dress : type - evening dress, fabric - satin, length - maxi, with embroidery";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCocktailDress()
        {
            var director = new Director();
            var designer = new DressDesigner();
            director.Designer = designer;
            director.MakeCocktailDress();
            var actual = designer.GetDress().ListParts();
            var expected = "Info about dress : type - cocktail dress, fabric - chiffon, length - midi";
            Assert.AreEqual(expected, actual);
        }
    }
}
