namespace Importar
{
    partial class Frm_software
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbAgrupacion = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
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
            this.gpbAgrupacion.Controls.Add(this.btnEditar);
            this.gpbAgrupacion.Controls.Add(this.btnEliminar);
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
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Image = global::Importar.Properties.Resources.edit_document_file_icon_123491;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(561, 421);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 42);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Image = global::Importar.Properties.Resources.iconfinder_trash_4341321_120557;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(467, 421);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 42);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDatonuevo
            // 
            this.btnDatonuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDatonuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatonuevo.Image = global::Importar.Properties.Resources._1486485557_add_create_new_more_plus_81188;
            this.btnDatonuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatonuevo.Location = new System.Drawing.Point(651, 421);
            this.btnDatonuevo.Name = "btnDatonuevo";
            this.btnDatonuevo.Size = new System.Drawing.Size(93, 42);
            this.btnDatonuevo.TabIndex = 8;
            this.btnDatonuevo.Text = "Agregar ";
            this.btnDatonuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatonuevo.UseVisualStyleBackColor = false;
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
            this.lblProcessing.Location = new System.Drawing.Point(384, 32);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(91, 13);
            this.lblProcessing.TabIndex = 7;
            this.lblProcessing.Text = "Processing......0%";
            // 
            // prgbProcessing
            // 
            this.prgbProcessing.Location = new System.Drawing.Point(188, 26);
            this.prgbProcessing.Name = "prgbProcessing";
            this.prgbProcessing.Size = new System.Drawing.Size(173, 23);
            this.prgbProcessing.TabIndex = 6;
            // 
            // txtNumeroDatos
            // 
            this.txtNumeroDatos.Location = new System.Drawing.Point(481, 29);
            this.txtNumeroDatos.Name = "txtNumeroDatos";
            this.txtNumeroDatos.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDatos.TabIndex = 5;
            // 
            // btnSubirDB
            // 
            this.btnSubirDB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubirDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubirDB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubirDB.Image = global::Importar.Properties.Resources.save_783481;
            this.btnSubirDB.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSubirDB.Location = new System.Drawing.Point(640, 18);
            this.btnSubirDB.Name = "btnSubirDB";
            this.btnSubirDB.Size = new System.Drawing.Size(104, 40);
            this.btnSubirDB.TabIndex = 4;
            this.btnSubirDB.Text = "Guardar";
            this.btnSubirDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubirDB.UseVisualStyleBackColor = false;
            this.btnSubirDB.Click += new System.EventHandler(this.btnSubirDB_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImportar.Image = global::Importar.Properties.Resources.ext_csv_filetype_icon_176252;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnImportar.Location = new System.Drawing.Point(21, 18);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(146, 40);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // Dgv_cuadriculaDedatos
            // 
            this.Dgv_cuadriculaDedatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_cuadriculaDedatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cuadriculaDedatos.Location = new System.Drawing.Point(21, 79);
            this.Dgv_cuadriculaDedatos.Name = "Dgv_cuadriculaDedatos";
            this.Dgv_cuadriculaDedatos.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Dgv_cuadriculaDedatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_cuadriculaDedatos.Size = new System.Drawing.Size(723, 331);
            this.Dgv_cuadriculaDedatos.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(788, 490);
            this.Controls.Add(this.gpbAgrupacion);
            this.Name = "Frm_software";
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
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}

