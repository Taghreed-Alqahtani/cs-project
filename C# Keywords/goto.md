
> goto

In c#, the Goto statement is used to transfer program control to the defined labeled statement, and it is useful to 
get out of the loop or exit from deeply nested loops based on our requirements.

 
The defined labeled statement must always exist in the goto statement's scope. 
We can define multiple goto statements in our application to transfer the program control to the specified labeled statement.

Example:
`` 
using System;

namespace NewProject
{
     class Program
     {
         static void Main(string[] args)
         {
             int i = 3, j = 0;
             switch (i)
             {
                 case 1:
                    j += 20;
                    Console.WriteLine("j value is {0}",j);
                    break;
                 case 2:
                    j += 5;
                    goto case 1;
                 case 3:
                    j += 30;
                    goto case 1;
                 default:
                    Console.WriteLine("invalid");
                    break;
             }
             Console.WriteLine("Press any Key to quit ");
             Console.ReadLine();
         }
     }
}
 ``