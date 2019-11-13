using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Ej21;

namespace Ej24_From
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            Fahrenheit fahrenheit = new Fahrenheit(float.Parse(txtFahrenheit.Text));
            txtFahrenheitAFahrenheit.Text = txtFahrenheit.Text;

            Kelvin varKelvin = (Kelvin)fahrenheit;
            txtFahrenheitAKelvin.Text = varKelvin.Cantidad.ToString();

            Celsius varCelsius = (Celsius)fahrenheit;
            txtFahrenheitACelsius.Text = varCelsius.Cantidad.ToString();
            
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            Celsius celsius = new Celsius(float.Parse(txtCelsius.Text));
            txtCelsiusACelsius.Text = txtCelsius.Text;

            Kelvin varKelvin = (Kelvin)celsius;
            txtCelsiusAKelvin.Text = varKelvin.Cantidad.ToString();

            Fahrenheit varFahrenheit = (Fahrenheit)celsius;
            txtCelsiusAFahrenheit.Text = varFahrenheit.Cantidad.ToString();

        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            Kelvin kelvin = new Kelvin(float.Parse(txtKelvin.Text));
            txtKelvinAKelvin.Text = txtKelvin.Text;

            Celsius varCelsuis = (Celsius)kelvin;
            txtKelvinACelsius.Text = varCelsuis.Cantidad.ToString();

            Fahrenheit varFahrenhit = (Fahrenheit)kelvin;
            txtKelvinAFahrenheit.Text = varFahrenhit.Cantidad.ToString();
        }
    }
}
