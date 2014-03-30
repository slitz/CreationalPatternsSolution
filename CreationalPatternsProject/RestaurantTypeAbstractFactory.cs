using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsProject
{
    public abstract class RestaurantAbstractFactory
    {
        public abstract IReader createReader();
        public abstract IMenuGenerator createMenuGenerator();
        public abstract IMenuFormatter createMenuFormatter();
    }

    public class RestaurantTypeFactoryMaker
    {
        public static RestaurantAbstractFactory getFactory(string country, string category, string format) 
        {
            switch (country)
            {
                case "GB":
                    if (category == RestaurantCategory.Diner.ToString())
                    {
                        switch (format)
                        {
                            case "Text":
                                return new BritishDinerTextConcreteRestaurant();
                            case "HTML":
                                return new BritishDinerHtmlConcreteRestaurant();
                            case "XML": 
                                return new BritishDinerXmlConcreteRestaurant();
                        }
                    }
                    else if (category == RestaurantCategory.AllDay.ToString())
                    {
                        switch (format)
                        {
                            case "Text":
                                return new BritishAllDayTextConcreteRestaurant();
                            case "HTML":
                                return new BritishAllDayHtmlConcreteRestaurant();
                            case "XML":
                                return new BritishAllDayXmlConcreteRestaurant();
                        }
                    }
                    else
                    {
                        switch (format)
                        {
                            case "Text":
                                return new BritishEveningTextConcreteRestaurant();
                            case "HTML":
                                return new BritishEveningHtmlConcreteRestaurant();
                            case "XML":
                                return new BritishEveningXmlConcreteRestaurant();
                        }
                    }
                    return null;
                case "US":
                    if (category == RestaurantCategory.Diner.ToString())
                    {
                        switch (format)
                        {
                            case "Text":
                                return new AmericanDinerTextConcreteRestaurant();
                            case "HTML":
                                return new AmericanDinerHtmlConcreteRestaurant();
                            case "XML":
                                return new AmericanDinerXmlConcreteRestaurant();
                        }
                    }
                    else if (category == RestaurantCategory.AllDay.ToString())
                    {
                        switch (format)
                        {
                            case "Text":
                                return new AmericanAllDayTextConcreteRestaurant();
                            case "HTML":
                                return new AmericanAllDayHtmlConcreteRestaurant();
                            case "XML":
                                return new AmericanAllDayXmlConcreteRestaurant();
                        }
                    }
                    else
                    {
                        switch (format)
                        {
                            case "Text":
                                return new AmericanEveningTextConcreteRestaurant();
                            case "HTML":
                                return new AmericanEveningHtmlConcreteRestaurant();
                            case "XML":
                                return new AmericanEveningXmlConcreteRestaurant();
                        }
                    }
                    return null;
                default:
                    return null;
            }
        }
    }

    public class BritishDinerTextConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.GB.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.Diner.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.Text.ToString()); }
    }

    public class BritishDinerHtmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.GB.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.Diner.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.HTML.ToString()); }
    }

    public class BritishDinerXmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.GB.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.Diner.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.XML.ToString()); }
    }

    public class BritishAllDayTextConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.GB.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.AllDay.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.Text.ToString()); }
    }

    public class BritishAllDayHtmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.GB.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.AllDay.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.HTML.ToString()); }
    }

    public class BritishAllDayXmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.GB.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.AllDay.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.XML.ToString()); }
    }
    public class BritishEveningTextConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.GB.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.EveningOnly.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.Text.ToString()); }
    }

    public class BritishEveningHtmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.GB.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.EveningOnly.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.HTML.ToString()); }
    }

    public class BritishEveningXmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.GB.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.EveningOnly.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.XML.ToString()); }
    }

    public class AmericanDinerTextConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.US.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.Diner.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.Text.ToString()); }
    }

    public class AmericanDinerHtmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.US.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.Diner.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.HTML.ToString()); }
    }

    public class AmericanDinerXmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.US.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.Diner.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.XML.ToString()); }
    }

    public class AmericanAllDayTextConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.US.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.AllDay.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.Text.ToString()); }
    }

    public class AmericanAllDayHtmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.US.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.AllDay.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.HTML.ToString()); }
    }

    public class AmericanAllDayXmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.US.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.AllDay.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.XML.ToString()); }
    }
    public class AmericanEveningTextConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.US.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.EveningOnly.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.Text.ToString()); }
    }

    public class AmericanEveningHtmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.US.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.EveningOnly.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.HTML.ToString()); }
    }

    public class AmericanEveningXmlConcreteRestaurant : RestaurantAbstractFactory
    {
        public override IReader createReader() { return new ReaderFactory().getReader(Country.US.ToString()); }
        public override IMenuGenerator createMenuGenerator() { return new MenuGeneratorFactory().getGenerator(RestaurantCategory.EveningOnly.ToString()); }
        public override IMenuFormatter createMenuFormatter() { return new MenuFormatterFactory().getFormatter(MenuFormat.XML.ToString()); }
    }
}
