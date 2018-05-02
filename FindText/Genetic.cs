using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindText {
    public class Genetic {

        public string Goal { get; private set; }
        public char[,] Population { get; private set; }
        public int TPopulation { get; private set; }
        public int TGeneration { get; private set; }
        public int Mutation { get; private set; }
        public int GLength { get; private set; }
        public double[] Fitness { get; private set; }
        public int Parents { get; private set; }


        public Genetic(string Goal, int TPopulation, int Mutation) {
            this.Goal = Goal;
            this.TPopulation = TPopulation;
            this.Mutation = Mutation;
            Parents = (40 * TPopulation) / 100;

            GLength = Goal.Length;
            TGeneration = 0;
            Population = new char[TPopulation, GLength];
            Fitness = new double[TPopulation];
        }

        public void Populate() {
            Random rnd = new Random();

            for (int x = 0; x < TPopulation; x++){
                for(int y = 0; y < GLength; y++) {
                    Population[x,y] = Convert.ToChar(rnd.Next(32, 128));
                }
            }

        }

        public void Repopulate() {
            char[,] Temp = new char[Parents, GLength];

            for (int x = 0; x < Parents; x++) {
                for (int y = 0; y < GLength; y++) {
                    Temp[x, y] = Population[TPopulation - 1 - x, y];
                }
            }
            Random rnd = new Random();
            for (int x = 0; x < TPopulation; x++) {
                for(int y = 0; y < GLength; y++) {
                    
                    int aux = rnd.Next(0, Parents);

                    Population[x, y] = Temp[aux, y];

                    int mut = rnd.Next(1, 100);
                    if (mut <= Mutation) {
                        int TemporaryLetter = Convert.ToInt32(Population[x, y]);
                        if (TemporaryLetter == 122) {
                            TemporaryLetter--;
                        } else {
                            TemporaryLetter++;
                        }

                        Population[x, y] = Convert.ToChar(TemporaryLetter);
                    }
                }
            }
            TGeneration++;
        }

        public void CalculateFitness() {
            int z;

            for (int x = 0; x < TPopulation; x++) {
                z = 0;
                for (int y = 0; y < GLength; y++) {
                    if (Population[x, y] == Goal[y]) {
                        z++;
                    }
                }
                if (z != 0) {
                    double Temp = (z * 100) / GLength;

                    Fitness[x] = Math.Round(Temp, 2);
                } else {
                    Fitness[x] = 0;
                }


            }

            Ordenate();
        }

        private void Ordenate() {
            int min;
            double aux;
            char[] aux2 = new char[GLength];

            for(int x = 0; x < TPopulation-1; x++) {
                min = x;
                for(int y = x+1; y < TPopulation; y++) {
                    if(Fitness[y] < Fitness[min]) {
                        min = y;
                    }
                }

                if(min != x) {
                    aux = Fitness[min];
                    Fitness[min] = Fitness[x];
                    Fitness[x] = aux;


                    for (int z = 0; z < GLength; z++) {
                        aux2[z] = Population[min, z];
                        Population[min, z] = Population[x, z];
                        Population[x, z] = aux2[z];
                    }
                }
            }
        }

        public bool isFinished() {
            char[] Temp = new char[GLength];
            for(int x = 0; x < GLength; x++) {
                Temp[x] = Population[TPopulation - 1, x];
            }
            string TempString = new string(Temp);

            return TempString == Goal ? true : false;
        }


    }
}
