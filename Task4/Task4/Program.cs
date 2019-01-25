using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good
            //TODO: Code Doesn't compile so I can't run it. 
            double packageweigt = 0.0;
            double cost = 0.0;

            Console.WriteLine("Please enter your package weight:");
            packageweigt = double.Parse(Console.ReadLine());

            if(packageweigt <=2)
            {
                cost = packageweigt * 2;
            }
            else if (packageweigt <= 5)
            {
                cost = packageweigt * 4;
            
            }
            else if(packageweigt <= 10)
            {
                cost = packageweigt * 6;
            
            }

            else
            {
                cost = packageweigt * 8;
            }
            Console.WriteLine("The cost for shipping your package is:" + cost);
            Console.ReadLine();
        }
    }
}

