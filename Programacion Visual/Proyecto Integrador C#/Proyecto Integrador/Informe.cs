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
    public partial class frmInforme : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;
        string q;

        public frmInforme()
        {
            InitializeComponent();
            AutocompleteText();
        }

        public void AutocompleteText()
        {
            txtUsuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            txtUsuario.AutoCompleteCustomSource = coll;
        }

        private void frmInforme_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            cmd.Connection = cn;
            txtUsuario.Select();
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cobro()
        {
            q = "Select * from Cobro WHERE CURP='" + txtUsuario.Text.ToString() + "' and Fecha='" + txtFecha.Text.ToString() + "'";
            cmd.CommandText = q;
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string[] Datos = new string[] { dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString() };
                    dgvMostrar.Rows.Add(Datos);
                }
            }
            dr.Close();
            cn.Close();
        }

        private void Saldo()
        {
            q = "Select * from Usuarios WHERE CURP='" + txtUsuario.Text.ToString() + "'";
            cmd.CommandText = q;
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtSaldo.Text = dr[21].ToString();
                }
            }
            dr.Close();
            cn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cobro();
            Saldo();
        }
    }
}
