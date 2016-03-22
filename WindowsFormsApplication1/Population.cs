using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Population
    {
        static int popsize = 20;
        Fitness fitcalc = new Fitness();
        List<Individual> individuals = new List<Individual>(popsize);
        static int generation;
        public List<int> ProdLine1 = new List<int>();
        public List<int> ProdLine2 = new List<int>();

        public Population()
        {
            generation++;
        }

        // Generates our initial population.
        public void GenerateRandomPopulation()
        {
            // These lines add the individual object to the list of individuals.
            individuals.Add(new Individual(new int[] {2, 1, 9, 3, 5, 4, 7, 6, 8, 0}));
            individuals.Add(new Individual(new int[] {0, 2, 1, 4, 5, 9, 8, 7, 3, 6}));
            individuals.Add(new Individual(new int[] {5, 2, 3, 4, 1, 8, 7, 6, 0, 9}));
            individuals.Add(new Individual(new int[] {9, 2, 4, 7, 1, 5, 8, 0, 3, 6}));
            individuals.Add(new Individual(new int[] {9, 1, 2, 8, 0, 7, 3, 4, 6, 5}));
            individuals.Add(new Individual(new int[] {2, 1, 3, 9, 4, 5, 6, 8, 7, 0}));
            individuals.Add(new Individual(new int[] {3, 2, 1, 4, 5, 7, 6, 9, 8, 0}));
            individuals.Add(new Individual(new int[] {5, 2, 3, 4, 1, 8, 7, 6, 0, 9}));
            individuals.Add(new Individual(new int[] {9, 2, 4, 7, 1, 5, 8, 0, 3, 6}));
            individuals.Add(new Individual(new int[] {9, 1, 2, 8, 0, 7, 3, 4, 6, 5}));
            individuals.Add(new Individual(new int[] {2, 1, 9, 3, 5, 4, 7, 6, 8, 0}));
            individuals.Add(new Individual(new int[] {0, 2, 1, 4, 5, 9, 8, 7, 3, 6}));
            individuals.Add(new Individual(new int[] {5, 2, 3, 4, 1, 8, 7, 6, 0, 9}));
            individuals.Add(new Individual(new int[] {9, 2, 4, 7, 1, 5, 8, 0, 3, 6}));
            individuals.Add(new Individual(new int[] {9, 1, 2, 8, 0, 7, 3, 4, 6, 5}));
            individuals.Add(new Individual(new int[] {2, 1, 9, 3, 5, 4, 7, 6, 8, 0}));
            individuals.Add(new Individual(new int[] {0, 2, 1, 4, 5, 9, 8, 7, 3, 6}));
            individuals.Add(new Individual(new int[] {5, 2, 3, 4, 1, 8, 7, 6, 0, 9}));
            individuals.Add(new Individual(new int[] {0, 2, 4, 6, 8, 1, 3, 5, 7, 9}));
            individuals.Add(new Individual(new int[] {0, 9, 8, 7, 6, 5, 4, 3, 2, 1}));
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
            Console.WriteLine(Environment.NewLine);
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
            }
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

