﻿namespace Importar.VIEW
{
    partial class Frm_AgregarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbGuardar = new System.Windows.Forms.GroupBox();
            this.lblcodigo_loc = new System.Windows.Forms.Label();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.txtSave_estado_ctr = new System.Windows.Forms.TextBox();
            this.txtSave_fecha_ctr = new System.Windows.Forms.TextBox();
            this.txtSave_valor_ctr = new System.Windows.Forms.TextBox();
            this.txtSave_id_emp = new System.Windows.Forms.TextBox();
            this.txtSave_codigo_trs = new System.Windows.Forms.TextBox();
            this.txtSave_consec_ctr = new System.Windows.Forms.TextBox();
            this.txtSave_codigo_loc = new System.Windows.Forms.TextBox();
            this.lblestado_ctr = new System.Windows.Forms.Label();
            this.lblfecha_ctr = new System.Windows.Forms.Label();
            this.lblvalor_ctr = new System.Windows.Forms.Label();
            this.lblid_emp = new System.Windows.Forms.Label();
            this.lblcodigo_trs = new System.Windows.Forms.Label();
            this.lblconsec_ctr = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpbGuardar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGuardar
            // 
            this.gpbGuardar.Controls.Add(this.lblcodigo_loc);
            this.gpbGuardar.Controls.Add(this.btnGuardarDatos);
            this.gpbGuardar.Controls.Add(this.txtSave_estado_ctr);
            this.gpbGuardar.Controls.Add(this.txtSave_fecha_ctr);
            this.gpbGuardar.Controls.Add(this.txtSave_valor_ctr);
            this.gpbGuardar.Controls.Add(this.txtSave_id_emp);
            this.gpbGuardar.Controls.Add(this.txtSave_codigo_trs);
            this.gpbGuardar.Controls.Add(this.txtSave_consec_ctr);
            this.gpbGuardar.Controls.Add(this.txtSave_codigo_loc);
            this.gpbGuardar.Controls.Add(this.lblestado_ctr);
            this.gpbGuardar.Controls.Add(this.lblfecha_ctr);
            this.gpbGuardar.Controls.Add(this.lblvalor_ctr);
            this.gpbGuardar.Controls.Add(this.lblid_emp);
            this.gpbGuardar.Controls.Add(this.lblcodigo_trs);
            this.gpbGuardar.Controls.Add(this.lblconsec_ctr);
            this.gpbGuardar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gpbGuardar.Location = new System.Drawing.Point(12, 12);
            this.gpbGuardar.Name = "gpbGuardar";
            this.gpbGuardar.Size = new System.Drawing.Size(336, 220);
            this.gpbGuardar.TabIndex = 0;
            this.gpbGuardar.TabStop = false;
            // 
            // lblcodigo_loc
            // 
            this.lblcodigo_loc.AutoSize = true;
            this.lblcodigo_loc.Location = new System.Drawing.Point(6, 31);
            this.lblcodigo_loc.Name = "lblcodigo_loc";
            this.lblcodigo_loc.Size = new System.Drawing.Size(36, 13);
            this.lblcodigo_loc.TabIndex = 15;
            this.lblcodigo_loc.Text = "Local:";
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarDatos.Image = global::Importar.Properties.Resources._1486485557_add_create_new_more_plus_81188;
            this.btnGuardarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarDatos.Location = new System.Drawing.Point(236, 176);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(97, 38);
            this.btnGuardarDatos.TabIndex = 14;
            this.btnGuardarDatos.Text = "Guardar ";
            this.btnGuardarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDatos.UseVisualStyleBackColor = false;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // txtSave_estado_ctr
            // 
            this.txtSave_estado_ctr.Location = new System.Drawing.Point(55, 145);
            this.txtSave_estado_ctr.Name = "txtSave_estado_ctr";
            this.txtSave_estado_ctr.Size = new System.Drawing.Size(73, 20);
            this.txtSave_estado_ctr.TabIndex = 13;
            // 
            // txtSave_fecha_ctr
            // 
            this.txtSave_fecha_ctr.Location = new System.Drawing.Point(224, 109);
            this.txtSave_fecha_ctr.Name = "txtSave_fecha_ctr";
            this.txtSave_fecha_ctr.Size = new System.Drawing.Size(73, 20);
            this.txtSave_fecha_ctr.TabIndex = 12;
            // 
            // txtSave_valor_ctr
            // 
            this.txtSave_valor_ctr.Location = new System.Drawing.Point(206, 66);
            this.txtSave_valor_ctr.Name = "txtSave_valor_ctr";
            this.txtSave_valor_ctr.Size = new System.Drawing.Size(73, 20);
            this.txtSave_valor_ctr.TabIndex = 11;
            // 
            // txtSave_id_emp
            // 
            this.txtSave_id_emp.Location = new System.Drawing.Point(69, 69);
            this.txtSave_id_emp.Name = "txtSave_id_emp";
            this.txtSave_id_emp.Size = new System.Drawing.Size(73, 20);
            this.txtSave_id_emp.TabIndex = 10;
            // 
            // txtSave_codigo_trs
            // 
            this.txtSave_codigo_trs.Location = new System.Drawing.Point(81, 106);
            this.txtSave_codigo_trs.Name = "txtSave_codigo_trs";
            this.txtSave_codigo_trs.Size = new System.Drawing.Size(73, 20);
            this.txtSave_codigo_trs.TabIndex = 9;
            // 
            // txtSave_consec_ctr
            // 
            this.txtSave_consec_ctr.Location = new System.Drawing.Point(206, 31);
            this.txtSave_consec_ctr.Name = "txtSave_consec_ctr";
            this.txtSave_consec_ctr.Size = new System.Drawing.Size(110, 20);
            this.txtSave_consec_ctr.TabIndex = 8;
            // 
            // txtSave_codigo_loc
            // 
            this.txtSave_codigo_loc.Location = new System.Drawing.Point(48, 31);
            this.txtSave_codigo_loc.Name = "txtSave_codigo_loc";
            this.txtSave_codigo_loc.Size = new System.Drawing.Size(47, 20);
            this.txtSave_codigo_loc.TabIndex = 7;
            // 
            // lblestado_ctr
            // 
            this.lblestado_ctr.AutoSize = true;
            this.lblestado_ctr.Location = new System.Drawing.Point(6, 148);
            this.lblestado_ctr.Name = "lblestado_ctr";
            this.lblestado_ctr.Size = new System.Drawing.Size(43, 13);
            this.lblestado_ctr.TabIndex = 6;
            this.lblestado_ctr.Text = "Estado:";
            // 
            // lblfecha_ctr
            // 
            this.lblfecha_ctr.AutoSize = true;
            this.lblfecha_ctr.Location = new System.Drawing.Point(178, 113);
            this.lblfecha_ctr.Name = "lblfecha_ctr";
            this.lblfecha_ctr.Size = new System.Drawing.Size(40, 13);
            this.lblfecha_ctr.TabIndex = 5;
            this.lblfecha_ctr.Text = "Fecha:";
            // 
            // lblvalor_ctr
            // 
            this.lblvalor_ctr.AutoSize = true;
            this.lblvalor_ctr.Location = new System.Drawing.Point(163, 72);
            this.lblvalor_ctr.Name = "lblvalor_ctr";
            this.lblvalor_ctr.Size = new System.Drawing.Size(34, 13);
            this.lblvalor_ctr.TabIndex = 4;
            this.lblvalor_ctr.Text = "Valor:";
            // 
            // lblid_emp
            // 
            this.lblid_emp.AutoSize = true;
            this.lblid_emp.Location = new System.Drawing.Point(6, 69);
            this.lblid_emp.Name = "lblid_emp";
            this.lblid_emp.Size = new System.Drawing.Size(57, 13);
            this.lblid_emp.TabIndex = 3;
            this.lblid_emp.Text = "Empleado:";
            // 
            // lblcodigo_trs
            // 
            this.lblcodigo_trs.AutoSize = true;
            this.lblcodigo_trs.Location = new System.Drawing.Point(6, 109);
            this.lblcodigo_trs.Name = "lblcodigo_trs";
            this.lblcodigo_trs.Size = new System.Drawing.Size(69, 13);
            this.lblcodigo_trs.TabIndex = 2;
            this.lblcodigo_trs.Text = "Transaccion:";
            // 
            // lblconsec_ctr
            // 
            this.lblconsec_ctr.AutoSize = true;
            this.lblconsec_ctr.Location = new System.Drawing.Point(131, 31);
            this.lblconsec_ctr.Name = "lblconsec_ctr";
            this.lblconsec_ctr.Size = new System.Drawing.Size(69, 13);
            this.lblconsec_ctr.TabIndex = 1;
            this.lblconsec_ctr.Text = "Consecutivo:";
            // 
            // Frm_AgregarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 244);
            this.Controls.Add(this.gpbGuardar);
            this.Name = "Frm_AgregarDatos";
            this.Text = "Agregar Transaccion";
            this.gpbGuardar.ResumeLayout(false);
            this.gpbGuardar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGuardar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblestado_ctr;
        private System.Windows.Forms.Label lblfecha_ctr;
        private System.Windows.Forms.Label lblvalor_ctr;
        private System.Windows.Forms.Label lblid_emp;
        private System.Windows.Forms.Label lblcodigo_trs;
        private System.Windows.Forms.Label lblconsec_ctr;
        private System.Windows.Forms.TextBox txtSave_estado_ctr;
        private System.Windows.Forms.TextBox txtSave_fecha_ctr;
        private System.Windows.Forms.TextBox txtSave_valor_ctr;
        private System.Windows.Forms.TextBox txtSave_id_emp;
        private System.Windows.Forms.TextBox txtSave_codigo_trs;
        private System.Windows.Forms.TextBox txtSave_consec_ctr;
        private System.Windows.Forms.TextBox txtSave_codigo_loc;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Label lblcodigo_loc;
    }
}