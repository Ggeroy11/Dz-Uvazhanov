using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace ConsoleApplication12
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(" 1 задание ");
                Console.WriteLine(" 1  2  3");
                Console.WriteLine(" \n\n2 задание ");
                Console.WriteLine("5\n10\n21");
                Console.WriteLine(" \n\n3 задание ");
                Console.WriteLine("Дано растояние  " + 1024 + "см");
                Console.WriteLine(" Растояние в метрах  " + 1024 / 100 + "м");
                Console.WriteLine(" \n\n4 задание ");
                Console.Write(234 / 7);
                Console.WriteLine(" \n\n5 задание ");
                int number = 65;
                Console.WriteLine("Дано число: " + number);
                Console.WriteLine("Число десятков: " + number / 10);
                Console.WriteLine("Число едениц: " + number % 10);
                Console.WriteLine("Сумма его цифр: " + ((number / 10) + (number % 10)));
                Console.WriteLine("Произведение его цифр: " + ((number / 10) * (number % 10)));
                Console.WriteLine(" \n\n6 задание ");
                bool A = true;
                bool B = false;
                bool C = false;
                Console.WriteLine("A или B" + (A || B));
                Console.WriteLine("A или B" + (A & B));
                Console.WriteLine("A или B" + (B || C));
                Console.WriteLine(" \n\n7 задание ");
                int radius = 25;
                int a = 5;
                double Sr;
                int Sa;
                Sr = 3.14 * radius * radius;
                Sa = a * a;
                Console.WriteLine("Площадь круга " + Sr);
                Console.WriteLine("Площадь квдарата " + Sa);
                if (Sa > Sr)
                {
                    Console.WriteLine("Площадь квадрата больше");
                }
                else
                {
                    Console.WriteLine("Площадь круга больше");
                }
                Console.WriteLine(" \n\n8 задание ");
                int V1 = 25;
                int m1 = 35;
                int V2 = 45;
                int m2 = 5;
                int p1 = m1 / V1;
                int p2 = m2 / V2;
                if (p1 > p2)
                {
                    Console.WriteLine("Плотность первого материала больше ");
                }
                else
                {
                    Console.WriteLine("Плотность второго  материала больше ");
                }
                Console.WriteLine(" \n\n9 задание ");
                int R1 = 220;
                int R2 = 100;
                int U1 = 6;
                int U2 = 12;
                int I1 = U1 / R1;
                int I2 = U2 / R2;
                if (I1 > I2)
                {
                    Console.WriteLine("по второму участку течет меньший ток");
                }
                else
                {
                    Console.WriteLine("по первому участку течет меньший ток");
                }
                Console.WriteLine(" \n\n10 задание ");
                Console.WriteLine("a) Все целые числа от 20 до 35");
                for (int i = 20; i <= 35; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("b)квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);");
                Console.WriteLine("Введите чилсло больше 10");
                string number1 = Console.ReadLine();
                int num = Int32.Parse(number1);
                for (int i = 10; i <= num; i++)
                {

                    Console.WriteLine(i * i);
                }
                Console.WriteLine("c.третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);");
                Console.WriteLine("Введите число меньше 50");
                string dip = Console.ReadLine();
                int num1 = Int32.Parse(dip);
                for (int i = num1; i < 50; i++)
                {
                    Console.WriteLine(i * i * i);
                }
                Console.WriteLine("d.все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).");
                Console.WriteLine("Введите диапазон  a и b");
                string g = Console.ReadLine();
                string n = Console.ReadLine();
                int go = Int32.Parse(g);
                int no = Int32.Parse(n);
                for (int i = go; i <= no; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
        }
    }

}
    }
}
