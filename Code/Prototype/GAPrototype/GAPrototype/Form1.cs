using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAPrototype
{
    public partial class Form1 : Form
    {
        private Chromosome[] Population;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulationGenerator popGen = new PopulationGenerator(Convert.ToInt32(txt_PopSize.Text), Convert.ToInt32(txt_ChromosomeLength.Text));
            Population = popGen.GeneratePopulation();

            foreach(Chromosome c in Population)
            {
                label1.Text += c.ToString();
            }
        }
    }
}
