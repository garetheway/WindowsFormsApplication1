using System;

namespace WindowsFormsApplication1
{
    public class Individual : IComparable
    {
        private static readonly int genelength = 10;
        private float fitness;
        private readonly int[] genes = new int[genelength];


        public Individual(int[] genes)
        {
            fitness = 0;
            this.genes = genes;
        }

        public Individual()
        {
            fitness = 0;
        }

        public int CompareTo(object individual)
        {
            var indv = (Individual) individual;
            if (getFitness() > indv.getFitness())
            {
                return -1;
            }

            if (getFitness() == indv.getFitness())
            {
                return 0;
            }

            return 1;
        }

        public int getGene(int index)
        {
            return genes[index];
        }

        public void setGene(int index, int value)
        {
            genes[index] = value;
        }

        public int getLength()
        {
            return genelength;
        }

        public void setFitness(float setFit)
        {
            fitness = setFit;
        }

        public float getFitness()
        {
            return fitness;
        }

        public int[] getGenes()
        {
            return genes;
        }
    }
}