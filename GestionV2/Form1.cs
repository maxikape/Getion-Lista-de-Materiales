using GestionV2.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mauriDataSet.Insumos' Puede moverla o quitarla según sea necesario.
            this.insumosTableAdapter.Fill(this.mauriDataSet.Insumos);

            // TODO: esta línea de código carga datos en la tabla 'mauriDataSet.Pedidos' Puede moverla o quitarla según sea necesario.
            this.pedidosTableAdapter.Fill(this.mauriDataSet.Pedidos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formu = new materiales();
            formu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

            txtCodigo.Text = dgvStock.CurrentRow.Cells[1].Value.ToString();
            

        }
        
    }
}
