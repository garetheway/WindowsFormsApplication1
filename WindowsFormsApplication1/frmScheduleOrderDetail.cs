using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters;

namespace WindowsFormsApplication1
{
    public partial class frmScheduleOrderDetail : Form
    {
        // Variable that tracks what work order record we are accessing in detailed view.
        public int workorderrecordindex;

        private void frmScheduleOrderDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduleDatabaseDataSet.WorkOrders' table. You can move, or remove it, as needed.
            this.workOrdersTableAdapter.Fill(this.scheduleDatabaseDataSet.WorkOrders);
        }

        public frmScheduleOrderDetail(Population pop, WorkOrderCollection workOrders, int workorderindex)
        {
            InitializeComponent();
            // Set the class variable to be equal to the variable passed relating to what work order is being viewed.
            workorderrecordindex = workorderindex;

            // Set the controls on the form to have the information for the unallocated work order we are accessing.
            txtWorkOrderID.Text = workOrders.orders[workorderindex].WorkOrderID;
            txtProduct.Text = workOrders.orders[workorderindex].Product;
            txtCustomer.Text = workOrders.orders[workorderindex].Customer;
            txtDueDate.Text = workOrders.orders[workorderindex].DueDate.Date.ToString("dd/MM/yyyy");
            txtQuantity.Text = workOrders.orders[workorderindex].Quantity.ToString();
            txtOrderNotes.Text = workOrders.orders[workorderindex].Notes;

            // Set the combo textbox to reflect the status of what information the database holds.
            if (workOrders.orders[workorderindex].Status == "HOLD")
            {
                cmbStatus.Text = "HOLD";
            }
            else if (workOrders.orders[workorderindex].Status == "SCHED")
            {
                cmbStatus.Text = "SCHED";
            }
            else if (workOrders.orders[workorderindex].Status == "WIP")
            {
                cmbStatus.Text = "WIP";
            }
            else if (workOrders.orders[workorderindex].Status == "KITTING")
            {
                cmbStatus.Text = "KITTING";
            }
        }

        // Action to take when the update button on the form is pressed.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Convert our string to an integer to update back to the database and locating the record.
            int workorderid = int.Parse(txtWorkOrderID.Text);

            // Locate the row we want to update.
            ScheduleDatabaseDataSet.WorkOrdersRow workorderrow;
            workorderrow = scheduleDatabaseDataSet.WorkOrders.FindByWorkOrderID(workorderid);

            // Assign the new values to the desired column.
            workorderrow.WorkOrderID = workorderid;
            workorderrow.Status = cmbStatus.Text;
            workorderrow.Notes = txtOrderNotes.Text;

            // Save the updated row to the database. 
            this.workOrdersTableAdapter.Update(this.scheduleDatabaseDataSet.WorkOrders);
            MessageBox.Show("Work Order Updated! Please close this window for the changes to reflect on the schedule.");
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            // Convert our string to an integer to update back to the database and locating the record.
            int workorderid = int.Parse(txtWorkOrderID.Text);

            // Locate the row we want to update.
            ScheduleDatabaseDataSet.WorkOrdersRow workorderrow;
            workorderrow = scheduleDatabaseDataSet.WorkOrders.FindByWorkOrderID(workorderid);

            workorderrow.Status = "ARCHIVED";

            this.workOrdersTableAdapter.Update(this.scheduleDatabaseDataSet.WorkOrders);
            MessageBox.Show("Work Order Archived!");
        }
    }
}
