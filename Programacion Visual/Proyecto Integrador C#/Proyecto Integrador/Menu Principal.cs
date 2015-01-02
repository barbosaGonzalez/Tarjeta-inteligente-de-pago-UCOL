using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Programa Funcionando ::..";
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Registrar Nuevo Usuario ::..";
            frmNuevo frm = new frmNuevo();   //Llama al segundo formulario
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Dar de baja a usuario ::..";
            frmBaja frm = new frmBaja();   //Llama al segundo formulario
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }

        private void renovarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Renovar Usuario ::..";
            frmRenovar frm = new frmRenovar();   //Llama al segundo formulario
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Saliendo ::..";
            DialogResult dialogResult = MessageBox.Show("¿Deseas salir?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                tssEstatus.Text = "..:: Menu Principal ::..";
            }
        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Consulta por camiones ::..";
            frmConsultaCamiones frm = new frmConsultaCamiones();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Consulta por usuarios ::..";
            frmConsultaUsuario frm = new frmConsultaUsuario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Cobrar a usuarios ::..";
            frmCobrar frm = new frmCobrar();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }

        private void recargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Recargar a usuarios ::..";
            frmRecarga frm = new frmRecarga();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }

        private void estadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Estadisticas de usuarios ::..";
            Estadisticas frm = new Estadisticas();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }

        private void camionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informacion2 frm = new Informacion2();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Estadisticas de camiones ::..";
            frmInforme frm = new frmInforme();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = Convert.ToString(DateTime.Now);
        }

        private void tipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssEstatus.Text = "..:: Estadisticas Por Tipo de Usuario ::..";
            TipodeUsuario frm = new TipodeUsuario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tssEstatus.Text = "..:: Menu Principal ::..";
        }
    }
}
