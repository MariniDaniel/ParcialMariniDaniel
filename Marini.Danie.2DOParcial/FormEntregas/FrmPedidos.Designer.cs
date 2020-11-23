namespace FormEntregas
{
    partial class FrmPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.dtvEnPreparacion = new System.Windows.Forms.DataGridView();
            this.dtvEntregados = new System.Windows.Forms.DataGridView();
            this.lblPedientes = new System.Windows.Forms.Label();
            this.lblEntregados = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarPedido = new System.Windows.Forms.Button();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.btnCantPedidos = new System.Windows.Forms.Button();
            this.picHelados = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picHelados2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDePedidosPorGustoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPedidoNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEnPreparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEntregados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelados2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvEnPreparacion
            // 
            this.dtvEnPreparacion.AllowUserToAddRows = false;
            this.dtvEnPreparacion.AllowUserToDeleteRows = false;
            this.dtvEnPreparacion.AllowUserToResizeColumns = false;
            this.dtvEnPreparacion.AllowUserToResizeRows = false;
            this.dtvEnPreparacion.BackgroundColor = System.Drawing.Color.Khaki;
            this.dtvEnPreparacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvEnPreparacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvEnPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvEnPreparacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtvEnPreparacion.EnableHeadersVisualStyles = false;
            this.dtvEnPreparacion.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtvEnPreparacion.Location = new System.Drawing.Point(25, 62);
            this.dtvEnPreparacion.Margin = new System.Windows.Forms.Padding(2);
            this.dtvEnPreparacion.Name = "dtvEnPreparacion";
            this.dtvEnPreparacion.ReadOnly = true;
            this.dtvEnPreparacion.RowHeadersVisible = false;
            this.dtvEnPreparacion.RowHeadersWidth = 62;
            this.dtvEnPreparacion.RowTemplate.Height = 28;
            this.dtvEnPreparacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtvEnPreparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvEnPreparacion.Size = new System.Drawing.Size(503, 312);
            this.dtvEnPreparacion.TabIndex = 0;
            // 
            // dtvEntregados
            // 
            this.dtvEntregados.AllowUserToAddRows = false;
            this.dtvEntregados.AllowUserToDeleteRows = false;
            this.dtvEntregados.AllowUserToResizeColumns = false;
            this.dtvEntregados.AllowUserToResizeRows = false;
            this.dtvEntregados.BackgroundColor = System.Drawing.Color.Khaki;
            this.dtvEntregados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvEntregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtvEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvEntregados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtvEntregados.EnableHeadersVisualStyles = false;
            this.dtvEntregados.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtvEntregados.Location = new System.Drawing.Point(582, 62);
            this.dtvEntregados.Margin = new System.Windows.Forms.Padding(2);
            this.dtvEntregados.Name = "dtvEntregados";
            this.dtvEntregados.ReadOnly = true;
            this.dtvEntregados.RowHeadersVisible = false;
            this.dtvEntregados.RowHeadersWidth = 62;
            this.dtvEntregados.RowTemplate.Height = 28;
            this.dtvEntregados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtvEntregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvEntregados.Size = new System.Drawing.Size(503, 319);
            this.dtvEntregados.TabIndex = 1;
            // 
            // lblPedientes
            // 
            this.lblPedientes.AutoSize = true;
            this.lblPedientes.BackColor = System.Drawing.Color.Khaki;
            this.lblPedientes.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedientes.Location = new System.Drawing.Point(148, 31);
            this.lblPedientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedientes.Name = "lblPedientes";
            this.lblPedientes.Size = new System.Drawing.Size(211, 22);
            this.lblPedientes.TabIndex = 2;
            this.lblPedientes.Text = "Pedidos en preparacion:";
            // 
            // lblEntregados
            // 
            this.lblEntregados.AutoSize = true;
            this.lblEntregados.BackColor = System.Drawing.Color.Khaki;
            this.lblEntregados.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregados.Location = new System.Drawing.Point(746, 31);
            this.lblEntregados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntregados.Name = "lblEntregados";
            this.lblEntregados.Size = new System.Drawing.Size(179, 22);
            this.lblEntregados.TabIndex = 3;
            this.lblEntregados.Text = "Pedidos entregados:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Khaki;
            this.btnSalir.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(942, 481);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 43);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarPedido
            // 
            this.btnCargarPedido.BackColor = System.Drawing.Color.Khaki;
            this.btnCargarPedido.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPedido.Location = new System.Drawing.Point(192, 387);
            this.btnCargarPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarPedido.Name = "btnCargarPedido";
            this.btnCargarPedido.Size = new System.Drawing.Size(167, 62);
            this.btnCargarPedido.TabIndex = 10;
            this.btnCargarPedido.Text = "Cargar Pedido";
            this.btnCargarPedido.UseVisualStyleBackColor = false;
            this.btnCargarPedido.Click += new System.EventHandler(this.btnCargarPedido_Click);
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.BackColor = System.Drawing.Color.Khaki;
            this.lblPedidos.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.Location = new System.Drawing.Point(20, 481);
            this.lblPedidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(111, 29);
            this.lblPedidos.TabIndex = 11;
            this.lblPedidos.Text = "Pedidos:";
            // 
            // btnCantPedidos
            // 
            this.btnCantPedidos.BackColor = System.Drawing.Color.Khaki;
            this.btnCantPedidos.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantPedidos.Location = new System.Drawing.Point(731, 395);
            this.btnCantPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCantPedidos.Name = "btnCantPedidos";
            this.btnCantPedidos.Size = new System.Drawing.Size(234, 66);
            this.btnCantPedidos.TabIndex = 13;
            this.btnCantPedidos.Text = "Cantidad De Pedidos Por Gusto";
            this.btnCantPedidos.UseVisualStyleBackColor = false;
            this.btnCantPedidos.Click += new System.EventHandler(this.btnCantPedidos_Click);
            // 
            // picHelados
            // 
            this.picHelados.Image = global::FormEntregas.Properties.Resources.ilustracion_heladeria_53876_59829;
            this.picHelados.Location = new System.Drawing.Point(-6, -3);
            this.picHelados.Name = "picHelados";
            this.picHelados.Size = new System.Drawing.Size(573, 544);
            this.picHelados.TabIndex = 14;
            this.picHelados.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Khaki;
            this.lblTitulo.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(458, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 22);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "-Bienvenido Al 2° Parcial-";
            // 
            // picHelados2
            // 
            this.picHelados2.Image = global::FormEntregas.Properties.Resources.ilustracion_heladeria_53876_59829;
            this.picHelados2.Location = new System.Drawing.Point(559, -3);
            this.picHelados2.Name = "picHelados2";
            this.picHelados2.Size = new System.Drawing.Size(571, 544);
            this.picHelados2.TabIndex = 16;
            this.picHelados2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarPedidoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargarPedidoToolStripMenuItem
            // 
            this.cargarPedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDePedidosPorGustoToolStripMenuItem,
            this.cargarPedidoNuevoToolStripMenuItem});
            this.cargarPedidoToolStripMenuItem.Name = "cargarPedidoToolStripMenuItem";
            this.cargarPedidoToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.cargarPedidoToolStripMenuItem.Text = "Opciones";
            // 
            // cantidadDePedidosPorGustoToolStripMenuItem
            // 
            this.cantidadDePedidosPorGustoToolStripMenuItem.Name = "cantidadDePedidosPorGustoToolStripMenuItem";
            this.cantidadDePedidosPorGustoToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.cantidadDePedidosPorGustoToolStripMenuItem.Text = "Cantidad De Pedidos Por Gusto";
            this.cantidadDePedidosPorGustoToolStripMenuItem.Click += new System.EventHandler(this.cantidadDePedidosPorGustoToolStripMenuItem_Click);
            // 
            // cargarPedidoNuevoToolStripMenuItem
            // 
            this.cargarPedidoNuevoToolStripMenuItem.Name = "cargarPedidoNuevoToolStripMenuItem";
            this.cargarPedidoNuevoToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.cargarPedidoNuevoToolStripMenuItem.Text = "Cargar Pedido Nuevo";
            this.cargarPedidoNuevoToolStripMenuItem.Click += new System.EventHandler(this.cargarPedidoNuevoToolStripMenuItem_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 535);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCantPedidos);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.btnCargarPedido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEntregados);
            this.Controls.Add(this.lblPedientes);
            this.Controls.Add(this.dtvEntregados);
            this.Controls.Add(this.dtvEnPreparacion);
            this.Controls.Add(this.picHelados2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picHelados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEntregas_FormClosing);
            this.Load += new System.EventHandler(this.FormEntregas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvEnPreparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEntregados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelados2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvEnPreparacion;
        private System.Windows.Forms.DataGridView dtvEntregados;
        private System.Windows.Forms.Label lblPedientes;
        private System.Windows.Forms.Label lblEntregados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarPedido;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Button btnCantPedidos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picHelados;
        private System.Windows.Forms.PictureBox picHelados2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDePedidosPorGustoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPedidoNuevoToolStripMenuItem;
    }
}

