using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //NO.1 
            Console.Write("Hello");
            Console.WriteLine("DILRUBA KHANAM JESEY");
            //NO.2
            int x = 7;
            int y = 6;
            int z = x + y;
            Console.WriteLine("sum : " + z);
            //NO.3
            double d = x / y;
            Console.WriteLine("div : " + d);
            //NO.4
            double k1 = -5 + 8 * 6;
            Console.WriteLine("res a : " + k1);
            double k2 = (55 + 9) % 9;
            Console.WriteLine("res b : " + k2);
            double k3 = 20 + -3 * 5 / 8;
            Console.WriteLine("res c : " + k3);
            double k4 = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("res d : " + k4);
            //NO.5
            int m = 4;
            int n = 4;
            int addition = m + n;
            double multiply = m * n;
            double subtract = m - n;
            double divide = m / n;
            double remainder = m % n;
            Console.WriteLine("res addition : " + addition);
            Console.WriteLine("res multiply : " + multiply);
            Console.WriteLine("res subtract : " + subtract);
            Console.WriteLine("res divide : " + divide);
            Console.WriteLine("res remainder : " + remainder);
            //NO.6
            double cal = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("calculation : " + cal);
            //NO.7
            double width = 5.5;
            double height = 8.5;
            double area = width * height;
            double perimeter = 2 * (width + height);
            Console.WriteLine("Area is "+width+"*"+height+" = "+area);
            Console.WriteLine("Perimeter is 2 * (" + width + "+" + height + ") = " + perimeter);
        }
    }
}
           
