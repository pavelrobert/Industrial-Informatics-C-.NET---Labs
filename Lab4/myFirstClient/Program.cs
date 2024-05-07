using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myFirstClient.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
            int sum = service.Add(2, 3);
            Console.WriteLine("The sum is " + sum.ToString());
            Console.ReadKey();
        }
    }
}
