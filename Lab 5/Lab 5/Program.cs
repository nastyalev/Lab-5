using NLog;
using System;

namespace Lab_5
{
    class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        [My(name = "Настя", lastname = "Левитова")]
        static void Main()
        {
            try
            {
                double a, b;
                char s;
                double c = 0.0;

                log.Trace("Запуск.");
                log.Trace("Приложение калькулятор.");
                
                Console.WriteLine("Приложение калькулятор.");
                Console.WriteLine("Ввод дробных чисел в виде 0,0");
                Console.WriteLine();
                
                log.Trace("Ввод первого числа.");
                Console.WriteLine("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());

                log.Trace("Ввод знака операции.");
                Console.WriteLine("Введите операцию: (+ - * /) ");
                s = Convert.ToChar(Console.ReadLine());
                
                log.Trace("Ввод второго числа.");
                Console.WriteLine("Введите второе число: ");
                b = Convert.ToDouble(Console.ReadLine());

                switch (s)
                {
                    case '+':
                        c = a + b;
                        Console.WriteLine("Результат = " + c);
                        break;

                    case '-':
                        c = a - b;
                        Console.WriteLine("Результат = " + c);
                        break;

                    case '/':
                        c = a / b;
                        Console.WriteLine("Результат = " + c);
                        break;

                    case '*':
                        c = a * b;
                        Console.WriteLine("Результат = " + c);
                        break;

                    default:
                        Console.WriteLine("Неверный оператор!");
                        log.Trace("Неверный оператор!");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка!");
                log.Error("Неверный формат! {0}", ex.Source);
            }
        }
    }
}



           
