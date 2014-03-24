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
                DialogResult resultLibre2 = MessageBox.Show("Liberar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultLibre2 == DialogResult.Yes)
                {
                    this.buttonMesa2.BackColor = Color.LawnGreen;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonOcupada2.Checked == true)
            {
                DialogResult resultOcupada2 = MessageBox.Show("Ocupar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultOcupada2 == DialogResult.Yes)
                {
                    this.buttonMesa2.BackColor = Color.Red;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonReservada2.Checked == true)
            {
                DialogResult resultReservada2 = MessageBox.Show("Reservar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultReservada2 == DialogResult.Yes)
                {
                    this.buttonMesa2.BackColor = Color.Cyan;
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



        private void buttonMesa3_Click(object sender, EventArgs e)
        {
            if (radioButtonLibre3.Checked == true)
            {
                DialogResult resultLibre3 = MessageBox.Show("Liberar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultLibre3 == DialogResult.Yes)
                {
                    this.buttonMesa3.BackColor = Color.LawnGreen;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonOcupada3.Checked == true)
            {
                DialogResult resultOcupada3 = MessageBox.Show("Ocupar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultOcupada3 == DialogResult.Yes)
                {
                    this.buttonMesa3.BackColor = Color.Red;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonReservada3.Checked == true)
            {
                DialogResult resultReservada3 = MessageBox.Show("Reservar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultReservada3 == DialogResult.Yes)
                {
                    this.buttonMesa3.BackColor = Color.Cyan;
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



        private void buttonMesavip1_Click(object sender, EventArgs e)
        {
            if (radioButtonLibreVip1.Checked == true)
            {
                DialogResult resultLibreVip1 = MessageBox.Show("Leberar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultLibreVip1 == DialogResult.Yes)
                {
                    this.buttonMesavip1.BackColor = Color.LawnGreen;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonOcupadaVip1.Checked == true)
            {
                DialogResult resultOcupadaVip1 = MessageBox.Show("Ocupar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultOcupadaVip1 == DialogResult.Yes)
                {
                    this.buttonMesavip1.BackColor = Color.Red;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonReservadaVip1.Checked == true)
            {
                DialogResult resultReservadaVip1 = MessageBox.Show("Reservar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultReservadaVip1 == DialogResult.Yes)
                {
                    this.buttonMesavip1.BackColor = Color.Cyan;
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



        private void buttonMesavip2_Click(object sender, EventArgs e)
        {
            if (radioButtonLibreVip2.Checked == true)
            {
                DialogResult resultLibreVip2 = MessageBox.Show("Leberar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultLibreVip2 == DialogResult.Yes)
                {
                    this.buttonMesavip2.BackColor = Color.LawnGreen;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonOcupadaVip2.Checked == true)
            {
                DialogResult resultOcupadaVip2 = MessageBox.Show("Ocupar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultOcupadaVip2 == DialogResult.Yes)
                {
                    this.buttonMesavip2.BackColor = Color.Red;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonReservadaVip2.Checked == true)
            {
                DialogResult resultReservadaVip2 = MessageBox.Show("Reservar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultReservadaVip2 == DialogResult.Yes)
                {
                    this.buttonMesavip2.BackColor = Color.Cyan;
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

        private void buttonMesavip3_Click(object sender, EventArgs e)
        {
            if (radioButtonLibreVip3.Checked == true)
            {
                DialogResult resultLibreVip3 = MessageBox.Show("Liberar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultLibreVip3 == DialogResult.Yes)
                {
                    this.buttonMesavip3.BackColor = Color.LawnGreen;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonOcupadaVip3.Checked == true)
            {
                DialogResult resultOcupadaVip3 = MessageBox.Show("Ocupar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultOcupadaVip3 == DialogResult.Yes)
                {
                    this.buttonMesavip3.BackColor = Color.Red;
                }
                else
                {
                    return;
                }
            }
            if (radioButtonReservadaVip3.Checked == true)
            {
                DialogResult resultReservadaVip3 = MessageBox.Show("Reservar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultReservadaVip3 == DialogResult.Yes)
                {
                    this.buttonMesavip3.BackColor = Color.Cyan;
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

    }
}
