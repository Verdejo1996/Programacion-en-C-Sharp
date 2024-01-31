namespace Practicanumeromil
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
            this.btnRespuesta1 = new System.Windows.Forms.Button();
            this.btnRespuesta2 = new System.Windows.Forms.Button();
            this.btnRespuesta3 = new System.Windows.Forms.Button();
            this.btnRespuesta4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRespuesta1
            // 
            this.btnRespuesta1.Location = new System.Drawing.Point(180, 160);
            this.btnRespuesta1.Name = "btnRespuesta1";
            this.btnRespuesta1.Size = new System.Drawing.Size(75, 23);
            this.btnRespuesta1.TabIndex = 0;
            this.btnRespuesta1.Text = "button1";
            this.btnRespuesta1.UseVisualStyleBackColor = true;
            this.btnRespuesta1.Click += new System.EventHandler(this.btnRespuesta1_Click);
            // 
            // btnRespuesta2
            // 
            this.btnRespuesta2.Location = new System.Drawing.Point(304, 160);
            this.btnRespuesta2.Name = "btnRespuesta2";
            this.btnRespuesta2.Size = new System.Drawing.Size(75, 23);
            this.btnRespuesta2.TabIndex = 1;
            this.btnRespuesta2.Text = "button2";
            this.btnRespuesta2.UseVisualStyleBackColor = true;
            this.btnRespuesta2.Click += new System.EventHandler(this.btnRespuesta2_Click);
            // 
            // btnRespuesta3
            // 
            this.btnRespuesta3.Location = new System.Drawing.Point(180, 201);
            this.btnRespuesta3.Name = "btnRespuesta3";
            this.btnRespuesta3.Size = new System.Drawing.Size(75, 23);
            this.btnRespuesta3.TabIndex = 2;
            this.btnRespuesta3.Text = "button3";
            this.btnRespuesta3.UseVisualStyleBackColor = true;
            this.btnRespuesta3.Click += new System.EventHandler(this.btnRespuesta3_Click);
            // 
            // btnRespuesta4
            // 
            this.btnRespuesta4.Location = new System.Drawing.Point(304, 201);
            this.btnRespuesta4.Name = "btnRespuesta4";
            this.btnRespuesta4.Size = new System.Drawing.Size(75, 23);
            this.btnRespuesta4.TabIndex = 3;
            this.btnRespuesta4.Text = "button4";
            this.btnRespuesta4.UseVisualStyleBackColor = true;
            this.btnRespuesta4.Click += new System.EventHandler(this.btnRespuesta4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pregunta:";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(170, 52);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(35, 13);
            this.lblPregunta.TabIndex = 5;
            this.lblPregunta.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRespuesta4);
            this.Controls.Add(this.btnRespuesta3);
            this.Controls.Add(this.btnRespuesta2);
            this.Controls.Add(this.btnRespuesta1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRespuesta1;
        private System.Windows.Forms.Button btnRespuesta2;
        private System.Windows.Forms.Button btnRespuesta3;
        private System.Windows.Forms.Button btnRespuesta4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPregunta;
    }
}

