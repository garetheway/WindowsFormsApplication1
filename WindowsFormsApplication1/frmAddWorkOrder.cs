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
    public partial class frmAddWorkOrder : Form
    {
        private void frmAddWorkOrder_Load(object sender, EventArgs e)
        {
            this.workOrdersTableAdapter.Fill(this.scheduleDatabaseDataSet.WorkOrders);
            this.BackColor = Color.FromArgb(73, 129, 161);
        }

        public frmAddWorkOrder()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            int wid = int.Parse(workOrderIDTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);


            // Create a new row.
            ScheduleDatabaseDataSet.WorkOrdersRow newRegionRow;
            newRegionRow = scheduleDatabaseDataSet.WorkOrders.NewWorkOrdersRow();
            newRegionRow.WorkOrderID = wid;
            newRegionRow.Product = productTextBox.Text;
            newRegionRow.Customer = customerTextBox.Text;
            newRegionRow.DueDate = dueDateDateTimePicker.Value.Date;
            newRegionRow.Quantity = quantity;
            newRegionRow.Status = statusComboBox.Text;

            // Add the row to the Region table 
            this.scheduleDatabaseDataSet.WorkOrders.Rows.Add(newRegionRow);

            // Save the new row to the database 
            this.workOrdersTableAdapter.Update(this.scheduleDatabaseDataSet.WorkOrders);

/*            System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ScheduleDatabase.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Region (RegionID, RegionDescription) VALUES (5, 'NorthWestern')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();*/

        }

        private void customerTextBox_mouseclick(object sender, EventArgs e)
        {
            MessageBox.Show("CLICKED");
        }
    }
}
