﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApplication1
{
    public class Algorithm
    {
        // Generate our random number.
        private static readonly Random RandomGenerator = new Random();
        // Threshold for crossover. If above this, one action occurs if not something else.
        private static readonly int _crossoverthresehold = 13;
        // Probability for an individual to mutate.
        private static readonly double _mutationThresehold = 0.27;
        // Variable to dictate if the fittest individual should be carried forward to the next generation. 
        // If set to true, the variable is carried forward.
        private static bool usingElitism = false;
        // How many individuals should be carried forward.
        private static int _loopcounter = 20;
        
        // Function that is used to evolve population by taking in the old population and applying GA operators.
        public static Population EvolvePopulation(Population oldPopulation)
        {
            // Create an instance of population that will be used to create the next generation.
            var newPopulation = new Population();

            // Function where if elitism has been set, 4 new individuals are used instead of 5.
            if (usingElitism)
            {
                _loopcounter = 19;
                // Add the fittest individual from the old generation to the new population.
                newPopulation.SaveIndividual(oldPopulation.GetFittest());
            }

            for (var i = 0; i < _loopcounter; i++)
            {
                //Select two individuals to use as the parents.
                var parents = SelectedParents(oldPopulation.getIndividuals());

                //Apply crossover to the two parents in order to return a child.
                var child = Applycrossover(parents[0], parents[1]);

                //Apply Mutation to the child. 
                newPopulation.SaveIndividual(ApplyMutation(child));
            }

            return newPopulation;
        }

        // Function to select the two parents from the old population.
        private static List<Individual> SelectedParents(List<Individual> individuals)
        {
            var rand = RandomGenerator.Next(19);
            var randa = RandomGenerator.Next(19);
            individuals.Sort();
            // Check random number to see which random individuals should be selected as the parents.
            if (rand < _crossoverthresehold)
            {
                return new List<Individual> {individuals[0], individuals[1]};
            }

            return new List<Individual> {individuals[rand], individuals[randa]};
        }

        // Function that applies crossover to the two parents in order to create a child.
        private static Individual Applycrossover(Individual parent1, Individual parent2)
        {
            // Delcare our child.
            var child = new int[10];
            // Generate a number between 1 and 10.
            var crossrand = RandomGenerator.Next(10);
            // Copies genes from the first parent, to the child, starting at position 'rand'. 
            Array.Copy(parent1.getGenes(), child, crossrand);

            // Set index to be equal to our last figure of 'rand'.
            var index = crossrand;

            // Check to see if the elements in parent2 are in the child, if not, add it.
            foreach (var element in parent2.getGenes())
            {
                if (child.Contains(element) == false)
                {
                    child[index] = element;
                    index++;
                }
            }
            return new Individual(child);
        }

        // Apply mutation to the child.
        private static Individual ApplyMutation(Individual ind)
        {
            // Create a random number between 0.0 and 1.0 that is the active probability.
            var mutationprobablily = RandomGenerator.NextDouble();


            if (mutationprobablily < _mutationThresehold)
            {

                var rand1 = RandomGenerator.Next(10);
                var rand2 = RandomGenerator.Next(10);
 
                var element1 = ind.getGene(rand1);
                var element2 = ind.getGene(rand2);
                ind.setGene(rand1, element2);
                ind.setGene(rand2, element1);
   
            }

            return ind;
        }
    }
}