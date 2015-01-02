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
    public partial class frmRecarga : Form
    {
        public frmRecarga()
        {
            InitializeComponent();
            AutocompleteText();
        }

        void AutocompleteText()
        {
            txtCurpRecargar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCurpRecargar.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            txtCurpRecargar.AutoCompleteCustomSource = coll;
        }

        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;
        string q;
        bool Existe = false;
        int Total, Saldo, Recarga;

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Recarga = Convert.ToInt32(cbxRecarga.Text);
            try
            {
                q = "select * from Usuarios";
                cmd.CommandText = q;
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["CURP"].ToString() == txtCurpRecargar.Text)
                    {
                        Existe = true;
                        Saldo = Convert.ToInt32(dr[21].ToString());
                        Total = Convert.ToInt32(Recarga + Saldo);
                        break;
                    }
                    else
                    {
                        Existe = false;
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message.ToString());
            }

            if (Existe == true)
            {
                q = "UPDATE Usuarios SET Saldo='" + Total.ToString() + "' WHERE CURP ='" + txtCurpRecargar.Text + "'";
                dosomething(q);
                MessageBox.Show("Hecho");
                txtCurpRecargar.Clear();
                txtCurpRecargar.Select();
                cbxRecarga.Text = "";
            }
        }

        private void dosomething(string q)
        {
            try
            {
                cn.Open();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception e)
            {
                cn.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            txtCurpRecargar.Select();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            cmd.Connection = cn;
            txtCurpRecargar.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCurpRecargar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbxRecarga.Select();
            }
        }
    }
}
