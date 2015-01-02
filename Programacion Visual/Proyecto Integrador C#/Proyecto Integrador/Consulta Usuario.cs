using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto_Integrador
{
    public partial class frmConsultaUsuario : Form
    {
        public frmConsultaUsuario()
        {
            InitializeComponent();
        }
        DataTable Table;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            txtBuscar.Select();
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            OleDbConnection Conecxion = new OleDbConnection(constring);
            OleDbCommand Instruccion = new OleDbCommand("Select *From Usuarios", Conecxion);
            try
            {
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();
                Adaptador.SelectCommand = Instruccion;
                Table = new DataTable();
                Adaptador.Fill(Table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Table;
                dgvMostrar.DataSource = bSource;
                Adaptador.Update(Table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(Table);
            DV.RowFilter = string.Format("CURP LIKE '%{0}%'", txtBuscar.Text);
            dgvMostrar.DataSource = DV;
        }
    }
}
