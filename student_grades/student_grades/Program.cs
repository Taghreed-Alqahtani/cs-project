using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            List<string> names = new List<string>();
            string loop = "yes";

            while (loop == "yes" || loop == "Yes")
            {
                Console.Write("enter student's name : ");
                names.Add(Console.ReadLine());
                Console.Write("enter student's grade : ");
                grades.Add(int.Parse(Console.ReadLine()));
                Console.Write("add another student?  (yes/no) ");
                loop = Console.ReadLine();

            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("student name : {0} , student grade : {1}", names[i], grades[i]);
            }
            Console.WriteLine("inter degree to search");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("number of student with grade : {0} is : {1}", y, search(grades, y));
        }

        public static int search(List<int> grades, int y)
        {
            int counter = 0;
            foreach (var item in grades)
            {
                if (item == y) counter++;
            }
            return counter;
        }
    }
}
