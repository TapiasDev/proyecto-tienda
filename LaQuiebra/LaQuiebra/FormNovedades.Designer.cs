namespace LaQuiebra
{
    partial class FormNovedades
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.txIDConsultar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btConsulta = new System.Windows.Forms.Button();
            this.dgvCreditos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btPagar = new System.Windows.Forms.Button();
            this.txObsPago = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txValorPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txIDCredito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Novedades";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.txIDConsultar);
            this.gbConsulta.Controls.Add(this.label2);
            this.gbConsulta.Controls.Add(this.btConsulta);
            this.gbConsulta.Location = new System.Drawing.Point(12, 45);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(262, 122);
            this.gbConsulta.TabIndex = 3;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consultar Creditos";
            // 
            // txIDConsultar
            // 
            this.txIDConsultar.Location = new System.Drawing.Point(60, 43);
            this.txIDConsultar.Name = "txIDConsultar";
            this.txIDConsultar.Size = new System.Drawing.Size(138, 20);
            this.txIDConsultar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(60, 89);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(138, 27);
            this.btConsulta.TabIndex = 0;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // dgvCreditos
            // 
            this.dgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditos.Location = new System.Drawing.Point(12, 207);
            this.dgvCreditos.Name = "dgvCreditos";
            this.dgvCreditos.Size = new System.Drawing.Size(776, 157);
            this.dgvCreditos.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btPagar);
            this.groupBox3.Controls.Add(this.txObsPago);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txValorPago);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txIDCredito);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(490, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 156);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registrar Pagos";
            // 
            // btPagar
            // 
            this.btPagar.Location = new System.Drawing.Point(82, 123);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(138, 27);
            this.btPagar.TabIndex = 9;
            this.btPagar.Text = "Pagar";
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // txObsPago
            // 
            this.txObsPago.Location = new System.Drawing.Point(106, 71);
            this.txObsPago.Multiline = true;
            this.txObsPago.Name = "txObsPago";
            this.txObsPago.Size = new System.Drawing.Size(186, 45);
            this.txObsPago.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Observaciones:";
            // 
            // txValorPago
            // 
            this.txValorPago.Location = new System.Drawing.Point(87, 45);
            this.txValorPago.Name = "txValorPago";
            this.txValorPago.Size = new System.Drawing.Size(138, 20);
            this.txValorPago.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valor Pago:";
            // 
            // txIDCredito
            // 
            this.txIDCredito.Location = new System.Drawing.Point(82, 19);
            this.txIDCredito.Name = "txIDCredito";
            this.txIDCredito.Size = new System.Drawing.Size(138, 20);
            this.txIDCredito.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID Credito:";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(312, 119);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(165, 48);
            this.btLimpiar.TabIndex = 6;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // FormNovedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvCreditos);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.label1);
            this.Name = "FormNovedades";
            this.Text = "FormNovedades";
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.TextBox txIDConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.DataGridView dgvCreditos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.TextBox txObsPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txValorPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txIDCredito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLimpiar;
    }
}