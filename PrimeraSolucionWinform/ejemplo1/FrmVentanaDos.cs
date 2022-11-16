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
    public partial class FrmVentanaDos : Form
    {
        //constructor
        public FrmVentanaDos()
        {
            //función que inicializa los componentes
            InitializeComponent();
        }

        private void FrmVentanaDos_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textNombre.Text;
            string ciudad = textUbicacion.Text;
            saludarLabel.Text = "Hola " + texto + " que bueno que nos visites desde " + ciudad;
        }

        private void btnAddPets_Click(object sender, EventArgs e)
        {
            string pet = tbPets.Text;
            listViewPets.Items.Add(pet);
        }
    }
}
