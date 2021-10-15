using System;

namespace ExampleInterfaceUsing
{
    public class Cat : IEat
    {
        public string Alias { get; set; }
        public string Breed { get; set; }

        public Cat(string alias, string breed)
        {
            Alias = alias;
            Breed = breed;
        }

        public void LetsEat(string someFood)
        {
            Console.WriteLine($"{Alias} now eat {someFood}");
        }
    }
}
