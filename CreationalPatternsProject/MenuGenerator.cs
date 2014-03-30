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
    public abstract class IMenuGeneratorFactory
    {
        public abstract IMenuGenerator getGenerator(string restaurantCatgory);
    }

    public class MenuGeneratorFactory : IMenuGeneratorFactory
    {
        public override IMenuGenerator getGenerator(string restaurantCategory)
        {
            if (restaurantCategory == "Diner")
            {
                return new DinerMenuGenerator();
            }
            else if(restaurantCategory == "EveningOnly")
            {
                return new EveningOnlyMenuGenerator();
            }
            else
            {
                return new AllDayMenuGenerator();
            }
        }
    }

    public interface IMenuGenerator
    {
        string generateMenuItems(XDocument foodItems, string country);
    }

    public class DinerMenuGenerator : IMenuGenerator
    {
        public string generateMenuItems(XDocument foodItems, string country)
        {
            string output = string.Empty;

            FoodItemCategory[] dinerItemsArray = { FoodItemCategory.Breakfast, FoodItemCategory.Lunch, FoodItemCategory.Snack, FoodItemCategory.Appetizer, FoodItemCategory.Dessert };

            var foodItemElements = foodItems.Root.Elements("FoodItem");
            foreach (XElement e in foodItemElements)
            {
                for (int x = 0; x < dinerItemsArray.Length; x++)
                {
                    if (e.Element("country").Value == country)
                    {
                        if (e.Element("category").Value == dinerItemsArray[x].ToString())
                        {
                            output += e.ToString() + "\n";
                        }
                    }
                }
            }
            
            return output;
        }
    }

    public class EveningOnlyMenuGenerator: IMenuGenerator
    {
        public string generateMenuItems(XDocument foodItems, string country)
        {
            string output = string.Empty;

            FoodItemCategory[] eveningOnlyItemsArray = { FoodItemCategory.Dinner, FoodItemCategory.Side, FoodItemCategory.Appetizer, FoodItemCategory.Dessert};

            var foodItemElements = foodItems.Root.Elements("FoodItem");
            foreach (XElement e in foodItemElements)
            {
                for (int x = 0; x < eveningOnlyItemsArray.Length; x++)
                {
                    if (e.Element("country").Value == country)
                    {
                        if (e.Element("category").Value == eveningOnlyItemsArray[x].ToString())
                        {
                            output += e.ToString() + "\n";
                        }
                    }
                }
            }

            return output;
        }
    }

    public class AllDayMenuGenerator : IMenuGenerator
    {
        public string generateMenuItems(XDocument foodItems, string country)
        {
            string output = string.Empty;

            FoodItemCategory[] allDayItemsArray = { FoodItemCategory.Breakfast, FoodItemCategory.Lunch, FoodItemCategory.Snack, FoodItemCategory.Side, FoodItemCategory.Appetizer, FoodItemCategory.Dinner, FoodItemCategory.Dessert };

            var foodItemElements = foodItems.Root.Elements("FoodItem");
            foreach (XElement e in foodItemElements)
            {
                for (int x = 0; x < allDayItemsArray.Length; x++)
                {
                    if (e.Element("country").Value == country)
                    {
                        if (e.Element("category").Value == allDayItemsArray[x].ToString())
                        {
                            output += e.ToString() + "\n";
                        }
                    }
                }
            }

            return output;
        }
    }
}
