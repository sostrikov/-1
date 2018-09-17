using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Цикл foreach
            Console.Write("\nЦикл foreach: ");
            int[] array1 = { 1, 2, 3 };
            foreach (int i2 in array1)
                Console.Write(i2);
            

            //Цикл while
            Console.Write("\nЦикл while: ");
            int i3 = 1;
            while (i3 <= 5)
            {
                Console.Write(i3);
                i3++;
            }
            //Цикл do while
            Console.Write("\nЦикл do while: ");
            int i4 = 0;
            do
            {
                Console.Write(i4);
                i4++;
            } while (i4 < 3);

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Обработка исключений bbbaaa
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            /*
            Console.WriteLine("\n\nДеление на 0:");
            try
            {
                
                int num1 = 1;
                int num2 = 1;
                string zero = "0";
                int.TryParse(zero, out num2);
                int num3 = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Попытка деления на 0");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Собственное исключение");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Это сообщение выводится в блоке finally");
            }
            */
            //-------------------------------------------------------------------
            //Console.WriteLine("\nСобственное исключение:");
            try
            {
                throw new Exception("!!! Новое исключение !!!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Попытка деления на 0");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nМое собственное исключение");
                Console.WriteLine(e.Message);
            }
           /* finally
            {
                Console.WriteLine("Это сообщение выводится в блоке finally");
            }
            */
            Console.ReadKey();
        }
    }
}
