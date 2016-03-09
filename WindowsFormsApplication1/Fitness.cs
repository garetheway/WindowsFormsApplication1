using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Fitness
    {
        public float CalculateFitness(Individual individual, List<WorkOrder> workOrders)
        {
            // Initialise the fitness rating to 0.
            float fitness = 0;
            // Static rate to indicate how many units can be completed per hour.
            int prodrate = 1000;

            double hours;

            // Initialise 'wodate' to be equal to the duedate of the first work order in the individual.
            // This initiates our completion date to be now, of which we can then build on later.
            DateTime completionDate = DateTime.Now;
            DateTime wodate = workOrders[(individual.getGene(0))].DueDate;
            var min = workOrders.Min(x => x.DueDate);
            var max = workOrders.Max(x => x.DueDate);
            var diff = (max - min).TotalDays/2;
            var mid = min.AddDays(diff);


            for (int i = 0; i < individual.getLength();)
            {
                // This calculates how long the work order will take to run.
                hours = workOrders[individual.getGene(i)].Quantity/prodrate;
                hours = Math.Round(hours);
                completionDate = completionDate.AddHours(hours);
                float daysbefore = (workOrders[individual.getGene(i)].DueDate.Date - completionDate.Date).Days;
                workOrders[(individual.getGene(i))].CompletionDate = completionDate;

                // Scale the fitness based on if the completion date is more than 0 days before the due date.
                if (daysbefore > 0)
                {
                    // Scale the fitness depending on how many days before it is due. If it is completed 1 day before, this increases the fitness compared to it being 
                  // completed 15 days before.
                   fitness += (1 / daysbefore * 1000);
                }
                
                // Scale the fitness based on if the completion date is less than 0 before the due date; meaning it breaks the due date.
                else if (daysbefore < 0)
                {
                    fitness -= 200;
                }
                
                // Scale the fitness based on if the order completion date is the same as the order due date. 
                else if (daysbefore == 0)
                {
                    fitness += 500;
                }

                fitness -= 1 / (i + 1) * (daysbefore * 100); 

                // Smaller the value of 'i' and closer the due date to now, the fitter.
                int individualLength = individual.getLength();
                int halfLength = individualLength / 2;

                if (workOrders[individual.getGene(i)].DueDate.Date == min.Date && i < halfLength)
                {
                    fitness += 2500;
                }
                if (workOrders[individual.getGene(i)].DueDate.Date == min.Date && i >= halfLength)
                {
                    fitness -= 500;
                }
                else if (workOrders[individual.getGene(i)].DueDate.Date < mid.Date && i < halfLength)
                {
                    fitness += 250;
                }
                else if (workOrders[individual.getGene(i)].DueDate.Date < mid.Date && i >= halfLength)
                {
                    fitness -= 300;
                }
                else if (workOrders[individual.getGene(i)].DueDate.Date == max.Date && i == individualLength)
                {
                    fitness += 500;
                }
                else if (workOrders[individual.getGene(i)].DueDate.Date > mid.Date && i < halfLength)
                {
                    fitness -= 500;
                }
                else if (workOrders[individual.getGene(i)].DueDate.Date > mid.Date && i >= halfLength)
                {
                    fitness += 500;
                }

                i++;
            }

            return fitness;
        }
    }
}
