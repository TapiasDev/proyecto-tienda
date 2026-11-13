namespace LaQuiebra
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olNingunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.actualizacionToolStripMenuItem,
            this.novedadesToolStripMenuItem,
            this.cerrarSesiToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.olNingunoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // actualizacionToolStripMenuItem
            // 
            this.actualizacionToolStripMenuItem.Name = "actualizacionToolStripMenuItem";
            this.actualizacionToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.actualizacionToolStripMenuItem.Text = "Actualización";
            this.actualizacionToolStripMenuItem.Click += new System.EventHandler(this.actualizacionToolStripMenuItem_Click);
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.novedadesToolStripMenuItem.Text = "Novedades";
            this.novedadesToolStripMenuItem.Click += new System.EventHandler(this.novedadesToolStripMenuItem_Click);
            // 
            // cerrarSesiToolStripMenuItem
            // 
            this.cerrarSesiToolStripMenuItem.Name = "cerrarSesiToolStripMenuItem";
            this.cerrarSesiToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiToolStripMenuItem_Click);
            // 
            // olNingunoToolStripMenuItem
            // 
            this.olNingunoToolStripMenuItem.Enabled = false;
            this.olNingunoToolStripMenuItem.Name = "olNingunoToolStripMenuItem";
            this.olNingunoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.olNingunoToolStripMenuItem.Text = "Rol: Ninguno";
            //
            // salirToolStripMenuItem
            //
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            //
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem olNingunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

