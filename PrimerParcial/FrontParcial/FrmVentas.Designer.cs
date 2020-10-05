namespace FrontParcial
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblVentasEmpleado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgListaEmpleados = new System.Windows.Forms.DataGridView();
            this.dtgListaVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(11, 21);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(94, 20);
            this.lblEmpleado.TabIndex = 4;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblVentasEmpleado
            // 
            this.lblVentasEmpleado.AutoSize = true;
            this.lblVentasEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasEmpleado.Location = new System.Drawing.Point(11, 205);
            this.lblVentasEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVentasEmpleado.Name = "lblVentasEmpleado";
            this.lblVentasEmpleado.Size = new System.Drawing.Size(183, 20);
            this.lblVentasEmpleado.TabIndex = 5;
            this.lblVentasEmpleado.Text = "Ventas del empleado:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(626, 402);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgListaEmpleados
            // 
            this.dtgListaEmpleados.AllowUserToAddRows = false;
            this.dtgListaEmpleados.AllowUserToDeleteRows = false;
            this.dtgListaEmpleados.AllowUserToResizeColumns = false;
            this.dtgListaEmpleados.AllowUserToResizeRows = false;
            this.dtgListaEmpleados.BackgroundColor = System.Drawing.Color.Peru;
            this.dtgListaEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgListaEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListaEmpleados.ColumnHeadersHeight = 40;
            this.dtgListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgListaEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgListaEmpleados.EnableHeadersVisualStyles = false;
            this.dtgListaEmpleados.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgListaEmpleados.Location = new System.Drawing.Point(15, 43);
            this.dtgListaEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dtgListaEmpleados.Name = "dtgListaEmpleados";
            this.dtgListaEmpleados.ReadOnly = true;
            this.dtgListaEmpleados.RowHeadersVisible = false;
            this.dtgListaEmpleados.RowHeadersWidth = 72;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgListaEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListaEmpleados.RowTemplate.Height = 31;
            this.dtgListaEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListaEmpleados.Size = new System.Drawing.Size(745, 160);
            this.dtgListaEmpleados.TabIndex = 7;
            this.dtgListaEmpleados.DoubleClick += new System.EventHandler(this.dtgListaEmpleados_DoubleClick);
            // 
            // dtgListaVentas
            // 
            this.dtgListaVentas.AllowUserToAddRows = false;
            this.dtgListaVentas.AllowUserToDeleteRows = false;
            this.dtgListaVentas.AllowUserToResizeColumns = false;
            this.dtgListaVentas.AllowUserToResizeRows = false;
            this.dtgListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgListaVentas.BackgroundColor = System.Drawing.Color.Peru;
            this.dtgListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListaVentas.ColumnHeadersHeight = 40;
            this.dtgListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgListaVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgListaVentas.EnableHeadersVisualStyles = false;
            this.dtgListaVentas.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgListaVentas.Location = new System.Drawing.Point(15, 236);
            this.dtgListaVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgListaVentas.Name = "dtgListaVentas";
            this.dtgListaVentas.ReadOnly = true;
            this.dtgListaVentas.RowHeadersVisible = false;
            this.dtgListaVentas.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgListaVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgListaVentas.RowTemplate.Height = 31;
            this.dtgListaVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgListaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListaVentas.Size = new System.Drawing.Size(745, 138);
            this.dtgListaVentas.TabIndex = 8;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(783, 448);
            this.Controls.Add(this.dtgListaVentas);
            this.Controls.Add(this.dtgListaEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblVentasEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblVentasEmpleado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgListaEmpleados;
        private System.Windows.Forms.DataGridView dtgListaVentas;
    }
}