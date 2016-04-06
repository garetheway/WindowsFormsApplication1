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
        public string Status;
        public string Notes;

        public WorkOrder(string WorkOrderID, string Product, string Customer, DateTime DueDate, DateTime CompletionDate, int Quantity, string Status, string Notes)
        {
            this.WorkOrderID = WorkOrderID;
            this.Product = Product;
            this.Customer = Customer;
            this.DueDate = DueDate;
            this.CompletionDate = CompletionDate;
            this.Quantity = Quantity;
            this.Status = Status;
            this.Notes = Notes;
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
