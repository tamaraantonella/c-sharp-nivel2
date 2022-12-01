using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //evaluo si ya esta abierta la ventada del form perfil
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmVentanaDos))
                {
                    MessageBox.Show("La ventana ya esta abierta");
                    return;
                }
            }
            FrmVentanaDos perfil = new FrmVentanaDos();
            perfil.MdiParent = this;
            //aca puedo tocar ambas ventanas
            //perfil.Show();
            //este me permite si o si trabajar en una sola ventana
            perfil.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
