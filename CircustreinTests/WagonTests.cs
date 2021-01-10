using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Logic.Type;

namespace CircustreinTests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        public void AddAnimalToFullWagonTest()
        {
            //Arrange
            Wagon wagon = new Wagon();
            Animal GrootteHerbi1 = new Animal(Type.Herbi, Size.Big);
            Animal GrootteHerbi2 = new Animal(Type.Herbi, Size.Big);
            Animal GrootteHerbi3 = new Animal(Type.Herbi, Size.Big);


            //Act
            wagon.AddAnimal(GrootteHerbi1);
            wagon.AddAnimal(GrootteHerbi2);

            var result = wagon.AddAnimal(GrootteHerbi3);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void AddAnimalToEmptyWagonTest()
        {
            //Arrange
            Wagon wagon = new Wagon();
            Animal GrootteHerbi1 = new Animal(Type.Herbi, Size.Big);

            //Act
            var result = wagon.AddAnimal(GrootteHerbi1);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void AddAnimalToHalfFullWagonTest_Succesfull()
        {
            //Arrange
            Wagon wagon = new Wagon();
            Animal GrootteHerbi1 = new Animal(Type.Herbi, Size.Big);
            Animal GrootteHerbi2 = new Animal(Type.Herbi, Size.Medium);
            Animal GrootteHerbi3 = new Animal(Type.Herbi, Size.Small);

            //Act
            wagon.AddAnimal(GrootteHerbi1);
            wagon.AddAnimal(GrootteHerbi2);

            var result = wagon.AddAnimal(GrootteHerbi3);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void AddAnimalToHalfFullWagonTest_UnSuccesfull()
        {
            //Arrange
            Wagon wagon = new Wagon();
            Animal GrootteHerbi1 = new Animal(Type.Herbi, Size.Big);
            Animal GrootteHerbi2 = new Animal(Type.Herbi, Size.Medium);
            Animal GrootteHerbi3 = new Animal(Type.Herbi, Size.Medium);

            //Act
            wagon.AddAnimal(GrootteHerbi1);
            wagon.AddAnimal(GrootteHerbi2);

            var result = wagon.AddAnimal(GrootteHerbi3);

            //Assert
            Assert.IsFalse(result);
        }
    }
}