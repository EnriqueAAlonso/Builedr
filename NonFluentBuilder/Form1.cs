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
        List<IFood> compras=new List<IFood>();
        private double PrecioFinal = 0;
        private long id = 0;
        
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void UpdateGrid()
        {
            StringBuilder text = new StringBuilder();
            foreach (IFood alimento in compras)
            {
           
                text.Append(alimento.print());
                text.AppendLine();
            }

            textBox1.Text = text.ToString();
            pago.Text = "$"+PrecioFinal.ToString();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Casera
            CaseraBuilder burguer = new CaseraBuilder(id);
            id += 1;
            IFood resultado = burguer.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Doble
            DobleBuilder burguer=new DobleBuilder(id);
            id += 1;
            IFood resultado = burguer.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();

            UpdateGrid();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Frida
           FridaBuilder burguer= new FridaBuilder(id);
            id += 1;
            IFood resultado = burguer.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Infantil
            InfantilBuilder burguer= new InfantilBuilder(id);
            id += 1;
            IFood resultado = burguer.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Jerry
            JerryBuilder burguer = new JerryBuilder(id);
            id += 1;
            IFood resultado = burguer.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Media
            MediaBuilder burguer = new MediaBuilder(id);
            id += 1;
            IFood resultado = burguer.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Nacho
             NachoBuilder burguer = new NachoBuilder(id);
            id += 1;
            IFood resultado = burguer.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Pancho
            PanchoBuilder burguer = new PanchoBuilder(id);
            id += 1;
            IFood resultado = burguer.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Parrilla
            ParrillaBuilder burguer = new ParrillaBuilder(id);
            id += 1;
            IFood resultado = burguer.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //Shelby
            ShelbyBuilder burguer = new ShelbyBuilder(id);
            id += 1;
            IFood resultado = burguer.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrecioFinal -= compras[e.RowIndex].getCosto();
            compras.RemoveAt(e.RowIndex);
            UpdateGrid();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrecioFinal = 0;
            compras=new List<IFood>();
            UpdateGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long nID = Convert.ToInt64(numericUpDown1.Value);
            bool found = false;
            for (int i = 0; i < compras.Count; i++)
            {
                if (compras[i].getID() == nID)
                {
                    PrecioFinal -= compras[i].getCosto();
                    compras.RemoveAt(i);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("ID invalido");
            }
            else
            {
                UpdateGrid();
            }

            numericUpDown1.Value = 0;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //Full
            FullBuilder sandwich = new FullBuilder(id);
            id += 1;
            IFood resultado = sandwich.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ClubBuilder sandwich = new ClubBuilder(id);
            id += 1;
            IFood resultado = sandwich.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ClasicoBuilder sandwich = new ClasicoBuilder(id);
            id += 1;
            IFood resultado = sandwich.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            RellenoBuilder sandwich = new RellenoBuilder(id);
            id += 1;
            IFood resultado = sandwich.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            PolloBuilder sandwich = new PolloBuilder(id);
            id += 1;
            IFood resultado = sandwich.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            GruesoBuilder baguette = new GruesoBuilder(id);
            id += 1;
            IFood resultado = baguette.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            JamonBuilder baguette = new JamonBuilder(id);
            id += 1;
            IFood resultado = baguette.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            SupremeBuilder baguette = new SupremeBuilder(id);
            id += 1;
            IFood resultado = baguette.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            VietnamBuilder baguette = new VietnamBuilder(id);
            id += 1;
            IFood resultado = baguette.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            StuffedBuilder baguette = new StuffedBuilder(id);
            id += 1;
            IFood resultado = baguette.cocinar();
            resultado.setId(id);
            compras.Add(resultado);
            PrecioFinal += resultado.getCosto();
            UpdateGrid();
        }
    }
}
