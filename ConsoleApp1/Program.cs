using MCronberg;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = MCronberg.PersonRepositoryStatic.JustGetPeople();
            /* foreach (var person in people)
                 Console.WriteLine(person.Gender);*/

            var persons = people.Where(i => i.Height < 170).OrderBy(i => i.Name).ThenBy(i => i.Gender).Select(i => new { i.Name, i.Gender});

            var res1 = persons.GroupBy(i => i.Gender);

            foreach (var Name in res1)
            {
                // udskriver extension
                Console.WriteLine($"Gruppe: {Name.Key}");
                foreach (var gender in Name)
                {
                    // udskriver fil
                    Console.WriteLine($"\t{gender}");
                }
            }

            /*foreach (var person in persons)
            {
                Console.WriteLine(person);
            }*/
        }
    }
}
