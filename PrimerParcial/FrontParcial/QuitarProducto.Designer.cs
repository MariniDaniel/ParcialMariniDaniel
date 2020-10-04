namespace FrontParcial
{
    partial class QuitarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuitarProducto));
            this.picAgregarProducto = new System.Windows.Forms.PictureBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dtgLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // picAgregarProducto
            // 
            this.picAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAgregarProducto.Image = global::FrontParcial.Properties.Resources.Deposito;
            this.picAgregarProducto.Location = new System.Drawing.Point(-8, -14);
            this.picAgregarProducto.Name = "picAgregarProducto";
            this.picAgregarProducto.Size = new System.Drawing.Size(370, 478);
            this.picAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAgregarProducto.TabIndex = 3;
            this.picAgregarProducto.TabStop = false;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(80, 128);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(197, 20);
            this.lblNombreProducto.TabIndex = 7;
            this.lblNombreProducto.Text = "Seleccione el producto ";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitar.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnQuitar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuitar.Location = new System.Drawing.Point(84, 383);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(178, 69);
            this.btnQuitar.TabIndex = 14;
            this.btnQuitar.Text = "Quitar Producto";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dtgLista
            // 
            this.dtgLista.AllowUserToAddRows = false;
            this.dtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLista.Location = new System.Drawing.Point(12, 167);
            this.dtgLista.Name = "dtgLista";
            this.dtgLista.ReadOnly = true;
            this.dtgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLista.Size = new System.Drawing.Size(336, 189);
            this.dtgLista.StandardTab = true;
            this.dtgLista.TabIndex = 15;
            // 
            // QuitarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 464);
            this.Controls.Add(this.dtgLista);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.picAgregarProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuitarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuitarProducto";
            this.Load += new System.EventHandler(this.QuitarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAgregarProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dtgLista;
    }
}