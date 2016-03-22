using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Parameters
            int numberOfGens= 250;


            //Initial Pop setup
            var workOrders = new WorkOrderCollection();
            workOrders.AssociateWorkOrders();
            var pop = new Population();
            

            pop.GenerateRandomPopulation(workOrders.orders);
            
            pop.EvaluateFitness(workOrders.orders);
            //pop.PrintPopulation();


            //Evolution
            for (int i = 0; i < numberOfGens; i++)
			{
                pop = Algorithm.EvolvePopulation(pop);
                pop.EvaluateFitness(workOrders.orders);
                //pop.PrintPopulation();
            }
            

            pop.AllocateLines(workOrders.orders);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(pop, workOrders));

    
        }
    }
}
