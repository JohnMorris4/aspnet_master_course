using System;

namespace HelloWorld
{

    
    class Program
    {
        enum PetType
        {
            Dog,
            Duck
        }
        class PetClass
        {
            public int Legs;
            public PetType Type;
            public string Name;
            public bool HasFur;
        }

        struct PetStruct
        {
            public int Legs;
            public PetType Type;
            public string Name;
            public bool HasFur;
        }

        static void MutiplyLegs(PetStruct petStruct, PetClass petClass)
        {
            petStruct.Legs = petStruct.Legs * 2;
            petClass.Legs = petClass.Legs * 2;
            Console.WriteLine("Internal Struct Method" + petStruct.Type + " has "  + petStruct.Legs + " Legs");
            Console.WriteLine("Internal Class Method" + petClass.Type + " has "  + petClass.Legs + " Legs");
        }

        static void Main(string[] args)
        {
            PetStruct dog = new PetStruct();
            dog.Type = PetType.Dog;
            dog.Legs = 4;
            dog.HasFur = true;
            Console.WriteLine("A " + dog.Type + " Has " + dog.Legs + " Legs" );

            PetClass duck = new PetClass();
            duck.HasFur = false;
            duck.Type = PetType.Duck;
            duck.Legs = 2;
            duck.Name = "Daffy";
            Console.WriteLine("A " + duck.Type + " Has " + duck.Legs + " Legs");
            //MutiplyLegs(dog, duck);
            //Console.WriteLine("Inside the Main Method" + dog.Type + " has " + dog.Legs + " Legs");
            //Console.WriteLine("Inside the Main Method" + duck.Type + " has " + duck.Legs + " Legs");

            PetStruct copiedDog = dog;
            PetClass copiedDuck = duck;
            Console.WriteLine("Inside the Main Method" + dog.Type + " has " + dog.Legs + " Legs");
            Console.WriteLine("Inside the Main Method" + duck.Type + " has " + duck.Legs + " Legs");
            copiedDog.Legs = copiedDog.Legs * 2;
            copiedDuck.Legs = copiedDuck.Legs * 2;
            Console.WriteLine("Inside the Copied  Method" + copiedDog.Type + " has " + copiedDog.Legs + " Legs");
            Console.WriteLine("Inside the Copied  Method" + copiedDuck.Type + " has " + copiedDuck.Legs + " Legs");
            Console.ReadLine();

           
        }

       
    }
}
