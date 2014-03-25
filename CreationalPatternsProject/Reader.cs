using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CreationalPatternsProject
{
    abstract class IReaderFactory
    {
        public abstract IReader getReader(string country);
    }

    class ReaderFactory : IReaderFactory
    {
        public override IReader getReader(string country)
        {
            if (country == "Great Britan")
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
        XDocument readFile();
    }

    public class JReader : IReader
    {
        string jsonPath = @"../../InputFiles/FoodItemData.json";
        XDocument xDoc;

        public XDocument readFile()
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
                }
                
                return xDoc;
            }
        }
    }

    public class XReader : IReader
    {
        string xmlPath = @"../../InputFiles/FoodItemData.xml";
        XDocument xDoc;

        public XDocument readFile()
        {
            xDoc = XDocument.Load(xmlPath);

            return xDoc;
        }
    }
}
