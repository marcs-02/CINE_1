namespace CINE_1
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
            this.TABLA = new System.Windows.Forms.TableLayoutPanel();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.TABLA.SuspendLayout();
            this.SuspendLayout();
            // 
            // TABLA
            // 
            this.TABLA.ColumnCount = 2;
            this.TABLA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TABLA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TABLA.Controls.Add(this.B3, 0, 1);
            this.TABLA.Controls.Add(this.B2, 1, 0);
            this.TABLA.Controls.Add(this.B1, 0, 0);
            this.TABLA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABLA.Location = new System.Drawing.Point(0, 0);
            this.TABLA.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.TABLA.Name = "TABLA";
            this.TABLA.RowCount = 2;
            this.TABLA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TABLA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TABLA.Size = new System.Drawing.Size(783, 402);
            this.TABLA.TabIndex = 0;
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Javanese Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(3, 7);
            this.B1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(385, 187);
            this.B1.TabIndex = 0;
            this.B1.Text = "CLIENTE";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Javanese Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(394, 7);
            this.B2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(385, 187);
            this.B2.TabIndex = 1;
            this.B2.Text = "PRODUCTO";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Javanese Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(3, 208);
            this.B3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(385, 187);
            this.B3.TabIndex = 2;
            this.B3.Text = "FACTURA";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 402);
            this.Controls.Add(this.TABLA);
            this.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "Form1";
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TABLA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TABLA;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
    }
}

