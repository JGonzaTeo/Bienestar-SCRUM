﻿namespace Capa_Diseño_SCM
{
    partial class Frm_BusquedaOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BusquedaOrdenCompra));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Dgv_consultaOrdenCompra = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_codPercepcion = new System.Windows.Forms.Label();
            this.Txt_Cod = new System.Windows.Forms.TextBox();
            this.Lbl_idapp = new System.Windows.Forms.Label();
            this.Pnl_nombreForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(93, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(348, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BUSQUEDA ORDEN DE COMPRA";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Pnl_nombreForm.Controls.Add(this.Lbl_idapp);
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.lblTitulo);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 1);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1293, 63);
            this.Pnl_nombreForm.TabIndex = 1;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1183, 15);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1136, 15);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1233, 15);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_seleccionar.FlatAppearance.BorderSize = 3;
            this.Btn_seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Location = new System.Drawing.Point(517, 80);
            this.Btn_seleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(164, 41);
            this.Btn_seleccionar.TabIndex = 73;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Dgv_consultaOrdenCompra
            // 
            this.Dgv_consultaOrdenCompra.AllowUserToAddRows = false;
            this.Dgv_consultaOrdenCompra.AllowUserToDeleteRows = false;
            this.Dgv_consultaOrdenCompra.AllowUserToResizeColumns = false;
            this.Dgv_consultaOrdenCompra.AllowUserToResizeRows = false;
            this.Dgv_consultaOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaOrdenCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.fechaP,
            this.fechaE,
            this.codP,
            this.total});
            this.Dgv_consultaOrdenCompra.Location = new System.Drawing.Point(15, 213);
            this.Dgv_consultaOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_consultaOrdenCompra.MultiSelect = false;
            this.Dgv_consultaOrdenCompra.Name = "Dgv_consultaOrdenCompra";
            this.Dgv_consultaOrdenCompra.ReadOnly = true;
            this.Dgv_consultaOrdenCompra.RowHeadersVisible = false;
            this.Dgv_consultaOrdenCompra.RowHeadersWidth = 51;
            this.Dgv_consultaOrdenCompra.RowTemplate.Height = 24;
            this.Dgv_consultaOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaOrdenCompra.Size = new System.Drawing.Size(1263, 297);
            this.Dgv_consultaOrdenCompra.TabIndex = 72;
            this.Dgv_consultaOrdenCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_consultaOrdenCompra_CellClick);
            this.Dgv_consultaOrdenCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_consultaOrdenCompra_CellDoubleClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "COD Orden Compra";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // fechaP
            // 
            this.fechaP.HeaderText = "Fecha Pedido";
            this.fechaP.MinimumWidth = 6;
            this.fechaP.Name = "fechaP";
            this.fechaP.ReadOnly = true;
            // 
            // fechaE
            // 
            this.fechaE.HeaderText = "Fecha Entrega";
            this.fechaE.MinimumWidth = 6;
            this.fechaE.Name = "fechaE";
            this.fechaE.ReadOnly = true;
            // 
            // codP
            // 
            this.codP.HeaderText = "COD Proveedor";
            this.codP.MinimumWidth = 6;
            this.codP.Name = "codP";
            this.codP.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // Lbl_codPercepcion
            // 
            this.Lbl_codPercepcion.AutoSize = true;
            this.Lbl_codPercepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codPercepcion.Location = new System.Drawing.Point(27, 89);
            this.Lbl_codPercepcion.Name = "Lbl_codPercepcion";
            this.Lbl_codPercepcion.Size = new System.Drawing.Size(234, 24);
            this.Lbl_codPercepcion.TabIndex = 75;
            this.Lbl_codPercepcion.Text = "Codigo Orden de Compra:";
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cod.Location = new System.Drawing.Point(289, 85);
            this.Txt_Cod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(207, 29);
            this.Txt_Cod.TabIndex = 74;
            this.Txt_Cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cod_KeyPress);
            this.Txt_Cod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Cod_KeyUp);
            // 
            // Lbl_idapp
            // 
            this.Lbl_idapp.AutoSize = true;
            this.Lbl_idapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idapp.ForeColor = System.Drawing.Color.White;
            this.Lbl_idapp.Location = new System.Drawing.Point(26, 15);
            this.Lbl_idapp.Name = "Lbl_idapp";
            this.Lbl_idapp.Size = new System.Drawing.Size(62, 25);
            this.Lbl_idapp.TabIndex = 7;
            this.Lbl_idapp.Text = "108 -";
            // 
            // Frm_BusquedaOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 554);
            this.Controls.Add(this.Lbl_codPercepcion);
            this.Controls.Add(this.Txt_Cod);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_consultaOrdenCompra);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_BusquedaOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BusquedaOrdenCompra";
            this.Load += new System.EventHandler(this.Frm_BusquedaOrdenCompra_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaOrdenCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button Btn_seleccionar;
        public System.Windows.Forms.DataGridView Dgv_consultaOrdenCompra;
        private System.Windows.Forms.Label Lbl_codPercepcion;
        private System.Windows.Forms.TextBox Txt_Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn codP;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label Lbl_idapp;
    }
}