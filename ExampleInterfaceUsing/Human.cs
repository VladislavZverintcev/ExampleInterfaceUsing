using System;

namespace ExampleInterfaceUsing
{
    public class Human : IEat
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public Human(string name, string race)
        {
            Name = name;
            Race = race;
        }

        public void LetsEat(string someFood)
        {
            Console.WriteLine($"{Name} now eat {someFood}");
        }
    }
}
