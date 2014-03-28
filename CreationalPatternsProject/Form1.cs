using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreationalPatternsProject
{
    public partial class restaurantMenusForm : Form
    {
        public restaurantMenusForm()
        {
            InitializeComponent();
        }

        private void generateMenuButton_Click(object sender, EventArgs e)
        {
            if (greatBritanRadioButton.Checked)
            {
                MenuCombinations.Instance.Country = greatBritanRadioButton.Tag.ToString();
                MenuCombinations.Instance.CurrencyCode = "GBP";
            }
            else
            {
                MenuCombinations.Instance.Country = unitedStatesRadioButton.Tag.ToString();
                MenuCombinations.Instance.CurrencyCode = "$";
            }

            if (dinerRadioButton.Checked)
            {
                MenuCombinations.Instance.RestaurantCategory = dinerRadioButton.Text;
            }
            else if (eveningOnlyRadioButton.Checked)
            {
                MenuCombinations.Instance.RestaurantCategory = eveningOnlyRadioButton.Text;
            }
            else
            {
                MenuCombinations.Instance.RestaurantCategory = allDayRadioButton.Text;
            }

            if (textRadioButton.Checked)
            {
                MenuCombinations.Instance.MenuFormat = textRadioButton.Text;
            }
            else if (htmlRadioButton.Checked)
            {
                MenuCombinations.Instance.MenuFormat = htmlRadioButton.Text;
            }
            else
            {
                MenuCombinations.Instance.MenuFormat = xmlRadioButton.Text;
            }

            // Create output directory if it does not exist
            Directory.CreateDirectory("../../OutputFiles/");

            RestaurantAbstractFactory absFactory = RestaurantTypeFactoryMaker.getFactory(MenuCombinations.Instance.Country, MenuCombinations.Instance.RestaurantCategory, MenuCombinations.Instance.MenuFormat);

            //IReaderFactory readerFactory = new ReaderFactory();
            //IMenuGeneratorFactory menuFactory = new MenuGeneratorFactory();
            //IMenuFormatterFactory menuFormatterFactory = new MenuFormatterFactory();

            //IReader reader = readerFactory.getReader(MenuCombinations.Instance.Country);
            //IMenuGenerator generator = menuFactory.getGenerator(MenuCombinations.Instance.RestaurantCategory);
            //IReader reader = absFactory.createReader();
            
            IMenuFormatter formatter = absFactory.createMenuFormatter();

            var menuFileName = formatter.generateMenu(absFactory.createMenuGenerator().generateMenuItems(absFactory.createReader().readFile(MenuCombinations.Instance.CurrencyCode), MenuCombinations.Instance.Country));

            MessageBox.Show(menuFileName);
            
        }
    }
}
