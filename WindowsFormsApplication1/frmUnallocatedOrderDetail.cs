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
        public int workorderrecordindex;
 

        public frmUnallocatedOrderDetail(Population pop, WorkOrderCollection workOrders, int workorderindex)
        {
            InitializeComponent();
            workorderrecordindex = workorderindex;

            txtWorkOrderID.Text = workOrders.unallocated[workorderindex].WorkOrderID;
            txtProduct.Text = workOrders.unallocated[workorderindex].Product;
            txtCustomer.Text = workOrders.unallocated[workorderindex].Customer;
            txtDueDate.Value = workOrders.unallocated[workorderindex].DueDate;
            txtQuantity.Text = workOrders.unallocated[workorderindex].Quantity.ToString();
            if (workOrders.unallocated[workorderindex].Status == "READY")
            {
                chckReadySchedule.Checked = true;
            }
            else
            {
                chckReadySchedule.Checked = false;
            }
        }

        

        private void workOrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workOrdersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scheduleDatabaseDataSet);

        }

        private void frmUnallocatedOrderDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduleDatabaseDataSet.WorkOrders' table. You can move, or remove it, as needed.
            this.workOrdersTableAdapter.Fill(this.scheduleDatabaseDataSet.WorkOrders);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           int workorderid = int.Parse(txtWorkOrderID.Text);
           int quantity = int.Parse(txtQuantity.Text);

            // Locate the row you want to update.
            ScheduleDatabaseDataSet.WorkOrdersRow workorderrow;
            workorderrow = scheduleDatabaseDataSet.WorkOrders.FindByWorkOrderID(workorderid);

            // Assign the new value to the desired column.
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
