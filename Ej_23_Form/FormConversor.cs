using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ej_23_From
{
    public partial class FormConversor : Form
    {       
        public FormConversor()
        {                       
            InitializeComponent();
        }

        private void lblEuroA_Click(object sender, EventArgs e)
        {

        }

        private void lblDolarA_Click(object sender, EventArgs e)
        {

        }

        private void lblPesosA_Click(object sender, EventArgs e)
        {

        }

        private void txtCotizacionDolar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCotizacionEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCotizacionPesos_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormConversor_Load(object sender, EventArgs e)
        {
            string valorDolar =  Dolar.GetCotizacion().ToString();
            txtCotizacionDolar.Text = valorDolar;
            string valorEuro = Euro.GetCotizacion().ToString();
            txtCotizacionEuro.Text = valorEuro;
            string valorPeso = Pesos.GetCotizacion().ToString();
            txtCotizacionPesos.Text = valorPeso;                       
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            if (btnCandado.ImageIndex == 0)
            {
                btnCandado.ImageIndex = 1;
                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPesos.Enabled = true;
            }
            else
            {
                btnCandado.ImageIndex = 0;
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPesos.Enabled = false;
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {           
            Dolar varDolar = new Dolar(double.Parse(txtDolar.Text), double.Parse(txtCotizacionDolar.Text));
            
            Euro varEuro = (Euro)varDolar;
            txtDolarAEuro.Text = varEuro.GetCantidad().ToString("00.00");

            Pesos varPesos = (Pesos)varDolar;
            txtDolarAPesos.Text = varPesos.GetCantidad().ToString("00.00");

            txtDolarADolar.Text = txtDolar.Text;
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            Euro varEuro = new Euro(double.Parse(txtEuro.Text), double.Parse(txtCotizacionEuro.Text));

            Dolar varDolar = (Dolar)varEuro;
            txtEuroADolar.Text = varDolar.GetCantidad().ToString("00.00");

            Pesos varPesos = (Pesos)varEuro;
            txtEuroAPesos.Text = varPesos.GetCantidad().ToString("00.00");

            txtEuroAEuro.Text = txtEuro.Text;
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            Pesos varPesos = new Pesos(double.Parse(txtPesos.Text), double.Parse(txtCotizacionPesos.Text));

            Euro varEuro = (Euro)varPesos;
            txtPesosAEuro.Text = varEuro.GetCantidad().ToString("00.00");

            Dolar varDolar = (Dolar)varPesos;
            txtPesosADolar.Text = varDolar.GetCantidad().ToString("00.00");

            txtPesosAPesos.Text = txtPesos.Text;
        }
    }
}
