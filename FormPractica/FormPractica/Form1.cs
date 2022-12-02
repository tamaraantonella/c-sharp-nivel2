using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void box_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(box_lastname.Text == "")
                box_lastname.BackColor = Color.Red;
            else if (box_name.Text == "")
                box_name.BackColor = Color.Red;   
            else if (box_address.Text == "")
                box_address.BackColor = Color.Red;
            else if (box_age.Text == "")
                box_age.BackColor = Color.Red;
            else
            {
                //write in multiline textbox  results
                results.Text = "Apellido y Nombre: " + box_lastname.Text+" "+box_name.Text + Environment.NewLine;
                results.Text += "Edad: " + box_age.Text + Environment.NewLine;
                results.Text += "Dirección: " + box_address.Text + Environment.NewLine;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //must close app
            this.Close();
        }
    }
}
