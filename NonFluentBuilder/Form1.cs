using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NonFluentBuilder.Builders;

namespace NonFluentBuilder
{
    public partial class Form1 : Form
    {
        List<Hamburguesa> compras=new List<Hamburguesa>();
        DobleBuilder doble = new DobleBuilder();
        private double PrecioFinal = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void setHeaders()
        {
            dataGridView1.Columns[1].HeaderText = "Pan";
            dataGridView1.Columns[2].HeaderText = "Costo";
            dataGridView1.Columns[3].HeaderText = "Nombre";
            dataGridView1.Columns[4].HeaderText = "foto";
            dataGridView1.Columns[5].HeaderText = "Papas";
            dataGridView1.Columns[6].HeaderText = "Tipo de Carne";
            
        }

        private void UpdateGrid()
        {
            var source = new BindingSource(compras,null);
            dataGridView1.DataSource = source;
            setHeaders();
            label3.Text = "$"+PrecioFinal.ToString();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Casera
            CaseraBuilder doble = new CaseraBuilder();
            compras.Add(doble.cocinar());
            PrecioFinal += doble.cocinar().costo;
            UpdateGrid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Doble
            DobleBuilder doble=new DobleBuilder();
            compras.Add(doble.cocinar());
            PrecioFinal += doble.cocinar().costo;
            UpdateGrid();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Frida
            FridaBuilder doble = new FridaBuilder();
            compras.Add(doble.cocinar());
            PrecioFinal += doble.cocinar().costo;
            UpdateGrid();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Infantil
            InfantilBuilder doble = new InfantilBuilder();
            compras.Add(doble.cocinar());
            PrecioFinal += doble.cocinar().costo;
            UpdateGrid();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Jerry
            JerryBuilder doble = new JerryBuilder();
            compras.Add(doble.cocinar());
            PrecioFinal += doble.cocinar().costo;
            UpdateGrid();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Media
            MediaBuilder doble = new MediaBuilder();
            compras.Add(doble.cocinar());
            PrecioFinal += doble.cocinar().costo;
            UpdateGrid();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Nacho
            NachoBuilder doble = new NachoBuilder();
            compras.Add(doble.cocinar());
            PrecioFinal += doble.cocinar().costo;
            UpdateGrid();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Pancho
            PanchoBuilder doble = new PanchoBuilder();
            compras.Add(doble.cocinar());
            PrecioFinal += doble.cocinar().costo;
            UpdateGrid();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Parrilla
            ParrillaBuilder doble = new ParrillaBuilder();
            compras.Add(doble.cocinar());
            PrecioFinal += doble.cocinar().costo;
            UpdateGrid();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //Shelby
            ShelbyBuilder doble = new ShelbyBuilder();
            compras.Add(doble.cocinar());
            PrecioFinal += doble.cocinar().costo;
            UpdateGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrecioFinal -= compras[e.RowIndex].costo;
            compras.RemoveAt(e.RowIndex);
            UpdateGrid();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrecioFinal = 0;
            compras=new List<Hamburguesa>();
            UpdateGrid();
        }
    }
}
