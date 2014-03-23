using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace trabajo_app_1
{
    public partial class FormMesas : Form
    {
        public FormMesas()
        {
            InitializeComponent();
        }

        private void buttonMesa1_Click(object sender, EventArgs e)
        {
            if(comboBoxMesa1.SelectedItem.Equals("Libre"))
            {
                this.buttonMesa1.BackColor = Color.Green;
            }
            if (comboBoxMesa1.SelectedItem.Equals("Reservada"))
            {
                this.buttonMesa1.BackColor = Color.DarkOrange;
            }
            if (comboBoxMesa1.SelectedItem.Equals("Ocupada"))
            {
                this.buttonMesa1.BackColor = Color.Red;
            }
            else
            {
                this.buttonMesa1.BackColor = Color.DarkSeaGreen;
            }
        }



        private void comboBoxMesa1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
