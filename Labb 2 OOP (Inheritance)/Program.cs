using System;

namespace Labb_2_OOP__Inheritance_
{
    public class Djur
    {
        public string Name;
        public int Age;
        public string Color;
        public int NumberOfLegs;
        public int NumberOfEyes;

        public Djur(string name, int age, string color, int numberoflegs, int numberofeyes)
        {
            this.Name = name;
            this.Age = age;
            this.Color = color;
            this.NumberOfLegs = numberoflegs;
            this.NumberOfEyes = numberofeyes;
        }
        public Djur(string name, int age, string color)
        {
            this.NumberOfLegs = 4;
            this.NumberOfEyes = 2;
            this.Name = name;
            this.Age = age;
            this.Color = color;
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
        public Dog(string collarcolor, string color,string name, int age) : base(name,age,color)
        {
            this.CollarColor = collarcolor;
        }

        public void Commands()
        {
            Console.WriteLine("Sit, Roll, Fetch ");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Dog Says: Woof Woof");
        }

    }
    public class Cat : Djur
    {
        public string NecklaceColor;
        
        public Cat(string necklacecolor, string color,string name, int age) : base(name, age, color)
        {
            this.NecklaceColor = necklacecolor;

        }

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
        
        public Mouse(string colorofeyes, string color,string name, int age) : base(name, age, color)
        {
            this.ColorOfEyes = colorofeyes;
        }

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
        public Bulldog(string CollarColor,string weight,string name, int age) : base(CollarColor,"White",name,age)
        {
            this.Weight = weight;
        }
        

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
        public Golden_Retriver(string CollarColor, string length, string name, int age) : base(CollarColor,"Brown",name,age)
        {
            this.Length = length;
        }

       

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
            Dog Dog = new Dog("Red","Brown","Teddy",5);
            Dog.MakeSound();

            Cat Cat = new Cat("Blue","Black","Pär",3);
            Cat.MakeSound();

            Mouse Mouse = new Mouse("Red","Grey","Åke",2);
            Mouse.MakeSound();

            Bulldog Bulldog = new Bulldog("Green","White","Sven",1);
            Bulldog.MakeSound();

            Golden_Retriver Golden_Retriver = new Golden_Retriver("Yellow","Brown","Olof",7);
            Golden_Retriver.MakeSound();

            Djur Fox = new Djur("Otto",4,"Red",8,2);
            Fox.MakeSound();




        }
    }
}
