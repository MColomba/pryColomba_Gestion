using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryColomba_Gestion
{
    public partial class frmPrincipal : Form
    {
        clsUsuario objConexionBD;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            objConexionBD = new clsUsuario();
            lblEstado.Text = objConexionBD.estadoConexion;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    objConexionBD = new clsUsuario();
                    objConexionBD.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);
                    if (objConexionBD.estadoConexion == "Usuario EXISTE")
                    {
                        frmMainUsuario frmMainUsuario = new frmMainUsuario(txtUsuario.Text);
                        frmMainUsuario.ShowDialog();
                    }
                    else
                    {
                        txtUsuario.Text = "";
                        txtContraseña.Text = "";
                        lblEstado.Text = "Error de inicio";
                    }
                }
                else
                {
                    MessageBox.Show("Falta la contraseña");
                }
            }
            else
            {
                MessageBox.Show("Falta el usuario");
            }
        }
    }
}
