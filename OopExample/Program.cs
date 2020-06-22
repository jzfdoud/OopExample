using System;

namespace OopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var collie = new Collie("Lassie", "White", true);
            Console.WriteLine($"{collie.Type}|{collie.IsLassie}|{collie.Color}|{collie.FurLength}|{collie.TailLength}");
            Console.WriteLine($"In response to bark() our collie {collie.Bark()}");
            Console.WriteLine($"In response to sit() our collie {collie.Sit()}");
            Console.WriteLine($"In response to herding() our collie");
            collie.Herding();

            var gs = new GermanSheperd("Police Dog");
            var barkValue = gs.Bark();

            var chi = new Chihuahua("Killer");
            var squeekValue = chi.Bark();

            Canine[] canines = new Canine[10];
            canines[0] = collie;
            canines[1] = gs;
            canines[2] = chi;

            for(var i = 0; i < canines.Length; i ++)
            {
                var dog = canines[i];
                if (dog == null) break;
                var col = dog as Collie;
                if (col !=null)
                {
                    col.Herding();
                }
                Console.WriteLine($"{dog.Name} is a {dog.Type}. It has a {dog.FurLength} {dog.Color} coat, and it's tail is {dog.TailLength}.");
            }
        }
    }
}
