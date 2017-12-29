using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Dog {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Legs { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            string[] stringArray = new string[5];

            int[] populatedIntArray = new int[] { 0, 1, 2, 3, 4, 5 };
            string[] populatedStringArray = new string[] { "One", "Two", "Three" };

            intArray[0] = 5;
            intArray[2] = 15;

            int firstValue = intArray[0];

            int[,] multiInt = new int[2, 3];
            int[,] multiIntWithContext = { {1, 2, 3 }, {4, 5, 6 } };

            Console.WriteLine("row 0" + multiIntWithContext[0, 0] + " " + multiIntWithContext[0, 1] + " " + multiIntWithContext[0, 2]);
            Console.WriteLine("row 1" + multiIntWithContext[1, 0] + " " + multiIntWithContext[1, 1] + " " + multiIntWithContext[1, 2]);

            Dog[] dogArray = new Dog[2];
            dogArray[0] = new Dog() { Name = "Rover" };

            

            List<string> strings = new List<string>();

            strings.Add("my first string");
            strings.Add("another");
            strings.Add("yet another");

            strings.Insert(0, "inserted");

            strings.Remove("another");
            strings.RemoveAt(0);

            strings.Sort();

            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("James", "Bond");
            names.Add("Money", "Penny");

            Console.WriteLine(names["Money"]);

            names.Remove("Money");

            List<Dog> dogs = new List<Dog>() {
                new Dog() { Id=1, Name = "Rover", Legs=4 },
                new Dog() { Id=2, Name="Fido", Legs=3 }
            };

            List<Dog> results = (from d in dogs
                                where d.Id == 1
                                select d).ToList();

            results = dogs.Where(d=>d.Name=="Fido").ToList();

            var varResults = from d in dogs
                             where d.Id == 1
                             select d;
            
            varResults = from d in dogs
                             where d.Id == 1
                             select d;


            Dog foundDog = (from d in dogs
                                 where d.Id == 1
                                 select d).FirstOrDefault();

            foundDog = dogs.FirstOrDefault(d => d.Name == "Fido");



            Console.ReadLine();
        }
    }
}
