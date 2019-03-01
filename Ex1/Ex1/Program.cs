using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex9();
        }

        static void Ex1()
        {
            Console.WriteLine("Hello");
            Console.ReadLine();
        }

        static void Ex2()
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Please enter the first number to add");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number to add");
            num2 = int.Parse(Console.ReadLine());
            num3 = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " + " + num2 + " = " + num3);
            Console.ReadLine();
        }

        static void Ex3()
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Please enter the first number to divide");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number to divide");
            num2 = int.Parse(Console.ReadLine());
            num3 = num1 / num2;
            Console.WriteLine("The answer for " + num1 + " / " + num2 + " = " + num3);
            Console.ReadLine();

        }

        static void Ex4()
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Please enter the first number to multiply");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number to multipy");
            num2 = int.Parse(Console.ReadLine());
            num3 = num1 * num2;
            Console.WriteLine("The product of " + num1 + " x " + num2 + " = " + num3);
            Console.ReadLine();
        }

        static void Ex5()
        {
            int num1;
            int i;
            Console.WriteLine("Please enter a number and its multiples up to 10 will be displayed");
            num1 = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(num1 * i);
            }
            Console.ReadLine();
        }

        static void Ex6()
        {
            double radius;
            double pi = 3.14159265359;
            double area;
            double perimeter;

            Console.WriteLine("Please enter the radius of the circle to calcuate area and perimeter");
            radius = double.Parse(Console.ReadLine());
            area = pi * (radius * radius);
            perimeter = (2 * pi) * radius;
            Console.WriteLine("The area of the circle is " + area + " and the perimeter is " + perimeter);
            Console.ReadLine();
        }

        static void Ex7()
        {
            double variable1;
            double variable2;
            double tempvariable;

            Console.WriteLine("Please enter the first number to be stored as variable 1");
            variable1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the first number to be stored as variable 2");
            variable2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Press enter to swap the variable values you have entered");
            Console.ReadLine();
            tempvariable = variable1;
            variable1 = variable2;
            variable2 = tempvariable;
            Console.WriteLine("Variable 1 is now " + variable1 + " and variable 2 is now " + variable2);
            Console.ReadLine();
        }

        static void Ex8()
        {
            int[] array1 = new int[1000];
            for (int i = 0; i <= 999; i++)
            {
                array1[i] = new Random().Next(1000, 9999);
                Console.WriteLine(array1[i]);
            }
            Console.ReadLine();
        }

        static void Ex9()
        {
            int min = 100;
            int max = 999;
            int size = 100;
            Random random = new Random();
            int[] array1 = new int[size];
            for (int i = 0; i < array1.Length; i++)    
            {
                int num = random.Next(min, max);
                while(array1.Contains(num))
                {
                    num = random.Next(min, max);
                }
                array1[i] = num;

            }
            Array.Sort(array1);
            foreach (int x in array1)
            {
                Console.WriteLine("{0} ", x);
            }
            Console.ReadLine();
        }
    }
}
