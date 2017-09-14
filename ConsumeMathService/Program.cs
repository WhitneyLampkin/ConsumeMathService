using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsumeMathService
{
    class Program
    {
        static void Main(string[] args)
        {
            //This code creates an instance of the proxy object that was created
            localhost.MyMathService myMathService = new localhost.MyMathService();
            Console.Write("2 + 4 = {0}", myMathService.Add(2, 4));
            Console.ReadLine();
        }
    }
}
