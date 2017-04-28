using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = CreateCustomerFromXml.ParseCustomerXml("C:\\temp\\sample_xml_2.xml");
            var generateDocx = new GenerateDocx();
            generateDocx.Generate(customers);
        }
    }
}
