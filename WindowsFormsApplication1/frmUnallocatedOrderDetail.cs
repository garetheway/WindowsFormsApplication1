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
    public partial class frmUnallocatedOrderDetail : Form
    {
        // Variable that tracks what work order record we are accessing in detailed view.
        public int workorderrecordindex;

        // Initiates our table adapter when the form loads.
        private void frmUnallocatedOrderDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduleDatabaseDataSet.WorkOrders' table. You can move, or remove it, as needed.
            this.workOrdersTableAdapter.Fill(this.scheduleDatabaseDataSet.WorkOrders);
        }

        public frmUnallocatedOrderDetail(Population pop, WorkOrderCollection workOrders, int workorderindex)
        {
            InitializeComponent();
            // Set the class variable to be equal to the variable passed relating to what work order is being viewed.
            workorderrecordindex = workorderindex;

            // Set the controls on the form to have the information for the unallocated work order we are accessing.
            txtWorkOrderID.Text = workOrders.unallocated[workorderindex].WorkOrderID;
            txtProduct.Text = workOrders.unallocated[workorderindex].Product;
            txtCustomer.Text = workOrders.unallocated[workorderindex].Customer;
            txtDueDate.Value = workOrders.unallocated[workorderindex].DueDate;
            txtQuantity.Text = workOrders.unallocated[workorderindex].Quantity.ToString();
            // If the status is 'READY' tick, the box!
            if (workOrders.unallocated[workorderindex].Status == "READY")
            {
                chckReadySchedule.Checked = true;
            }
            else
            {
                chckReadySchedule.Checked = false;
            }
        }

        // Action to take when the update button on the form is pressed.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Convert our string to an integer to update back to the database and locating the record.
            int workorderid = int.Parse(txtWorkOrderID.Text);
            // Convert our string to an integer to update back to the database.
            int quantity = int.Parse(txtQuantity.Text);

            // Locate the row we want to update.
            ScheduleDatabaseDataSet.WorkOrdersRow workorderrow;
            workorderrow = scheduleDatabaseDataSet.WorkOrders.FindByWorkOrderID(workorderid);

            // Assign the new values to the desired column.
            workorderrow.WorkOrderID = workorderid;
            workorderrow.Product = txtProduct.Text;
            workorderrow.Customer = txtCustomer.Text;
            workorderrow.DueDate = txtDueDate.Value;
            workorderrow.Quantity = quantity;
            if (chckReadySchedule.Checked == true)
            {
                workorderrow.Status = "READY";
            }
            else
            {
                workorderrow.Status = "Unallocated";
            }

            // Save the updated row to the database. 
            this.workOrdersTableAdapter.Update(this.scheduleDatabaseDataSet.WorkOrders);
            MessageBox.Show("Work Order Updated! Please close this window for the changes to reflect on the schedule.");
        }
    }
}
