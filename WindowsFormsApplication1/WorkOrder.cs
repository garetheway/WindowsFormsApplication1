using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class WorkOrder
    {
        public string WorkOrderID;
        public string Product;
        public string Customer;
        public DateTime DueDate;
        public DateTime CompletionDate;
        public int Quantity;

        public WorkOrder(string WorkOrderID, string Product, string Customer, DateTime DueDate, int Quantity)
        {
            this.WorkOrderID = WorkOrderID;
            this.Product = Product;
            this.Customer = Customer;
            this.DueDate = DueDate;
            this.Quantity = Quantity;
        }

        public void PrintOrder()
        {
            Console.Out.WriteLine(WorkOrderID);
            Console.Out.WriteLine(Product);
            Console.Out.WriteLine(Customer);
            Console.Out.WriteLine(DueDate);
            Console.Out.WriteLine(Quantity);
            Console.Out.WriteLine("\n");
        }
    }



}
