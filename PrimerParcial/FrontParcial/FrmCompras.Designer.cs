namespace FrontParcial
{
    partial class FrmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.picPrincipal = new System.Windows.Forms.PictureBox();
            this.dtgListaInventario = new System.Windows.Forms.DataGridView();
            this.lblCantidadAComprar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblEncabezadoMonto = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgCompras = new System.Windows.Forms.DataGridView();
            this.btnClienteExiste = new System.Windows.Forms.Button();
            this.btnClienteNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // picPrincipal
            // 
            this.picPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPrincipal.Enabled = false;
            this.picPrincipal.Image = global::FrontParcial.Properties.Resources.Venta2;
            this.picPrincipal.Location = new System.Drawing.Point(-10, -1);
            this.picPrincipal.Name = "picPrincipal";
            this.picPrincipal.Size = new System.Drawing.Size(852, 580);
            this.picPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrincipal.TabIndex = 1;
            this.picPrincipal.TabStop = false;
            // 
            // dtgListaInventario
            // 
            this.dtgListaInventario.AllowUserToAddRows = false;
            this.dtgListaInventario.AllowUserToDeleteRows = false;
            this.dtgListaInventario.AllowUserToResizeColumns = false;
            this.dtgListaInventario.AllowUserToResizeRows = false;
            this.dtgListaInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListaInventario.BackgroundColor = System.Drawing.Color.Tan;
            this.dtgListaInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgListaInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListaInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListaInventario.ColumnHeadersHeight = 30;
            this.dtgListaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgListaInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListaInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListaInventario.EnableHeadersVisualStyles = false;
            this.dtgListaInventario.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgListaInventario.Location = new System.Drawing.Point(12, 25);
            this.dtgListaInventario.Name = "dtgListaInventario";
            this.dtgListaInventario.ReadOnly = true;
            this.dtgListaInventario.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgListaInventario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListaInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListaInventario.Size = new System.Drawing.Size(464, 530);
            this.dtgListaInventario.StandardTab = true;
            this.dtgListaInventario.TabIndex = 17;
            this.dtgListaInventario.DoubleClick += new System.EventHandler(this.dtgListaInventario_DoubleClick);
            // 
            // lblCantidadAComprar
            // 
            this.lblCantidadAComprar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidadAComprar.AutoSize = true;
            this.lblCantidadAComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAComprar.Location = new System.Drawing.Point(522, 25);
            this.lblCantidadAComprar.Name = "lblCantidadAComprar";
            this.lblCantidadAComprar.Size = new System.Drawing.Size(228, 20);
            this.lblCantidadAComprar.TabIndex = 18;
            this.lblCantidadAComprar.Text = "Indique cantidad a comprar";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Y seleccione el producto + 2Clicks";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(552, 60);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(161, 20);
            this.txtStock.TabIndex = 20;
            // 
            // lblEncabezadoMonto
            // 
            this.lblEncabezadoMonto.AutoSize = true;
            this.lblEncabezadoMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezadoMonto.Location = new System.Drawing.Point(500, 503);
            this.lblEncabezadoMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEncabezadoMonto.Name = "lblEncabezadoMonto";
            this.lblEncabezadoMonto.Size = new System.Drawing.Size(121, 24);
            this.lblEncabezadoMonto.TabIndex = 21;
            this.lblEncabezadoMonto.Text = "Monto total: $";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(654, 503);
            this.lblMontoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(20, 24);
            this.lblMontoTotal.TabIndex = 22;
            this.lblMontoTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Con 2 Clicks saca un producto";
            // 
            // dtgCompras
            // 
            this.dtgCompras.AllowUserToAddRows = false;
            this.dtgCompras.AllowUserToDeleteRows = false;
            this.dtgCompras.AllowUserToResizeColumns = false;
            this.dtgCompras.AllowUserToResizeRows = false;
            this.dtgCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCompras.BackgroundColor = System.Drawing.Color.Tan;
            this.dtgCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCompras.ColumnHeadersHeight = 30;
            this.dtgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCompras.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgCompras.EnableHeadersVisualStyles = false;
            this.dtgCompras.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgCompras.Location = new System.Drawing.Point(484, 189);
            this.dtgCompras.Name = "dtgCompras";
            this.dtgCompras.ReadOnly = true;
            this.dtgCompras.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dtgCompras.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCompras.Size = new System.Drawing.Size(343, 196);
            this.dtgCompras.StandardTab = true;
            this.dtgCompras.TabIndex = 25;
            this.dtgCompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCompras_CellDoubleClick);
            // 
            // btnClienteExiste
            // 
            this.btnClienteExiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteExiste.Location = new System.Drawing.Point(484, 417);
            this.btnClienteExiste.Name = "btnClienteExiste";
            this.btnClienteExiste.Size = new System.Drawing.Size(170, 44);
            this.btnClienteExiste.TabIndex = 26;
            this.btnClienteExiste.Text = "Cliente Existente";
            this.btnClienteExiste.UseVisualStyleBackColor = true;
            this.btnClienteExiste.Click += new System.EventHandler(this.btnClienteExiste_Click);
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteNuevo.Location = new System.Drawing.Point(657, 417);
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Size = new System.Drawing.Size(170, 44);
            this.btnClienteNuevo.TabIndex = 27;
            this.btnClienteNuevo.Text = "Cliente Nuevo";
            this.btnClienteNuevo.UseVisualStyleBackColor = true;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 575);
            this.Controls.Add(this.btnClienteNuevo);
            this.Controls.Add(this.btnClienteExiste);
            this.Controls.Add(this.dtgCompras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.lblEncabezadoMonto);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidadAComprar);
            this.Controls.Add(this.dtgListaInventario);
            this.Controls.Add(this.picPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puesto De Venta";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPrincipal;
        private System.Windows.Forms.DataGridView dtgListaInventario;
        private System.Windows.Forms.Label lblCantidadAComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblEncabezadoMonto;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgCompras;
        private System.Windows.Forms.Button btnClienteExiste;
        private System.Windows.Forms.Button btnClienteNuevo;
    }
}