using System;

namespace DZ_2._2
{
    class Program
    {
        enum Months
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Для того чтобы определить текущий месяц, прошу ввести порядковый его номер с 1 до 12 :");
                Months months;
                int M = int.Parse(Console.ReadLine());         
                months = (Months)M;
            Console.WriteLine($"Текущий месяц {months}");

         }
          


        }

    }



