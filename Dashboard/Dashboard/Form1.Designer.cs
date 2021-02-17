
namespace Dashboard
{
    partial class Form1
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
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpComerciales = new System.Windows.Forms.TableLayoutPanel();
            this.tlpComercial2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpComercial1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbComercial1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlpComerciales.SuspendLayout();
            this.tlpComercial2.SuspendLayout();
            this.tlpComercial1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tlpBase.ColumnCount = 2;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.86047F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.13953F));
            this.tlpBase.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpBase.Controls.Add(this.tlpComerciales, 1, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.7874F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.2126F));
            this.tlpBase.Size = new System.Drawing.Size(1115, 659);
            this.tlpBase.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.Logo_empresa_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tlpComerciales
            // 
            this.tlpComerciales.ColumnCount = 3;
            this.tlpComerciales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpComerciales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpComerciales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpComerciales.Controls.Add(this.tlpComercial1, 0, 0);
            this.tlpComerciales.Controls.Add(this.tlpComercial2, 1, 0);
            this.tlpComerciales.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tlpComerciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComerciales.Location = new System.Drawing.Point(202, 3);
            this.tlpComerciales.Name = "tlpComerciales";
            this.tlpComerciales.RowCount = 1;
            this.tlpComerciales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComerciales.Size = new System.Drawing.Size(910, 130);
            this.tlpComerciales.TabIndex = 1;
            // 
            // tlpComercial2
            // 
            this.tlpComercial2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpComercial2.ColumnCount = 2;
            this.tlpComercial2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComercial2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComercial2.Controls.Add(this.button1, 0, 0);
            this.tlpComercial2.Location = new System.Drawing.Point(306, 3);
            this.tlpComercial2.Name = "tlpComercial2";
            this.tlpComercial2.RowCount = 1;
            this.tlpComercial2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComercial2.Size = new System.Drawing.Size(297, 124);
            this.tlpComercial2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(609, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 124);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tlpComercial1
            // 
            this.tlpComercial1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpComercial1.ColumnCount = 2;
            this.tlpComercial1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComercial1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComercial1.Controls.Add(this.pictureBox2, 0, 0);
            this.tlpComercial1.Controls.Add(this.tbComercial1, 1, 0);
            this.tlpComercial1.Location = new System.Drawing.Point(3, 3);
            this.tlpComercial1.Name = "tlpComercial1";
            this.tlpComercial1.RowCount = 1;
            this.tlpComercial1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComercial1.Size = new System.Drawing.Size(297, 124);
            this.tlpComercial1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Dashboard.Properties.Resources.usuario_jpg;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbComercial1
            // 
            this.tbComercial1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComercial1.Location = new System.Drawing.Point(151, 3);
            this.tbComercial1.Multiline = true;
            this.tbComercial1.Name = "tbComercial1";
            this.tbComercial1.Size = new System.Drawing.Size(143, 118);
            this.tbComercial1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1115, 659);
            this.Controls.Add(this.tlpBase);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tlpBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlpComerciales.ResumeLayout(false);
            this.tlpComercial2.ResumeLayout(false);
            this.tlpComercial1.ResumeLayout(false);
            this.tlpComercial1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tlpComerciales;
        private System.Windows.Forms.TableLayoutPanel tlpComercial2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpComercial1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbComercial1;
        private System.Windows.Forms.Button button1;
    }
}

