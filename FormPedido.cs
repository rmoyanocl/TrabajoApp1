using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Printing;


/*
 * RESTOGROUP
*/

namespace trabajo_app_1
{
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
            //comboBoxVinos.Enabled = false;

        }

        static void main()
        {

        }
         
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxMesero.SelectedIndex.Equals(-1) || comboBoxMesa.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Llene todos los datos");
            }
            else
            {
                //Agregar al ListBox
                listBoxResult.Items.Add("--Datos de la Mesa--");
                listBoxResult.Items.Add("Nombre Mesero : " + comboBoxMesero.Text);
                listBoxResult.Items.Add("Mesa: " + comboBoxMesa.Text);
                listBoxResult.Items.Add("Fecha: " + dateTimePickerFecha.Text);
                //listBoxResult.Items.Add("--Fin Comentario--");

                //Limpiar ComboBox
                comboBoxMesero.Text = "";
                comboBoxMesa.Text = "";
                dateTimePickerFecha.Text = "";
                //comboBoxAperitivo.Text = "";
            }
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
        }

        private void comboBoxMesero_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBoxBebidas.SelectedIndex.Equals(-1) || (comboBoxComida.SelectedIndex.Equals(-1) || 
                comboBoxPostre.SelectedIndex.Equals(-1) || comboBoxVinos.SelectedIndex.Equals(-1)))
            {
                MessageBox.Show("Llene todos los datos");
            }
            else
            {
                listBoxPedido.Items.Add("--Inicio Pedido--");
                //listBoxPedido.Items.Add("Datos Mesa " + 

                //Agregar al ListBox
                listBoxPedido.Items.Add("RESTAURANTE RESTOGROUP");
                listBoxPedido.Items.Add(" ");
                listBoxPedido.Items.Add("Alonso de Ovalle 1586, Santiago Centro");
                listBoxPedido.Items.Add("Teléfono: +56 2 2354 0600");
                listBoxPedido.Items.Add("Fecha: " + dateTimePickerFecha.Text);
                listBoxPedido.Items.Add("Hora: " + dateTimePickerTime.Text);
                listBoxPedido.Items.Add(" ");
                listBoxPedido.Items.Add("Comida : " + comboBoxComida.Text);
                listBoxPedido.Items.Add("Postre : " + comboBoxPostre.Text);
                listBoxPedido.Items.Add("Bebida : " + comboBoxBebidas.Text);
                listBoxPedido.Items.Add("Vino : " + comboBoxVinos.Text);
                listBoxPedido.Items.Add(" ");
                listBoxPedido.Items.Add("--Fin Pedido--");

                //Limpiar ComboBox
                comboBoxComida.Text = "";
                comboBoxPostre.Text = "";
                comboBoxBebidas.Text = "";
                comboBoxVinos.Text = "";

                int f;
                for (f = 1; f <= 1; f++)
                {
                    textBoxNumPedido.Text = f.ToString();
                }



            }
        }
             

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVinos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            /*
            if (listBoxPedido.Text.Length == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
            }
            else
            {
            */
                DialogResult resultimprimir = MessageBox.Show("Desea Guardar e Imprimir pedido?", "Imprimir",
                MessageBoxButtons.YesNo);

                if (resultimprimir == DialogResult.Yes)
                {
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                    pd.Print();
                }
                else
                {
                    return;
                }
            /*
            }
            */
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            string tex = "";
            for (int i = 0; i < listBoxPedido.Items.Count - 1; i++)
            {
                tex = tex + listBoxPedido.Items[i].ToString() + "\n";
            }

            Font printFont = new Font("3 of 9 Barcode", 18);
            Font printFont1 = new Font("Times New Roman", 11, FontStyle.Bold);
            SolidBrush br = new SolidBrush(Color.Black);
            ev.Graphics.DrawString("Pedidos", printFont, br, 10, 65);
            ev.Graphics.DrawString(tex, printFont1, br, 10, 85);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            /*
            if (listBoxPedido.Text.Length == 0)
            {
                MessageBox.Show("No hay datos para borrar");
            }
            else
            {
            */
                DialogResult resulLimpiar = MessageBox.Show("Desea limpiar datos?", "Limpiar",
            MessageBoxButtons.YesNo);

                if (resulLimpiar == DialogResult.Yes)
                {
                    listBoxPedido.Items.Clear();
                    textBoxNumPedido.Clear();
                }
                else
                {
                    return;
                }
            /*
            }
            */
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

}

}
