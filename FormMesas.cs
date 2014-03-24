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

            /*
            //Cambiar estado del boton mesa dependiendo del item seleccionado en el combobox
            *
            if(comboBoxMesa1.SelectedItem.Equals("Libre"))
            {
                this.buttonMesa1.BackColor = Color.Green;
            }
            if (comboBoxMesa1.SelectedItem.Equals("Reservada"))
            {
                this.buttonMesa1.BackColor = Color.Brown;
            }
            if (comboBoxMesa1.SelectedItem.Equals("Ocupada"))
            {
                this.buttonMesa1.BackColor = Color.Red;
            }
            else
            {
                return;
            }
            * 
            */


            if (radioButtonLibre1.Checked == true)
            {

                DialogResult resultLibre1 = MessageBox.Show("Liberar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultLibre1 == DialogResult.Yes)
                {
                    this.buttonMesa1.BackColor = Color.LawnGreen;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonOcupada1.Checked == true)
            {
                DialogResult resultOcupada1 = MessageBox.Show("Ocupar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultOcupada1 == DialogResult.Yes)
                {
                    this.buttonMesa1.BackColor = Color.Red;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonReservada1.Checked == true)
            {
                DialogResult resultReservada1 = MessageBox.Show("Reservar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultReservada1 == DialogResult.Yes)
                {
                    this.buttonMesa1.BackColor = Color.Cyan;
                }
                else
                {
                    return;
                }   
            }
            else
            {
                return;
            }
        }





        private void buttonMesa2_Click(object sender, EventArgs e)
        {
            if (radioButtonLibre2.Checked == true)
            {
                this.buttonMesa2.BackColor = Color.LawnGreen;
            }
            if (radioButtonOcupada2.Checked == true)
            {
                this.buttonMesa2.BackColor = Color.Red;
            }
            if (radioButtonReservada2.Checked == true)
            {
                this.buttonMesa2.BackColor = Color.Cyan;
            }
            else
            {
                return;
            }
        }

        private void buttonMesa3_Click(object sender, EventArgs e)
        {
            if (radioButtonLibre3.Checked == true)
            {
                this.buttonMesa3.BackColor = Color.LawnGreen;
            }
            if (radioButtonOcupada3.Checked == true)
            {
                this.buttonMesa3.BackColor = Color.Red;
            }
            if (radioButtonReservada3.Checked == true)
            {
                this.buttonMesa3.BackColor = Color.Cyan;
            }
            else
            {
                return;
            }
        }

        private void buttonMesavip1_Click(object sender, EventArgs e)
        {
            if (radioButtonLibreVip1.Checked == true)
            {
                this.buttonMesavip1.BackColor = Color.LawnGreen;
            }
            if (radioButtonOcupadaVip1.Checked == true)
            {
                this.buttonMesavip1.BackColor = Color.Red;
            }
            if (radioButtonReservadaVip1.Checked == true)
            {
                this.buttonMesavip1.BackColor = Color.Cyan;
            }
            else
            {
                return;
            }
        }

        private void buttonMesavip2_Click(object sender, EventArgs e)
        {
            if (radioButtonLibreVip2.Checked == true)
            {
                this.buttonMesavip2.BackColor = Color.LawnGreen;
            }
            if (radioButtonOcupadaVip2.Checked == true)
            {
                this.buttonMesavip2.BackColor = Color.Red;
            }
            if (radioButtonReservadaVip2.Checked == true)
            {
                this.buttonMesavip2.BackColor = Color.Cyan;
            }
            else
            {
                return;
            }
        }

        private void buttonMesavip3_Click(object sender, EventArgs e)
        {
            if (radioButtonLibreVip3.Checked == true)
            {
                this.buttonMesavip3.BackColor = Color.LawnGreen;
            }
            if (radioButtonOcupadaVip3.Checked == true)
            {
                this.buttonMesavip3.BackColor = Color.Red;
            }
            if (radioButtonReservadaVip3.Checked == true)
            {
                this.buttonMesavip3.BackColor = Color.Cyan;
            }
            else
            {
                return;
            }
        }

    }
}
