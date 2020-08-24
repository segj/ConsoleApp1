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

            var persons = people.Where(i => i.Height < 170 && i.IsHealthy).OrderBy(i => i.Name).ThenBy(i => i.Gender).Select(i => new { i.Name, i.Gender});

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
