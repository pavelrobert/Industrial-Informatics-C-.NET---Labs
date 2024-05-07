using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Exemp1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public class Element
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        [WebMethod(Description = "This method displays a message")]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod(Description = "This method calculates and displays the sum of 2 numbers")]
        public int Add(int a, int b)
        {
            return a + b;
        }
        [WebMethod(Description = "This method calculates from F to C")]
        public double fromCtoF(double C)
        {
            double result1;
            result1 = C * 9 / 5 + 32;
            return result1;
        }
        [WebMethod(Description = "This method calculates from C to F")]
        public double fromFtoC(double F)
        {
            double result2;
            result2 = (F - 32) * 5 / 9;
            return result2;
        }
        [WebMethod(Description = "This method displays the current date and time")]
        public DateTime getCurrentDateAndTime()
        {
            return DateTime.Now;
        }
        [WebMethod(Description = "This method displays a list with 5 elements")]
       
        public List<Element> getListOfElements()
        {
            List<Element> elements = new List<Element>();
            for(int i = 0; i < 5; i++)
            {
                Element element = new Element
                {
                    Id = i, Name = "Element" + i
                };
                elements.Add(element);
            }
            return elements;
        }
        [WebMethod(Description = "This method converts from lei to Euro")]
        public double leiToEuro(double lei)
        {
            double result;
            result = lei / 4.95;
            return result;

        }
        [WebMethod(Description = "This method converts from euro to lei")]
        public double euroToLei(double euro)
        {
            double result;
            result = euro * 4.95;
            return result;
        }
    }
}
