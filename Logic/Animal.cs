using System;

namespace Logic
{
    public enum Size
    {
        Small = 1,
        Medium = 3,
        Big = 5
    }
    public enum Type
    {
        Carno,
        Herbi
    }

    public class Animal
    {
        public Animal(Type type, Size size)
        {
            Size = size;
            Type = type;
        }
        public Size Size { get; private set; }
        public Type Type { get; private set; }
    }
}
