using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace CircustreinTests
{
    [TestClass]
    public class TreinTests
    {

        [TestMethod]
        public void DistributeAllAnimals_Succesfull()
        {
            //Arrange
            List<Animal> Animals = new List<Animal>()
            {
                new Animal(Type.Herbi, Size.Big),
                new Animal(Type.Carno, Size.Big),
                new Animal(Type.Carno, Size.Medium),
                new Animal(Type.Herbi, Size.Medium),
                new Animal(Type.Herbi, Size.Small),
                new Animal(Type.Carno, Size.Medium),
                new Animal(Type.Herbi, Size.Small),
                new Animal(Type.Herbi, Size.Small),
                new Animal(Type.Carno, Size.Small)
            };

            Train trein = new Train();

            //Act
            trein.DistributeAnimals(Animals);

            //Assert
            Assert.AreEqual(5, trein.GetWagons().Count);
        }

        [TestMethod]
        public void DistributeAllAnimalsInCorrectWagons_Succesfull()
        {
            //Arrange
            List<Animal> Animals = new List<Animal>()
            {
                new Animal(Type.Herbi, Size.Big),
                new Animal(Type.Carno, Size.Big),
                new Animal(Type.Carno, Size.Medium)
            };

            Train train = new Train();

            Wagon CorrectWagon1 = new Wagon();
            Wagon CorrectWagon2 = new Wagon();

            CorrectWagon1.AddAnimal(Animals[1]);
            CorrectWagon2.AddAnimal(Animals[2]);
            CorrectWagon2.AddAnimal(Animals[0]);

            //Act
            train.DistributeAnimals(Animals);

            //Assert
            //Assert.AreEqual(2, train.GetWagons().Count);
            //CollectionAssert.AreEqual(CorrectWagon1.GetAnimals(), train.GetWagons()[0].GetAnimals());
            //CollectionAssert.AreEqual(CorrectWagon2.GetAnimals(), train.GetWagons()[1].GetAnimals());
        }

        [TestMethod]
        public void SpecificTestCase()
        {
            //Arrange
            List<Animal> Animals = new List<Animal>()
            {
                new Animal(Type.Herbi, Size.Small),
                new Animal(Type.Herbi, Size.Small),
                new Animal(Type.Herbi, Size.Small),
                new Animal(Type.Herbi, Size.Small),
                new Animal(Type.Herbi, Size.Small),
                new Animal(Type.Carno, Size.Big),
                new Animal(Type.Carno, Size.Big),
                new Animal(Type.Herbi, Size.Medium),
                new Animal(Type.Herbi, Size.Medium),
                new Animal(Type.Herbi, Size.Medium),
                new Animal(Type.Herbi, Size.Medium),
                new Animal(Type.Herbi, Size.Medium),
                new Animal(Type.Herbi, Size.Big),
                new Animal(Type.Herbi, Size.Big),
                new Animal(Type.Herbi, Size.Big),
                new Animal(Type.Herbi, Size.Big),
                new Animal(Type.Herbi, Size.Big),
                new Animal(Type.Carno, Size.Medium),
                new Animal(Type.Carno, Size.Medium),
                new Animal(Type.Carno, Size.Medium),
            };

            Train train = new Train();

            //Act
            train.DistributeAnimals(Animals);

            //Asserts
            Assert.AreEqual(8, train.GetWagons().Count);
        }
    }
}
