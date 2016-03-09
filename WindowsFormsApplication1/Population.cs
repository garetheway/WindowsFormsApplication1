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

        public Population()
        {
            generation++;
        }

        // Generates our initial population.
        public void GenerateRandomPopulation()
        {
            // These lines add the individual object to the list of individuals.
            individuals.Add(new Individual(new int[] { 2, 1, 9, 3, 5, 4, 7, 6, 8, 0 }));
            individuals.Add(new Individual(new int[] { 0, 2, 1, 4, 5, 9, 8, 7 , 3, 6}));
            individuals.Add(new Individual(new int[] { 5, 2, 3, 4, 1, 8, 7 , 6, 0, 9}));
            individuals.Add(new Individual(new int[] { 9, 2, 4, 7, 1, 5, 8, 0, 3, 6}));
            individuals.Add(new Individual(new int[] { 9, 1, 2, 8, 0, 7, 3, 4, 6, 5}));
            individuals.Add(new Individual(new int[] { 2, 1, 3, 9, 4, 5, 6, 8, 7, 0 }));
            individuals.Add(new Individual(new int[] { 3, 2, 1, 4, 5, 7, 6, 9, 8, 0 }));
            individuals.Add(new Individual(new int[] { 5, 2, 3, 4, 1, 8, 7, 6, 0, 9 }));
            individuals.Add(new Individual(new int[] { 9, 2, 4, 7, 1, 5, 8, 0, 3, 6 }));
            individuals.Add(new Individual(new int[] { 9, 1, 2, 8, 0, 7, 3, 4, 6, 5 }));
            individuals.Add(new Individual(new int[] { 2, 1, 9, 3, 5, 4, 7, 6, 8, 0 }));
            individuals.Add(new Individual(new int[] { 0, 2, 1, 4, 5, 9, 8, 7, 3, 6 }));
            individuals.Add(new Individual(new int[] { 5, 2, 3, 4, 1, 8, 7, 6, 0, 9 }));
            individuals.Add(new Individual(new int[] { 9, 2, 4, 7, 1, 5, 8, 0, 3, 6 }));
            individuals.Add(new Individual(new int[] { 9, 1, 2, 8, 0, 7, 3, 4, 6, 5 }));
            individuals.Add(new Individual(new int[] { 2, 1, 9, 3, 5, 4, 7, 6, 8, 0 }));
            individuals.Add(new Individual(new int[] { 0, 2, 1, 4, 5, 9, 8, 7, 3, 6 }));
            individuals.Add(new Individual(new int[] { 5, 2, 3, 4, 1, 8, 7, 6, 0, 9 }));
            individuals.Add(new Individual(new int[] { 0, 2, 4, 6, 8, 1, 3, 5, 7, 9}));
            individuals.Add(new Individual(new int[] { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 }));
        }

        // Print the list of individuals each generation along with the fitness rating and the generation.
        public void PrintPopulation()
        {
            //for (int index = 0; index < individuals.Count; index++)
            //{
                //var ind = individuals[index];
                //for (int i = 0; i < ind.getLength(); i++)
                //{
                 //   Console.Write(ind.getGene(i));
                //}

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

        public void PrintWorkOrders(List<WorkOrder> workOrders)
        {
            individuals.Sort();

            Individual fittestIndividual = individuals.ElementAt(0);

            for (int i = 0; i < fittestIndividual.getLength(); i++)
            {
               // workOrders[(fittestIndividual.getGene(i) - 1)].PrintOrder();
            }

            Console.Out.WriteLine("Final Fitness: " + fittestIndividual.getFitness());

            
            for (int k = 0; k < fittestIndividual.getLength(); k++)
            {
                Console.Out.WriteLine(workOrders[fittestIndividual.getGene(k)].WorkOrderID + " - " +
                                      workOrders[fittestIndividual.getGene(k)].DueDate + " COMP: " + workOrders[fittestIndividual.getGene(k)].CompletionDate + (workOrders[fittestIndividual.getGene(k)].DueDate.Date >= workOrders[fittestIndividual.getGene(k)].CompletionDate.Date));
            }


        }

        public void EvaluateFitness(List<WorkOrder> workOrders)
        {
            foreach (var individual in individuals)
            {
                individual.setFitness(fitcalc.CalculateFitness(individual, workOrders));
            }
        }
        
        public List<Individual> getIndividuals(){
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

