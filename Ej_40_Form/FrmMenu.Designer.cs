﻿namespace Ej_40_Form
{
    partial class FrmMenu
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
            this.btmLlamada = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmLlamada
            // 
            this.btmLlamada.Location = new System.Drawing.Point(12, 12);
            this.btmLlamada.Name = "btmLlamada";
            this.btmLlamada.Size = new System.Drawing.Size(308, 57);
            this.btmLlamada.TabIndex = 0;
            this.btmLlamada.Text = "Generar Llamada";
            this.btmLlamada.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(12, 92);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(308, 57);
            this.btnTotal.TabIndex = 1;
            this.btnTotal.Text = "Facturación Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(12, 168);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(308, 57);
            this.btnLocal.TabIndex = 2;
            this.btnLocal.Text = "Facturación Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnProvincial
            // 
            this.btnProvincial.Location = new System.Drawing.Point(12, 245);
            this.btnProvincial.Name = "btnProvincial";
            this.btnProvincial.Size = new System.Drawing.Size(308, 57);
            this.btnProvincial.TabIndex = 3;
            this.btnProvincial.Text = "Facturación Provincial";
            this.btnProvincial.UseVisualStyleBackColor = true;
            this.btnProvincial.Click += new System.EventHandler(this.btnProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(308, 57);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 413);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProvincial);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btmLlamada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmLlamada;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}

