using System;

namespace Labb_2_OOP__Inheritance_
{
    public class Djur
    {
        public string Name;
        public string Age;
        public string Color;
        public string NumberOfLegs;
        public string NumberOfEyes;

        public Djur(string name, string age, string color, string numberoflegs, string numberofeyes)
        {
            this.Name = name;
            this.Age = age;
            this.Color = color;
            this.NumberOfLegs = numberoflegs;
            this.NumberOfEyes = numberofeyes;
        }


        public virtual void MakeSound()
        {
            Console.WriteLine("Some sort of animal sound");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Nom Nom");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("zzzz");
        }

    }
    public class Dog : Djur
    {
        public string CollarColor;

        public void Commands()
        {
            Console.WriteLine("Sit, Roll, Fetch ");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Dog Says: Woof Woof");
        }

    }
    class Cat : Djur
    {
        public string NecklaceColor;

        public void Spin()
        {
            Console.WriteLine("Rawroooorr");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat Says: Meow Meow");
        }

    }
    public class Mouse : Djur
    {

        public string ColorOfEyes;

        public void Stare()
        {
            Console.WriteLine("Staring intensifies");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mouse Says: Pew Pew");
        }
    }
    public class Bulldog : Dog
    {
        public string Weight;

        public void Askforfood()
        {
            Console.WriteLine("Roof Roof Food Roof Roof");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bulldog Says: Roof Roof");
        }
    }
    public class Golden_Retriver : Dog
    {
        public string Length;

        public void Run()
        {
            Console.WriteLine("ZOOOOOOOM");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Golden Retriver Says: Woofity Woofity");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog Dog = new Dog();
            Dog.MakeSound();

            Cat Cat = new Cat();
            Cat.MakeSound();

            Mouse Mouse = new Mouse();
            Mouse.MakeSound();

            Bulldog Bulldog = new Bulldog();
            Bulldog.MakeSound();

            Golden_Retriver Golden_Retriver = new Golden_Retriver();
            Golden_Retriver.MakeSound();

        }
    }
}
