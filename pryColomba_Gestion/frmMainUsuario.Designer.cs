namespace pryColomba_Gestion
{
    partial class frmMainUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.tabReporte = new System.Windows.Forms.TabPage();
            this.btnListarProveedores = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabReporte.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Controls.Add(this.tabReporte);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(141, 81);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRegistro
            // 
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(208, 55);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Registro";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // tabReporte
            // 
            this.tabReporte.Controls.Add(this.btnListarProveedores);
            this.tabReporte.Location = new System.Drawing.Point(4, 22);
            this.tabReporte.Name = "tabReporte";
            this.tabReporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabReporte.Size = new System.Drawing.Size(133, 55);
            this.tabReporte.TabIndex = 1;
            this.tabReporte.Text = "Reportes";
            this.tabReporte.UseVisualStyleBackColor = true;
            // 
            // btnListarProveedores
            // 
            this.btnListarProveedores.Location = new System.Drawing.Point(7, 16);
            this.btnListarProveedores.Name = "btnListarProveedores";
            this.btnListarProveedores.Size = new System.Drawing.Size(114, 23);
            this.btnListarProveedores.TabIndex = 0;
            this.btnListarProveedores.Text = "Listado Proveedores";
            this.btnListarProveedores.UseVisualStyleBackColor = true;
            this.btnListarProveedores.Click += new System.EventHandler(this.btnListarProveedores_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(118, 17);
            this.lblUsuario.Text = "toolStripStatusLabel1";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 17);
            this.lblFecha.Text = "toolStripStatusLabel1";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 128);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.Size = new System.Drawing.Size(776, 297);
            this.dgvProveedores.TabIndex = 2;
            this.dgvProveedores.Visible = false;
            // 
            // frmMainUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMainUsuario";
            this.Text = "frmMainUsuario";
            this.tabControl1.ResumeLayout(false);
            this.tabReporte.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabReporte;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Button btnListarProveedores;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
    }
}