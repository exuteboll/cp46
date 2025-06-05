using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        enum Days
        {
            Январь, Февраль, Март ,Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь 
        }
        static void Main(string[] args)
        {
            Days i;
            for (i = Days.Январь; i <= Days.Декабрь;i++) 
                Console.WriteLine((int)i + " " + i);
            Console.ReadKey();
        }
    }
}
