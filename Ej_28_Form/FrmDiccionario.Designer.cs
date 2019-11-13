namespace Ej_28_Form
{
    partial class frmEj28
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxDiccionario = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btrCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxDiccionario
            // 
            this.richTextBoxDiccionario.Location = new System.Drawing.Point(28, 12);
            this.richTextBoxDiccionario.Name = "richTextBoxDiccionario";
            this.richTextBoxDiccionario.Size = new System.Drawing.Size(426, 261);
            this.richTextBoxDiccionario.TabIndex = 0;
            this.richTextBoxDiccionario.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btrCalcular
            // 
            this.btrCalcular.Location = new System.Drawing.Point(379, 299);
            this.btrCalcular.Name = "btrCalcular";
            this.btrCalcular.Size = new System.Drawing.Size(75, 23);
            this.btrCalcular.TabIndex = 2;
            this.btrCalcular.Text = "Calcular";
            this.btrCalcular.UseVisualStyleBackColor = true;
            this.btrCalcular.Click += new System.EventHandler(this.btrCalcular_Click);
            // 
            // frmEj28
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 348);
            this.Controls.Add(this.btrCalcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxDiccionario);
            this.Name = "frmEj28";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ej_28";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDiccionario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btrCalcular;
    }
}

