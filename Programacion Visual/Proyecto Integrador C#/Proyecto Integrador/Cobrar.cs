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
    public partial class frmCobrar : Form
    {
        public frmCobrar()
        {
            InitializeComponent();
            AutocompleteText();
        }

        void AutocompleteText()
        {
            txtCurpCobrar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCurpCobrar.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            txtCurpCobrar.AutoCompleteCustomSource = coll;
        }

        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;
        string q, Tipo;
        bool Existe = false;
        int Total, Saldo, Cobro;
        DateTime thisDay = DateTime.Today;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCurpCobrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar_Cobro();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Cobro();
        }

        private void Buscar_Cobro()
        {
            try
            {
                q = "select * from Usuarios";
                cmd.CommandText = q;
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["CURP"].ToString() == txtCurpCobrar.Text)
                    {
                        Existe = true;
                        Saldo = Convert.ToInt32(dr[21].ToString());
                        Tipo = Convert.ToString(dr[20]);
                        if (Tipo == "Tercera Edad" || Tipo == "Estudiante" || Tipo == "Discapacitado")
                        {
                            Cobro = 3;
                        }
                        else if (Tipo == "Publico en General")
                        {
                            Cobro = 6;
                        }
                        Total = Convert.ToInt32(Saldo - Cobro);
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

            if (Saldo <= 3)
            {
                MessageBox.Show("No cuentas con suficiente saldo");
                Close();
            }
            else if (Existe == true)
            {
                q = "UPDATE Usuarios SET Saldo='" + Total.ToString() + "' WHERE CURP ='" + txtCurpCobrar.Text + "'";
                dosomething(q);
                //q = "UPDATE Camiones SET CantidaddeUsuarios='" + Total.ToString() + "','"++"' WHERE CURP ='" + txtCurpCobrar.Text + "'";
                q = "INSERT INTO Cobro(CURP, Fecha, TipodeUsuario, Ruta) VALUES('" + txtCurpCobrar.Text.ToString() + "','"+thisDay.ToString("d")+"','" + Tipo.ToString() + "','" + cmbRutaCobrar.Text.ToString() + "')";
                dosomething(q);
                MessageBox.Show("Hecho");
                txtCurpCobrar.Clear();
                txtCurpCobrar.Select();
                cmbRutaCobrar.Text = "";
            }
        }

        private void Camiones_Cobro()
        { 
            
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

        private void frmCobrar_Load(object sender, EventArgs e)
        {
            txtCurpCobrar.Select();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            cmd.Connection = cn;
            txtCurpCobrar.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
