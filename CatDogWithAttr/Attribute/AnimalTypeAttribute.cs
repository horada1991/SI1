using System;

namespace CatDogWithAttr.Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    class AnimalTypeAttribute : System.Attribute
    {
        public readonly TypeEnum Type;

        public string Description { get; set; }

        public AnimalTypeAttribute(TypeEnum type)
        {
            Type = type;
        }

        internal enum TypeEnum { Mammal, Reptile, Bird, Insect, Aquatic }

        public override string ToString()
        {
            string toReturn = $"Animal Type: {this.Type}";
            toReturn += (Description == null) ? "" : $", Description: {this.Description}";

            return toReturn;
        }
    }
}
