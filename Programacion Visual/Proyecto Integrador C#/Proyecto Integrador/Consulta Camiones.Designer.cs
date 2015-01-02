namespace Proyecto_Integrador
{
    partial class frmConsultaCamiones
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridConsultaCamiones = new System.Windows.Forms.DataGridView();
            this.cmbconsultaCamiones = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaCamiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(635, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridConsultaCamiones
            // 
            this.dataGridConsultaCamiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridConsultaCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaCamiones.Location = new System.Drawing.Point(12, 74);
            this.dataGridConsultaCamiones.Name = "dataGridConsultaCamiones";
            this.dataGridConsultaCamiones.Size = new System.Drawing.Size(720, 294);
            this.dataGridConsultaCamiones.TabIndex = 4;
            // 
            // cmbconsultaCamiones
            // 
            this.cmbconsultaCamiones.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbconsultaCamiones.ForeColor = System.Drawing.Color.Black;
            this.cmbconsultaCamiones.FormattingEnabled = true;
            this.cmbconsultaCamiones.Items.AddRange(new object[] {
            "1",
            "10",
            "11",
            "13",
            "13A",
            "14",
            "17",
            "19",
            "20",
            "21",
            "22",
            "24",
            "24A",
            "27",
            "27A",
            "28",
            "29",
            "03",
            "30",
            "31",
            "04",
            "05",
            "08",
            "06",
            "06A",
            "07",
            "09",
            "09A",
            "Incluyente A",
            "Incluyente B"});
            this.cmbconsultaCamiones.Location = new System.Drawing.Point(506, 37);
            this.cmbconsultaCamiones.Name = "cmbconsultaCamiones";
            this.cmbconsultaCamiones.Size = new System.Drawing.Size(121, 28);
            this.cmbconsultaCamiones.TabIndex = 5;
            this.cmbconsultaCamiones.SelectedIndexChanged += new System.EventHandler(this.cmbconsultaCamiones_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Integrador.Properties.Resources.Logo_200x200_negativo_lila;
            this.pictureBox2.Location = new System.Drawing.Point(665, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Integrador.Properties.Resources.parachoques;
            this.pictureBox1.Location = new System.Drawing.Point(12, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 87);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label20.Location = new System.Drawing.Point(8, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(198, 20);
            this.label20.TabIndex = 90;
            this.label20.Text = "Consultas de Camiones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(376, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Selecciona la Ruta";
            // 
            // frmConsultaCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbconsultaCamiones);
            this.Controls.Add(this.dataGridConsultaCamiones);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmConsultaCamiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Di-Bus 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaCamiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridConsultaCamiones;
        private System.Windows.Forms.ComboBox cmbconsultaCamiones;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
    }
}