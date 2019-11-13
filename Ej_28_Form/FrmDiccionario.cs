using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_28_Form
{
    public partial class frmEj28 : Form
    {
        public frmEj28()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxDiccionario.Clear();
        }

        private void btrCalcular_Click(object sender, EventArgs e)
        {
            string words = richTextBoxDiccionario.Text;
            int contador = 0;
            string[] split = words.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            Dictionary<string, int> Palabras = new Dictionary<string, int>();
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    contador++;
                    Palabras.Add(s, contador);
                }
            }
            MessageBox.Show(contador.ToString());
            foreach (var item in Palabras)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}
