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
            int numberOfGens= 300;


            //Initial Pop setup
            var pop = new Population();
            var workOrders = new WorkOrderCollection();

            pop.GenerateRandomPopulation();
            workOrders.AssociateWorkOrders();
            pop.EvaluateFitness(workOrders.orders);
            pop.PrintPopulation();


            //Evolution
            for (int i = 0; i < numberOfGens; i++)
			{
                pop = Algorithm.EvolvePopulation(pop);
                pop.EvaluateFitness(workOrders.orders);
                pop.PrintPopulation();
            }

            pop.PrintWorkOrders(workOrders.orders);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

    
        }
    }
}
