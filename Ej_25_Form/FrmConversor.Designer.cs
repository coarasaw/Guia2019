namespace Ej_25_Form
{
    partial class ForConversor
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
            this.lblBinarioADecimal = new System.Windows.Forms.Label();
            this.lblDecimalABinario = new System.Windows.Forms.Label();
            this.txtBinarioDecimal = new System.Windows.Forms.TextBox();
            this.txtDecimalBinario = new System.Windows.Forms.TextBox();
            this.txtResultadoBinDec = new System.Windows.Forms.TextBox();
            this.txtResultadoDecBin = new System.Windows.Forms.TextBox();
            this.btnBinarioDecimal = new System.Windows.Forms.Button();
            this.btnDecimalBinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBinarioADecimal
            // 
            this.lblBinarioADecimal.AutoSize = true;
            this.lblBinarioADecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinarioADecimal.Location = new System.Drawing.Point(9, 35);
            this.lblBinarioADecimal.Name = "lblBinarioADecimal";
            this.lblBinarioADecimal.Size = new System.Drawing.Size(159, 20);
            this.lblBinarioADecimal.TabIndex = 0;
            this.lblBinarioADecimal.Text = "Bianario a Decimal";
            // 
            // lblDecimalABinario
            // 
            this.lblDecimalABinario.AutoSize = true;
            this.lblDecimalABinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalABinario.Location = new System.Drawing.Point(9, 81);
            this.lblDecimalABinario.Name = "lblDecimalABinario";
            this.lblDecimalABinario.Size = new System.Drawing.Size(149, 20);
            this.lblDecimalABinario.TabIndex = 1;
            this.lblDecimalABinario.Text = "Decimal a Binario";
            // 
            // txtBinarioDecimal
            // 
            this.txtBinarioDecimal.Location = new System.Drawing.Point(199, 35);
            this.txtBinarioDecimal.Name = "txtBinarioDecimal";
            this.txtBinarioDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtBinarioDecimal.TabIndex = 2;
            // 
            // txtDecimalBinario
            // 
            this.txtDecimalBinario.Location = new System.Drawing.Point(199, 81);
            this.txtDecimalBinario.Name = "txtDecimalBinario";
            this.txtDecimalBinario.Size = new System.Drawing.Size(100, 20);
            this.txtDecimalBinario.TabIndex = 3;
            // 
            // txtResultadoBinDec
            // 
            this.txtResultadoBinDec.Enabled = false;
            this.txtResultadoBinDec.Location = new System.Drawing.Point(450, 35);
            this.txtResultadoBinDec.Name = "txtResultadoBinDec";
            this.txtResultadoBinDec.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoBinDec.TabIndex = 4;
            // 
            // txtResultadoDecBin
            // 
            this.txtResultadoDecBin.Enabled = false;
            this.txtResultadoDecBin.Location = new System.Drawing.Point(450, 83);
            this.txtResultadoDecBin.Name = "txtResultadoDecBin";
            this.txtResultadoDecBin.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoDecBin.TabIndex = 5;
            // 
            // btnBinarioDecimal
            // 
            this.btnBinarioDecimal.Location = new System.Drawing.Point(342, 31);
            this.btnBinarioDecimal.Name = "btnBinarioDecimal";
            this.btnBinarioDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnBinarioDecimal.TabIndex = 6;
            this.btnBinarioDecimal.Text = "->";
            this.btnBinarioDecimal.UseVisualStyleBackColor = true;
            this.btnBinarioDecimal.Click += new System.EventHandler(this.btnBinarioDecimal_Click);
            // 
            // btnDecimalBinario
            // 
            this.btnDecimalBinario.Location = new System.Drawing.Point(342, 83);
            this.btnDecimalBinario.Name = "btnDecimalBinario";
            this.btnDecimalBinario.Size = new System.Drawing.Size(75, 23);
            this.btnDecimalBinario.TabIndex = 7;
            this.btnDecimalBinario.Text = "->";
            this.btnDecimalBinario.UseVisualStyleBackColor = true;
            this.btnDecimalBinario.Click += new System.EventHandler(this.btnDecimalBinario_Click);
            // 
            // ForConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(572, 132);
            this.Controls.Add(this.btnDecimalBinario);
            this.Controls.Add(this.btnBinarioDecimal);
            this.Controls.Add(this.txtResultadoDecBin);
            this.Controls.Add(this.txtResultadoBinDec);
            this.Controls.Add(this.txtDecimalBinario);
            this.Controls.Add(this.txtBinarioDecimal);
            this.Controls.Add(this.lblDecimalABinario);
            this.Controls.Add(this.lblBinarioADecimal);
            this.Name = "ForConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numérico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinarioADecimal;
        private System.Windows.Forms.Label lblDecimalABinario;
        private System.Windows.Forms.TextBox txtBinarioDecimal;
        private System.Windows.Forms.TextBox txtDecimalBinario;
        private System.Windows.Forms.TextBox txtResultadoBinDec;
        private System.Windows.Forms.TextBox txtResultadoDecBin;
        private System.Windows.Forms.Button btnBinarioDecimal;
        private System.Windows.Forms.Button btnDecimalBinario;
    }
}

