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
    public partial class frmRenovarDatos : Form
    {
        public string OldCurp;

        public frmRenovarDatos()
        {
            InitializeComponent();
        }
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {

            string q = "UPDATE Usuarios SET Nombre='" + txtRenovarNombre.Text.ToString() + "', ApellidoPaterno='" + txtRenovarApellidoPaterno.Text.ToString() + "', ApellidoMaterno='" + txtRenovarApellidoMaterno.Text.ToString() + "', Sexo='" + cmbRenovarSexo.Text.ToString() + "', Escuela='" + txtRenovarEscuela.Text.ToString() + "', Grado='" + cmbRenovarGrado.Text.ToString() + "', Grupo='" + cmbRenovarGrupo.Text.ToString() + "',Tipo='"+ cmbRenovarTipo.Text.ToString()+"',Direccion='" + txtRenovarDireccion.Text.ToString() + "', Colonia='" + txtRenovarColonia.Text.ToString() + "', TelefonoFijo='" + txtRenovarFijo.Text.ToString() + "', TelefonoCelular='" + txtRenovarCelular.Text.ToString() + "', Correo='" + txtRenovarCorreo.Text.ToString() + "', Edad='" + txtRenovarEdad.Text.ToString() + "', LugardeNacimiento='" + txtRenovarLugar.Text.ToString() + "', FechadeNacimiento='" + txtRenovarFecha.Text.ToString() + "', EstadoCivil='" + cmbRenovarEstadoCivil.Text.ToString() + "', Alergia='" + txtRenovarAlergia.Text.ToString() + "', TipodeSangre='" + cmbRenovarSangre.Text.ToString() + "' WHERE CURP ='" + OldCurp + "'";
            dosomething(q);
            MessageBox.Show("Hecho");
            Close();
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

        private void loaddata()
        {
            try
            {
                string q = "select * from Usuarios WHERE CURP ='" + OldCurp + "'";
                cmd.CommandText = q;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //string[] Registros = new string[] { dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString(), dr[17].ToString(), dr[18].ToString(), dr[19].ToString() };
                        
                        txtRenovarNombre.Text = dr[1].ToString();
                        txtRenovarApellidoPaterno.Text = dr[2].ToString();
                        txtRenovarApellidoMaterno.Text = dr[3].ToString();
                        cmbRenovarSexo.Text = dr[4].ToString();
                        txtRenovarEscuela.Text = dr[5].ToString();
                        cmbRenovarGrado.Text = dr[6].ToString();
                        cmbRenovarGrupo.Text = dr[7].ToString();
                        cmbRenovarTipo.Text = dr[8].ToString();
                        txtRenovarDireccion.Text = dr[9].ToString();
                        txtRenovarColonia.Text = dr[10].ToString();
                        txtRenovarFijo.Text = dr[11].ToString();
                        txtRenovarCelular.Text = dr[12].ToString();
                        txtRenovarCorreo.Text = dr[13].ToString();
                        txtRenovarEdad.Text = dr[14].ToString();
                        txtRenovarLugar.Text = dr[15].ToString();
                        txtRenovarFecha.Text = dr[16].ToString();
                        cmbRenovarEstadoCivil.Text = dr[17].ToString();
                        txtRenovarAlergia.Text = dr[18].ToString();
                        cmbRenovarSangre.Text = dr[19].ToString();
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

        private void frmRenovarDatos_Load(object sender, EventArgs e)
        {
            txtRenovarNombre.Select();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            cmd.Connection = cn;
            loaddata();
        }

        private void txtRenovarFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarCelular.Select();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRenovarCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarCorreo.Select();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRenovarEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarLugar.Select();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRenovarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarApellidoPaterno.Select();
            }
        }

        private void txtRenovarApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarApellidoMaterno.Select();
            }
        }

        private void txtRenovarApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbRenovarSexo.Select();
            }
        }

        private void cmbRenovarSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarEscuela.Select();
            }
        }

        private void txtRenovarEscuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbRenovarGrado.Select();
            }
        }

        private void cmbRenovarGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbRenovarGrupo.Select();
            }
        }

        private void cmbRenovarGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbRenovarTipo.Select();
            }
        }

        private void cmbRenovarTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarDireccion.Select();
            }
        }

        private void txtRenovarCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarEdad.Select();
            }
        }

        private void cmbRenovarEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarAlergia.Select();
            }
        }

        private void txtRenovarColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarFijo.Select();
            }
        }

        private void txtRenovarDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarColonia.Select();
            }
        }

        private void txtRenovarLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRenovarFecha.Select();
            }
        }

        private void txtRenovarFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbRenovarEstadoCivil.Select();
            }
        }

        private void txtRenovarAlergia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbRenovarSangre.Select();
            }
        }
    }
}
