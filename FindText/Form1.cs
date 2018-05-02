using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindText {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public void UpdateScreen(Genetic Text) {
            listBox1.Items.Clear();
            char[] temp = new char[Text.GLength];

            for (int x = 0; x < Text.TPopulation; x++) {

                for (int y = 0; y < Text.GLength; y++) {
                    temp[y] = Text.Population[x, y];
                }


                listBox1.Items.Add(new string(temp));
            }

            char[] Temp = new char[Text.GLength];
            for (int x = 0; x < Text.GLength; x++) {
                Temp[x] = Text.Population[Text.TPopulation - 1, x];
            }
            LblBestPhrase.Text = new string(Temp);
            LblTGeneration.Text = Text.TGeneration.ToString();
            LblAFitness.Text = Text.Fitness[Text.TPopulation - 1].ToString();
            LblTPopulation.Text = Text.TPopulation.ToString();
            LblMutation.Text = Text.Mutation.ToString() + "%";
        }

        private void Form1_Load(object sender, EventArgs e) {
            Genetic Text = new Genetic("To be or not to be.", 300, 10);
        
            Text.Populate();
            Text.CalculateFitness();
            UpdateScreen(Text);

            object _lock = new object();
            Task t = Task.Run(()=> {
                while (!Text.isFinished()) {
                    lock (_lock) {
                        Text.Repopulate();
                    }
                    lock (_lock) {
                        Text.CalculateFitness();
                    }
                    Invoke(new Action(() => {
                        UpdateScreen(Text);
                    }));
                    Thread.Sleep(100);
                }
            });

        }

    }
}
