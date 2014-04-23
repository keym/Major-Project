using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            int PopulationSize = Convert.ToInt32(nud_PopulationSize.Value);
            int TimeLimit = Convert.ToInt32(nud_Time.Value);
            int Cipher = 0, Crossover = 0, Fitness = 0, Mutation = 0, Selection = 0;
            Boolean flag = true;

            if (cmb_Cipher.Text != "")
            {
                Cipher = cmb_Cipher.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Please select cipher");
                flag = false;
            }

            if (cmb_Crossover.Text != "")
            {
                Crossover = cmb_Crossover.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Please select crossover function");
                flag = false;
            }

            if (cmb_Fitness.Text != "")
            {
                Fitness = cmb_Fitness.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Please select fitness function");
                flag = false;
            }

            if (cmb_Mutation.Text != "")
            {
                Mutation = cmb_Mutation.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Please select mutation function");
                flag = false;
            }

            if (cmb_Selection.Text != "")
            {
                Selection = cmb_Selection.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Please select selection function");
                flag = false;
            }

            if(flag)
            {
            PopMan popMan = new PopMan(PopulationSize, TimeLimit, Cipher, Fitness, Selection, Mutation, Crossover);
            popMan.Run();
            }
        }

        private void Frm1_Load(object sender, EventArgs e)
        {

        }
    }
}
