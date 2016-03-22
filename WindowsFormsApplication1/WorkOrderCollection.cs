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
            DataTable dt = WorkOrdersTableAdapter.GetData();

            // Create objects of work orders from the database.
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

        public int WorkOrderCount()
        {
            return orders.Count();
        }
    }
}
