using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Formulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias por usar C#");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("Hola ");
            //this.BackColor = Color.Blue;
            if(textLastName.Text == "")
                textLastName.BackColor = Color.Red;
            else
                textLastName.BackColor = System.Drawing.SystemColors.Control;
        }

        private void Formulario_Click(object sender, EventArgs e)
        {
            //este evento se ejecuta cuando se hace click en el formulario
            //y determina la posicion del mouse
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Click izquierdo");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Click derecho");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Click central");
            else
                MessageBox.Show("Click no identificado");

        }

        private void labelForm_MouseMove(object sender, MouseEventArgs e)
        {
            labelForm.BackColor = Color.Cyan;
            labelForm.Cursor = Cursors.Hand;
        }

        private void labelForm_MouseLeave(object sender, EventArgs e)
        {
            labelForm.BackColor = System.Drawing.SystemColors.Control;
            labelForm.Cursor = Cursors.Arrow;
        }

        private void textLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
