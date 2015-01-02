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
    public partial class frmConsultaCamiones : Form
    {
        public frmConsultaCamiones()
        {
            InitializeComponent();
        }
        DataTable Table;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbconsultaCamiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            OleDbConnection Conecxion = new OleDbConnection(constring);
            OleDbCommand Instruccion = new OleDbCommand("Select *From Camiones WHERE NumerodeRuta = '" + cmbconsultaCamiones.Text + "'", Conecxion);

            try
            {
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();
                Adaptador.SelectCommand = Instruccion;
                Table = new DataTable();
                Adaptador.Fill(Table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Table;
                dataGridConsultaCamiones.DataSource = bSource;
                Adaptador.Update(Table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
