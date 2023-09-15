using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task42();
        }

        static void Task15()
        {
            for (int i = 20; i < 36; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 10; i < b; i++)
            {
                Console.Write((i * i) + " ");
            }

            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < 50; i++)
            {
                Console.Write((i * i * i) + " ");
            }

            int a2, b2;
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                Console.Write((i) + " ");
            }

        }
        static void Task14()
        {
            double rezist1 = Convert.ToInt32(Console.ReadLine());
            double rezist2 = Convert.ToInt32(Console.ReadLine());
            double volt1 = Convert.ToInt32(Console.ReadLine());
            double volt2 = Convert.ToInt32(Console.ReadLine());
            double I1 = volt1 / rezist1;
            double I2 = volt2 / rezist2;
            if (I1 < I2)
            {
                Console.WriteLine("I1 less: " + I1);
            }
            else if (I2 < I1)
            {
                Console.WriteLine("I2 less: " + I2);
            }
            else
            {
                Console.WriteLine("power is equal");
            }
        }
        static void Task13()
        {
            double v1 = Convert.ToInt32(Console.ReadLine());
            double v2 = Convert.ToInt32(Console.ReadLine());
            double m1 = Convert.ToInt32(Console.ReadLine());
            double m2 = Convert.ToInt32(Console.ReadLine());
            double p1 = m1 * v1;
            double p2 = m2 * v2;

            if (p1 > p2)
            {
                Console.WriteLine("Material 1 better: " + p1);
            }
            else if (p1 < p2)
            {
                Console.WriteLine("Material 2 better: " + p2);
            }
            else
            {
                Console.WriteLine("materials density is equal");
            }
        }
        static void Task12()
        {
            int radius = Convert.ToInt32(Console.ReadLine());
            int storona = Convert.ToInt32(Console.ReadLine());
            double pr2 = 3.14 * (radius * radius);
            double storona2 = storona * storona;
            if (pr2 > storona2)
            {
                Console.WriteLine("Circle: " + pr2);
            }
            else if (pr2 < storona2)
            {
                Console.WriteLine("Square: " + storona2);
            }
            else
            {
                Console.WriteLine("equal");
            }
        }
        static void Task11()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            bool a = A || B;
            bool b = A && B;
            bool c = B || C;
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void Task10()
        {
            int twice = Convert.ToInt32(Console.ReadLine());
            int a = twice / 10;
            int b = twice % 10;
            int c = a + b;
            int d = a * b;
            Console.WriteLine(a + " " + b + " " + c + " " + d);
        }
        static void Task9()
        {
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("weeks: " + days / 7);
        }
        static void Task8()
        {
            int cm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m: " + cm / 100);
        }
        static void Task7()
        {
            Console.Write("5");
            Console.Write("10");
            Console.Write("15");
        }
        static void Task6()
        {
            Console.WriteLine(" 1 2 3 ");
        }
        static void Task25()
        {
            int number = int.Parse(Console.ReadLine());

            int digit1 = (number / 10) % 10;
            int digit2 = number % 10;

            int sum = digit1 + digit2;
            int product = digit1 * digit2;

            Console.WriteLine("desiatki: " + digit1);
            Console.WriteLine("edinits: " + digit2);
            Console.WriteLine("summ: " + sum);
            Console.WriteLine("product: " + product);
        }
        static void Task23()
        {
            double v = Convert.ToInt32(Console.ReadLine());
            double m = Convert.ToInt32(Console.ReadLine());
            double p = m * v;
            Console.WriteLine("plotnost: " + p);
        }
        static void Task26()
        {
            int number = int.Parse(Console.ReadLine());


            int digit1 = number / 1000;
            int digit2 = (number / 100) % 10;
            int digit3 = (number / 10) % 10;
            int digit4 = number % 10;

            int sum = digit1 + digit2 + digit3 + digit4;
            int product = digit1 * digit2 * digit3 * digit4;

            Console.WriteLine("summ: " + sum);
            Console.WriteLine("product: " + product);
        }
        static void Task41()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} pound = {i*0.453} kg");
            }
        }
        static void Task42()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"9 x {i} = " + 9*i);
            }
        }
        static void Task39()
        {
            int num = 20;
            for (int i = 0; i < 10; i++) 
            {
                Console.Write(" " + num);
            }
        }
        static void Task30()
        {
            float first = float.Parse(Console.ReadLine());
            float second = float.Parse(Console.ReadLine());

            if(first > second)
            {
                Console.WriteLine("first bigger: " +  first);
                Console.WriteLine("second less: " + second);
            } else if(second > first)
            {
                Console.WriteLine("second bigger: " + second);
                Console.WriteLine("first less: " + first);
            } else
            {
                Console.WriteLine("they equal");
            }
        }
        static void Task33()
        {
            int number = int.Parse(Console.ReadLine());

            int odin = number / 10;
            int dva = number % 10;

            if(odin == dva)
            {
                Console.WriteLine("ravni");
            } else if(odin > dva)
            {
                Console.WriteLine("odin bolshe dva: " + odin);
            }
            else
            {
                Console.WriteLine("dva bolshe odin: " + dva);
            }
        }
        static void Task31()
        {
            double km = Convert.ToDouble(Console.ReadLine());
            double ft = Convert.ToDouble(Console.ReadLine());
            double kmft = ft * 0.305;
            if(km < kmft)
            {
                Console.WriteLine("menshe: " + km);
            } else { Console.WriteLine("menshe: " +  kmft); }
        }
        static void Task1()
        {
            int spaces = 0;
            char inchar;

            do
            {
                inchar = Console.ReadKey().KeyChar;

                if (inchar == ' ')
                {
                    spaces++;
                }
            }
            while (inchar != '.');
            Console.WriteLine("spaces: " +  spaces);
        }
    }
}
