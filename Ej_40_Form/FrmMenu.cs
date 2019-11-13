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
    public partial class FrmMenu : Form
    {
        Centralita central;
        public FrmMenu()
        {
            InitializeComponent();
            this.Text = "Menú - Central Telefónica";

            this.central = new Centralita("Central-Wally");
            Local l1 = new Local("3452345", 30, "23452345", (float)2.65);
            Local l1b = l1;
            Provincial l2 = new Provincial("53452345", Franja.Franja_1, 15, "#546745634");
            Local l3 = new Local("6785678", 40, "6345346", (float)2.65);
            Provincial l4 = new Provincial(Franja.Franja_3, l2);

            this.central = central + l1;
            this.central = central + l1b;
            this.central = central + l2;
            this.central = central + l3;
            this.central = central + l4;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.central);
            frmMostrar.Tipo = TipoLlamada.Todas;
            frmMostrar.ShowDialog();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.central);
            frmMostrar.Tipo = TipoLlamada.Local;
            frmMostrar.ShowDialog();
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.central);
            frmMostrar.Tipo = TipoLlamada.Provincial;
            frmMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
