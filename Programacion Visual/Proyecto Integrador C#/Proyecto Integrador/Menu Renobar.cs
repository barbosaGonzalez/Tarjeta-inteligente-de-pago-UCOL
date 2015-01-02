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
    public partial class frmRenovar : Form
    {
        public frmRenovar()
        {
            InitializeComponent();
            AutocompleteText();
        }

        void AutocompleteText()
        {
            txtCurpRenovar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCurpRenovar.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            txtCurpRenovar.AutoCompleteCustomSource = coll;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtCurpRenovar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }
        }

        private void Buscar()
        {
            frmRenovarDatos frm = new frmRenovarDatos();
            frm.OldCurp = txtCurpRenovar.Text;
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
        private void frmRenovar_Load(object sender, EventArgs e)
        {
            txtCurpRenovar.Select();
            txtCurpRenovar.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
