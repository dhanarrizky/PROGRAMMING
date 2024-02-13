using System;

namespace CheckInterface
{
    interface IAnimal 
    {
        string AnimalSound();
    }

    interface IGander
    {
        string GanderMyAnimal();
    }

    class Pig : IAnimal
    {
        public string AnimalSound()
        {
            return "NGOK NGOK";
        }
    }

    class Dog : IAnimal, IGander
    {
        public string AnimalSound()
        {
            return "GUk GUk";
        }

        public string GanderMyAnimal(){
            return "Male";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");

            // Creating instances of Pig and Dog
            // Pig pig = new Pig();
            // Dog dog = new Dog();

            // // Calling AnimalSound() for Pig and Dog
            // Console.WriteLine("Pig sound: " + pig.AnimalSound());
            // Console.WriteLine("Dog sound: " + dog.AnimalSound());
            // Console.WriteLine("====================================================================");
            

            // IGander ganderOfAnimal = dog;
            // Console.WriteLine("Gender Of Dog : "+ ganderOfAnimal.GanderMyAnimal());

            //=============================================
            // List<IAnimal> animals = new List<IAnimal>();
            // Dog dog = new Dog();
            // Pig pig = new Pig();

            // animals.Add(dog);
            // animals.Add(pig);

            // foreach (var item in animals)
            // {
            //     Console.WriteLine("Animals : "+ item.AnimalSound());
            // }

            IAnimal iDog = new Dog();
            IAnimal iPig = new Pig();

            Console.WriteLine(iDog.AnimalSound());
            Console.WriteLine(iPig.AnimalSound());

            IGander iGander = new Dog();
            Console.WriteLine("Dor Gander : " + iGander.GanderMyAnimal());
            
        }
    }
}
