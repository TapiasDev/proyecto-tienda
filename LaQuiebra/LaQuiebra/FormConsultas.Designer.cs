namespace LaQuiebra
{
    partial class FormConsultas
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
            this.txInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbNom = new System.Windows.Forms.RadioButton();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Por ID y Nombre";
            // 
            // txInfo
            // 
            this.txInfo.Location = new System.Drawing.Point(281, 140);
            this.txInfo.Name = "txInfo";
            this.txInfo.Size = new System.Drawing.Size(203, 20);
            this.txInfo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese el ID o el Nombre";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 174);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(776, 234);
            this.dgvClientes.TabIndex = 5;
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Checked = true;
            this.rbID.Location = new System.Drawing.Point(232, 82);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(36, 17);
            this.rbID.TabIndex = 6;
            this.rbID.TabStop = true;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            // 
            // rbNom
            // 
            this.rbNom.AutoSize = true;
            this.rbNom.Location = new System.Drawing.Point(483, 82);
            this.rbNom.Name = "rbNom";
            this.rbNom.Size = new System.Drawing.Size(62, 17);
            this.rbNom.TabIndex = 7;
            this.rbNom.TabStop = true;
            this.rbNom.Text = "Nombre";
            this.rbNom.UseVisualStyleBackColor = true;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(624, 116);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(164, 44);
            this.btLimpiar.TabIndex = 8;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(12, 117);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(164, 44);
            this.btBuscar.TabIndex = 9;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.rbNom);
            this.Controls.Add(this.rbID);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txInfo);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbNom;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btBuscar;
    }
}