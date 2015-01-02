namespace Proyecto_Integrador
{
    partial class TipodeUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.rdbEstudiante = new System.Windows.Forms.RadioButton();
            this.rdbDiscapacitados = new System.Windows.Forms.RadioButton();
            this.rdbTercera = new System.Windows.Forms.RadioButton();
            this.rdbGeneral = new System.Windows.Forms.RadioButton();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodeUsuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe la fecha (DD/MM/AAAA)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecciona el tipo de usuario";
            // 
            // rdbEstudiante
            // 
            this.rdbEstudiante.AutoSize = true;
            this.rdbEstudiante.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEstudiante.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rdbEstudiante.Location = new System.Drawing.Point(226, 35);
            this.rdbEstudiante.Name = "rdbEstudiante";
            this.rdbEstudiante.Size = new System.Drawing.Size(93, 24);
            this.rdbEstudiante.TabIndex = 2;
            this.rdbEstudiante.TabStop = true;
            this.rdbEstudiante.Text = "Estudiante";
            this.rdbEstudiante.UseVisualStyleBackColor = true;
            // 
            // rdbDiscapacitados
            // 
            this.rdbDiscapacitados.AutoSize = true;
            this.rdbDiscapacitados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDiscapacitados.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rdbDiscapacitados.Location = new System.Drawing.Point(340, 35);
            this.rdbDiscapacitados.Name = "rdbDiscapacitados";
            this.rdbDiscapacitados.Size = new System.Drawing.Size(121, 24);
            this.rdbDiscapacitados.TabIndex = 3;
            this.rdbDiscapacitados.TabStop = true;
            this.rdbDiscapacitados.Text = "Discapacitados";
            this.rdbDiscapacitados.UseVisualStyleBackColor = true;
            // 
            // rdbTercera
            // 
            this.rdbTercera.AutoSize = true;
            this.rdbTercera.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTercera.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rdbTercera.Location = new System.Drawing.Point(470, 37);
            this.rdbTercera.Name = "rdbTercera";
            this.rdbTercera.Size = new System.Drawing.Size(109, 24);
            this.rdbTercera.TabIndex = 4;
            this.rdbTercera.TabStop = true;
            this.rdbTercera.Text = "Tercera Edad";
            this.rdbTercera.UseVisualStyleBackColor = true;
            // 
            // rdbGeneral
            // 
            this.rdbGeneral.AutoSize = true;
            this.rdbGeneral.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGeneral.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rdbGeneral.Location = new System.Drawing.Point(598, 37);
            this.rdbGeneral.Name = "rdbGeneral";
            this.rdbGeneral.Size = new System.Drawing.Size(146, 24);
            this.rdbGeneral.TabIndex = 5;
            this.rdbGeneral.TabStop = true;
            this.rdbGeneral.Text = "Publico en General";
            this.rdbGeneral.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(228, 3);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(127, 26);
            this.txtFecha.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Location = new System.Drawing.Point(48, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.Location = new System.Drawing.Point(186, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMostrar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CURP,
            this.Fecha,
            this.TipodeUsuarios,
            this.Ruta});
            this.dgvMostrar.Location = new System.Drawing.Point(48, 122);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(514, 164);
            this.dgvMostrar.TabIndex = 9;
            // 
            // CURP
            // 
            this.CURP.HeaderText = "CURP";
            this.CURP.Name = "CURP";
            this.CURP.Width = 62;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 62;
            // 
            // TipodeUsuarios
            // 
            this.TipodeUsuarios.HeaderText = "TipodeUsuario";
            this.TipodeUsuarios.Name = "TipodeUsuarios";
            this.TipodeUsuarios.Width = 101;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.Width = 55;
            // 
            // TipodeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(797, 318);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.rdbGeneral);
            this.Controls.Add(this.rdbTercera);
            this.Controls.Add(this.rdbDiscapacitados);
            this.Controls.Add(this.rdbEstudiante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TipodeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipodeUsuario";
            this.Load += new System.EventHandler(this.TipodeUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbEstudiante;
        private System.Windows.Forms.RadioButton rdbDiscapacitados;
        private System.Windows.Forms.RadioButton rdbTercera;
        private System.Windows.Forms.RadioButton rdbGeneral;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodeUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
    }
}