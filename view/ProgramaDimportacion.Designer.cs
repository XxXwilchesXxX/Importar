﻿namespace Importar
{
    partial class software
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
            this.grpAgrupacion = new System.Windows.Forms.GroupBox();
            this.txtNumeroDatos = new System.Windows.Forms.TextBox();
            this.btnSubirDB = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.Dgv_cuadriculaDedatos = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.grpAgrupacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cuadriculaDedatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgrupacion
            // 
            this.grpAgrupacion.BackColor = System.Drawing.SystemColors.Info;
            this.grpAgrupacion.Controls.Add(this.txtNumeroDatos);
            this.grpAgrupacion.Controls.Add(this.btnSubirDB);
            this.grpAgrupacion.Controls.Add(this.btnImportar);
            this.grpAgrupacion.Controls.Add(this.Dgv_cuadriculaDedatos);
            this.grpAgrupacion.Location = new System.Drawing.Point(12, 12);
            this.grpAgrupacion.Name = "grpAgrupacion";
            this.grpAgrupacion.Size = new System.Drawing.Size(769, 426);
            this.grpAgrupacion.TabIndex = 0;
            this.grpAgrupacion.TabStop = false;
            // 
            // txtNumeroDatos
            // 
            this.txtNumeroDatos.Location = new System.Drawing.Point(500, 21);
            this.txtNumeroDatos.Name = "txtNumeroDatos";
            this.txtNumeroDatos.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDatos.TabIndex = 5;
            // 
            // btnSubirDB
            // 
            this.btnSubirDB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubirDB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubirDB.Location = new System.Drawing.Point(615, 18);
            this.btnSubirDB.Name = "btnSubirDB";
            this.btnSubirDB.Size = new System.Drawing.Size(146, 23);
            this.btnSubirDB.TabIndex = 4;
            this.btnSubirDB.Text = "Subir a la DB ";
            this.btnSubirDB.UseVisualStyleBackColor = false;
            this.btnSubirDB.Click += new System.EventHandler(this.btnSubirDB_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImportar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImportar.Location = new System.Drawing.Point(6, 19);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(146, 23);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // Dgv_cuadriculaDedatos
            // 
            this.Dgv_cuadriculaDedatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_cuadriculaDedatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cuadriculaDedatos.Location = new System.Drawing.Point(6, 48);
            this.Dgv_cuadriculaDedatos.Name = "Dgv_cuadriculaDedatos";
            this.Dgv_cuadriculaDedatos.Size = new System.Drawing.Size(755, 372);
            this.Dgv_cuadriculaDedatos.TabIndex = 1;
            // 
            // software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.grpAgrupacion);
            this.Name = "software";
            this.Text = "Programa de insertar archivo CSV";
            this.grpAgrupacion.ResumeLayout(false);
            this.grpAgrupacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cuadriculaDedatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgrupacion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView Dgv_cuadriculaDedatos;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnSubirDB;
        private System.Windows.Forms.TextBox txtNumeroDatos;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}

