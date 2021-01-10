using System;
using System.Collections.Generic;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Type = Logic.Type;

namespace CircustreinTests
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void Sorting_FilledList()
        {
            //Arrange
            Sorter sorter = new Sorter();


            List<Animal> Animals = new List<Animal>()
            {
                new Animal(Type.Herbi, Size.Medium),
                new Animal(Type.Carno, Size.Big),
                new Animal(Type.Carno, Size.Medium),
                new Animal(Type.Herbi, Size.Small),
                new Animal(Type.Herbi, Size.Big),
                new Animal(Type.Carno, Size.Small),
            };

            List<Animal>[] Correct = new List<Animal>[]
            {
                new List<Animal>
                {
                    Animals[4],
                    Animals[0],
                    Animals[3]
                },
                new List<Animal>
                {
                    Animals[1],
                    Animals[2],
                    Animals[5]
                }
            };

            //Act
            var SortedAnimals = sorter.SortDieren(Animals);

            //Assert
            CollectionAssert.AreEqual(Correct[0], SortedAnimals[0]);
            CollectionAssert.AreEqual(Correct[1], SortedAnimals[1]);
        }
    }
}
