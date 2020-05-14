using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace linqexcercise
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth","mathematics"};
            var chosenwords = words.Where(w => w.Contains("th"));
            foreach (var item in chosenwords)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();


            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var chosennames = names.Distinct();
            foreach (var item in chosennames)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("#############");
            Console.WriteLine();


            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };

            var grades = classGrades.Average(c=> +c.Split(',').Select(double.Parse).OrderBy(x=>x).Skip(1).Average());
            
                Console.WriteLine(grades);

            // Write a function that takes in a string of letters(i.e. “Terrill”) and returns an 
            //alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
            string name = "Terrill";
            var sortname = name.GroupBy(x => x).OrderBy(x => x);

            //foreach (var item in sortname)
            {
                Console.WriteLine(sortname);

            }
            Console.ReadLine();
        }
    }
}
