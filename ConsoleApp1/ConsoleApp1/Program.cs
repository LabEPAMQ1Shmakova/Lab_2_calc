using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Method1(double a, double b, double total, char oper);
        { 
         
        
        }
        static void Main(string[] args)
        {
            

            do
            {
                Console.Clear();
                Console.WriteLine("Консольный калькулятор");
                Console.WriteLine("Введите первое число");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выберите действие:");
                Console.WriteLine("Сложение (знак +)");
                Console.WriteLine("Вычитание (знак -)");
                Console.WriteLine("Умножение(знак *)");
                Console.WriteLine("Деление(знак /)");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                b = Convert.ToDouble(Console.ReadLine());

                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("Сумма равна " + total);
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Разность равна " + total);
                }
                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Произведение равно " + total);
                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine("Частное равно " + total);
                }

                else
                {
                    Console.WriteLine("Действие введено неверно!");

                }

                Console.WriteLine("Для продолжения вычислений нажмите любую клавишу");
                Console.WriteLine("Для выхода нажмите клавишу Escape");

            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);

                      
        }
    }
}
