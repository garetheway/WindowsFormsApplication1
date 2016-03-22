using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class WorkOrderCollection
    {
        public List<WorkOrder> orders = new List<WorkOrder>();
        public List<WorkOrder> unallocated = new List<WorkOrder>();


        public void AssociateWorkOrders()
        {
            // Set up the connection to the database.
            ScheduleDatabaseDataSet ScheduleDatabaseDataSet = new ScheduleDatabaseDataSet();
            ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter WorkOrdersTableAdapter =
                new ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter();
            WorkOrdersTableAdapter.Fill(ScheduleDatabaseDataSet.WorkOrders);
            DataTable dt = WorkOrdersTableAdapter.GetUnallocatedOrders();

            // Staticly create work orders. Let's get rid of this soon!
            orders.Add(new WorkOrder("100", "ProductA", "Joe", new DateTime(2016, 3, 18), 2000, "HOLD"));
            orders.Add(new WorkOrder("101", "ProductC", "John", new DateTime(2016, 3, 14), 5000, "HOLD"));
            orders.Add(new WorkOrder("102", "ProductC", "George", new DateTime(2016, 3, 13), 3000, ""));
            orders.Add(new WorkOrder("103", "ProductC", "Josh", new DateTime(2016, 3, 15), 10000, ""));
            orders.Add(new WorkOrder("104", "ProductB", "Gareth", new DateTime(2016, 3, 13), 5000, "KITTING"));
            orders.Add(new WorkOrder("105", "ProductA", "David", new DateTime(2016, 3, 14), 3000, "WIP"));
            orders.Add(new WorkOrder("106", "ProductB", "Tom", new DateTime(2016, 3, 20), 7000, ""));
            orders.Add(new WorkOrder("107", "ProductB", "Eric", new DateTime(2016, 3, 18), 3000, ""));
            orders.Add(new WorkOrder("108", "ProductA", "Ross", new DateTime(2016, 3, 29), 10000, "KITTING"));
            orders.Add(new WorkOrder("109", "ProductD", "Lewis", new DateTime(2016, 3, 25), 20000, "HOLD"));
            
            // Create work orders from the database.
                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    string workorderid = dt.Rows[index]["WorkOrderID"].ToString();
                    string product = dt.Rows[index]["Product"].ToString();
                    string customer = dt.Rows[index]["Customer"].ToString();
                    int quantity = int.Parse(dt.Rows[index]["Quantity"].ToString());
                    string duedate = dt.Rows[index]["DueDate"].ToString();
                    string status = dt.Rows[index]["Status"].ToString();
                    DateTime duedatetime = Convert.ToDateTime(duedate);

                    if (status == "Unallocated")
                    {
                        unallocated.Add(new WorkOrder(workorderid, product, customer, duedatetime, quantity, status));
                    }
                    else
                    {
                        orders.Add(new WorkOrder(workorderid, product, customer, duedatetime, quantity, status));
                    }
                }
        }
    }
}
