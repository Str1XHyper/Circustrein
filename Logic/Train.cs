using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Train
    {
        private List<Wagon> Wagons = new List<Wagon>();
        private Sorter sorter = new Sorter();

        public void DistributeAnimals(List<Animal> Dieren)
        {
            var sorted = sorter.SortDieren(Dieren);
            List<Animal> Herbis = sorted[0];
            List<Animal> Carnos = sorted[1];

            DistributeCarnos(Carnos);
            DistributeHerbis(Herbis);
        }

        private void DistributeCarnos(List<Animal> Carnos)
        {
            foreach (Animal Carno in Carnos)
            {
                AddAnimalToNewWagon(Carno);
            }
        }

        private void DistributeHerbis(List<Animal> Herbis)
        {
            foreach (Animal Herbi in Herbis)
            {
                bool AddedAnimal = false;
                foreach (Wagon wagon in Wagons)
                {
                    if (wagon.AddAnimal(Herbi))
                    {
                        AddedAnimal = true;
                        break;
                    }
                }
                if (AddedAnimal == false)
                {
                    AddAnimalToNewWagon(Herbi);
                }
            }
        }

        private void AddAnimalToNewWagon(Animal dier)
        {
            var wagon = CreateWagon();
            wagon.AddAnimal(dier);
            Wagons.Add(wagon);
        }

        private Wagon CreateWagon()
        {
            return new Wagon();
        }

        public List<Wagon> GetWagons() => Wagons;
    }
}
