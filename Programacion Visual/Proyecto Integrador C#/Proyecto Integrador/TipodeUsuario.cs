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
    public partial class TipodeUsuario : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;
        string q;
        string tipo;
        public TipodeUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TipodeUsuario_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            cmd.Connection = cn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rdbEstudiante.Checked == true)
            {
                tipo = "Estudiante";
            }
            else if(rdbDiscapacitados.Checked==true)
            {
                tipo = "Discapacitado";
            }
            else if (rdbTercera.Checked == true)
            {
                tipo = "Tercera Edad";
            }
            else if (rdbGeneral.Checked == true)
            {
                tipo = "Publico en General";
            }
            q = "Select * from Cobro WHERE Fecha='" + txtFecha.Text.ToString() + "' and TipodeUsuario='" + tipo.ToString() + "'";
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
    }
}
