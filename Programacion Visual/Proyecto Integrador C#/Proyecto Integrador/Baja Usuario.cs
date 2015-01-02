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
    public partial class frmBajaDatos : Form
    {
        public string OldCurp;
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;

        public frmBajaDatos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string q;
            q = "DELETE FROM Usuarios WHERE CURP ='" + OldCurp + "'";
            dosomething(q);
            MessageBox.Show("Hecho");
            Close();
        }

        private void frmBajaDatos_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            cmd.Connection = cn;
            loaddata();
        }

        private void dosomething(String q)
        {
            try
            {
                cn.Open();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                cn.Close();
                loaddata();
            }
            catch (Exception e)
            {
                cn.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void loaddata()
        {
            try
            {
                string q = "select * from Usuarios WHERE CURP ='"+OldCurp+"'";
                cmd.CommandText = q;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtBajaCURP.Text = dr[0].ToString();
                        txtBajaNombre.Text = dr[1].ToString();
                        txtBajaApellidoPaterno.Text = dr[2].ToString();
                        txtBajaApellidoMaterno.Text = dr[3].ToString();
                        txtBajaSexo.Text = dr[4].ToString();
                        txtBajaEscuela.Text = dr[5].ToString();
                        txtBajaGrado.Text = dr[6].ToString();
                        txtBajaGrupo.Text = dr[7].ToString();
                        txtBajaTipo.Text = dr[8].ToString();
                        txtBajaDireccion.Text = dr[9].ToString();
                        txtBajaColonia.Text = dr[10].ToString();
                        txtBajaFijo.Text = dr[11].ToString();
                        txtBajaCelular.Text = dr[12].ToString();
                        txtBajaCorreo.Text = dr[13].ToString();
                        txtBajaEdad.Text = dr[14].ToString();
                        txtBajaLugar.Text = dr[15].ToString();
                        txtBajaFecha.Text = dr[16].ToString();
                        txtBajaEstadoCivil.Text = dr[17].ToString();
                        txtBajaAlergia.Text = dr[18].ToString();
                        txtBajaSangre.Text = dr[19].ToString();
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception e)
            {
                cn.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }
    }
}
