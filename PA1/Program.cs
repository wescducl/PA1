using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PA1

    internal class Program
{
   public abstract class Animal
    {
        private string name;
        private int age;
        private string noise;
        private int weight;

        void printInfo()
        {
            Console.WriteLine("This animal's name is " + name+" and is "+
                age+" years old and it's favorite noise to make is "+ noise+" and it weighs " +
                weight+" pounds");
        }
        void AgeUp(int years)
        {
            age += years;
        }

        void makeNoise()
        {
            Console.WriteLine("Your animal just said " + noise);
        }
    }
    public class Cat :  Animal
{
        void printInfo()
        {
            Console.WriteLine("This cat's name is " + name + " and is " +
                age + " years old and it's favorite noise to make is " + noise + " and it weighs " +
                weight + " pounds");
            void makeNoise()
        {
            Console.WriteLine("Your cat just went " + noise);
        }
        void ageUp(int years)
    {
        age += years;
    }

}
        public class Cassowary : Animal
        {
            void printInfo()
            {
                Console.WriteLine("This cassowary's name is " + name + " and is " +
                    age + " years old and it's favorite noise to make is " + noise + " and it weighs " +
                    weight + " pounds");
                void makeNoise()
                {
                    Console.WriteLine("Your cassowary just went " + noise);
                }
                void ageUp(int years)
                {
                    age += years;
                }

            }
            public class Jaguar : Animal
            {
                private int dangerfloof;
                void printInfo()
                {
                    Console.WriteLine("This Jaguar's name is " + name + " and is " +
                        age + " years old and it's favorite noise to make is " + noise + " and it weighs " +
                        weight + " pounds and a danger floof level of "=dangerfloof);
                    void makeNoise()
                    {
                        Console.WriteLine("Your Jaguar just went " + noise);
                    }
                    void ageUp(int years)
                    {
                        age += years;
                    }

                }
                static void Main(string[] args)
        {
        }
    }
}
