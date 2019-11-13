using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_61_Form
{
    public partial class FormEj61 : Form
    {
        public FormEj61()
        {
            InitializeComponent();
        }

        private void FormEj61_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(txtNombre.Text.ToString(), txtApellido.Text.ToString());
            PersonaDAO.Guardar(p);
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                List<Persona> lista = new List<Persona>();
                lista = PersonaDAO.Leer();
                lstPersona.Items.Clear(); 
                 
                foreach (Persona item in lista)
                {
                    lstPersona.Items.Add(item); //estoy guardando el objeto
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ", ex.ToString());
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Persona txtEditar = (Persona)lstPersona.SelectedItem;
            int idLista = txtEditar.ID;
            
            PersonaDAO.Modificar(new Persona(idLista, txtNombre.Text.ToString(), txtApellido.Text.ToString()));
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void lstPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtApellido.Text = ((Persona)lstPersona.SelectedItem).Apellido;
            txtNombre.Text = ((Persona)lstPersona.SelectedItem).Nombre;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona txtEditar = (Persona)lstPersona.SelectedItem;
            int idLista = txtEditar.ID;

            PersonaDAO.Eliminar(new Persona(idLista, "", ""));
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
    }
}
