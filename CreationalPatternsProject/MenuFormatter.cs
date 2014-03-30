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
    public abstract class IMenuFormatterFactory
    {
        public abstract IMenuFormatter getFormatter(string menuFormat);
    }

    public class MenuFormatterFactory : IMenuFormatterFactory
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
            string fileName = MenuSelection.Instance.Country.ToString() + MenuSelection.Instance.RestaurantCategory.ToString() + "Menu" + ".txt";
            string menuItems = string.Empty;
            string breakfastItems = string.Empty;
            string snackItems = string.Empty;
            string appetizerItems = string.Empty;
            string lunchItems = string.Empty;
            string dinnerItems = string.Empty;
            string dessertItems = string.Empty;
            string sideItems = string.Empty;

            XmlDocument xml = new XmlDocument();
            xml.LoadXml("<root>" + menu + "</root>");
            XmlNodeList nodes = xml.SelectNodes("/root/FoodItem");

            foreach (XmlNode node in nodes)
            {
                string name = node["name"].InnerText;
                string description = node["description"].InnerText;
                string price = node["price"].InnerText;
                string category = node["category"].InnerText;
                string currencyCode = node["currencycode"].InnerText;

                if (node["category"].InnerText == FoodItemCategory.Breakfast.ToString())
                {
                    breakfastItems += addToFoodItem(name, currencyCode, price, description); 
                }
                else if (node["category"].InnerText == FoodItemCategory.Snack.ToString())
                {
                    snackItems += addToFoodItem(name, currencyCode, price, description); 
                }
                else if (node["category"].InnerText == FoodItemCategory.Appetizer.ToString())
                {
                    appetizerItems += addToFoodItem(name, currencyCode, price, description); 
                }
                else if (node["category"].InnerText == FoodItemCategory.Lunch.ToString())
                {
                    lunchItems += addToFoodItem(name, currencyCode, price, description); 
                }
                else if (node["category"].InnerText == FoodItemCategory.Dinner.ToString())
                {
                    dinnerItems += addToFoodItem(name, currencyCode, price, description); 
                }
                else if (node["category"].InnerText == FoodItemCategory.Dessert.ToString())
                {
                    dessertItems += addToFoodItem(name, currencyCode, price, description); 
                }
                else
                {
                    sideItems += addToFoodItem(name, currencyCode, price, description); 
                }
            }

            if (!string.IsNullOrEmpty(breakfastItems))
            {
                menuItems += addToMenuItems(FoodItemCategory.Breakfast.ToString().ToUpper(), breakfastItems);
            }
            if (!string.IsNullOrEmpty(snackItems))
            {
                menuItems += addToMenuItems(FoodItemCategory.Snack.ToString().ToUpper(), snackItems);
            }
            if (!string.IsNullOrEmpty(appetizerItems))
            {
                menuItems += addToMenuItems(FoodItemCategory.Appetizer.ToString().ToUpper(), appetizerItems);
            }
            if (!string.IsNullOrEmpty(lunchItems))
            {
                menuItems += addToMenuItems(FoodItemCategory.Lunch.ToString().ToUpper(), lunchItems);
            }
            if (!string.IsNullOrEmpty(dinnerItems))
            {
                menuItems += addToMenuItems(FoodItemCategory.Dinner.ToString().ToUpper(), dinnerItems);
            }
            if (!string.IsNullOrEmpty(dessertItems))
            {
                menuItems += addToMenuItems(FoodItemCategory.Dessert.ToString().ToUpper(), dessertItems);
            }
            if (!string.IsNullOrEmpty(sideItems))
            {
                menuItems += addToMenuItems(FoodItemCategory.Side.ToString().ToUpper(), sideItems);
            }

            using (StreamWriter sw = new StreamWriter("../../OutputFiles/" + fileName))
            {
                sw.Write(menuItems);
            }

            return fileName;
        }

        // Method to add the food items
        public string addToFoodItem(string name, string currencyCode, string price, string description)
        {
            int pad = 95;
            return name.PadRight(pad) + currencyCode + price + Environment.NewLine + description + Environment.NewLine + Environment.NewLine;
        }

        // Method to add the food categories
        public string addToMenuItems(string category, string items)
        {
            return category + Environment.NewLine + Environment.NewLine + items;
        }
    }

    public class HtmlMenuFormatter : IMenuFormatter
    {
        public string generateMenu(string menu)
        {
            string fileName = MenuSelection.Instance.Country.ToString() + MenuSelection.Instance.RestaurantCategory.ToString() + "Menu" + ".html";
            string menuItems = string.Empty;
            string breakfastItems = string.Empty;
            string snackItems = string.Empty;
            string appetizerItems = string.Empty;
            string lunchItems = string.Empty;
            string dinnerItems = string.Empty;
            string dessertItems = string.Empty;
            string sideItems = string.Empty;

            XmlDocument xml = new XmlDocument();
            xml.LoadXml("<root>" + menu + "</root>");
            XmlNodeList nodes = xml.SelectNodes("/root/FoodItem");

            foreach (XmlNode node in nodes)
            {
                string name = node["name"].InnerText;
                string description = node["description"].InnerText;
                string price = node["price"].InnerText;
                string category = node["category"].InnerText;
                string currencyCode = node["currencycode"].InnerText;

                if (node["category"].InnerText == FoodItemCategory.Breakfast.ToString())
                {
                    breakfastItems += addLineItem(name, description, currencyCode, price);
                }
                else if (node["category"].InnerText == FoodItemCategory.Snack.ToString())
                {
                    snackItems += addLineItem(name, description, currencyCode, price);
                }
                else if (node["category"].InnerText == FoodItemCategory.Appetizer.ToString())
                {
                    appetizerItems += addLineItem(name, description, currencyCode, price);
                }
                else if (node["category"].InnerText == FoodItemCategory.Lunch.ToString())
                {
                    lunchItems += addLineItem(name, description, currencyCode, price);
                }
                else if (node["category"].InnerText == FoodItemCategory.Dinner.ToString())
                {
                    dinnerItems += addLineItem(name, description, currencyCode, price);
                }
                else if (node["category"].InnerText == FoodItemCategory.Dessert.ToString())
                {
                    dessertItems += addLineItem(name, description, currencyCode, price);
                }
                else
                {
                    sideItems += addLineItem(name, description, currencyCode, price);
                }
            }

            if (!string.IsNullOrEmpty(breakfastItems))
            {
                menuItems += addHeader(FoodItemCategory.Breakfast.ToString().ToUpper(), breakfastItems);
            }
            if (!string.IsNullOrEmpty(snackItems))
            {
                menuItems += addHeader(FoodItemCategory.Snack.ToString().ToUpper(), snackItems);
            }
            if (!string.IsNullOrEmpty(appetizerItems))
            {
                menuItems += addHeader(FoodItemCategory.Appetizer.ToString().ToUpper(), appetizerItems);
            }
            if (!string.IsNullOrEmpty(lunchItems))
            {
                menuItems += addHeader(FoodItemCategory.Lunch.ToString().ToUpper(), lunchItems);
            }
            if (!string.IsNullOrEmpty(dinnerItems))
            {
                menuItems += addHeader(FoodItemCategory.Dinner.ToString().ToUpper(), dinnerItems);
            }
            if (!string.IsNullOrEmpty(dessertItems))
            {
                menuItems += addHeader(FoodItemCategory.Dessert.ToString().ToUpper(), dessertItems);
            }
            if (!string.IsNullOrEmpty(sideItems))
            {
                menuItems += addHeader(FoodItemCategory.Side.ToString().ToUpper(), sideItems);
            }

            using (StreamWriter sw = new StreamWriter("../../OutputFiles/" + fileName))
            {
                sw.Write("<HTML><HEAD><TITLE>Menu</TITLE></HEAD><BODY><CENTER>Menu</CENTER>" +  menuItems + "</BODY></HTML>");
            }

            return fileName;
        }

        // Mehtod to add the line items
        public string addLineItem(string name, string description, string currencyCode, string price)
        {
            return "<LI>" + name + "<BR>" + "<I>" + description + "</I><BR>" + currencyCode + price + "</LI>";
        }

        // Method to add the headers
        public string addHeader(string heading, string category)
        {
            return "<H1>" + heading + "</H1><UL>" + category + "</UL>";
        }
    }


    public class XmlMenuFormatter : IMenuFormatter
    {
        string outputPath = @"../../OutputFiles/";
        string fileName = MenuSelection.Instance.Country.ToString() + MenuSelection.Instance.RestaurantCategory.ToString() + "Menu" + ".xml";

        public string generateMenu(string menu)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml("<root>" + menu + "</root>");
            XmlNodeList nodes = xml.SelectNodes("/root/FoodItem");

            XmlDocument newXml = new XmlDocument();
            XmlElement root = newXml.CreateElement("MenuItems");
            XmlElement breakfast = newXml.CreateElement("FoodItemCategory");
            breakfast.SetAttribute("category", FoodItemCategory.Breakfast.ToString().ToUpper());
            XmlElement snack = newXml.CreateElement("FoodItemCategory");
            snack.SetAttribute("category", FoodItemCategory.Snack.ToString().ToUpper());
            XmlElement appetizer = newXml.CreateElement("FoodItemCategory");
            appetizer.SetAttribute("category", FoodItemCategory.Appetizer.ToString().ToUpper());
            XmlElement lunch = newXml.CreateElement("FoodItemCategory");
            lunch.SetAttribute("category", FoodItemCategory.Lunch.ToString().ToUpper());
            XmlElement dinner = newXml.CreateElement("FoodItemCategory");
            dinner.SetAttribute("category", FoodItemCategory.Dinner.ToString().ToUpper());
            XmlElement dessert = newXml.CreateElement("FoodItemCategory");
            dessert.SetAttribute("category", FoodItemCategory.Dessert.ToString().ToUpper());
            XmlElement side = newXml.CreateElement("FoodItemCategory");
            side.SetAttribute("category", FoodItemCategory.Side.ToString().ToUpper());

            newXml.AppendChild(root);

            foreach (XmlNode node in nodes)
            {
                string name = node["name"].InnerText;
                string description = node["description"].InnerText;
                string price = node["price"].InnerText;
                string category = node["category"].InnerText;
                string currencyCode = node["currencycode"].InnerText;

                // Determine food category for the current node and add as a child node
                if (node["category"].InnerText == FoodItemCategory.Breakfast.ToString())
                {
                    XmlNode menuItem = addNode(newXml, name, description, price, category, currencyCode);

                    breakfast.AppendChild(menuItem);
                    
                }
                else if (node["category"].InnerText == FoodItemCategory.Snack.ToString())
                {
                    XmlNode menuItem = addNode(newXml, name, description, price, category, currencyCode);

                    snack.AppendChild(menuItem);
                }
                else if (node["category"].InnerText == FoodItemCategory.Appetizer.ToString())
                {
                    XmlNode menuItem = addNode(newXml, name, description, price, category, currencyCode);

                    appetizer.AppendChild(menuItem);
                }
                else if (node["category"].InnerText == FoodItemCategory.Lunch.ToString())
                {
                    XmlNode menuItem = addNode(newXml, name, description, price, category, currencyCode);

                    lunch.AppendChild(menuItem);
                }
                else if (node["category"].InnerText == FoodItemCategory.Dinner.ToString())
                {
                    XmlNode menuItem = addNode(newXml, name, description, price, category, currencyCode);

                    dinner.AppendChild(menuItem);
                }
                else if (node["category"].InnerText == FoodItemCategory.Dessert.ToString())
                {
                    XmlNode menuItem = addNode(newXml, name, description, price, category, currencyCode);

                    dessert.AppendChild(menuItem);
                }
                else
                {
                    XmlNode menuItem = addNode(newXml, name, description, price, category, currencyCode);

                    side.AppendChild(menuItem);
                }
            }

            // If FoodItemCategory node has child nodes add it to root
            if (breakfast.HasChildNodes)
            {
                root.AppendChild(breakfast);
            }
            if (snack.HasChildNodes)
            {
                root.AppendChild(snack);
            }
            if (appetizer.HasChildNodes)
            {
                root.AppendChild(appetizer);
            }
            if (lunch.HasChildNodes)
            {
                root.AppendChild(lunch);
            }
            if (dinner.HasChildNodes)
            {
                root.AppendChild(dinner);
            }
            if (dessert.HasChildNodes)
            {
                root.AppendChild(dessert);
            }
            if (side.HasChildNodes)
            {
                root.AppendChild(side);
            }

            // Write xml menu
            XmlTextWriter writer = new XmlTextWriter(outputPath + fileName, null);
            writer.Formatting = Formatting.Indented;
            newXml.Save(writer);
            return fileName;
        }

        // Method to add the food item in the required structure
        public XmlNode addNode(XmlDocument newXml, string name, string description, string price, string category, string currencyCode)
        {
            // Create child nodes
            XmlNode menuItem = newXml.CreateNode(XmlNodeType.Element, "MenuItem", null);
            XmlNode itemName = newXml.CreateNode(XmlNodeType.Element, "Name", null);
            XmlNode itemPrice = newXml.CreateNode(XmlNodeType.Element, "Price", null);
            XmlNode itemCurrencyCode = newXml.CreateNode(XmlNodeType.Element, "CurrencyCode", null);
            XmlNode itemAmount = newXml.CreateNode(XmlNodeType.Element, "Amount", null);
            XmlNode itemDescription = newXml.CreateNode(XmlNodeType.Element, "Description", null);

            // Add inner text
            itemName.InnerText = name;
            itemCurrencyCode.InnerText = currencyCode;
            itemAmount.InnerText = price;
            itemDescription.InnerText = description;

            // Append nodes
            itemPrice.AppendChild(itemCurrencyCode);
            itemPrice.AppendChild(itemAmount);
            menuItem.AppendChild(itemName);
            menuItem.AppendChild(itemPrice);
            menuItem.AppendChild(itemDescription);

            return menuItem;
        }
    }
}
