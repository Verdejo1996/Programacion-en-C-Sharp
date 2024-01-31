namespace Libreria
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
            this.lbLibros = new System.Windows.Forms.ListBox();
            this.lbEstante1 = new System.Windows.Forms.ListBox();
            this.lbEstante2 = new System.Windows.Forms.ListBox();
            this.lbPrestamos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnPrestar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLibros
            // 
            this.lbLibros.FormattingEnabled = true;
            this.lbLibros.Location = new System.Drawing.Point(226, 81);
            this.lbLibros.Name = "lbLibros";
            this.lbLibros.Size = new System.Drawing.Size(654, 95);
            this.lbLibros.TabIndex = 0;
            // 
            // lbEstante1
            // 
            this.lbEstante1.FormattingEnabled = true;
            this.lbEstante1.Location = new System.Drawing.Point(64, 264);
            this.lbEstante1.Name = "lbEstante1";
            this.lbEstante1.Size = new System.Drawing.Size(507, 95);
            this.lbEstante1.TabIndex = 1;
            // 
            // lbEstante2
            // 
            this.lbEstante2.FormattingEnabled = true;
            this.lbEstante2.Location = new System.Drawing.Point(616, 264);
            this.lbEstante2.Name = "lbEstante2";
            this.lbEstante2.Size = new System.Drawing.Size(484, 95);
            this.lbEstante2.TabIndex = 2;
            // 
            // lbPrestamos
            // 
            this.lbPrestamos.FormattingEnabled = true;
            this.lbPrestamos.Location = new System.Drawing.Point(226, 472);
            this.lbPrestamos.Name = "lbPrestamos";
            this.lbPrestamos.Size = new System.Drawing.Size(654, 95);
            this.lbPrestamos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Libros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estante 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estante 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prestamos:";
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.Location = new System.Drawing.Point(226, 235);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar1.TabIndex = 8;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = true;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Location = new System.Drawing.Point(805, 235);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar2.TabIndex = 9;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // btnPrestar
            // 
            this.btnPrestar.Location = new System.Drawing.Point(496, 365);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(75, 23);
            this.btnPrestar.TabIndex = 10;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(805, 582);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 11;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnPrestar2
            // 
            this.btnPrestar2.Location = new System.Drawing.Point(1025, 365);
            this.btnPrestar2.Name = "btnPrestar2";
            this.btnPrestar2.Size = new System.Drawing.Size(75, 23);
            this.btnPrestar2.TabIndex = 12;
            this.btnPrestar2.Text = "Prestar";
            this.btnPrestar2.UseVisualStyleBackColor = true;
            this.btnPrestar2.Click += new System.EventHandler(this.btnPrestar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 666);
            this.Controls.Add(this.btnPrestar2);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.btnAgregar2);
            this.Controls.Add(this.btnAgregar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrestamos);
            this.Controls.Add(this.lbEstante2);
            this.Controls.Add(this.lbEstante1);
            this.Controls.Add(this.lbLibros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLibros;
        private System.Windows.Forms.ListBox lbEstante1;
        private System.Windows.Forms.ListBox lbEstante2;
        private System.Windows.Forms.ListBox lbPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnPrestar2;
    }
}

