using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
            /*Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции
             * (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ.
             * Используйте обработку исключений для защиты от ввода некорректных данных.
             * */
            
        {
            double a=0 , b=0 , Div, Mul, Sum, Ext;
            int Code=0;
            
            Console.WriteLine("Введите первое число:");
            try
            {a=Convert.ToDouble(Console.ReadLine());}
            catch (FormatException) 
            {Console.WriteLine("Неверный формат числа");}
            
            Console.WriteLine("Введите второе число:");
            try{ b = Convert.ToDouble(Console.ReadLine()); }
            catch (FormatException)
            { Console.WriteLine("Неверный формат числа"); }

            Sum = (a + b);
            Div = (a / b);
            Mul = (a * b);
            Ext = (a - b);
            
            Console.WriteLine("Введите тип действия");
            Console.WriteLine("1-суммировать a и b");
            Console.WriteLine("2-вычесть из a число b");
            Console.WriteLine("3-перемножить a и b");
            Console.WriteLine("4-разделить число a на число b");
            
            
            try
            { Code = Convert.ToInt32(Console.ReadLine()); }
            catch (FormatException)
            { Console.WriteLine("Нет операции с указанным выбором"); }
            if (Code >4 || Code<1)
            { Console.WriteLine("Неверный формат команды"); }
            
            if (Code ==1)
            {
                Console.WriteLine("Результат равен {0}",Sum);
            }
            if (Code == 2)
            {
                Console.WriteLine("Результат равен {0}", Ext);
            }
            if (Code == 3)
            {
                Console.WriteLine("Результат равен{0}",Mul);
            }
            if (Code == 4)
            {
                Console.WriteLine("Результат равен{0}", Div);
            }
            
            
            Console.ReadKey();
        }
        


    }

}
