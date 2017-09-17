using System;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading;


namespace XML_LINQ
{
	class Program
	{
		static void Main(string[] args)
		{
		
			XDocument xdoc = XDocument.Load(@"XmlFile.xml");
            XDocument xdoc1 = XDocument.Load(@"TestXML2.xml");
            xdoc.Descendants().First();
            xdoc.Descendants("Root").Descendants("Customers").Select(p => new
            {

           //     customerID = p.Attribute("CustomerID")?.Value,
                companyName = p.Element("CompanyName")?.Value,
                contactName = p.Element("ContactName")?.Value,
                contactTitle = p.Element("ContactTitle")?.Value,
                phone = p.Element("Phone")?.Value,
                fax = p.Element("Fax")?.Value
                                     
			}).ToList().ForEach(p => {

				//Console.WriteLine("CustomerID: " + p.customerID);
				Console.WriteLine("CompanyName: " + p.companyName);
                Console.WriteLine("ContactName: " + p.contactName);
                Console.WriteLine("ContactTitle: " + p.contactTitle);
                Console.WriteLine("Phone: " + p.phone);

                if (!String.IsNullOrEmpty(p.fax))
				{
                    Console.WriteLine("Fax: " + p.fax);
				}

                Console.WriteLine("=================================");

			});

   //         xdoc.Descendants("FullAddress").Select(p => new
			//{

			//	address = p.Element("Address").Value,
			//	city = p.Element("City").Value,
   //             region = p.Element("Region").Value,
   //             postalCode = p.Element("PostalCode").Value,
			//	country = p.Element("Country").Value
		
			//}).ToList().ForEach(p => {

   //             Console.WriteLine("FullAddress: \nAddress: " + p.address);
   //             Console.WriteLine("City: " + p.city);
   //             Console.WriteLine("Region: " + p.region);
   //             Console.WriteLine("PostalCode: " + p.postalCode);
   //             Console.WriteLine("Country: " + p.country);
			//	Console.WriteLine("==================================");

			//});

			//xdoc.Descendants("Order").Select(p => new
			//{

			//	customerID = p.Element("CustomerID").Value,
			//	employeeID = p.Element("EmployeeID").Value,
			//	orderDate = p.Element("OrderDate").Value,
			//	requiredDate = p.Element("RequiredDate").Value,
   //             shippedDate = p.Attribute("ShippedDate").Value

			//}).ToList().ForEach(p => {

			//	Console.WriteLine("CustomerID: " + p.customerID);
			//	Console.WriteLine("EmployeeID: " + p.employeeID);
			//	Console.WriteLine("OrderDate: " + p.orderDate);
			//	Console.WriteLine("RequiredDate: " + p.requiredDate);
			//	Console.WriteLine("ShippedDate: " + p.shippedDate);
			//	Console.WriteLine("==================================");

			//});

			//Console.ReadLine();
		}
	}
}
