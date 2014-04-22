namespace Genetic_Algorithm
{
    partial class Frm1
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
            this.btn_Run = new System.Windows.Forms.Button();
            this.lbl_PopSize = new System.Windows.Forms.Label();
            this.lbl_ChromosomeLength = new System.Windows.Forms.Label();
            this.cmb_Cipher = new System.Windows.Forms.ComboBox();
            this.nud_PopulationSize = new System.Windows.Forms.NumericUpDown();
            this.cmb_Selection = new System.Windows.Forms.ComboBox();
            this.cmb_Mutation = new System.Windows.Forms.ComboBox();
            this.cmb_Crossover = new System.Windows.Forms.ComboBox();
            this.lbl_Selection = new System.Windows.Forms.Label();
            this.lbl_Mutation = new System.Windows.Forms.Label();
            this.lbl_Crossover = new System.Windows.Forms.Label();
            this.lbl_Fitness = new System.Windows.Forms.Label();
            this.cmb_Fitness = new System.Windows.Forms.ComboBox();
            this.nud_Time = new System.Windows.Forms.NumericUpDown();
            this.lbl_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(165, 199);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 0;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // lbl_PopSize
            // 
            this.lbl_PopSize.AutoSize = true;
            this.lbl_PopSize.Location = new System.Drawing.Point(16, 39);
            this.lbl_PopSize.Name = "lbl_PopSize";
            this.lbl_PopSize.Size = new System.Drawing.Size(80, 13);
            this.lbl_PopSize.TabIndex = 3;
            this.lbl_PopSize.Text = "Population Size";
            // 
            // lbl_ChromosomeLength
            // 
            this.lbl_ChromosomeLength.AutoSize = true;
            this.lbl_ChromosomeLength.Location = new System.Drawing.Point(16, 67);
            this.lbl_ChromosomeLength.Name = "lbl_ChromosomeLength";
            this.lbl_ChromosomeLength.Size = new System.Drawing.Size(37, 13);
            this.lbl_ChromosomeLength.TabIndex = 4;
            this.lbl_ChromosomeLength.Text = "Cipher";
            // 
            // cmb_Cipher
            // 
            this.cmb_Cipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cipher.FormattingEnabled = true;
            this.cmb_Cipher.Items.AddRange(new object[] {
            "Substitution",
            "Z408",
            "Z340"});
            this.cmb_Cipher.Location = new System.Drawing.Point(119, 64);
            this.cmb_Cipher.Name = "cmb_Cipher";
            this.cmb_Cipher.Size = new System.Drawing.Size(121, 21);
            this.cmb_Cipher.TabIndex = 5;
            // 
            // nud_PopulationSize
            // 
            this.nud_PopulationSize.Location = new System.Drawing.Point(119, 37);
            this.nud_PopulationSize.Name = "nud_PopulationSize";
            this.nud_PopulationSize.Size = new System.Drawing.Size(120, 20);
            this.nud_PopulationSize.TabIndex = 6;
            this.nud_PopulationSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_Selection
            // 
            this.cmb_Selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Selection.FormattingEnabled = true;
            this.cmb_Selection.Items.AddRange(new object[] {
            "Roulette Wheel",
            "Stochastic Universal",
            "Tournament"});
            this.cmb_Selection.Location = new System.Drawing.Point(119, 118);
            this.cmb_Selection.Name = "cmb_Selection";
            this.cmb_Selection.Size = new System.Drawing.Size(121, 21);
            this.cmb_Selection.TabIndex = 7;
            // 
            // cmb_Mutation
            // 
            this.cmb_Mutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mutation.FormattingEnabled = true;
            this.cmb_Mutation.Items.AddRange(new object[] {
            "Single Allele",
            "Multiple Allele"});
            this.cmb_Mutation.Location = new System.Drawing.Point(119, 145);
            this.cmb_Mutation.Name = "cmb_Mutation";
            this.cmb_Mutation.Size = new System.Drawing.Size(121, 21);
            this.cmb_Mutation.TabIndex = 8;
            // 
            // cmb_Crossover
            // 
            this.cmb_Crossover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Crossover.FormattingEnabled = true;
            this.cmb_Crossover.Items.AddRange(new object[] {
            "Single Point",
            "Dual Point"});
            this.cmb_Crossover.Location = new System.Drawing.Point(119, 172);
            this.cmb_Crossover.Name = "cmb_Crossover";
            this.cmb_Crossover.Size = new System.Drawing.Size(121, 21);
            this.cmb_Crossover.TabIndex = 9;
            // 
            // lbl_Selection
            // 
            this.lbl_Selection.AutoSize = true;
            this.lbl_Selection.Location = new System.Drawing.Point(16, 121);
            this.lbl_Selection.Name = "lbl_Selection";
            this.lbl_Selection.Size = new System.Drawing.Size(51, 13);
            this.lbl_Selection.TabIndex = 10;
            this.lbl_Selection.Text = "Selection";
            // 
            // lbl_Mutation
            // 
            this.lbl_Mutation.AutoSize = true;
            this.lbl_Mutation.Location = new System.Drawing.Point(16, 148);
            this.lbl_Mutation.Name = "lbl_Mutation";
            this.lbl_Mutation.Size = new System.Drawing.Size(48, 13);
            this.lbl_Mutation.TabIndex = 11;
            this.lbl_Mutation.Text = "Mutation";
            // 
            // lbl_Crossover
            // 
            this.lbl_Crossover.AutoSize = true;
            this.lbl_Crossover.Location = new System.Drawing.Point(16, 175);
            this.lbl_Crossover.Name = "lbl_Crossover";
            this.lbl_Crossover.Size = new System.Drawing.Size(54, 13);
            this.lbl_Crossover.TabIndex = 12;
            this.lbl_Crossover.Text = "Crossover";
            // 
            // lbl_Fitness
            // 
            this.lbl_Fitness.AutoSize = true;
            this.lbl_Fitness.Location = new System.Drawing.Point(16, 94);
            this.lbl_Fitness.Name = "lbl_Fitness";
            this.lbl_Fitness.Size = new System.Drawing.Size(40, 13);
            this.lbl_Fitness.TabIndex = 13;
            this.lbl_Fitness.Text = "Fitness";
            // 
            // cmb_Fitness
            // 
            this.cmb_Fitness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Fitness.FormattingEnabled = true;
            this.cmb_Fitness.Items.AddRange(new object[] {
            "N-Gram",
            "Bi-Gram",
            "Tri-Gram",
            "Reduced"});
            this.cmb_Fitness.Location = new System.Drawing.Point(119, 91);
            this.cmb_Fitness.Name = "cmb_Fitness";
            this.cmb_Fitness.Size = new System.Drawing.Size(121, 21);
            this.cmb_Fitness.TabIndex = 14;
            // 
            // nud_Time
            // 
            this.nud_Time.Location = new System.Drawing.Point(119, 11);
            this.nud_Time.Name = "nud_Time";
            this.nud_Time.Size = new System.Drawing.Size(120, 20);
            this.nud_Time.TabIndex = 15;
            this.nud_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(16, 13);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(54, 13);
            this.lbl_time.TabIndex = 16;
            this.lbl_time.Text = "Time Limit";
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.nud_Time);
            this.Controls.Add(this.cmb_Fitness);
            this.Controls.Add(this.lbl_Fitness);
            this.Controls.Add(this.lbl_Crossover);
            this.Controls.Add(this.lbl_Mutation);
            this.Controls.Add(this.lbl_Selection);
            this.Controls.Add(this.cmb_Crossover);
            this.Controls.Add(this.cmb_Mutation);
            this.Controls.Add(this.cmb_Selection);
            this.Controls.Add(this.nud_PopulationSize);
            this.Controls.Add(this.cmb_Cipher);
            this.Controls.Add(this.lbl_ChromosomeLength);
            this.Controls.Add(this.lbl_PopSize);
            this.Controls.Add(this.btn_Run);
            this.Name = "Frm1";
            this.Text = "Genetic Algorithm";
            this.Load += new System.EventHandler(this.Frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_PopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label lbl_PopSize;
        private System.Windows.Forms.Label lbl_ChromosomeLength;
        private System.Windows.Forms.ComboBox cmb_Cipher;
        private System.Windows.Forms.NumericUpDown nud_PopulationSize;
        private System.Windows.Forms.ComboBox cmb_Selection;
        private System.Windows.Forms.ComboBox cmb_Mutation;
        private System.Windows.Forms.ComboBox cmb_Crossover;
        private System.Windows.Forms.Label lbl_Selection;
        private System.Windows.Forms.Label lbl_Mutation;
        private System.Windows.Forms.Label lbl_Crossover;
        private System.Windows.Forms.Label lbl_Fitness;
        private System.Windows.Forms.ComboBox cmb_Fitness;
        private System.Windows.Forms.NumericUpDown nud_Time;
        private System.Windows.Forms.Label lbl_time;
    }
}

