using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsProject
{
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
}
