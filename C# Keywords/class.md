> class

Class is a keyword in C#.NET which is used to create a class. Classes are special kinds of templates from which you can create objects.
Each object contains data and methods to manipulate and access that data. The class defines the data and 
the functionality that each object of that class can contain.

A class declaration consists of a class header and body. The class header includes attributes, modifiers, and the class keyword.
The class body encapsulates the members of the class that are the data members and member functions


``

using System;
using System.Linq;
namespace LINQDemo
{
    class Program // class declaration..
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };
           
            int MSTotal = intNumbers.Sum(num => {
                if (num > 50)
                    return num;
                else
                    return 0;
            });
            
            Console.WriteLine("Sum = " + MSTotal);
            Console.ReadKey();
        }
    }
}

``