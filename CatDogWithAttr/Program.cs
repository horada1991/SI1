using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CatDogWithAttr.Model;

namespace CatDogWithAttr
{
    class Program
    {
        private static void DumpAttributes(MemberInfo member)
        {
            Console.WriteLine("Attributes for : " + member.Name);
            foreach (object attribute in member.GetCustomAttributes(true))
            {
                Console.WriteLine(attribute);
            }
        }

        static void Main(string[] args)
        {
            DumpAttributes(typeof(Cat));
            DumpAttributes(typeof(Dog));
            DumpAttributes(typeof(Stork));

            Console.ReadLine();
        }
    }
}
