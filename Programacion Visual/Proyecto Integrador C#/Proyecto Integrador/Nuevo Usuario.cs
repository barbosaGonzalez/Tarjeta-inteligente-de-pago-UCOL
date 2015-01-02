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
    public partial class frmNuevo : Form
    {
        public frmNuevo()
        {
            InitializeComponent();
        }

        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;
        string q;
        string tipo;
        bool Existe = false;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            if (rdbEstudiante.Checked == true)
            {
                tipo = rdbEstudiante.Text;
            }
            else if (rdbDiscapacitado.Checked == true)
            {
                tipo = rdbDiscapacitado.Text;
            }
            else if (rdbTE.Checked == true)
            {
                tipo = rdbTE.Text;
            }
            else if (rdbPG.Checked == true)
            {
                tipo = rdbPG.Text;
            }
            try
            {
                q = "select * from Usuarios";
                cmd.CommandText = q;
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["CURP"].ToString() == txtNuevoCURP.Text)
                    {
                        Existe = true;
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
                MessageBox.Show("CURP No Valida");
                txtNuevoCURP.Clear();
            }
            if (Existe == false)
            {
                q = "INSERT INTO Usuarios(CURP, Nombre, ApellidoPaterno, ApellidoMaterno, Sexo, Escuela, Grado, Grupo, Tipo, Direccion, Colonia, TelefonoFijo, TelefonoCelular, Correo, Edad, LugardeNacimiento, FechadeNacimiento, EstadoCivil, Alergia, TipodeSangre, TipodeUsuario, Saldo) VALUES ('" + txtNuevoCURP.Text.ToString() + "','" + txtNuevoNombre.Text.ToString() + "','" + txtNuevoApellidoPaterno.Text.ToString() + "','" + txtNuevoApellidoMaterno.Text.ToString() + "','" + cmbNuevoSexo.Text.ToString() + "','" + txtNuevoEscuela.Text.ToString() + "','" + cmbNuevoGrado.Text.ToString() + "','" + cmbNuevoGrupo.Text.ToString() + "','" + cmbNuevoTipo.Text.ToString() + "','" + txtNuevoDireccion.Text.ToString() + "','" + txtNuevoColonia.Text.ToString() + "','" + txtNuevoFijo.Text.ToString() + "','" + txtNuevoCelular.Text.ToString() + "','" + txtNuevoCorreo.Text.ToString() + "','" + txtNuevoEdad.Text.ToString() + "','" + txtNuevoLugar.Text.ToString() + "','" + txtNuevoFecha.Text.ToString() + "','" + cmbNuevoEstadoCivil.Text.ToString() + "','" + txtNuevoAlergia.Text.ToString() + "','" + cmbNuevoSangre.Text.ToString() + "','"+tipo.ToString()+"','"+0.ToString()+"')";
                dosomething(q);
                MessageBox.Show("Hecho");
                txtNuevoAlergia.Clear();
                txtNuevoApellidoMaterno.Clear();
                txtNuevoApellidoPaterno.Clear();
                txtNuevoCelular.Clear();
                txtNuevoColonia.Clear();
                txtNuevoCorreo.Clear();
                txtNuevoCURP.Clear();
                txtNuevoDireccion.Clear();
                txtNuevoEdad.Clear();
                txtNuevoEscuela.Clear();
                txtNuevoFecha.Clear();
                txtNuevoFijo.Clear();
                txtNuevoLugar.Clear();
                txtNuevoNombre.Clear();
                cmbNuevoEstadoCivil.Text = "";
                cmbNuevoGrado.Text = "";
                cmbNuevoGrupo.Text = "";
                cmbNuevoSangre.Text = "";
                cmbNuevoSexo.Text = "";
                cmbNuevoTipo.Text = "";
                
                rdbDiscapacitado.Checked = true;
                rdbDiscapacitado.Checked = false;
                
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
        private void frmNuevo_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            cmd.Connection = cn;
            txtNuevoCURP.Select();
            txtNuevoCURP.CharacterCasing = CharacterCasing.Upper;
        }

        #region Focus
        private void txtNuevoFecha_Click(object sender, EventArgs e)
        {
            txtNuevoFecha.Clear();
        }
        private void txtNuevoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)|| char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoCelular.Select();
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtNuevoCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoCorreo.Select();
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtNuevoEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoLugar.Select();
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtNuevoCURP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoNombre.Select();
            }
        }
        private void txtNuevoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoApellidoPaterno.Select();
            }
        }
        private void txtNuevoApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbNuevoSexo.Select();
            }
        }
        private void txtNuevoApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoApellidoMaterno.Select();
            }
        }
        private void cmbNuevoSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoDireccion.Select();
            }
        }
        private void txtNuevoEscuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbNuevoGrado.Select();
            }
        }
        private void cmbNuevoGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbNuevoTipo.Select();
            }
        }
        private void cmbNuevoGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbNuevoGrupo.Select();
            }
        }
        private void cmbNuevoTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoDireccion.Select();
            }
        }
        private void txtNuevoDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoColonia.Select();
            }
        }
        private void txtNuevoColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoFijo.Select();
            }
        }
        private void txtNuevoCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoEdad.Select();
            }
        }
        private void txtNuevoLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoFecha.Select();
            }
        }
        private void txtNuevoFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbNuevoEstadoCivil.Select();
            }
        }
        private void cmbNuevoEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoAlergia.Select();
            }
        }
        private void txtNuevoAlergia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbNuevoSangre.Select();
            }
        }
        #endregion

        private void cmbNuevoSangre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNuevoEscuela.Select();
            }
        }
    }
}

