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
            this.txt_PopSize = new System.Windows.Forms.TextBox();
            this.txt_ChromosomeLength = new System.Windows.Forms.TextBox();
            this.lbl_PopSize = new System.Windows.Forms.Label();
            this.lbl_ChromosomeLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(154, 137);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 0;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // txt_PopSize
            // 
            this.txt_PopSize.Location = new System.Drawing.Point(119, 37);
            this.txt_PopSize.Name = "txt_PopSize";
            this.txt_PopSize.Size = new System.Drawing.Size(100, 20);
            this.txt_PopSize.TabIndex = 1;
            // 
            // txt_ChromosomeLength
            // 
            this.txt_ChromosomeLength.Location = new System.Drawing.Point(119, 64);
            this.txt_ChromosomeLength.Name = "txt_ChromosomeLength";
            this.txt_ChromosomeLength.Size = new System.Drawing.Size(100, 20);
            this.txt_ChromosomeLength.TabIndex = 2;
            // 
            // lbl_PopSize
            // 
            this.lbl_PopSize.AutoSize = true;
            this.lbl_PopSize.Location = new System.Drawing.Point(13, 37);
            this.lbl_PopSize.Name = "lbl_PopSize";
            this.lbl_PopSize.Size = new System.Drawing.Size(80, 13);
            this.lbl_PopSize.TabIndex = 3;
            this.lbl_PopSize.Text = "Population Size";
            // 
            // lbl_ChromosomeLength
            // 
            this.lbl_ChromosomeLength.AutoSize = true;
            this.lbl_ChromosomeLength.Location = new System.Drawing.Point(13, 64);
            this.lbl_ChromosomeLength.Name = "lbl_ChromosomeLength";
            this.lbl_ChromosomeLength.Size = new System.Drawing.Size(104, 13);
            this.lbl_ChromosomeLength.TabIndex = 4;
            this.lbl_ChromosomeLength.Text = "Chromosome Length";
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbl_ChromosomeLength);
            this.Controls.Add(this.lbl_PopSize);
            this.Controls.Add(this.txt_ChromosomeLength);
            this.Controls.Add(this.txt_PopSize);
            this.Controls.Add(this.btn_Run);
            this.Name = "Frm1";
            this.Text = "Genetic Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.TextBox txt_PopSize;
        private System.Windows.Forms.TextBox txt_ChromosomeLength;
        private System.Windows.Forms.Label lbl_PopSize;
        private System.Windows.Forms.Label lbl_ChromosomeLength;
    }
}

