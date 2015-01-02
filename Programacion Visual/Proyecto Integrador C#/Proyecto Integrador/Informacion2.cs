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
    public partial class Informacion2 : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;
        int E=0, T=0, D=0, P=0, Total=0;
        public Informacion2()
        {
            InitializeComponent();
        }

        private void Informacion2_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            cmd.Connection = cn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "Select * from Cobro WHERE Ruta='"+ cmbRuta.Text.ToString()+"' and Fecha='"+txtFecha.Text.ToString()+"'";
            cmd.CommandText = q;
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr[3].ToString() == "Estudiante")
                    {
                        E++;
                    }
                    else if (dr[3].ToString() == "Discapacitado")
                    {
                        D++;
                    }
                    else if (dr[3].ToString() == "Publico en General")
                    {
                        P++;
                    }
                    else if (dr[3].ToString() == "Tercera Edad")
                    {
                        T++;
                    }
                }
            }
            dr.Close();
            cn.Close();
            txtDiscapacitados.Text = Convert.ToString(D);
            txtEdad.Text = Convert.ToString(T);
            txtEstudiante.Text = Convert.ToString(E);
            txtPG.Text = Convert.ToString(P);
            Total = ((D*3)+(T*3)+(E*3)+(P*6));
            txtGanancias.Text = Convert.ToString(Total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFecha_Click(object sender, EventArgs e)
        {
            txtFecha.Clear();
        }
    }
}
