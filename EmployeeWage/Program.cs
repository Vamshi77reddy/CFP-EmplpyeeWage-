using System;

namespace EmployeeWage
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                Console.WriteLine(" Check whether Employee is present or absent");
                int empPresesent = 1;
                Random random = new Random();
                int empCheck = random.Next(2);
                if (empCheck == empPresesent)
                {
                    Console.WriteLine("Employee is Present");
                }
                else
                    Console.WriteLine("Employee is Absent");
            }
        }
    }
    
