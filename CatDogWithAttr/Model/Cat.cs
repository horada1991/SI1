using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatDogWithAttr.Attribute;

namespace CatDogWithAttr
{
    [AnimalType(AnimalTypeAttribute.TypeEnum.Mammal)]
    class Cat : Animal
    {
    }
}
