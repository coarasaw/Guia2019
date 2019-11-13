namespace Ej_23_From
{
    partial class FormConversor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversor));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionPesos = new System.Windows.Forms.TextBox();
            this.btnCandado = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.ImageList(this.components);
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblPesosA = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.txtPesosAEuro = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCotizacion.Location = new System.Drawing.Point(12, 26);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(179, 41);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotización";
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Enabled = false;
            this.txtCotizacionDolar.Location = new System.Drawing.Point(530, 38);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionDolar.TabIndex = 1;
            this.txtCotizacionDolar.TextChanged += new System.EventHandler(this.txtCotizacionDolar_TextChanged);
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Enabled = false;
            this.txtCotizacionEuro.Location = new System.Drawing.Point(388, 38);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionEuro.TabIndex = 2;
            this.txtCotizacionEuro.TextChanged += new System.EventHandler(this.txtCotizacionEuro_TextChanged);
            // 
            // txtCotizacionPesos
            // 
            this.txtCotizacionPesos.Enabled = false;
            this.txtCotizacionPesos.Location = new System.Drawing.Point(665, 38);
            this.txtCotizacionPesos.Name = "txtCotizacionPesos";
            this.txtCotizacionPesos.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionPesos.TabIndex = 3;
            this.txtCotizacionPesos.TextChanged += new System.EventHandler(this.txtCotizacionPesos_TextChanged);
            // 
            // btnCandado
            // 
            this.btnCandado.ImageIndex = 0;
            this.btnCandado.ImageList = this.imagen;
            this.btnCandado.Location = new System.Drawing.Point(208, 26);
            this.btnCandado.Name = "btnCandado";
            this.btnCandado.Size = new System.Drawing.Size(162, 43);
            this.btnCandado.TabIndex = 4;
            this.btnCandado.UseVisualStyleBackColor = true;
            this.btnCandado.Click += new System.EventHandler(this.btnCandado_Click);
            // 
            // imagen
            // 
            this.imagen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagen.ImageStream")));
            this.imagen.TransparentColor = System.Drawing.Color.Transparent;
            this.imagen.Images.SetKeyName(0, "CandadoAbierto.png");
            this.imagen.Images.SetKeyName(1, "CandadoCerrado.png");
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(25, 136);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(42, 17);
            this.lblEuro.TabIndex = 5;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(22, 178);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(47, 17);
            this.lblDolar.TabIndex = 6;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.Location = new System.Drawing.Point(22, 225);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(52, 17);
            this.lblPesos.TabIndex = 7;
            this.lblPesos.Text = "Pesos";
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroA.Location = new System.Drawing.Point(399, 70);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(75, 31);
            this.lblEuroA.TabIndex = 8;
            this.lblEuroA.Text = "Euro";
            this.lblEuroA.Click += new System.EventHandler(this.lblEuroA_Click);
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarA.Location = new System.Drawing.Point(540, 70);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(84, 31);
            this.lblDolarA.TabIndex = 9;
            this.lblDolarA.Text = "Dolar";
            this.lblDolarA.Click += new System.EventHandler(this.lblDolarA_Click);
            // 
            // lblPesosA
            // 
            this.lblPesosA.AutoSize = true;
            this.lblPesosA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesosA.Location = new System.Drawing.Point(671, 71);
            this.lblPesosA.Name = "lblPesosA";
            this.lblPesosA.Size = new System.Drawing.Size(95, 31);
            this.lblPesosA.TabIndex = 10;
            this.lblPesosA.Text = "Pesos";
            this.lblPesosA.Click += new System.EventHandler(this.lblPesosA_Click);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(85, 136);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 11;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(85, 178);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 12;
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(85, 222);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 13;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(388, 133);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAEuro.TabIndex = 14;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(530, 133);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroADolar.TabIndex = 15;
            // 
            // txtEuroAPesos
            // 
            this.txtEuroAPesos.Location = new System.Drawing.Point(665, 133);
            this.txtEuroAPesos.Name = "txtEuroAPesos";
            this.txtEuroAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAPesos.TabIndex = 16;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(388, 178);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAEuro.TabIndex = 17;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(530, 178);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarADolar.TabIndex = 18;
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.Location = new System.Drawing.Point(665, 178);
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAPesos.TabIndex = 19;
            // 
            // txtPesosAEuro
            // 
            this.txtPesosAEuro.Location = new System.Drawing.Point(388, 222);
            this.txtPesosAEuro.Name = "txtPesosAEuro";
            this.txtPesosAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAEuro.TabIndex = 20;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.Location = new System.Drawing.Point(530, 224);
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesosADolar.TabIndex = 21;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Location = new System.Drawing.Point(665, 225);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAPesos.TabIndex = 22;
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(243, 136);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEuro.TabIndex = 23;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(243, 178);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 24;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Location = new System.Drawing.Point(243, 219);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPesos.TabIndex = 25;
            this.btnConvertPesos.Text = "->";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            this.btnConvertPesos.Click += new System.EventHandler(this.btnConvertPesos_Click);
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.btnConvertPesos);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtPesosADolar);
            this.Controls.Add(this.txtPesosAEuro);
            this.Controls.Add(this.txtDolarAPesos);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAPesos);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblPesosA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.btnCandado);
            this.Controls.Add(this.txtCotizacionPesos);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.lblCotizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.FormConversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtCotizacionPesos;
        private System.Windows.Forms.Button btnCandado;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblPesosA;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPesos;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.TextBox txtPesosAEuro;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.TextBox txtPesosAPesos;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.ImageList imagen;
    }
}

