namespace Importar
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
            this.Agrupacion = new System.Windows.Forms.GroupBox();
            this.btnSubirDB = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.cuadriculaDedatos = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Agrupacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuadriculaDedatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Agrupacion
            // 
            this.Agrupacion.BackColor = System.Drawing.SystemColors.Info;
            this.Agrupacion.Controls.Add(this.btnSubirDB);
            this.Agrupacion.Controls.Add(this.btnConectar);
            this.Agrupacion.Controls.Add(this.btnImportar);
            this.Agrupacion.Controls.Add(this.cuadriculaDedatos);
            this.Agrupacion.Location = new System.Drawing.Point(12, 12);
            this.Agrupacion.Name = "Agrupacion";
            this.Agrupacion.Size = new System.Drawing.Size(769, 426);
            this.Agrupacion.TabIndex = 0;
            this.Agrupacion.TabStop = false;
            // 
            // btnSubirDB
            // 
            this.btnSubirDB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubirDB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubirDB.Location = new System.Drawing.Point(310, 19);
            this.btnSubirDB.Name = "btnSubirDB";
            this.btnSubirDB.Size = new System.Drawing.Size(146, 23);
            this.btnSubirDB.TabIndex = 4;
            this.btnSubirDB.Text = "Subir a la DB ";
            this.btnSubirDB.UseVisualStyleBackColor = false;
            this.btnSubirDB.Click += new System.EventHandler(this.btnSubirDB_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConectar.Location = new System.Drawing.Point(158, 19);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(146, 23);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
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
            // cuadriculaDedatos
            // 
            this.cuadriculaDedatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.cuadriculaDedatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuadriculaDedatos.Location = new System.Drawing.Point(6, 48);
            this.cuadriculaDedatos.Name = "cuadriculaDedatos";
            this.cuadriculaDedatos.Size = new System.Drawing.Size(755, 372);
            this.cuadriculaDedatos.TabIndex = 1;
            // 
            // software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.Agrupacion);
            this.Name = "software";
            this.Text = "Programa de insertar archivo CSV";
            this.Agrupacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cuadriculaDedatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Agrupacion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView cuadriculaDedatos;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnSubirDB;
    }
}

