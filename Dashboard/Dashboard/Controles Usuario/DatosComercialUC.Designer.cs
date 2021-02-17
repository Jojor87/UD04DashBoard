
namespace Dashboard.Controles_Usuario
{
    partial class DatosComercialUC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbComercial = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbComercial = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbComercial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gbComercial, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbComercial
            // 
            this.gbComercial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbComercial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbComercial.Controls.Add(this.pictureBox1);
            this.gbComercial.Controls.Add(this.tbComercial);
            this.gbComercial.Location = new System.Drawing.Point(3, 3);
            this.gbComercial.Name = "gbComercial";
            this.gbComercial.Size = new System.Drawing.Size(514, 335);
            this.gbComercial.TabIndex = 0;
            this.gbComercial.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.usuario_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(198, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbComercial
            // 
            this.tbComercial.Location = new System.Drawing.Point(-3, 111);
            this.tbComercial.Multiline = true;
            this.tbComercial.Name = "tbComercial";
            this.tbComercial.Size = new System.Drawing.Size(517, 218);
            this.tbComercial.TabIndex = 0;
            this.tbComercial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DatosComercialUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DatosComercialUC";
            this.Size = new System.Drawing.Size(520, 341);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbComercial.ResumeLayout(false);
            this.gbComercial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbComercial;
        private System.Windows.Forms.TextBox tbComercial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
