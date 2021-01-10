using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Sorter
    {
        public List<Animal>[] SortDieren(List<Animal> toBeSorted)
        {
            var Sorted = SortBySize(toBeSorted);
            return SortByType(Sorted);
        }

        private List<Animal>[] SortByType(List<Animal> allAnimals)
        {
            List<Animal> Herbis = new List<Animal>();
            List<Animal> Carnos = new List<Animal>();

            foreach (Animal animal in allAnimals)
            {
                if (animal.Type == Type.Herbi)
                {
                    Herbis.Add(animal);
                }
                if (animal.Type == Type.Carno)
                {
                    Carnos.Add(animal);
                }
            }
            List<Animal>[] Sorted = new List<Animal>[2];
            Sorted[0] = Herbis;
            Sorted[1] = Carnos;

            return Sorted;
        }

        private List<Animal> SortBySize(List<Animal> allAnimals)
        {
            List<Animal> Sorted = new List<Animal>();
            List<Animal> Medium = new List<Animal>();
            List<Animal> Small = new List<Animal>();

            foreach(Animal animal in allAnimals)
            {
                switch (animal.Size)
                {
                    case Size.Big:
                        Sorted.Add(animal);
                        break;
                    case Size.Medium:
                        Medium.Add(animal);
                        break;
                    case Size.Small:
                        Small.Add(animal);
                        break;
                }
            }
            Sorted.AddRange(Medium);
            Sorted.AddRange(Small);

            return Sorted;
        }
    }
}
