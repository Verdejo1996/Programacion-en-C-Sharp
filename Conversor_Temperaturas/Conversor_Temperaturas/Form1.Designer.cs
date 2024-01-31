namespace Conversor_Temperaturas
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
            this.txtEscalaIn = new System.Windows.Forms.TextBox();
            this.cmbTemperatura = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.dtgTemperaturas = new System.Windows.Forms.DataGridView();
            this.Ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsIf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEF = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTemperaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEscalaIn
            // 
            this.txtEscalaIn.Location = new System.Drawing.Point(263, 95);
            this.txtEscalaIn.Name = "txtEscalaIn";
            this.txtEscalaIn.Size = new System.Drawing.Size(121, 20);
            this.txtEscalaIn.TabIndex = 0;
            // 
            // cmbTemperatura
            // 
            this.cmbTemperatura.FormattingEnabled = true;
            this.cmbTemperatura.Location = new System.Drawing.Point(35, 95);
            this.cmbTemperatura.Name = "cmbTemperatura";
            this.cmbTemperatura.Size = new System.Drawing.Size(121, 21);
            this.cmbTemperatura.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(420, 95);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(263, 157);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(121, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // dtgTemperaturas
            // 
            this.dtgTemperaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTemperaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingresos,
            this.EsIn,
            this.EsIf,
            this.Conv});
            this.dtgTemperaturas.Location = new System.Drawing.Point(35, 274);
            this.dtgTemperaturas.Name = "dtgTemperaturas";
            this.dtgTemperaturas.Size = new System.Drawing.Size(444, 150);
            this.dtgTemperaturas.TabIndex = 7;
            // 
            // Ingresos
            // 
            this.Ingresos.HeaderText = "Ingresos";
            this.Ingresos.Name = "Ingresos";
            // 
            // EsIn
            // 
            this.EsIn.HeaderText = "Escala Inicial";
            this.EsIn.Name = "EsIn";
            // 
            // EsIf
            // 
            this.EsIf.HeaderText = "Escala Final";
            this.EsIf.Name = "EsIf";
            // 
            // Conv
            // 
            this.Conv.HeaderText = "Conversion";
            this.Conv.Name = "Conv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Temperatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Escala Inicial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Escala Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Resultado:";
            // 
            // cmbEF
            // 
            this.cmbEF.FormattingEnabled = true;
            this.cmbEF.Location = new System.Drawing.Point(35, 155);
            this.cmbEF.Name = "cmbEF";
            this.cmbEF.Size = new System.Drawing.Size(121, 21);
            this.cmbEF.TabIndex = 17;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(420, 157);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbEF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgTemperaturas);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbTemperatura);
            this.Controls.Add(this.txtEscalaIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTemperaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEscalaIn;
        private System.Windows.Forms.ComboBox cmbTemperatura;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.DataGridView dtgTemperaturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsIf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEF;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

