namespace Practica_Pilas
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
            this.lbAlquilados = new System.Windows.Forms.ListBox();
            this.lbPedidos = new System.Windows.Forms.ListBox();
            this.lbEnEspera = new System.Windows.Forms.ListBox();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLibros
            // 
            this.lbLibros.FormattingEnabled = true;
            this.lbLibros.Location = new System.Drawing.Point(57, 29);
            this.lbLibros.Name = "lbLibros";
            this.lbLibros.Size = new System.Drawing.Size(602, 95);
            this.lbLibros.TabIndex = 0;
            // 
            // lbAlquilados
            // 
            this.lbAlquilados.FormattingEnabled = true;
            this.lbAlquilados.Location = new System.Drawing.Point(57, 171);
            this.lbAlquilados.Name = "lbAlquilados";
            this.lbAlquilados.Size = new System.Drawing.Size(602, 95);
            this.lbAlquilados.TabIndex = 1;
            // 
            // lbPedidos
            // 
            this.lbPedidos.FormattingEnabled = true;
            this.lbPedidos.Location = new System.Drawing.Point(57, 329);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(602, 95);
            this.lbPedidos.TabIndex = 2;
            // 
            // lbEnEspera
            // 
            this.lbEnEspera.FormattingEnabled = true;
            this.lbEnEspera.Location = new System.Drawing.Point(57, 498);
            this.lbEnEspera.Name = "lbEnEspera";
            this.lbEnEspera.Size = new System.Drawing.Size(602, 95);
            this.lbEnEspera.TabIndex = 3;
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(57, 130);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(75, 23);
            this.btnAlquilar.TabIndex = 4;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(57, 272);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 5;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(57, 430);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(75, 23);
            this.btnPedidos.TabIndex = 6;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(57, 599);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(116, 23);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Agregar a espera";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Quitar espera";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Quitar pedidos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 684);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.lbEnEspera);
            this.Controls.Add(this.lbPedidos);
            this.Controls.Add(this.lbAlquilados);
            this.Controls.Add(this.lbLibros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLibros;
        private System.Windows.Forms.ListBox lbAlquilados;
        private System.Windows.Forms.ListBox lbPedidos;
        private System.Windows.Forms.ListBox lbEnEspera;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

