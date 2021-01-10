using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Wagon
    {
        public int Capacity { get; private set; } = 10;
        public int CurrentContent { get; private set; }
        private List<Animal> Animals = new List<Animal>();

        public bool AddAnimal(Animal animal)
        {
            if(IsCompatible(animal) && HasSpace(animal))
            {
                Animals.Add(animal);
                CurrentContent += (int)animal.Size;
                return true;
            }
            return false;
        }

        private bool IsCompatible(Animal animal)
        {
            if (Animals.Count == 0)
            {
                return true;
            }

            if (Animals.Count >= 1)
            {
                if (Animals[0].Size == Size.Big && Animals[0].Type == Type.Carno)
                {
                    return false;
                }
                else if (animal.Size == Size.Big)
                {
                    return true;
                }
                else if (animal.Size == Size.Medium)
                {
                    if (Animals[0].Size >= Size.Medium && Animals[0].Type == Type.Carno)
                    {
                        return false;
                    }
                    return true;
                }
                else if (animal.Size == Size.Small)
                {
                    if (Animals[0].Size >= Size.Small && Animals[0].Type == Type.Carno)
                    {
                        return false;
                    }
                    return true;
                }
            }

            throw new Exception("List count less then zero");
        }

        private bool HasSpace(Animal dier)
        {
            if((int)dier.Size <= (Capacity - CurrentContent)) // < Veranderd in <=
            {
                return true;
            }
            return false;
        }



        public IReadOnlyList<Animal> GetAnimals() => Animals;
    }
}
