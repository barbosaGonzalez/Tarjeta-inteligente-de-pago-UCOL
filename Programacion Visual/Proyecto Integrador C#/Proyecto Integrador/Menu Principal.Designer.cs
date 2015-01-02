namespace Proyecto_Integrador
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.stsEstatus = new System.Windows.Forms.StatusStrip();
            this.tssEstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dITecnologiesSolutionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renovarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stsEstatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblHora.Location = new System.Drawing.Point(369, 36);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(90, 20);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora y Fecha";
            // 
            // stsEstatus
            // 
            this.stsEstatus.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.stsEstatus.BackColor = System.Drawing.Color.Indigo;
            this.stsEstatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsEstatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssEstatus});
            this.stsEstatus.Location = new System.Drawing.Point(0, 379);
            this.stsEstatus.Name = "stsEstatus";
            this.stsEstatus.Size = new System.Drawing.Size(548, 22);
            this.stsEstatus.TabIndex = 12;
            this.stsEstatus.Text = "statusStrip1";
            // 
            // tssEstatus
            // 
            this.tssEstatus.ForeColor = System.Drawing.Color.White;
            this.tssEstatus.Name = "tssEstatus";
            this.tssEstatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dITecnologiesSolutionsToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.cobroToolStripMenuItem,
            this.informeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dITecnologiesSolutionsToolStripMenuItem
            // 
            this.dITecnologiesSolutionsToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dITecnologiesSolutionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.dITecnologiesSolutionsToolStripMenuItem.Name = "dITecnologiesSolutionsToolStripMenuItem";
            this.dITecnologiesSolutionsToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.dITecnologiesSolutionsToolStripMenuItem.Text = "DI-Tecnologies & Solutions";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.renovarToolStripMenuItem});
            this.registroToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.nuevoToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.bajaToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // renovarToolStripMenuItem
            // 
            this.renovarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.renovarToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.renovarToolStripMenuItem.Name = "renovarToolStripMenuItem";
            this.renovarToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.renovarToolStripMenuItem.Text = "Renovar";
            this.renovarToolStripMenuItem.Click += new System.EventHandler(this.renovarToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camionToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // camionToolStripMenuItem
            // 
            this.camionToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.camionToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.camionToolStripMenuItem.Name = "camionToolStripMenuItem";
            this.camionToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.camionToolStripMenuItem.Text = "Camion";
            this.camionToolStripMenuItem.Click += new System.EventHandler(this.camionToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // cobroToolStripMenuItem
            // 
            this.cobroToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cobroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobrarToolStripMenuItem,
            this.recargarToolStripMenuItem});
            this.cobroToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.cobroToolStripMenuItem.Name = "cobroToolStripMenuItem";
            this.cobroToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.cobroToolStripMenuItem.Text = "Cobro";
            // 
            // cobrarToolStripMenuItem
            // 
            this.cobrarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cobrarToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.cobrarToolStripMenuItem.Name = "cobrarToolStripMenuItem";
            this.cobrarToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.cobrarToolStripMenuItem.Text = "Cobrar";
            this.cobrarToolStripMenuItem.Click += new System.EventHandler(this.cobrarToolStripMenuItem_Click);
            // 
            // recargarToolStripMenuItem
            // 
            this.recargarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.recargarToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.recargarToolStripMenuItem.Name = "recargarToolStripMenuItem";
            this.recargarToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.recargarToolStripMenuItem.Text = "Recargar";
            this.recargarToolStripMenuItem.Click += new System.EventHandler(this.recargarToolStripMenuItem_Click);
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.informeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadToolStripMenuItem,
            this.camionesToolStripMenuItem,
            this.usuarioToolStripMenuItem1,
            this.tipoDeUsuarioToolStripMenuItem});
            this.informeToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.informeToolStripMenuItem.Text = "Reportes";
            // 
            // estadToolStripMenuItem
            // 
            this.estadToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.estadToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.estadToolStripMenuItem.Name = "estadToolStripMenuItem";
            this.estadToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.estadToolStripMenuItem.Text = "Estadísticas";
            this.estadToolStripMenuItem.Click += new System.EventHandler(this.estadToolStripMenuItem_Click);
            // 
            // camionesToolStripMenuItem
            // 
            this.camionesToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.camionesToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.camionesToolStripMenuItem.Name = "camionesToolStripMenuItem";
            this.camionesToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.camionesToolStripMenuItem.Text = "Camiones";
            this.camionesToolStripMenuItem.Click += new System.EventHandler(this.camionesToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.usuarioToolStripMenuItem1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(177, 24);
            this.usuarioToolStripMenuItem1.Text = "Usuario";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // tipoDeUsuarioToolStripMenuItem
            // 
            this.tipoDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tipoDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tipoDeUsuarioToolStripMenuItem.Name = "tipoDeUsuarioToolStripMenuItem";
            this.tipoDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.tipoDeUsuarioToolStripMenuItem.Text = "Tipo de Usuario";
            this.tipoDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUsuarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Integrador.Properties.Resources.Logo_200x200_negativo;
            this.pictureBox2.Location = new System.Drawing.Point(21, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proyecto_Integrador.Properties.Resources.camión_morado_frente1;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proyecto_Integrador.Properties.Resources.camión_morado_frente;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 401);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.stsEstatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal  Di-Bus 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.stsEstatus.ResumeLayout(false);
            this.stsEstatus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.StatusStrip stsEstatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renovarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dITecnologiesSolutionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem estadToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssEstatus;
        private System.Windows.Forms.ToolStripMenuItem camionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

