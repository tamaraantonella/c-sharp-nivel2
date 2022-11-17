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

        private void btnAddPets_Click(object sender, EventArgs e)
        {
            string pet = tbPets.Text;
            listViewPets.Items.Add(pet);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            string ciudad = textUbicacion.Text;
            DateTime fecha = fechaNacimiento.Value;
            string vet = checkVet.Checked == true ? "si" : "no";
            string message = "Nombre " + nombre + " de la ciudad de " + ciudad + ", con fecha de nacimiento " + fecha + " y con veterinario?: " + vet;
            MessageBox.Show(message);
            //saludarLabel.Text = "Hola " + texto + " que bueno que nos visites desde " + ciudad;
        }
    }
}
