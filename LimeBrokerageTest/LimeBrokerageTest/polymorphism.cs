using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimeBrokerageTest
{
    
    public class Animal
    {
        public string name;

        public Animal()
        {
            name = "Animal";
            //Console.WriteLine("Animal Constructor fired.");
        }

        public Animal(string animalName)
        {
            name = animalName;
            //Console.WriteLine("Overloaded Animal Constructor fired.");
        }
    }

    public class Bird : Animal
    {
        public Bird(string birdName) : base(birdName)
        {
            //Console.WriteLine("Bird Constructor fired.");
        }
        
    }

    public class Chicken : Bird
    {
        public Chicken(string chickenName) : base(chickenName)
        {
        }
    }

    public class Tester 
    {
        public Tester()
        {
            //Console.WriteLine("Tester Constructor fired.");

            var animal= new Animal();
            var bird = new Bird("Ostrich");
            var chicken = new Chicken("Red Chicken");


            //Demonstration of how a derived class is too specific to be used

            //All derived classed can be passed into a base class
            DoAnimal(animal); //works
            DoAnimal(bird); //works because a bird is an animal
            DoAnimal(chicken); //works because a chicken is a bird is an animal

            
            //DoBird(animal); //does not work becauase an animal is not a bird, and cannot specifics about bird
            DoBird(bird); //works 
            DoBird(chicken); //works

            //DoChicken(animal); //does not work
            //DoChicken(bird); //does not work
            DoChicken(chicken); //works



        }

        void DoAnimal(Animal animal)
        {
            Console.WriteLine(animal.GetType().ToString());
        }

        void DoBird(Bird bird)
        {
            Console.WriteLine(bird.GetType().ToString());
        }

        void DoChicken(Chicken chicken)
        {
            Console.WriteLine(chicken.GetType().ToString());
        }

    }
}
