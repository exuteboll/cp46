using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        enum Operation
        {
            add, substract, multiply, divide
        }
       
    
            static void Main(string[] args)
        {
            double x =  15;
            double y=  5;
            double result= 0 ;
            Operation op = Operation.divide;

            if(op == Operation.add)
            {
                result = x + y;
            }
            else if ( op == Operation.divide)
            {
                result = x / y;

            }
            else if (op == Operation.multiply)
            {
                result = x * y;
            }
            else if (op == Operation.substract)
            {
                result = x - y;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
