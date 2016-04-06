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
        public List<WorkOrder> archived = new List<WorkOrder>();

        // Function to populate the 'orders' list.
        public void AssociateWorkOrders()
        {
            // Set up the connection to the database.
            ScheduleDatabaseDataSet ScheduleDatabaseDataSet = new ScheduleDatabaseDataSet();
            ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter WorkOrdersTableAdapter =
                new ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter();
            WorkOrdersTableAdapter.Fill(ScheduleDatabaseDataSet.WorkOrders);
            DataTable onu = WorkOrdersTableAdapter.GetOrdersNotUnallocated();

            // Create objects of work orders from the database.
            for (int index = 0; index < onu.Rows.Count; index++)
            {
                string workorderid = onu.Rows[index]["WorkOrderID"].ToString();
                string product = onu.Rows[index]["Product"].ToString();
                string customer = onu.Rows[index]["Customer"].ToString();
                int quantity = int.Parse(onu.Rows[index]["Quantity"].ToString());
                string duedate = onu.Rows[index]["DueDate"].ToString();
                string completiondate = onu.Rows[index]["CompletionDate"].ToString();
                string status = onu.Rows[index]["Status"].ToString();
                string notes = onu.Rows[index]["Notes"].ToString();
                DateTime duedatetime = Convert.ToDateTime(duedate);
                DateTime completiondatetime = Convert.ToDateTime(completiondate);
                orders.Add(new WorkOrder(workorderid, product, customer, duedatetime, completiondatetime, quantity, status, notes));
            }
        }

        // Function to populate the 'unallocated orders' list.
        public void AssociateUnallocatedOrders()
        {
            ScheduleDatabaseDataSet ScheduleDatabaseDataSet = new ScheduleDatabaseDataSet();
            ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter WorkOrdersTableAdapter =
                new ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter();
            WorkOrdersTableAdapter.Fill(ScheduleDatabaseDataSet.WorkOrders);
            DataTable ouo = WorkOrdersTableAdapter.GetUnallocatedOrders();

            // Create objects of work orders from the database.
            for (int index = 0; index < ouo.Rows.Count; index++)
            {
                string workorderid = ouo.Rows[index]["WorkOrderID"].ToString();
                string product = ouo.Rows[index]["Product"].ToString();
                string customer = ouo.Rows[index]["Customer"].ToString();
                int quantity = int.Parse(ouo.Rows[index]["Quantity"].ToString());
                string duedate = ouo.Rows[index]["DueDate"].ToString();
                string status = ouo.Rows[index]["Status"].ToString();
                string notes = ouo.Rows[index]["Notes"].ToString();
                DateTime duedatetime = Convert.ToDateTime(duedate);
                DateTime completiondatetime = DateTime.Now;
                unallocated.Add(new WorkOrder(workorderid, product, customer, duedatetime, completiondatetime, quantity, status, notes));
            }  
        }

        public void AssociateArchivedOrders()
        {
            ScheduleDatabaseDataSet ScheduleDatabaseDataSet = new ScheduleDatabaseDataSet();
            ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter WorkOrdersTableAdapter =
                new ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter();
            WorkOrdersTableAdapter.Fill(ScheduleDatabaseDataSet.WorkOrders);
            DataTable oa = WorkOrdersTableAdapter.GetArchived();

            // Create objects of work orders from the database.
            for (int index = 0; index < oa.Rows.Count; index++)
            {
                string workorderid = oa.Rows[index]["WorkOrderID"].ToString();
                string product = oa.Rows[index]["Product"].ToString();
                string customer = oa.Rows[index]["Customer"].ToString();
                int quantity = int.Parse(oa.Rows[index]["Quantity"].ToString());
                string duedate = oa.Rows[index]["DueDate"].ToString();
                string status = oa.Rows[index]["Status"].ToString();
                string notes = oa.Rows[index]["Notes"].ToString();
                DateTime duedatetime = Convert.ToDateTime(duedate);
                DateTime completiondatetime = DateTime.Now;
                archived.Add(new WorkOrder(workorderid, product, customer, duedatetime, completiondatetime, quantity, status, notes));
            }
        }

        public int WorkOrderCount()
        {
            return orders.Count();
        }
    }
}
