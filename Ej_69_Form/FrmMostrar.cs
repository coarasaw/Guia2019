using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_69_Form
{
    public partial class FrmMostrar : Form
    {
        public delegate void ActualizaNombreDelegate(string dato);

        public FrmMostrar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string dato)
        {
            this.lblEtiqueta.Text = dato;
        }
    }
}
