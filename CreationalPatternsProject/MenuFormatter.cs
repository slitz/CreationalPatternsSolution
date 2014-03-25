using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CreationalPatternsProject
{
    abstract class IMenuFormatterFactory
    {
        public abstract IMenuFormatter getFormatter(string menuFormat);
    }

    class MenuFormatterFactory : IMenuFormatterFactory
    {
        public override IMenuFormatter getFormatter(string menuFormat)
        {
            if (menuFormat == "Text")
            {
                return new TextMenuFormatter();
            }
            else if (menuFormat == "HTML")
            {
                return new HtmlMenuFormatter();
            }
            else
            {
                return new XmlMenuFormatter();
            }
        }
    }

    public interface IMenuFormatter
    {
        string generateMenu(string menu);
    }

    public class TextMenuFormatter : IMenuFormatter
    {
        public string generateMenu(string menu)
        {
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".txt";
            string menuItems = string.Empty;
            string breakfastItems = string.Empty;
            string snackItems = string.Empty;
            string appetizerItems = string.Empty;
            string lunchItems = string.Empty;
            string dinnerItems = string.Empty;
            string dessertItems = string.Empty;
            string sideItems = string.Empty;
            int pad = 95;

            XmlDocument xml = new XmlDocument();
            xml.LoadXml("<root>" + menu + "</root>");
            XmlNodeList nodes = xml.SelectNodes("/root/FoodItem");

            foreach (XmlNode node in nodes)
            {
                string name = node["name"].InnerText;
                string description = node["description"].InnerText;
                string price = node["price"].InnerText;
                string category = node["category"].InnerText;

                if (node["category"].InnerText == FoodItemCategory.Breakfast.ToString())
                {
                    breakfastItems += name.PadRight(pad) + price + "\n" + description + "\n\n";
                }
                else if (node["category"].InnerText == FoodItemCategory.Snack.ToString())
                {
                    snackItems += name.PadRight(pad) + price + "\n" + description + "\n\n";
                }
                else if (node["category"].InnerText == FoodItemCategory.Appetizer.ToString())
                {
                    appetizerItems += name.PadRight(pad) + price + "\n" + description + "\n\n";
                }
                else if (node["category"].InnerText == FoodItemCategory.Lunch.ToString())
                {
                    lunchItems += name.PadRight(pad) + price + "\n" + description + "\n\n";
                }
                else if (node["category"].InnerText == FoodItemCategory.Dinner.ToString())
                {
                    dinnerItems += name.PadRight(pad) + price + "\n" + description + "\n\n";
                }
                else if (node["category"].InnerText == FoodItemCategory.Dessert.ToString())
                {
                    dessertItems += name.PadRight(pad) + price + "\n" + description + "\n\n";
                }
                else
                {
                    sideItems += name.PadRight(pad) + price + "\n" + description + "\n\n";
                }
            }

            if (!string.IsNullOrEmpty(breakfastItems))
            {
                menuItems += FoodItemCategory.Breakfast.ToString().ToUpper() + "\n\n" + breakfastItems;
            }
            if (!string.IsNullOrEmpty(snackItems))
            {
                menuItems += FoodItemCategory.Snack.ToString().ToUpper() + "\n\n" + snackItems;
            }
            if (!string.IsNullOrEmpty(appetizerItems))
            {
                menuItems += FoodItemCategory.Appetizer.ToString().ToUpper() + "\n\n" + appetizerItems;
            }
            if (!string.IsNullOrEmpty(lunchItems))
            {
                menuItems += FoodItemCategory.Lunch.ToString().ToUpper() + "\n\n" + lunchItems;
            }
            if (!string.IsNullOrEmpty(dinnerItems))
            {
                menuItems += FoodItemCategory.Dinner.ToString().ToUpper() + "\n\n" + dinnerItems;
            }
            if (!string.IsNullOrEmpty(dessertItems))
            {
                menuItems += FoodItemCategory.Dessert.ToString().ToUpper() + "\n\n" + dessertItems;
            }
            if (!string.IsNullOrEmpty(sideItems))
            {
                menuItems += FoodItemCategory.Side.ToString().ToUpper() + "\n\n" + sideItems;
            }

            using (StreamWriter sw = new StreamWriter("../../OutputFiles/" + fileName))
            {
                sw.Write(menuItems);
            }

            return fileName;
        }
    }

    public class HtmlMenuFormatter : IMenuFormatter
    {
        public string generateMenu(string menu)
        {
            
            return "";
        }
    }

    public class XmlMenuFormatter : IMenuFormatter
    {
        string outputPath = @"../../OutputFiles/";
        string fileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xml";
        public string generateMenu(string menu)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml("<root>" + menu + "</root>");
            
            XmlTextWriter writer = new XmlTextWriter(outputPath + fileName, null);
            writer.Formatting = Formatting.Indented;
            xml.Save(writer);
            return fileName;
        }
    }
}
