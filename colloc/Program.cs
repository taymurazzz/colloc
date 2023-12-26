using colloc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colloc
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studA = new Student();
            Student studB = new Student();
            Student studAbaev = new Student("Абаев Георгий", 7, 3.4);
            Student studBagaev = new Student("Багаев Аслан", 4, 4);

            Console.WriteLine(studA);
            Console.WriteLine(studB);
            Console.WriteLine(studAbaev);
            Console.WriteLine(studBagaev);

            studBagaev.Pass();
            Console.WriteLine(studBagaev);

            School school = new School("ФизМат");
            school.Add(studA);
            school.Add(studB);
            school.Add(studAbaev);
            school.Add(studBagaev);

            Console.WriteLine(school);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            school.Sort();
        }
    }
}


