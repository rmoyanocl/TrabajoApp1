using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;


namespace trabajo_app_1
{
    public partial class FormPedido : Form
    {
        //INICIO Intento de Conexión a MySql Parte1
        MySqlConnection connection = new MySqlConnection();
        String connectionString;
        List<Pedidos> listapedidos = new List<Pedidos>();
        //FIN Intento de Conexión a MySql Parte1

    
        public FormPedido()
        {
            InitializeComponent();
            //IniciarConexion();
        }
            

            //INICIO Intento de Conexión a MySql Parte2
            private void IniciarConexion()
            {
                try
                {
                    connectionString = "Server= 190.98.197.102; Database = rubenmoy_trabajo_app; Uid=rubenmoy_trabajo; Pwd=trabajoapp699;";
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("La conexión se ha realizado con exito", "Bien hecho!");
                                    
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ocurrió un error al intentar conectar", "ERROR");
                }
            }
            //FIN Intento de Conexión a MySql Parte2
            

         static void main()
        {
            ArrayList lista1 = new ArrayList();
            
            
        }
         
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
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

            listBoxPedido.Items.Add("--Inicio Pedido--");
            //listBoxPedido.Items.Add("Datos Mesa " + 

            //Agregar al ListBox
            listBoxPedido.Items.Add("RESTAURANTE EL QUERY");
            listBoxPedido.Items.Add("Alonso de Ovalle 1586, Santiago Centro");
            listBoxPedido.Items.Add("Teléfono: +56 2 2354 0600");
            listBoxPedido.Items.Add("Fecha: " + dateTimePickerFecha.Text);
            listBoxPedido.Items.Add(" ");
            listBoxPedido.Items.Add("Comida : " + comboBoxComida.Text);
            listBoxPedido.Items.Add("Postre : " + comboBoxPostre.Text);
            listBoxPedido.Items.Add("Bebida : " + comboBoxBebidas.Text);
            listBoxPedido.Items.Add("Vino : " + comboBoxVinos.Text);
            listBoxPedido.Items.Add(" ");
            listBoxPedido.Items.Add("*Gracias Por Su Preferencia*");
            listBoxPedido.Items.Add("--Fin Pedido--");

            //Limpiar ComboBox
            comboBoxComida.Text = "";
            comboBoxPostre.Text = "";
            comboBoxBebidas.Text = "";
            comboBoxVinos.Text = "";


            //INICIO Intento de Conexión a MySql Parte3
            MySqlCommand instruccion = connection.CreateCommand();
            instruccion.CommandText = "SELECT Bebida1, Comida1, Postre1, Vino1 FROM Pedidos";
            MySqlDataReader reader = instruccion.ExecuteReader();
            while (reader.Read())
            {
                Pedidos ObjPedidos = new Pedidos();
                ObjPedidos.Bebida1 = reader["Bebida1"].ToString();
                ObjPedidos.Comida1 = reader["Comida1"].ToString();
                ObjPedidos.Postre1 = reader["Postre1"].ToString();
                ObjPedidos.Vino1 = reader["Vino1"].ToString();

            }
            DataGridView1.DataSource = listapedidos;
            reader.Dispose();
            //FIN Intento de Conexión a MySql Parte3

        }
             

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxVinos_SelectedIndexChanged(object sender, EventArgs e)
        {

           //Intento de ocultar comboBox según item seleccionado :(
           /* if (comboBoxBebidas.SelectedItem.Equals("Vino"))
            {
                
                comboBoxVinos.Visible = false;

            } */

        }

        private void listBoxPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button3.Click += )
            { 
                
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            
        }
    
}

}
