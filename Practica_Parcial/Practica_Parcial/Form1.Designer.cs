namespace Practica_Parcial
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
            this.lbRopero = new System.Windows.Forms.ListBox();
            this.lbManiqui = new System.Windows.Forms.ListBox();
            this.btnVestir = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRopero
            // 
            this.lbRopero.FormattingEnabled = true;
            this.lbRopero.Location = new System.Drawing.Point(127, 98);
            this.lbRopero.Name = "lbRopero";
            this.lbRopero.Size = new System.Drawing.Size(119, 95);
            this.lbRopero.TabIndex = 0;
            // 
            // lbManiqui
            // 
            this.lbManiqui.FormattingEnabled = true;
            this.lbManiqui.Location = new System.Drawing.Point(406, 98);
            this.lbManiqui.Name = "lbManiqui";
            this.lbManiqui.Size = new System.Drawing.Size(119, 95);
            this.lbManiqui.TabIndex = 1;
            // 
            // btnVestir
            // 
            this.btnVestir.Location = new System.Drawing.Point(171, 220);
            this.btnVestir.Name = "btnVestir";
            this.btnVestir.Size = new System.Drawing.Size(75, 23);
            this.btnVestir.TabIndex = 2;
            this.btnVestir.Text = "Vestir";
            this.btnVestir.UseVisualStyleBackColor = true;
            this.btnVestir.Click += new System.EventHandler(this.btnVestir_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Location = new System.Drawing.Point(450, 220);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(75, 23);
            this.btnDeshacer.TabIndex = 3;
            this.btnDeshacer.Text = "Deshacer Cambios";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.btnVestir);
            this.Controls.Add(this.lbManiqui);
            this.Controls.Add(this.lbRopero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRopero;
        private System.Windows.Forms.ListBox lbManiqui;
        private System.Windows.Forms.Button btnVestir;
        private System.Windows.Forms.Button btnDeshacer;
    }
}

