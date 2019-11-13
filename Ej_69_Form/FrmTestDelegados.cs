﻿using System;
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
    public partial class FrmTestDelegados : Form
    {
        public event FrmMostrar.ActualizaNombreDelegate EventoActualizaNombre;

        public FrmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.EventoActualizaNombre.Invoke(this.txtDatos.Text);
        }
    }
}
