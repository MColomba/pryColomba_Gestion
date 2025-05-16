using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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

        private void btnListarProveedores_Click(object sender, EventArgs e)
        {
            dgvProveedores.Rows.Clear();
            StreamReader lector = new StreamReader(@"../../Archivos/datosProveedor.txt");

            int i = 0;
            string registro = lector.ReadLine();
            
            if (registro != null)
            {
                string[] columnas = registro.Split('\t');
                while (i < columnas.Length)
                {
                    DataGridViewColumn column = new DataGridViewColumn();
                    column.Name = columnas[i];
                    column.HeaderText = columnas[i];
                    dgvProveedores.Columns.Add(column);
                    i += 1;
                }

                registro = lector.ReadLine();
                while (registro != null)
                {
                    string[] campos = registro.Split('\t');
                    dgvProveedores.Rows.Add(campos[0], campos[1], campos[2], campos[3],
                        campos[4], campos[5], campos[6], campos[7]);
                    registro = lector.ReadLine();
                }
                lector.Close();
                dgvProveedores.Visible = true;
            }    
        }
    }
}
