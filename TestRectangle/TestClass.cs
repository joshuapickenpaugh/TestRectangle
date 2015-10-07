//Joshua Pickenpaugh, IN2017, Adv.C#
//Modulue 7, October 6th, 2015.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRectangle
{
    //2b:
    class TestClass
    {
        static void Main(string[] args)
        {
            //2c:
            int num1 = 1;
            int num2 = 2;
            int total = 0;

            total = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, total);

            //2d:
            Add(20, 30);
            //2e:
            Add(20, 30, 25);

            //2g:
            Rectangle rectangle = new Rectangle();
            rectangle.RectangleArea(3, 5);

            //2h:
            rectangle.RectangleArea(4, 5);

            Console.ReadKey();
        }

        public static void Add(int firstNUM, int secondNUM)
        {
            int totalNUM = 0;
            totalNUM = firstNUM + secondNUM;
            Console.WriteLine("In the user-defined method Add(), the total is: {0}", totalNUM);
        }

        public static void Add(int firstNUM, int secondNUM, int thirdNUM)
        {
            int totalNUM = 0;
            totalNUM = firstNUM + secondNUM + thirdNUM;
            Console.WriteLine("In the overloaded Add() method, the total is: {0}", totalNUM);
        }
    }
}
