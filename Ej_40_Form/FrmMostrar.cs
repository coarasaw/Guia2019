using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bilblioteca_CentralitaAbstractasPolimorfismo;

namespace Ej_40_Form
{
    public partial class FrmMostrar : Form
    {
        TipoLlamada tipo;
        Centralita central;
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.central = centralita;
            this.tipo = TipoLlamada.Todas;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            richTextBox.Text = "\n\t::::::::::::::::::::::::::::::::::::::: FACTURACION :::::::::::::::::::::::::::::::::::::::\n\n";
            richTextBox.Text += this.central.ToString();
            richTextBox.Enabled = false;
        }
        public TipoLlamada Tipo
        {
            set { this.tipo = value; }
        }
    }
}
