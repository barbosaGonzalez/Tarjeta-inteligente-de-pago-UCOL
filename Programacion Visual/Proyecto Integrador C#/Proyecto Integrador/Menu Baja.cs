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
    public partial class frmBaja : Form
    {
        public frmBaja()
        {
            InitializeComponent(); 
            AutocompleteText();
        }

        void AutocompleteText()
        {
            txtCurpBaja.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCurpBaja.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            OleDbConnection Conecxion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'");
            OleDbCommand Instruccion = new OleDbCommand("Select * From Usuarios", Conecxion);
            OleDbDataReader Lector;
            Conecxion.Open();
            Lector = Instruccion.ExecuteReader();
            while (Lector.Read())
            {
                coll.Add(Lector["CURP"].ToString());
            }
            Lector.Close();
            Conecxion.Close();
            txtCurpBaja.AutoCompleteCustomSource = coll;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtCurpBaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar(); 
            }
        }

        private void Buscar()
        {
            frmBajaDatos frm = new frmBajaDatos();
            frm.OldCurp = txtCurpBaja.Text;
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmBaja_Load(object sender, EventArgs e)
        {
            txtCurpBaja.Select();
            txtCurpBaja.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
