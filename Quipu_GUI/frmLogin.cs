using Quipu_BE;
using Quipu_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quipu_GUI
{
    public partial class frmLogin : Form
    {
        Int16 intentos = 0;
        Int16 tiempo = 20;
        // Declaramos instancias....
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "" & txtContrasena.Text.Trim() != "")
            {
                objUsuarioBE = objUsuarioBL.ConsultaUsuario(txtUsuario.Text.Trim().ToLower());

                if (objUsuarioBE.Correo_usuario == null)
                {
                    MessageBox.Show("Usuario no existe",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos(intentos);
                    

                }
                
                // Si el login existe, validamos el password....
                if (txtUsuario.Text == objUsuarioBE.Correo_usuario &  txtContrasena.Text == objUsuarioBE.Contrasena)
                {
                    // Si las credenciales son correctas se  registran las mismas en la clase estatica clsCredenciales
                    // y se lanza el MDI Principal
                    this.Hide();
                    timer1.Enabled = false;
                    ClsUsuario.Usuario = objUsuarioBE.Nom_usuario;
                    ClsUsuario.email = objUsuarioBE.Correo_usuario;
                    ClsUsuario.FechaUltCon = objUsuarioBE.Fecha_ult_con;
                    ClsUsuario.Estado = objUsuarioBE.Est_usuario;
                    ClsUsuario.Rol = objUsuarioBE.Rol;
                    objUsuarioBL.ActualizarConexion(objUsuarioBE.Correo_usuario);
                    MDIPrincipal mdi = new MDIPrincipal();
                    mdi.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos(intentos);

                }
            }
            else {
                MessageBox.Show("Ingrese datos de Usuario y Password",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos(intentos);
            }
        }

        private void ValidaAccesos(Int16 intIntentos)
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fmrLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }
    }
}
