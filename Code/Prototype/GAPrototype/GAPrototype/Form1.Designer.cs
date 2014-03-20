namespace GAPrototype
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_PopulationSize = new System.Windows.Forms.Label();
            this.lbl_ChromosomeLength = new System.Windows.Forms.Label();
            this.txt_PopSize = new System.Windows.Forms.TextBox();
            this.txt_ChromosomeLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CrossoverRate = new System.Windows.Forms.Label();
            this.lbl_MutationRate = new System.Windows.Forms.Label();
            this.txt_CrossoverRate = new System.Windows.Forms.TextBox();
            this.txt_MutationRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_PopulationSize
            // 
            this.lbl_PopulationSize.AutoSize = true;
            this.lbl_PopulationSize.Location = new System.Drawing.Point(29, 45);
            this.lbl_PopulationSize.Name = "lbl_PopulationSize";
            this.lbl_PopulationSize.Size = new System.Drawing.Size(80, 13);
            this.lbl_PopulationSize.TabIndex = 1;
            this.lbl_PopulationSize.Text = "Population Size";
            // 
            // lbl_ChromosomeLength
            // 
            this.lbl_ChromosomeLength.AutoSize = true;
            this.lbl_ChromosomeLength.Location = new System.Drawing.Point(29, 67);
            this.lbl_ChromosomeLength.Name = "lbl_ChromosomeLength";
            this.lbl_ChromosomeLength.Size = new System.Drawing.Size(104, 13);
            this.lbl_ChromosomeLength.TabIndex = 2;
            this.lbl_ChromosomeLength.Text = "Chromosome Length";
            // 
            // txt_PopSize
            // 
            this.txt_PopSize.Location = new System.Drawing.Point(139, 38);
            this.txt_PopSize.Name = "txt_PopSize";
            this.txt_PopSize.Size = new System.Drawing.Size(100, 20);
            this.txt_PopSize.TabIndex = 3;
            // 
            // txt_ChromosomeLength
            // 
            this.txt_ChromosomeLength.Location = new System.Drawing.Point(139, 64);
            this.txt_ChromosomeLength.Name = "txt_ChromosomeLength";
            this.txt_ChromosomeLength.Size = new System.Drawing.Size(100, 20);
            this.txt_ChromosomeLength.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // lbl_CrossoverRate
            // 
            this.lbl_CrossoverRate.AutoSize = true;
            this.lbl_CrossoverRate.Location = new System.Drawing.Point(30, 94);
            this.lbl_CrossoverRate.Name = "lbl_CrossoverRate";
            this.lbl_CrossoverRate.Size = new System.Drawing.Size(80, 13);
            this.lbl_CrossoverRate.TabIndex = 6;
            this.lbl_CrossoverRate.Text = "Crossover Rate";
            // 
            // lbl_MutationRate
            // 
            this.lbl_MutationRate.AutoSize = true;
            this.lbl_MutationRate.Location = new System.Drawing.Point(29, 119);
            this.lbl_MutationRate.Name = "lbl_MutationRate";
            this.lbl_MutationRate.Size = new System.Drawing.Size(74, 13);
            this.lbl_MutationRate.TabIndex = 7;
            this.lbl_MutationRate.Text = "Mutation Rate";
            // 
            // txt_CrossoverRate
            // 
            this.txt_CrossoverRate.Location = new System.Drawing.Point(139, 90);
            this.txt_CrossoverRate.Name = "txt_CrossoverRate";
            this.txt_CrossoverRate.Size = new System.Drawing.Size(100, 20);
            this.txt_CrossoverRate.TabIndex = 8;
            // 
            // txt_MutationRate
            // 
            this.txt_MutationRate.Location = new System.Drawing.Point(139, 116);
            this.txt_MutationRate.Name = "txt_MutationRate";
            this.txt_MutationRate.Size = new System.Drawing.Size(100, 20);
            this.txt_MutationRate.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_MutationRate);
            this.Controls.Add(this.txt_CrossoverRate);
            this.Controls.Add(this.lbl_MutationRate);
            this.Controls.Add(this.lbl_CrossoverRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ChromosomeLength);
            this.Controls.Add(this.txt_PopSize);
            this.Controls.Add(this.lbl_ChromosomeLength);
            this.Controls.Add(this.lbl_PopulationSize);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_PopulationSize;
        private System.Windows.Forms.Label lbl_ChromosomeLength;
        private System.Windows.Forms.TextBox txt_PopSize;
        private System.Windows.Forms.TextBox txt_ChromosomeLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CrossoverRate;
        private System.Windows.Forms.Label lbl_MutationRate;
        private System.Windows.Forms.TextBox txt_CrossoverRate;
        private System.Windows.Forms.TextBox txt_MutationRate;
    }
}

