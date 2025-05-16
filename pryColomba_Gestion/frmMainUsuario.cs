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
    public partial class frmMainUsuario : Form
    {
        public frmMainUsuario(string Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
            lblFecha.Text = DateTime.Now.ToString();
        }
    }
}
