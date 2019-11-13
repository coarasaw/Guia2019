using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ej_13;

namespace Ej_25_Form
{
    public partial class ForConversor : Form
    {
        public ForConversor()
        {
            InitializeComponent();
        }

        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            txtResultadoBinDec.Text = (Conversor.BinarioDecimal(txtBinarioDecimal.Text)).ToString();            
        }

        private void btnDecimalBinario_Click(object sender, EventArgs e)
        {
            txtResultadoDecBin.Text = (Conversor.DecimalBinario(double.Parse(txtDecimalBinario.Text)));            
        }
    }
}
