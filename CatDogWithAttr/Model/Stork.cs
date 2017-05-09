using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatDogWithAttr.Attribute;

namespace CatDogWithAttr.Model
{
    [AnimalType(AnimalTypeAttribute.TypeEnum.Bird, Description = "This is big bird and it sometimes stands on one foot.")]
    class Stork
    {
    }
}
