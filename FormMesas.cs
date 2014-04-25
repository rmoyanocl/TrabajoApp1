using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * RESTOGROUP
*/

namespace trabajo_app_1
{
    public partial class FormMesas : Form
    {
        public FormMesas()
        {
            InitializeComponent();

            labelNom1.Visible = false;
            textBoxNom1.Visible = false;
            labelTel1.Visible = false;
            textBoxTel1.Visible = false;
            buttonGuardar1.Visible = false;

            labelNom2.Visible = false;
            textBoxNom2.Visible = false;
            labelTel2.Visible = false;
            textBoxTel2.Visible = false;
            buttonGuardar2.Visible = false;

            labelNom3.Visible = false;
            textBoxNom3.Visible = false;
            labelTel3.Visible = false;
            textBoxTel3.Visible = false;
            buttonGuardar3.Visible = false;

            labelNom4.Visible = false;
            textBoxNom4.Visible = false;
            labelTel4.Visible = false;
            textBoxTel4.Visible = false;
            buttonGuardar4.Visible = false;

            labelNom5.Visible = false;
            textBoxNom5.Visible = false;
            labelTel5.Visible = false;
            textBoxTel5.Visible = false;
            buttonGuardar5.Visible = false;

            labelNom6.Visible = false;
            textBoxNom6.Visible = false;
            labelTel6.Visible = false;
            textBoxTel6.Visible = false;
            buttonGuardar6.Visible = false;

            labelNomVip1.Visible = false;
            textBoxNomVip1.Visible = false;
            labelTelVip1.Visible = false;
            textBoxTelVip1.Visible = false;
            buttonGuardarVip1.Visible = false;

            labelNomVip2.Visible = false;
            textBoxNomVip2.Visible = false;
            labelTelVip2.Visible = false;
            textBoxTelVip2.Visible = false;
            buttonGuardarVip2.Visible = false;

            labelNomVip3.Visible = false;
            textBoxNomVip3.Visible = false;
            labelTelVip3.Visible = false;
            textBoxTelVip3.Visible = false;
            buttonGuardarVip3.Visible = false;

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
                    textBox1.Text = "LIBRE";
                    labelNom1.Visible = false;
                    textBoxNom1.Visible = false;
                    labelTel1.Visible = false;
                    textBoxTel1.Visible = false;
                    buttonGuardar1.Visible = false;

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
                    textBox1.Text = "OCUPADA";
                    labelNom1.Visible = false;
                    textBoxNom1.Visible = false;
                    labelTel1.Visible = false;
                    textBoxTel1.Visible = false;
                    buttonGuardar1.Visible = false;


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
                    textBox1.Text = "RESERVADA";
                    labelNom1.Visible = true;
                    textBoxNom1.Visible = true;
                    labelTel1.Visible = true;
                    textBoxTel1.Visible = true;
                    buttonGuardar1.Visible = true;

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
                    textBox2.Text = "LIBRE";
                    labelNom2.Visible = false;
                    textBoxNom2.Visible = false;
                    labelTel2.Visible = false;
                    textBoxTel2.Visible = false;
                    buttonGuardar2.Visible = false;

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
                    textBox2.Text = "OCUPADA";
                    labelNom2.Visible = false;
                    textBoxNom2.Visible = false;
                    labelTel2.Visible = false;
                    textBoxTel2.Visible = false;
                    buttonGuardar2.Visible = false;

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
                    textBox2.Text = "RESERVADA";
                    labelNom2.Visible = true;
                    textBoxNom2.Visible = true;
                    labelTel2.Visible = true;
                    textBoxTel2.Visible = true;
                    buttonGuardar2.Visible = true;

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
                    textBox3.Text = "LIBRE";
                    labelNom3.Visible = false;
                    textBoxNom3.Visible = false;
                    labelTel3.Visible = false;
                    textBoxTel3.Visible = false;
                    buttonGuardar3.Visible = false;


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
                    textBox3.Text = "OCUPADA";
                    labelNom3.Visible = false;
                    textBoxNom3.Visible = false;
                    labelTel3.Visible = false;
                    textBoxTel3.Visible = false;
                    buttonGuardar3.Visible = false;

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
                    textBox3.Text = "RESERVADA";
                    labelNom3.Visible = true;
                    textBoxNom3.Visible = true;
                    labelTel3.Visible = true;
                    textBoxTel3.Visible = true;
                    buttonGuardar3.Visible = true;

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
                    textBoxVip1.Text = "LIBRE";
                    labelNomVip1.Visible = false;
                    textBoxNomVip1.Visible = false;
                    labelTelVip1.Visible = false;
                    textBoxTelVip1.Visible = false;
                    buttonGuardarVip1.Visible = false;

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
                    textBoxVip1.Text = "OCUPADA";
                    labelNomVip1.Visible = false;
                    textBoxNomVip1.Visible = false;
                    labelTelVip1.Visible = false;
                    textBoxTelVip1.Visible = false;
                    buttonGuardarVip1.Visible = false;

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
                    textBoxVip1.Text = "RESERVADA";
                    labelNomVip1.Visible = true;
                    textBoxNomVip1.Visible = true;
                    labelTelVip1.Visible = true;
                    textBoxTelVip1.Visible = true;
                    buttonGuardarVip1.Visible = true;

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
                    textBoxVip2.Text = "LIBRE";
                    labelNomVip2.Visible = false;
                    textBoxNomVip2.Visible = false;
                    labelTelVip2.Visible = false;
                    textBoxTelVip2.Visible = false;
                    buttonGuardarVip2.Visible = false;

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
                    textBoxVip2.Text = "OCUPADA";
                    labelNomVip2.Visible = false;
                    textBoxNomVip2.Visible = false;
                    labelTelVip2.Visible = false;
                    textBoxTelVip2.Visible = false;
                    buttonGuardarVip2.Visible = false;

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
                    textBoxVip2.Text = "RESERVADA";
                    labelNomVip2.Visible = true;
                    textBoxNomVip2.Visible = true;
                    labelTelVip2.Visible = true;
                    textBoxTelVip2.Visible = true;
                    buttonGuardarVip2.Visible = true;

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
                    textBoxVip3.Text = "LIBRE";
                    labelNomVip3.Visible = false;
                    textBoxNomVip3.Visible = false;
                    labelTelVip3.Visible = false;
                    textBoxTelVip3.Visible = false;
                    buttonGuardarVip3.Visible = false;


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
                    textBoxVip3.Text = "OCUPADA";
                    labelNomVip3.Visible = false;
                    textBoxNomVip3.Visible = false;
                    labelTelVip3.Visible = false;
                    textBoxTelVip3.Visible = false;
                    buttonGuardarVip3.Visible = false;

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
                    textBoxVip3.Text = "RESERVADA";
                    labelNomVip3.Visible = true;
                    textBoxNomVip3.Visible = true;
                    labelTelVip3.Visible = true;
                    textBoxTelVip3.Visible = true;
                    buttonGuardarVip3.Visible = true;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVip3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void FormMesas_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButtonLibre4.Checked == true)
            {
                DialogResult resultLibre4 = MessageBox.Show("Liberar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultLibre4 == DialogResult.Yes)
                {
                    this.buttonMesa4.BackColor = Color.LawnGreen;
                    textBox4.Text = "LIBRE";
                    labelNom4.Visible = false;
                    textBoxNom4.Visible = false;
                    labelTel4.Visible = false;
                    textBoxTel4.Visible = false;
                    buttonGuardar4.Visible = false;

                }
                else
                {
                    return;
                }
            }
            if (radioButtonOcupada4.Checked == true)
            {
                DialogResult resultOcupada4 = MessageBox.Show("Ocupar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultOcupada4 == DialogResult.Yes)
                {
                    this.buttonMesa4.BackColor = Color.Red;
                    textBox4.Text = "OCUPADA";
                    labelNom4.Visible = false;
                    textBoxNom4.Visible = false;
                    labelTel4.Visible = false;
                    textBoxTel4.Visible = false;
                    buttonGuardar4.Visible = false;

                }
                else
                {
                    return;
                }
            }
            if (radioButtonReservada4.Checked == true)
            {
                DialogResult resultReservada4 = MessageBox.Show("Reservar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultReservada4 == DialogResult.Yes)
                {
                    this.buttonMesa4.BackColor = Color.Cyan;
                    textBox4.Text = "RESERVADA";
                    labelNom4.Visible = true;
                    textBoxNom4.Visible = true;
                    labelTel4.Visible = true;
                    textBoxTel4.Visible = true;
                    buttonGuardar4.Visible = true;


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

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMesa5_Click(object sender, EventArgs e)
        {
            if (radioButtonLibre5.Checked == true)
            {
                DialogResult resultLibre5 = MessageBox.Show("Liberar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultLibre5 == DialogResult.Yes)
                {
                    this.buttonMesa5.BackColor = Color.LawnGreen;
                    textBox5.Text = "LIBRE";
                    labelNom5.Visible = false;
                    textBoxNom5.Visible = false;
                    labelTel5.Visible = false;
                    textBoxTel5.Visible = false;
                    buttonGuardar5.Visible = false;

                }
                else
                {
                    return;
                }
            }
            if (radioButtonOcupada5.Checked == true)
            {
                DialogResult resultOcupada5 = MessageBox.Show("Ocupar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultOcupada5 == DialogResult.Yes)
                {
                    this.buttonMesa5.BackColor = Color.Red;
                    textBox5.Text = "OCUPADA";
                    labelNom5.Visible = false;
                    textBoxNom5.Visible = false;
                    labelTel5.Visible = false;
                    textBoxTel5.Visible = false;
                    buttonGuardar5.Visible = false;

                }
                else
                {
                    return;
                }
            }
            if (radioButtonReservada5.Checked == true)
            {
                DialogResult resultReservada5 = MessageBox.Show("Reservar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultReservada5 == DialogResult.Yes)
                {
                    this.buttonMesa5.BackColor = Color.Cyan;
                    textBox5.Text = "RESERVADA";
                    labelNom5.Visible = true;
                    textBoxNom5.Visible = true;
                    labelTel5.Visible = true;
                    textBoxTel5.Visible = true;
                    buttonGuardar5.Visible = true;


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


        private void buttonMesa6_Click(object sender, EventArgs e)
        {
            if (radioButtonLibre6.Checked == true)
            {
                DialogResult resultLibre6 = MessageBox.Show("Liberar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultLibre6 == DialogResult.Yes)
                {
                    this.buttonMesa6.BackColor = Color.LawnGreen;
                    textBox6.Text = "LIBRE";
                    labelNom6.Visible = false;
                    textBoxNom6.Visible = false;
                    labelTel6.Visible = false;
                    textBoxTel6.Visible = false;
                    buttonGuardar6.Visible = false;

                }
                else
                {
                    return;
                }
            }
            if (radioButtonOcupada6.Checked == true)
            {
                DialogResult resultOcupada6 = MessageBox.Show("Ocupar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultOcupada6 == DialogResult.Yes)
                {
                    this.buttonMesa6.BackColor = Color.Red;
                    textBox6.Text = "OCUPADA";
                    labelNom6.Visible = false;
                    textBoxNom6.Visible = false;
                    labelTel6.Visible = false;
                    textBoxTel6.Visible = false;
                    buttonGuardar6.Visible = false;

                }
                else
                {
                    return;
                }
            }
            if (radioButtonReservada6.Checked == true)
            {
                DialogResult resultReservada6 = MessageBox.Show("Reservar esta mesa?",
                "Mesas Disponibles",
                MessageBoxButtons.YesNo);

                if (resultReservada6 == DialogResult.Yes)
                {
                    this.buttonMesa6.BackColor = Color.Cyan;
                    textBox6.Text = "RESERVADA";
                    labelNom6.Visible = true;
                    textBoxNom6.Visible = true;
                    labelTel6.Visible = true;
                    textBoxTel6.Visible = true;
                    buttonGuardar6.Visible = true;

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


        private void buttonGuardar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNom1.Text) || string.IsNullOrEmpty(textBoxTel1.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
            else
            {
                MessageBox.Show("Reserva Guardada.");
                labelNom1.Visible = false;
                textBoxNom1.Visible = false;
                labelTel1.Visible = false;
                textBoxTel1.Visible = false;
                buttonGuardar1.Visible = false;
                textBoxNom1.Text = "";
                textBoxTel1.Text = "";
            }
        }

        private void buttonGuardar2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNom2.Text) || string.IsNullOrEmpty(textBoxTel2.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
            else
            {
                MessageBox.Show("Reserva Guardada.");
                labelNom2.Visible = false;
                textBoxNom2.Visible = false;
                labelTel2.Visible = false;
                textBoxTel2.Visible = false;
                buttonGuardar2.Visible = false;
                textBoxNom2.Text = "";
                textBoxTel2.Text = "";
            }
        }

        private void buttonGuardar3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNom3.Text) || string.IsNullOrEmpty(textBoxTel3.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
            else
            {
                MessageBox.Show("Reserva Guardada.");
                labelNom3.Visible = false;
                textBoxNom3.Visible = false;
                labelTel3.Visible = false;
                textBoxTel3.Visible = false;
                buttonGuardar3.Visible = false;
                textBoxNom3.Text = "";
                textBoxTel3.Text = "";
            }
        }


        private void buttonGuardar4_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxNom4.Text) || string.IsNullOrEmpty(textBoxTel4.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
            else
            {
                MessageBox.Show("Reserva Guardada.");
                labelNom4.Visible = false;
                textBoxNom4.Visible = false;
                labelTel4.Visible = false;
                textBoxTel4.Visible = false;
                buttonGuardar4.Visible = false;
                textBoxNom4.Text = "";
                textBoxTel4.Text = "";
            }

        }


        private void buttonGuardar5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNom5.Text) || string.IsNullOrEmpty(textBoxTel5.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
            else
            {
                MessageBox.Show("Reserva Guardada.");
                labelNom5.Visible = false;
                textBoxNom5.Visible = false;
                labelTel5.Visible = false;
                textBoxTel5.Visible = false;
                buttonGuardar5.Visible = false;
                textBoxNom5.Text = "";
                textBoxTel5.Text = "";
            }
        }


        private void buttonGuardar6_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxNom6.Text) || string.IsNullOrEmpty(textBoxTel6.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
            else
            {
                MessageBox.Show("Reserva Guardada.");
                labelNom6.Visible = false;
                textBoxNom6.Visible = false;
                labelTel6.Visible = false;
                textBoxTel6.Visible = false;
                buttonGuardar6.Visible = false;
                textBoxNom6.Text = "";
                textBoxTel6.Text = "";
            }
        }

        private void buttonGuardarVip1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNomVip1.Text) || string.IsNullOrEmpty(textBoxTelVip1.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
            else
            {
                MessageBox.Show("Reserva Guardada.");
                labelNomVip1.Visible = false;
                textBoxNomVip1.Visible = false;
                labelTelVip1.Visible = false;
                textBoxTelVip1.Visible = false;
                buttonGuardarVip1.Visible = false;
                textBoxNomVip1.Text = "";
                textBoxTelVip1.Text = "";
            }
        }

        private void buttonGuardarVip2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNomVip2.Text) || string.IsNullOrEmpty(textBoxTelVip2.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
            else
            {
                MessageBox.Show("Reserva Guardada.");
                labelNomVip2.Visible = false;
                textBoxNomVip2.Visible = false;
                labelTelVip2.Visible = false;
                textBoxTelVip2.Visible = false;
                buttonGuardarVip2.Visible = false;
                textBoxNomVip2.Text = "";
                textBoxTelVip2.Text = "";
            }
        }

        private void buttonGuardarVip3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNomVip3.Text) || string.IsNullOrEmpty(textBoxTelVip3.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
            else
            {
                MessageBox.Show("Reserva Guardada.");
                labelNomVip3.Visible = false;
                textBoxNomVip3.Visible = false;
                labelTelVip3.Visible = false;
                textBoxTelVip3.Visible = false;
                buttonGuardarVip3.Visible = false;
                textBoxNomVip3.Text = "";
                textBoxTelVip3.Text = "";
            }
        }

        private void textBoxTel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTel1_Click(object sender, EventArgs e)
        {

        }

        private void labelNom1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNom1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonReservada1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOcupada1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonLibre1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
