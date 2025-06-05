using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        enum Days
        {
            понедельник, вторник, среда, четверг, пятница, суббота, воскресенье
        }
        static void Main(string[] args)
        {
            Days i;
            for (i = Days.понедельник; i <= Days.воскресенье; i++)
                Console.WriteLine(i + " имеет значение " + (int)i);
            Console.ReadKey();
        }
    }
}
