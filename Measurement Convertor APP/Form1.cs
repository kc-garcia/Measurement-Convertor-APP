using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measurement_Convertor_APP
{
    public partial class ConvertorGUI : Form
    {
        public ConvertorGUI()
        {
            InitializeComponent();
        }

        private void textBoxMeasurement_TextChanged(object sender, EventArgs e)
        {
            double inputValue = 0;
            string input = textBoxMeasurement.Text;
            if (!double.TryParse(input, out inputValue) & input !="")
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (textBoxMeasurement.Text == "Only Numbers")
            {
                MessageBox.Show("Invalid Input");
            }

            else
            {
                string option = comboBoxOperations.Text;
                double value = Convert.ToDouble(textBoxMeasurement.Text);
                switch (option)
                {
                    case "Meters To Feet": textBoxResult.Text = Convert.ToString(Convertor.MetersToFeet(value)); break;
                    case "Kilometers To Miles": textBoxResult.Text = Convert.ToString(Convertor.KilometersToMiles(value)); break;
                    case "Centimeters To Inches": textBoxResult.Text = Convert.ToString(Convertor.CentimetersToInches(value)); break;
                    case "Feet To Meters": textBoxResult.Text = Convert.ToString(Convertor.FeetToMeters(value)); break;
                    case "Miles To Kilometers": textBoxResult.Text = Convert.ToString(Convertor.MilesToKilometers(value)); break;
                    case "Inches To Centimeters": textBoxResult.Text = Convert.ToString(Convertor.InchesToCentimeters(value)); break;
                }
            }
        }

    }
}
