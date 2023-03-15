using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms1
{
    internal class Program
    {
        public static void FullName(Person p)
        {
            Console.WriteLine(p);
        }

        public static bool BornInSpring(Person p)
        {
            if (p.DOB.Month > 2 && p.DOB.Month < 6)
                return true;
            else
                return false;
        }
        public static int Compdate(Person p1, Person p2)
        {
            return p1.DOB.CompareTo(p2.DOB);
        }
        public static bool BornInSummer(Person p)
        {
            if (p.DOB.Month > 5 && p.DOB.Month < 9)

                return true;
            else
                return false;

        }

        public static void compname(Person p1 , Person p2)
        {
             p1.Name.CompareTo(p2.Name);
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() { Name = "John",LastName = "Doe",DOB = new DateTime(1999,4,2)},
                new Person() { Name = "Jane",LastName = "Doe",DOB = new DateTime(1991,5,2)},
                new Person() { Name = "Fernando",LastName = "tran",DOB = new DateTime(1999,4,2)},
                new Person() { Name = "ricardo",LastName = "spec",DOB = new DateTime(1980,6,2)},
                new Person() { Name = "romeo",LastName = "bush",DOB = new DateTime(1995,7,2)},


            };
            Console.WriteLine("gvarebi");
            var gvarebi = people.Select(o => o.LastName).ToList();
            gvarebi.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("saxelebi");
            var saxelebi = people.Select(o => o.Name).ToList();
            saxelebi.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("tarigi");
            var tarigi = people.Select(o =>o.DOB).ToList();
            tarigi.ForEach(i=> Console.WriteLine(i));

            Console.WriteLine("spring");
            List<Person> bornInSpring = people.FindAll(BornInSpring);
            bornInSpring.ForEach(FullName);

            Console.WriteLine("summer ");
            List<Person> borninsummer = people.FindAll(BornInSummer);
            borninsummer.ForEach(FullName);

            Console.WriteLine("sort");
            people.Sort((i, o) => i.DOB.CompareTo(o.DOB));
            people.ForEach(i => Console.WriteLine(i));
            
            Console.WriteLine("sort name");
            people.Sort((i,o)=>i.Name.CompareTo(o.Name));
            people.ForEach(i => Console.WriteLine(i));


        }
    }
}
