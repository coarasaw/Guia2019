namespace Ej_56_For_
{
    partial class frmArchivosTexto
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.rtxtContenido = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(16, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(347, 35);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "&Buscar Archivo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnMostrar.Enabled = false;
            this.btnMostrar.Location = new System.Drawing.Point(16, 58);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(347, 90);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "&Mostrar Contenido\r\n";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(388, 58);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(347, 90);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "&Guardar Archivo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(385, 21);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(345, 22);
            this.txtPath.TabIndex = 4;
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.FileName = "Abrir";
            // 
            // rtxtContenido
            // 
            this.rtxtContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtContenido.Location = new System.Drawing.Point(0, 155);
            this.rtxtContenido.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtContenido.Name = "rtxtContenido";
            this.rtxtContenido.Size = new System.Drawing.Size(747, 308);
            this.rtxtContenido.TabIndex = 1;
            this.rtxtContenido.Text = "";
            // 
            // frmArchivosTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 453);
            this.Controls.Add(this.rtxtContenido);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmArchivosTexto";
            this.Text = "Archivos de Textos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.RichTextBox rtxtContenido;
    }
}

