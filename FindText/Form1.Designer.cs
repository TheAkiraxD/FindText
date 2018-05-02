namespace FindText {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.LblBestPhrase = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTGeneration = new System.Windows.Forms.Label();
            this.LblAFitness = new System.Windows.Forms.Label();
            this.LblTPopulation = new System.Windows.Forms.Label();
            this.LblMutation = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblGoal = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Best phrase:";
            // 
            // LblBestPhrase
            // 
            this.LblBestPhrase.AutoSize = true;
            this.LblBestPhrase.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBestPhrase.Location = new System.Drawing.Point(34, 117);
            this.LblBestPhrase.Name = "LblBestPhrase";
            this.LblBestPhrase.Size = new System.Drawing.Size(383, 59);
            this.LblBestPhrase.TabIndex = 1;
            this.LblBestPhrase.Text = "To be or not to be.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total generations:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average fitness:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total population:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mutation rate:";
            // 
            // LblTGeneration
            // 
            this.LblTGeneration.AutoSize = true;
            this.LblTGeneration.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTGeneration.Location = new System.Drawing.Point(194, 234);
            this.LblTGeneration.Name = "LblTGeneration";
            this.LblTGeneration.Size = new System.Drawing.Size(40, 23);
            this.LblTGeneration.TabIndex = 6;
            this.LblTGeneration.Text = "100";
            // 
            // LblAFitness
            // 
            this.LblAFitness.AutoSize = true;
            this.LblAFitness.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAFitness.Location = new System.Drawing.Point(194, 261);
            this.LblAFitness.Name = "LblAFitness";
            this.LblAFitness.Size = new System.Drawing.Size(40, 23);
            this.LblAFitness.TabIndex = 7;
            this.LblAFitness.Text = "100";
            // 
            // LblTPopulation
            // 
            this.LblTPopulation.AutoSize = true;
            this.LblTPopulation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTPopulation.Location = new System.Drawing.Point(194, 288);
            this.LblTPopulation.Name = "LblTPopulation";
            this.LblTPopulation.Size = new System.Drawing.Size(40, 23);
            this.LblTPopulation.TabIndex = 8;
            this.LblTPopulation.Text = "100";
            // 
            // LblMutation
            // 
            this.LblMutation.AutoSize = true;
            this.LblMutation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMutation.Location = new System.Drawing.Point(194, 315);
            this.LblMutation.Name = "LblMutation";
            this.LblMutation.Size = new System.Drawing.Size(40, 23);
            this.LblMutation.TabIndex = 9;
            this.LblMutation.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Goal:";
            // 
            // LblGoal
            // 
            this.LblGoal.AutoSize = true;
            this.LblGoal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGoal.Location = new System.Drawing.Point(40, 424);
            this.LblGoal.Name = "LblGoal";
            this.LblGoal.Size = new System.Drawing.Size(127, 19);
            this.LblGoal.TabIndex = 11;
            this.LblGoal.Text = "To be or not to be.";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ColumnWidth = 210;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(500, 12);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1004, 560);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 589);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LblGoal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblMutation);
            this.Controls.Add(this.LblTPopulation);
            this.Controls.Add(this.LblAFitness);
            this.Controls.Add(this.LblTGeneration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblBestPhrase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblBestPhrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblTGeneration;
        private System.Windows.Forms.Label LblAFitness;
        private System.Windows.Forms.Label LblTPopulation;
        private System.Windows.Forms.Label LblMutation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblGoal;
        private System.Windows.Forms.ListBox listBox1;
    }
}

