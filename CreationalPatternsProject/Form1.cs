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
            string outputDirectory = @"../../OutputFiles/";

            // Get selected country radio button and store value in MenuSelection class
            if (greatBritanRadioButton.Checked)
            {
                MenuSelection.Instance.Country = greatBritanRadioButton.Tag.ToString();
                MenuSelection.Instance.CurrencyCode = "GBP";
            }
            else
            {
                MenuSelection.Instance.Country = unitedStatesRadioButton.Tag.ToString();
                MenuSelection.Instance.CurrencyCode = "$";
            }

            // Get selected restaurant category radio button and store value in MenuSelection class
            if (dinerRadioButton.Checked)
            {
                MenuSelection.Instance.RestaurantCategory = dinerRadioButton.Tag.ToString();
            }
            else if (eveningOnlyRadioButton.Checked)
            {
                MenuSelection.Instance.RestaurantCategory = eveningOnlyRadioButton.Tag.ToString();
            }
            else
            {
                MenuSelection.Instance.RestaurantCategory = allDayRadioButton.Tag.ToString();
            }

            // Get selected format radio button and store value in MenuSelection class
            if (textRadioButton.Checked)
            {
                MenuSelection.Instance.MenuFormat = textRadioButton.Text;
            }
            else if (htmlRadioButton.Checked)
            {
                MenuSelection.Instance.MenuFormat = htmlRadioButton.Text;
            }
            else
            {
                MenuSelection.Instance.MenuFormat = xmlRadioButton.Text;
            }

            // Create output directory if it does not exist
            Directory.CreateDirectory(outputDirectory);

            RestaurantAbstractFactory absFactory = RestaurantTypeFactoryMaker.getFactory(MenuSelection.Instance.Country, MenuSelection.Instance.RestaurantCategory, MenuSelection.Instance.MenuFormat);
        
            IMenuFormatter formatter = absFactory.createMenuFormatter();

            var menuFileName = formatter.generateMenu(absFactory.createMenuGenerator().generateMenuItems(absFactory.createReader().readFile(MenuSelection.Instance.CurrencyCode), MenuSelection.Instance.Country));

            MessageBox.Show("File location: " + outputDirectory + menuFileName, "Menu Created");
            
        }
    }
}
