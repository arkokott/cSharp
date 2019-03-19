using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class AnimalObject
    {
        public virtual void Animal()
        {
            Console.WriteLine("Zwierze wydaje głos.");
        }
    }

    public class Cat : AnimalObject
    {
        public override void Animal()
        {
            Console.WriteLine("Kot miauczy.");
        }
    }

    public class Dog : AnimalObject
    {
        public override void Animal()
        {
            Console.WriteLine("Pies szczeka.");
        }
    }

    public class Duck : AnimalObject
    {
        public override void Animal()
        {
            Console.WriteLine("Kaczka gdacze.");
        }
    }

    class Program
    {
        static void Main()
        {
            List<AnimalObject> AnimalList = new List<AnimalObject>();

            AnimalList.Add(new Cat());
            AnimalList.Add(new Dog());
            AnimalList.Add(new Duck());

            foreach (AnimalObject animalObj in AnimalList)
            {
                animalObj.Animal();
            }

            Console.ReadLine();

        }
    }
}
