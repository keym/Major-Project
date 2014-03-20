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
            Boolean terminate = false;
            DateTime Begin = DateTime.Now;
            while(terminate == false)
            {
            PopulationGenerator popGen = new PopulationGenerator(Convert.ToInt32(txt_PopSize.Text), Convert.ToInt32(txt_ChromosomeLength.Text));
            Population = popGen.GeneratePopulation();
            Z340 z340 = new Z340();

            Fitness fit = new Fitness(Population, z340);
            Population = fit.calcFitness();

            Selection selection = new Selection(Population);
            Chromosome[] intermediate = selection.selectAlleles();

            Genetics gen = new Genetics(Convert.ToDouble(txt_CrossoverRate.Text), Convert.ToDouble(txt_MutationRate.Text));
            Population = gen.reproduce(intermediate);

            Termination terminator = new Termination();
            terminate = terminator.doesTerminate(Begin);
            }

            foreach(Chromosome c in Population)
            {
                label1.Text += c.ToString();
            }
        }
    }
}
