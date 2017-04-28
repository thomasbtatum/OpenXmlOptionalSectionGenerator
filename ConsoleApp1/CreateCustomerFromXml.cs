using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    public static class CreateCustomerFromXml
    {

        //see http://stackoverflow.com/a/5195781/819019
        //and http://stackoverflow.com/a/8417377/819019
        public static IEnumerable<Customer> ParseCustomerXml(string xmlFileName)
        {
            System.Xml.Linq.XNamespace ns = "https://schemas.mycorp.com";
            System.Xml.Linq.XDocument doc = System.Xml.Linq.XDocument.Load(xmlFileName);
            var Customers = from c in doc.Descendants(ns + "Customer")
                            select new Customer()
                            {
                                Name = (string)c.Descendants(ns + "Name").FirstOrDefault(),
                                Orders = from o in c.Descendants(ns + "Order")
                                         select new Order() 
                                                  {
                                                      Id = (string) o.Descendants(ns + "Id").FirstOrDefault(),
                                                      Date = (string)o.Descendants(ns + "Date").FirstOrDefault()
                                                  }
                            };
            int x = 1;

            return Customers;
        }
    }
}
