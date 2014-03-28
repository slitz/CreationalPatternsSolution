using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CreationalPatternsProject
{
    public abstract class IReaderFactory
    {
        public abstract IReader getReader(string country);
    }

    public class ReaderFactory : IReaderFactory
    {
        public override IReader getReader(string country)
        {
            if (country == "GB")
            {
                return new XReader();
            }
            else
            {
                return new JReader();
            }
        }
    }

    public interface IReader
    {  
        XDocument readFile(string currency);
    }

    public class JReader : IReader
    {
        string jsonPath = @"../../InputFiles/FoodItemData.json";
        XDocument xDoc;

        public XDocument readFile(string currency)
        {
            using (StreamReader r = new StreamReader(jsonPath))
            {
                string json = r.ReadToEnd();

                // Change format to XML so the IMenuGenerator classes have a common format to work with
                xDoc = JsonConvert.DeserializeXNode(json, "root");

                // Change the element name to FoodItem so the IMenuGenerator classes have common element names to work with 
                var elements = xDoc.Root.Elements("FoodItemData");
                foreach (XElement e in elements)
                {
                    e.Name = "FoodItem";
                    e.Add(new XElement("currencycode", currency));
                }
                
                return xDoc;
            }
        }
    }

    public class XReader : IReader
    {
        string xmlPath = @"../../InputFiles/FoodItemData.xml";
        XDocument xDoc;

        public XDocument readFile(string currency)
        {
            xDoc = XDocument.Load(xmlPath);

            // Add new node for country so the IMenuGenerator classes have common elements to work with 
            var elements = xDoc.Root.Elements("FoodItem");
            foreach (XElement e in elements)
            {
                string c = e.Attribute("country").Value;
                e.Add(new XElement("country", c));
                e.Add(new XElement("currencycode", currency));
            }

            return xDoc;
        }
    }
}
