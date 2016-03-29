using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        frmAddWorkOrder newwrkorderFrm = new frmAddWorkOrder();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.workOrdersTableAdapter.Fill(this.scheduleDatabaseDataSet.WorkOrders);
            panelTop.BackColor = Color.FromArgb(73, 129, 161);
            pnlBottom.BackColor = Color.FromArgb(0, 14, 60);
            lblSwinprod.BackColor = Color.FromArgb(73, 129, 161);
            lblProdLine1.BackColor = Color.FromArgb(0, 14, 60);
            lblProdLine2.BackColor = Color.FromArgb(0, 14, 60);
        }

        public Form1(Population pop, WorkOrderCollection workOrders)
        {
            InitializeComponent();
            List<TextBox> unallocatedOrders = new List<TextBox>();
            List<TextBox> prodLine1 = new List<TextBox>();
            List<TextBox> prodLine2 = new List<TextBox>();
            DataTable dt = workOrdersTableAdapter.GetUnallocatedOrders();


            // SET UP UNALLOCATED ORDERS
            for (int i = 0; i < workOrders.unallocated.Count; i++)
            {
                unallocatedOrders.Add(new TextBox());
                unallocatedOrders[i].Location = new System.Drawing.Point(i*125, 40);
                unallocatedOrders[i].Size = new System.Drawing.Size(120, 80);
                unallocatedOrders[i].Multiline = true;
                unallocatedOrders[i].Enabled = false;
                unallocatedOrders[i].Name = "txtprodUA" + i.ToString();
                this.Controls.Add(unallocatedOrders[i]);
            }

            // SET UP PRODUCTION LINE 1
            for (int i = 0; i < pop.ProdLine1.Count; i++)
            {
                prodLine1.Add(new TextBox());
                prodLine1[i].Location = new System.Drawing.Point(i*155, 200);
                prodLine1[i].Size = new System.Drawing.Size(150, 90);
                prodLine1[i].Multiline = true;
                prodLine1[i].Enabled = false;
                prodLine1[i].Name = "txtprod1L" + i.ToString();
                this.Controls.Add(prodLine1[i]);
            }

            // SET UP PRODUCTION LINE 2
            for (int i = 0; i < pop.ProdLine2.Count; i++)
            {
                prodLine2.Add(new TextBox());
                prodLine2[i].Location = new System.Drawing.Point(i*155, 325);
                prodLine2[i].Size = new System.Drawing.Size(150, 90);
                prodLine2[i].Multiline = true;
                prodLine2[i].Enabled = false;
                this.Controls.Add(prodLine2[i]);
            }

            // ALLOCATION OF UNALLOCATED ORDERS
            for (int index = 0; index < unallocatedOrders.Count; index++)
            {
                TextBox wo = unallocatedOrders[index];
                if (wo.Text == String.Empty)
                {
                    wo.AppendText("ID: " + workOrders.unallocated[index].WorkOrderID.ToString() + Environment.NewLine +
                                  "Customer: " + workOrders.unallocated[index].Customer + Environment.NewLine +
                                  "Product: " + workOrders.unallocated[index].Product + Environment.NewLine + "Qty: " +
                                  workOrders.unallocated[index].Quantity + Environment.NewLine + "Due: " +
                                  workOrders.unallocated[index].DueDate.Date.ToString("dd/MM/yyyy") +
                                  Environment.NewLine + "CD: " +
                                  workOrders.unallocated[index].CompletionDate.Date.ToString("dd/MM/yyyy"));
                    wo.BackColor = Color.FromArgb(165, 192, 208);
                }
                wo.BringToFront();
                wo = null;
            }


            // ALLOCATION OF LINE 1
            foreach (int myInt in pop.ProdLine1)
            {
                for (int index = 0; index < prodLine1.Count; index++)
                {
                    TextBox wo = prodLine1[index];
                    if (wo.Text == String.Empty)
                    {
                        wo.AppendText("ID: " + workOrders.orders[myInt].WorkOrderID.ToString() + Environment.NewLine +
                                      "Customer: " + workOrders.orders[myInt].Customer + Environment.NewLine +
                                      "Product: " + workOrders.orders[myInt].Product + Environment.NewLine + "Qty: " +
                                      workOrders.orders[myInt].Quantity + Environment.NewLine + "Due: " +
                                      workOrders.orders[myInt].DueDate.Date.ToString("dd/MM/yyyy") +
                                      Environment.NewLine + "CD: " +
                                      workOrders.orders[myInt].CompletionDate.Date.ToString("dd/MM/yyyy"));

                        if (workOrders.orders[myInt].Status == "HOLD")
                        {
                            wo.BackColor = Color.FromArgb(255, 76, 76);
                        }
                        else if (workOrders.orders[myInt].Status == "KITTING")
                        {
                            wo.BackColor = Color.Yellow;
                        }
                        else if (workOrders.orders[myInt].Status == "WIP")
                        {
                            wo.BackColor = Color.Chartreuse;
                        }
                        break;
                    }
                    wo = null;
                }
            }

            // ALLOCATION OF LINE 2
            foreach (int myInt in pop.ProdLine2)
            {
                for (int index = 0; index < prodLine2.Count; index++)
                {
                    TextBox wo = prodLine2[index];
                    if (wo.Text == String.Empty)
                    {
                        wo.AppendText("ID: " + workOrders.orders[myInt].WorkOrderID.ToString() + Environment.NewLine +
                                      "Customer: " + workOrders.orders[myInt].Customer + Environment.NewLine +
                                      "Product: " + workOrders.orders[myInt].Product + Environment.NewLine + "Qty: " +
                                      workOrders.orders[myInt].Quantity + Environment.NewLine + "Due: " +
                                      workOrders.orders[myInt].DueDate.Date.ToString("dd/MM/yyyy") +
                                      Environment.NewLine + "CD: " +
                                      workOrders.orders[myInt].CompletionDate.Date.ToString("dd/MM/yyyy"));

                        if (workOrders.orders[myInt].Status == "HOLD")
                        {
                            wo.BackColor = Color.FromArgb(255, 76, 76);
                        }
                        else if (workOrders.orders[myInt].Status == "KITTING")
                        {
                            wo.BackColor = Color.Yellow;
                        }
                        else if (workOrders.orders[myInt].Status == "WIP")
                        {
                            wo.BackColor = Color.Chartreuse;
                        }
                        break;
                    }
                    wo = null;
                }
            }

            pnlBottom.SendToBack();
            btnAddNew.MouseHover += new EventHandler(btnAddNew_Hover);
            btnAddNew.MouseLeave += new EventHandler(btnAddNew_Leave);
            newwrkorderFrm.FormClosed += new FormClosedEventHandler(frmAddWorkOrder_FormClosed);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            newwrkorderFrm.Show();
        }

        private void btnAddNew_Hover(object sender, EventArgs e)
        {
            btnAddNew.BackColor = Color.SkyBlue;
        }

        private void btnAddNew_Leave(object sender, EventArgs e)
        {
            btnAddNew.BackColor = Color.White;
        }


        private void frmAddWorkOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Please restart the application to view the new work order created.");
        }
    }
}
