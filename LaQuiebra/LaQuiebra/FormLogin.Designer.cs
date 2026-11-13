namespace LaQuiebra
{
    partial class FormLogin
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContrasena = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txContrasena = new System.Windows.Forms.TextBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lbTitulo
            //
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(62, 20);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(205, 24);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "La Quiebra LTDA";
            //
            // lbUsuario
            //
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(40, 72);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuario:";
            //
            // lbContrasena
            //
            this.lbContrasena.AutoSize = true;
            this.lbContrasena.Location = new System.Drawing.Point(40, 108);
            this.lbContrasena.Name = "lbContrasena";
            this.lbContrasena.Size = new System.Drawing.Size(64, 13);
            this.lbContrasena.TabIndex = 3;
            this.lbContrasena.Text = "Contraseña:";
            //
            // txUsuario
            //
            this.txUsuario.Location = new System.Drawing.Point(120, 69);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(160, 20);
            this.txUsuario.TabIndex = 2;
            //
            // txContrasena
            //
            this.txContrasena.Location = new System.Drawing.Point(120, 105);
            this.txContrasena.Name = "txContrasena";
            this.txContrasena.Size = new System.Drawing.Size(160, 20);
            this.txContrasena.TabIndex = 4;
            this.txContrasena.UseSystemPasswordChar = true;
            //
            // btIngresar
            //
            this.btIngresar.Location = new System.Drawing.Point(64, 150);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(90, 28);
            this.btIngresar.TabIndex = 5;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            //
            // btSalir
            //
            this.btSalir.Location = new System.Drawing.Point(176, 150);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(90, 28);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            //
            // FormLogin
            //
            this.AcceptButton = this.btIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 205);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.txContrasena);
            this.Controls.Add(this.lbContrasena);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContrasena;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txContrasena;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Button btSalir;
    }
}
