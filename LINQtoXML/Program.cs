using System;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace XML_LINQ
{
	class Program
	{
		static void Main(string[] args)
		{
			//XDocument xdoc = XDocument.Load(@"TestXML2.xml");
			
			//xdoc.Descendants("product").Select(p => new
			//{

			//	id = p.Attribute("id").Value,
			//	name = p.Element("name").Value,

			//}).ToList().ForEach(p => {

			//	Console.WriteLine("Id: " + p.id);
   //             Console.WriteLine("Name: " + p.name);

			//});

			//Console.ReadLine();

			XDocument xdoc = XDocument.Load(@"XmlFile.xml");

            xdoc.Descendants("Customer").Select(p => new
            {

                customerID = p.Attribute("CustomerID").Value,
                companyName = p.Element("CompanyName").Value,
                contactName = p.Element("ContactName").Value,
                contactTitle = p.Element("ContactTitle").Value,
                phone = p.Element("Phone").Value,
                fax = p.Element("Fax")?.Value

              
			}).ToList().ForEach(p => {

				Console.WriteLine("CustomerID: " + p.customerID);
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

            xdoc.Descendants("FullAddress").Select(p => new
			{

				address = p.Element("Address").Value,
				city = p.Element("City").Value,
                region = p.Element("Region").Value,
                postalCode = p.Element("PostalCode").Value,
				country = p.Element("Country").Value,
				

			}).ToList().ForEach(p => {

                Console.WriteLine("FullAddress: \nAddress: " + p.address);
                Console.WriteLine("City: " + p.city);
                Console.WriteLine("Region: " + p.region);
                Console.WriteLine("PostalCode: " + p.postalCode);
                Console.WriteLine("Country: " + p.country);
				Console.WriteLine("=================================");

			});


			Console.ReadLine();
		}
	}
}
