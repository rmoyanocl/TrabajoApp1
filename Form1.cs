using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Por Ruben Moyano

namespace trabajo_app_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmPers administrativo = new FormAdmPers();
            administrativo.MdiParent = this;
            administrativo.Show();

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedido pedido = new FormPedido();
            pedido.MdiParent = this;
            pedido.Show();

        }


        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMesas mesas = new FormMesas();
            mesas.MdiParent = this;
            mesas.Show();

        }



    }
}
