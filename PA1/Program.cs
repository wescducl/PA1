using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


static void Main(string[] args)
{
}
            }
        }
    }
}  
    public abstract class Animal
    {
        private string name;
        private int age;
        private string noise;
        private int weight;


    Animal() 
    {
        name = "Animal";
        age= 0;
        noise = "MMM";
        weight = 0;
    }
    Animal(string a, int b, string c, int d)
    {
        this.name = a;
        this.age = b;
        this.noise = c;
        this.weight = d;
    }
        void printInfo()
        {
            Console.WriteLine("This animal's name is " + name + " and is " +
                age + " years old and it's favorite noise to make is " + noise + " and it weighs " +
                weight + " pounds");
        }
        void AgeUp(int years)
        {
            age += years;
        }

        void makeNoise()
        {
            Console.WriteLine("Your "+noise+" just said " + noise);
        }
    }
public class Cat : Animal
{
    void Cat::printInfo()
    {
        Console.WriteLine("This cat's name is " + Animal.name + " and is " +
            Animal.age + " years old and it's favorite noise to make is " + Animal.noise + " and it weighs " +
            Animal.weight + " pounds");
        void Cat::makeNoise()
        {
            Console.WriteLine("Your cat just went " + noise);
        }
        void Cat::ageUp(int years)
        {
            Cat::Animal.ageUp(years);
        }

    }
}
public class Cassowary : Animal
{
    void Cassowary::printInfo()
    {
        Console.WriteLine("This cassowary's name is " + Animal.name + " and is " +
            Animal.age + " years old and it's favorite noise to make is " + Animal.noise + " and it weighs " +
            Animal.weight + " pounds");
        void Cassowary::makeNoise()
        {
            Console.WriteLine("Your cassowary just went " + noise);
        }
        void Cassowary::ageUp(int years)
        {
            Cassowary::Animal.ageUp(years);
        }

    }
}
    public class Jaguar : Animal
    {
        private int dangerfloof;
        void Jaguar::printInfo()
        {
            Console.WriteLine("This Jaguar's name is " + Animal.name + " and is " +
            Animal.age + " years old and it's favorite noise to make is " + Animal.noise + " and it weighs " +
            Animal.weight + " pounds and a danger floof level of " = dangerfloof);
            void makeNoise()
            {
                Console.WriteLine("Your Jaguar just went " + noise);
            }
            void Jaguar::ageUp(int years)
            {
                Jaguar::Animal.ageUp(years);
            }

        }
    }
     

