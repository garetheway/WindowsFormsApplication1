using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Population
    {
        static int popsize = 50;
        Fitness fitcalc = new Fitness();
        Individual ind = new Individual();
        private static readonly Random RandomGenerator = new Random();
        public List<Individual> individuals = new List<Individual>(popsize);
        static int generation;
        public List<int> ProdLine1 = new List<int>();
        public List<int> ProdLine2 = new List<int>();

        public Population()
        {
            generation++;
        }

        // Generates our initial population.
        public void GenerateRandomPopulation(List<WorkOrder> workOrders)
        {
            // Calculate the number of orders that exist that need to be scheduled.
            int workordernum = workOrders.Count;
            // Set the length of an individual to be equal to the number of orders to schedule.
            ind.setLength(workordernum);
            // Declare an integer array to hold the possible values that make up our permutation.
            int[] numbers = new int[ind.getLength()];
            // Fill the integer array with the values to that are used within the permutation.
            for (int num = 0; num < numbers.Length; num++)
            {
                numbers[num] = num;
            }
            // Using the values generated, randomly distribute them within an array to use as an individual. 
            for (int k = 0; k < popsize; k++)
            {
                int[] genes = numbers.OrderBy(x => RandomGenerator.Next()).ToArray();
                individuals.Add(new Individual(genes));
            }
        }

        // Print the list of individuals each generation along with the fitness rating and the generation.
        public void PrintPopulation()
        {
            individuals.Sort();
            Individual fittestIndividual = individuals.ElementAt(0);
            for (int i = 0; i < fittestIndividual.getLength(); i++)
            {
                Console.Write(fittestIndividual.getGene(i));
            }
            Console.Write("   Fitness: " + fittestIndividual.getFitness());
            Console.Write("   Gen: " + generation);
            Console.WriteLine(Environment.NewLine);
        }

        // Allocate the fittest individual to seperate production lines.
        public void AllocateLines(List<WorkOrder> workOrders)
        {
            // Determine what is the fittes individual from the last generation and save it.
            individuals.Sort();
            Individual fittestIndividual = individuals.ElementAt(0);

            // Allocate to the production lines on a greedy basis of odd numbers to the first line, even numbers to the second.
            for (int i = 0; i < fittestIndividual.getLength(); i++)
            {
                if (IsOdd(i))
                {
                    ProdLine1.Add(fittestIndividual.getGene(i));
                }
                else
                {
                    ProdLine2.Add(fittestIndividual.getGene(i));
                }
            }

            // Print out the information for the first production line. 
/*            Console.WriteLine(Environment.NewLine);
            Console.Write("LINE 1:" + Environment.NewLine);
            for (int i = 0; i < ProdLine1.Count; i++)
            {
                Console.Write("ID: " + workOrders[ProdLine1[i]].WorkOrderID + " - Completion: " +
                              workOrders[ProdLine1[i]].CompletionDate + Environment.NewLine);
            }

            // Print out the information for the second production line. 
            Console.WriteLine(Environment.NewLine);
            Console.Write("LINE 2:" + Environment.NewLine);
            for (int i = 0; i < ProdLine2.Count; i++)
            {
                Console.Write("ID: " + workOrders[ProdLine2[i]].WorkOrderID + " - Completion: " +
                              workOrders[ProdLine2[i]].CompletionDate + Environment.NewLine);
            }*/
        }

        // Function to calculate if a value is odd. We use this for the greedy algorithm.
        public static bool IsOdd(int value)
        {
            return value%2 != 0;
        }


        public void EvaluateFitness(List<WorkOrder> workOrders)
        {
            foreach (var individual in individuals)
            {
                individual.setFitness(fitcalc.CalculateFitness(individual, workOrders));
            }
        }

        public List<Individual> getIndividuals()
        {
            return individuals;
        }


        public void SaveIndividual(Individual ind)
        {
            individuals.Add(ind);
        }

        public Individual GetFittest()
        {
            individuals.Sort();
            return individuals.ElementAt(0);
        }
    }
}

