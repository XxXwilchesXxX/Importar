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
            this.components = new System.ComponentModel.Container();
            this.gpbAgrupacion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDatonuevo = new System.Windows.Forms.Button();
            this.lblFilasImportadas = new System.Windows.Forms.Label();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.prgbProcessing = new System.Windows.Forms.ProgressBar();
            this.txtNumeroDatos = new System.Windows.Forms.TextBox();
            this.btnSubirDB = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.Dgv_cuadriculaDedatos = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.gpbAgrupacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cuadriculaDedatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbAgrupacion
            // 
            this.gpbAgrupacion.BackColor = System.Drawing.SystemColors.Info;
            this.gpbAgrupacion.Controls.Add(this.btnEliminar);
            this.gpbAgrupacion.Controls.Add(this.btnActualizar);
            this.gpbAgrupacion.Controls.Add(this.btnDatonuevo);
            this.gpbAgrupacion.Controls.Add(this.lblFilasImportadas);
            this.gpbAgrupacion.Controls.Add(this.lblProcessing);
            this.gpbAgrupacion.Controls.Add(this.prgbProcessing);
            this.gpbAgrupacion.Controls.Add(this.txtNumeroDatos);
            this.gpbAgrupacion.Controls.Add(this.btnSubirDB);
            this.gpbAgrupacion.Controls.Add(this.btnImportar);
            this.gpbAgrupacion.Controls.Add(this.Dgv_cuadriculaDedatos);
            this.gpbAgrupacion.Location = new System.Drawing.Point(12, 12);
            this.gpbAgrupacion.Name = "gpbAgrupacion";
            this.gpbAgrupacion.Size = new System.Drawing.Size(769, 466);
            this.gpbAgrupacion.TabIndex = 0;
            this.gpbAgrupacion.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(416, 435);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(522, 435);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 23);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizaryeliminar_Click);
            // 
            // btnDatonuevo
            // 
            this.btnDatonuevo.Location = new System.Drawing.Point(637, 435);
            this.btnDatonuevo.Name = "btnDatonuevo";
            this.btnDatonuevo.Size = new System.Drawing.Size(124, 23);
            this.btnDatonuevo.TabIndex = 8;
            this.btnDatonuevo.Text = "Agregar un nuevo dato ";
            this.btnDatonuevo.UseVisualStyleBackColor = true;
            this.btnDatonuevo.Click += new System.EventHandler(this.btnDatonuevo_Click);
            // 
            // lblFilasImportadas
            // 
            this.lblFilasImportadas.AutoSize = true;
            this.lblFilasImportadas.Location = new System.Drawing.Point(18, 440);
            this.lblFilasImportadas.Name = "lblFilasImportadas";
            this.lblFilasImportadas.Size = new System.Drawing.Size(116, 13);
            this.lblFilasImportadas.TabIndex = 1;
            this.lblFilasImportadas.Text = "Esperando Importacion";
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Location = new System.Drawing.Point(362, 23);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(91, 13);
            this.lblProcessing.TabIndex = 7;
            this.lblProcessing.Text = "Processing......0%";
            // 
            // prgbProcessing
            // 
            this.prgbProcessing.Location = new System.Drawing.Point(171, 18);
            this.prgbProcessing.Name = "prgbProcessing";
            this.prgbProcessing.Size = new System.Drawing.Size(173, 23);
            this.prgbProcessing.TabIndex = 6;
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
            this.btnImportar.Text = "Cargar archivo CSV";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(788, 490);
            this.Controls.Add(this.gpbAgrupacion);
            this.Name = "software";
            this.Text = "Programa de insertar archivo CSV";
            this.gpbAgrupacion.ResumeLayout(false);
            this.gpbAgrupacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cuadriculaDedatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAgrupacion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView Dgv_cuadriculaDedatos;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnSubirDB;
        private System.Windows.Forms.TextBox txtNumeroDatos;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.ProgressBar prgbProcessing;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblFilasImportadas;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Button btnDatonuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

