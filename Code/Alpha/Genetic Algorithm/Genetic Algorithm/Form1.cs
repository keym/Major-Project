using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetic_Algorithm
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            int PopulationSize = Convert.ToInt32(txt_PopSize.Text);
            int ChromosomeLength = Convert.ToInt32(txt_ChromosomeLength.Text);

            ZodiacPopMan popMan = new ZodiacPopMan(PopulationSize, ChromosomeLength);
            popMan.Run();
        }
    }
}
