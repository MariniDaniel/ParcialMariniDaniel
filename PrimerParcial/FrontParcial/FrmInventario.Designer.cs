namespace FrontParcial
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.picInventario = new System.Windows.Forms.PictureBox();
            this.dtgListaInventario = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockMenorA10ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaInventario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAgregarProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregarProducto.Location = new System.Drawing.Point(474, 252);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(152, 157);
            this.btnAgregarProducto.TabIndex = 12;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // picInventario
            // 
            this.picInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInventario.Image = global::FrontParcial.Properties.Resources.Deposito;
            this.picInventario.Location = new System.Drawing.Point(3, -6);
            this.picInventario.Name = "picInventario";
            this.picInventario.Size = new System.Drawing.Size(645, 614);
            this.picInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInventario.TabIndex = 1;
            this.picInventario.TabStop = false;
            // 
            // dtgListaInventario
            // 
            this.dtgListaInventario.AllowUserToResizeColumns = false;
            this.dtgListaInventario.AllowUserToResizeRows = false;
            this.dtgListaInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListaInventario.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgListaInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dtgListaInventario.Location = new System.Drawing.Point(24, 158);
            this.dtgListaInventario.Name = "dtgListaInventario";
            this.dtgListaInventario.ReadOnly = true;
            this.dtgListaInventario.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgListaInventario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListaInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListaInventario.Size = new System.Drawing.Size(444, 349);
            this.dtgListaInventario.TabIndex = 16;
            this.dtgListaInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLista_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockMenorA10ToolStripMenuItem1,
            this.mostrarTotalToolStripMenuItem});
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // stockMenorA10ToolStripMenuItem1
            // 
            this.stockMenorA10ToolStripMenuItem1.Name = "stockMenorA10ToolStripMenuItem1";
            this.stockMenorA10ToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.stockMenorA10ToolStripMenuItem1.Text = "Stock menor a 10";
            this.stockMenorA10ToolStripMenuItem1.Click += new System.EventHandler(this.stockMenorA10ToolStripMenuItem1_Click);
            // 
            // mostrarTotalToolStripMenuItem
            // 
            this.mostrarTotalToolStripMenuItem.Name = "mostrarTotalToolStripMenuItem";
            this.mostrarTotalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.mostrarTotalToolStripMenuItem.Text = "Mostrar Total";
            this.mostrarTotalToolStripMenuItem.Click += new System.EventHandler(this.mostrarTotalToolStripMenuItem_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(638, 605);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtgListaInventario);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.picInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaInventario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picInventario;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dtgListaInventario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockMenorA10ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarTotalToolStripMenuItem;
    }
}