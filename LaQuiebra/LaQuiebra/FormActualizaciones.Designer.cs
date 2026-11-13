namespace LaQuiebra
{
    partial class FormActualizaciones
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txIDConsultar = new System.Windows.Forms.TextBox();
            this.txCodigoIngresar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txMontoIngresar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btIngresar = new System.Windows.Forms.Button();
            this.txIDModificar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txMontoModificar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txSaldoModificar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txEstadoModificar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.txIDRetirar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btRetirar = new System.Windows.Forms.Button();
            this.dgvCreditos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.gbConsulta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actualizaciones";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.txIDConsultar);
            this.gbConsulta.Controls.Add(this.label2);
            this.gbConsulta.Controls.Add(this.btConsulta);
            this.gbConsulta.Location = new System.Drawing.Point(12, 57);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(262, 122);
            this.gbConsulta.TabIndex = 2;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consultar Creditos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btIngresar);
            this.groupBox2.Controls.Add(this.txMontoIngresar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txCodigoIngresar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(320, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresar Creditos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btModificar);
            this.groupBox3.Controls.Add(this.txEstadoModificar);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txSaldoModificar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txMontoModificar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txIDModificar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(623, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 156);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificar Creditos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btRetirar);
            this.groupBox4.Controls.Add(this.txIDRetirar);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(927, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 122);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RetirarCreditos";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(1207, 57);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(61, 121);
            this.btLimpiar.TabIndex = 4;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // txIDConsultar
            // 
            this.txIDConsultar.Location = new System.Drawing.Point(60, 43);
            this.txIDConsultar.Name = "txIDConsultar";
            this.txIDConsultar.Size = new System.Drawing.Size(138, 20);
            this.txIDConsultar.TabIndex = 2;
            // 
            // txCodigoIngresar
            // 
            this.txCodigoIngresar.Location = new System.Drawing.Point(103, 19);
            this.txCodigoIngresar.Name = "txCodigoIngresar";
            this.txCodigoIngresar.Size = new System.Drawing.Size(138, 20);
            this.txCodigoIngresar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo Cliente:";
            // 
            // txMontoIngresar
            // 
            this.txMontoIngresar.Location = new System.Drawing.Point(95, 46);
            this.txMontoIngresar.Name = "txMontoIngresar";
            this.txMontoIngresar.Size = new System.Drawing.Size(138, 20);
            this.txMontoIngresar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto Inicial:";
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(63, 89);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(138, 27);
            this.btIngresar.TabIndex = 3;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // txIDModificar
            // 
            this.txIDModificar.Location = new System.Drawing.Point(82, 19);
            this.txIDModificar.Name = "txIDModificar";
            this.txIDModificar.Size = new System.Drawing.Size(138, 20);
            this.txIDModificar.TabIndex = 10;
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
            // txMontoModificar
            // 
            this.txMontoModificar.Location = new System.Drawing.Point(95, 45);
            this.txMontoModificar.Name = "txMontoModificar";
            this.txMontoModificar.Size = new System.Drawing.Size(138, 20);
            this.txMontoModificar.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Monto Inicial:";
            // 
            // txSaldoModificar
            // 
            this.txSaldoModificar.Location = new System.Drawing.Point(95, 71);
            this.txSaldoModificar.Name = "txSaldoModificar";
            this.txSaldoModificar.Size = new System.Drawing.Size(138, 20);
            this.txSaldoModificar.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Saldo Actual:";
            // 
            // txEstadoModificar
            // 
            this.txEstadoModificar.Location = new System.Drawing.Point(68, 96);
            this.txEstadoModificar.Name = "txEstadoModificar";
            this.txEstadoModificar.Size = new System.Drawing.Size(86, 20);
            this.txEstadoModificar.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Estado:";
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(82, 123);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(138, 27);
            this.btModificar.TabIndex = 9;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // txIDRetirar
            // 
            this.txIDRetirar.Location = new System.Drawing.Point(74, 43);
            this.txIDRetirar.Name = "txIDRetirar";
            this.txIDRetirar.Size = new System.Drawing.Size(138, 20);
            this.txIDRetirar.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "ID Credito:";
            // 
            // btRetirar
            // 
            this.btRetirar.Location = new System.Drawing.Point(74, 89);
            this.btRetirar.Name = "btRetirar";
            this.btRetirar.Size = new System.Drawing.Size(138, 27);
            this.btRetirar.TabIndex = 3;
            this.btRetirar.Text = "Retirar";
            this.btRetirar.UseVisualStyleBackColor = true;
            this.btRetirar.Click += new System.EventHandler(this.btRetirar_Click);
            // 
            // dgvCreditos
            // 
            this.dgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditos.Location = new System.Drawing.Point(12, 245);
            this.dgvCreditos.Name = "dgvCreditos";
            this.dgvCreditos.Size = new System.Drawing.Size(1256, 227);
            this.dgvCreditos.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Activo, Cumplido o Anulado";
            // 
            // FormActualizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 480);
            this.Controls.Add(this.dgvCreditos);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.label1);
            this.Name = "FormActualizaciones";
            this.Text = "FormActualizaciones";
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.TextBox txIDConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.TextBox txCodigoIngresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.TextBox txMontoIngresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.TextBox txEstadoModificar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txSaldoModificar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txMontoModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txIDModificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRetirar;
        private System.Windows.Forms.TextBox txIDRetirar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCreditos;
        private System.Windows.Forms.Label label5;
    }
}