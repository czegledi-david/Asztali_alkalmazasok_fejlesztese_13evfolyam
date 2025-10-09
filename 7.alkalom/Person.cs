using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace myclasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => name;
        public int Age => age;

        public override string ToString()
        {
            return $"Név: {name}, Kor: {age}";
        }

        public bool YoungerThan(Person other)
        {
            return other.age < this.age;
        }
    }

}

namespace myclasses.persons
{
    using myclasses;
    using System.Net;

    public class Child : Person
    {
        private string school;

        public Child(string name, int age, string school) : base(name, age)
        {
            this.school = school;
        }

        public string School => school;

        public override string ToString()
        {
            return $"{base.ToString()}, Iskola: {school}";
        }



    }
    public class Adult : Person
    {
        private string workplace;

        public Adult(string name, int age, string workplace) : base(name, age)
        {
            this.workplace = workplace;
        }

        public string Workplace => workplace;

        public override string ToString()
        {
            return $"{base.ToString()}, Munkahely: {workplace}";
        }


    }
}

namespace myapp
{
    using myclasses;
    using myclasses.persons;

    class Program
    {
        static Person ReadInPersons()
        {
            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.Write("School: ");
                string iskola = Console.ReadLine();
                return new Child(name, age, iskola);
            }
            else
            {
                Console.Write("Workplace: ");
                string workplace = Console.ReadLine();
                return new Adult(name, age, workplace);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Első személy adatai:");
            Person person1 = ReadInPersons();

            Console.WriteLine("Második személy adatai:");
            Person person2 = ReadInPersons();

            Console.WriteLine("Létrehozott személyek:");
            Console.WriteLine(person1);
            Console.WriteLine(person2);

            Console.WriteLine("Típusvizsgálat:");
            // typeof
            Console.WriteLine($"typeof(Child): {typeof(Child)}");
            Console.WriteLine($"typeof(Adult): {typeof(Adult)}");
            Console.WriteLine("___________________________________________");
            //GetType()
            Console.WriteLine($"person1.GetType(): {person1.GetType()}");
            Console.WriteLine($"person2.GetType(): {person2.GetType()}");


        }

    }

}

