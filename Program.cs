using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace lesson7
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //var names = new string[] { "saeed", "khaled", "mohamed" };
            //Console.WriteLine($"Length: {names.Length}");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadKey();


            //var boys = new string[] { "saeed", "khaled", "mohamed" };
            //var girls = new string[] { "roya", "nada" };
            //var allStudents = new string[5];

            //boys.CopyTo(allStudents, 0);
            //girls.CopyTo(allStudents, 3);

            //Console.WriteLine("All boy");
            //Console.WriteLine("---------------------");
            //foreach (var boy in boys)
            //{
            //    Console.WriteLine(boy);
            //}

            //Console.WriteLine("All girl");
            //Console.WriteLine("---------------------");
            //foreach (var girl in girls)
            //{
            //    Console.WriteLine(girl);
            //}

            //Console.WriteLine("All Student");
            //Console.WriteLine("---------------------");
            //foreach (var student in allStudents)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.ReadKey();


            //var names = new string[] { "saeed", "khaled", "mohamed", "mohamed", "mohamed" };

            //var index = Array.IndexOf(names, "mohamed");
            //Console.WriteLine(index);
            //Console.ReadKey();

            //var names = new[] { "saeed", "khaled", "mohamed" };
            //Console.WriteLine("All array Elements before clear");
            //Console.WriteLine("===================\n");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Array.Clear(names, 0, 1);
            //Console.WriteLine("All array Elements after clear");
            //Console.WriteLine("===================\n");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadKey();


            //var names = new[] { "saeed", "ahmed", "mohamed", "bader" };
            //Console.WriteLine("names befor modify");
            //Console.WriteLine("=====================");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("names after sort");
            //Console.WriteLine("=====================");
            //Array.Sort(names);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("names after revers");
            //Console.WriteLine("=====================");
            //Array.Reverse(names);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadKey();

            //var names = new string[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter student name");
            //    names[i] = Console.ReadLine();
            //}

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadKey();


            //List<string> names = new List<string>() { "saeed", "mohamed", "khaled" };
            //names.Add("roya");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadKey();

            //List<string> names = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Enter student name or exit to print all name");
            //    var input = Console.ReadLine();
            //    if (input == "exit")
            //    {
            //        Console.WriteLine("=========================");
            //        foreach (var name in names)
            //        {
            //            Console.WriteLine(name);
            //        }
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        names.Add(input);
            //    }
            //}



            //List<string> names = new List<string>();
            //List<string> boys = new List<string>() { "saeed", "khaled" };
            //List<string> girl = new List<string>() { "roya", "maha", "fatemah" };

            //names.AddRange(boys);
            //names.AddRange(girl);

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadKey();

            List<string> students = new List<string>() { "saeed", "khaled", "mohamed", "roya" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            //students.Remove("khaled");
            //students.RemoveAt(0);

            Console.WriteLine("=====================");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(students.Count);
            //Console.WriteLine(students.LastIndexOf("saeed"));

            var isThere = students.Contains("saeed");
            Console.ReadKey();
        }
    }
}