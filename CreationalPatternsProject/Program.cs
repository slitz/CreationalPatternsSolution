using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreationalPatternsProject
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new restaurantMenusForm());
        }
    }

    public enum Country
    {
        GB,
        US
    }

    public enum RestaurantCategory
    {
        Diner,
        EveningOnly,
        AllDay
    }

    public enum MenuFormat
    {
        Text,
        Html,
        Xml
    }

    public enum FoodItemCategory
    {
        Breakfast,
        Snack,
        Appetizer,
        Lunch,
        Dinner,
        Dessert,
        Side 
    }

    // Singleton
    public sealed class MenuCombinations
    {
        private string _Country;
        private string _CurrencyCode;
        private string _RestaurantCategory;
        private string _MenuFormat;
        private static volatile MenuCombinations instance;
        private static object syncRoot = new Object();

        private MenuCombinations() { }

        public static MenuCombinations Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new MenuCombinations();
                    }
                }

                return instance;
            }
        }

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public string CurrencyCode
        {
            get { return _CurrencyCode; }
            set { _CurrencyCode = value; }
        }

        public string RestaurantCategory
        {
            get { return _RestaurantCategory; }
            set { _RestaurantCategory = value; }
        }

        public string MenuFormat        
        {
            get { return _MenuFormat; }
            set { _MenuFormat = value; }
        }
    }

    public interface IRestaurantFactory 
    {
	    IReader createReader();
	    IMenuGenerator createMenuGenerator();
	    IMenuFormatter createMenuFormatter();
    }

    //public class BritishRestaurantFactory : IRestaurantFactory
    //{
    //    public IReader createReader()
    //    {
    //        return new Reader();  
    //    }
    //    public IMenuGenerator createMenuGenerator()
    //    {
    //        return new MenuGenerator();
    //    }
    //    public IMenuFormatter createMenuFormatter()
    //    {
    //        return new MenuFormatter();
    //    }
    //}

    //public class AmericanRestaurantFactory : IRestaurantFactory
    //{
    //    public IReader createReader()
    //    {
    //        return new Reader();
    //    }
    //    public IMenuGenerator createMenuGenerator()
    //    {
    //        return new MenuGenerator();
    //    }
    //    public IMenuFormatter createMenuFormatter()
    //    {
    //        return new MenuFormatter();
    //    }
    //}

}
