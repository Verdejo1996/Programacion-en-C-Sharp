namespace TP_ProgramacionII_Punto1
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
            this.txtPrimerN = new System.Windows.Forms.TextBox();
            this.txtSegN = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrimerN
            // 
            this.txtPrimerN.Location = new System.Drawing.Point(110, 79);
            this.txtPrimerN.Name = "txtPrimerN";
            this.txtPrimerN.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerN.TabIndex = 0;
            // 
            // txtSegN
            // 
            this.txtSegN.Location = new System.Drawing.Point(300, 79);
            this.txtSegN.Name = "txtSegN";
            this.txtSegN.Size = new System.Drawing.Size(100, 20);
            this.txtSegN.TabIndex = 1;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(215, 134);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 208);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtSegN);
            this.Controls.Add(this.txtPrimerN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimerN;
        private System.Windows.Forms.TextBox txtSegN;
        private System.Windows.Forms.Button btnSuma;
    }
}

