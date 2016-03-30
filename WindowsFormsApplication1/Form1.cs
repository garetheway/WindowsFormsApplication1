using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Application = System.Windows.Application;
using MessageBox = System.Windows.Forms.MessageBox;

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
            List<TextBox> prodLine1 = new List<TextBox>();
            List<TextBox> prodLine2 = new List<TextBox>();


            // Set up the unallocated orders.
            LoadUnallocated(pop, workOrders);
            // Set up the production lines!
            LoadSchedule(pop, workOrders);


            /*// SET UP PRODUCTION LINE 1
            for (int i = 0; i < pop.ProdLine1.Count; i++)
            {
                prodLine1.Add(new TextBox());
                prodLine1[i].Name = "P" + i;
                prodLine1[i].Location = new System.Drawing.Point(i*155);
                prodLine1[i].Size = new System.Drawing.Size(150, 90);
                prodLine1[i].Multiline = true;
                prodLine1[i].ReadOnly = true;
                pnlLine1.Controls.Add(prodLine1[i]);
            }

            // SET UP PRODUCTION LINE 2
            for (int i = 0; i < pop.ProdLine2.Count; i++)
            {
                prodLine2.Add(new TextBox());
                prodLine2[i].Location = new System.Drawing.Point(i*155);
                prodLine2[i].Size = new System.Drawing.Size(150, 90);
                prodLine2[i].Multiline = true;
                prodLine2[i].ReadOnly = true;
                pnlLine2.Controls.Add(prodLine2[i]);
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
                }
            }

            pnlBottom.SendToBack();*/
            btnAddNew.MouseHover += new EventHandler(btnAddNew_Hover);
            btnAddNew.MouseLeave += new EventHandler(btnAddNew_Leave);
            // This line calls the 'LoadUnallocated' function whenever the new work form is closed.
            newwrkorderFrm.FormClosed += (sender, e) => LoadUnallocated(pop, workOrders);
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

        // Function to refresh the unallocated orders list.
        private void LoadUnallocated(Population pop, WorkOrderCollection workOrders)
        {
            workOrders.unallocated.Clear();
            workOrders.AssociateUnallocatedOrders();
            pnlUnallocated.Controls.Clear();
            List<TextBox> unallocatedOrders = new List<TextBox>();


            // SET UP UNALLOCATED ORDERS
            for (int i = 0; i < workOrders.unallocated.Count; i++)
            {
                unallocatedOrders.Add(new TextBox());
                unallocatedOrders[i].Location = new System.Drawing.Point(i*125);
                unallocatedOrders[i].Size = new System.Drawing.Size(120, 80);
                unallocatedOrders[i].Multiline = true;
                unallocatedOrders[i].ReadOnly = true;
                // When an unallocated order is clicked, open the detailed view.
                unallocatedOrders[i].Click += (sender, e) => WorkOrderClick(sender, e, pop, workOrders);
                unallocatedOrders[i].Name = "txtprodUA" + i.ToString();
                unallocatedOrders[i].BackColor = Color.FromArgb(165, 192, 208);
                pnlUnallocated.Controls.Add(unallocatedOrders[i]);
            }

            foreach (WorkOrder workorder in workOrders.unallocated)
            {
                for (int index = 0; index < unallocatedOrders.Count; index++)
                {
                    TextBox wo = unallocatedOrders[index];
                    if (wo.Text == String.Empty)
                    {
                        wo.AppendText("ID: " + workOrders.unallocated[index].WorkOrderID.ToString() +
                                      Environment.NewLine +
                                      "Customer: " + workOrders.unallocated[index].Customer + Environment.NewLine +
                                      "Product: " + workOrders.unallocated[index].Product + Environment.NewLine +
                                      "Qty: " +
                                      workOrders.unallocated[index].Quantity + Environment.NewLine + "Due: " +
                                      workOrders.unallocated[index].DueDate.Date.ToString("dd/MM/yyyy"));
                        if (workOrders.unallocated[index].Status == "READY")
                        {
                            wo.BackColor = Color.Aquamarine;
                            break;
                        }
                    }
                }
            }
            panelTop.SendToBack();
            pnlUnallocated.Refresh();
        }

        private void LoadSchedule(Population pop, WorkOrderCollection workOrders)
        {
            workOrders.orders.Clear();
            workOrders.AssociateWorkOrders();
            pnlLine1.Controls.Clear();
            pnlLine2.Controls.Clear();
            List<TextBox> prodLine1 = new List<TextBox>();
            List<TextBox> prodLine2 = new List<TextBox>();

            // SET UP PRODUCTION LINE 1
            for (int i = 0; i < pop.ProdLine1.Count; i++)
            {
                prodLine1.Add(new TextBox());
                prodLine1[i].Name = "P" + i;
                prodLine1[i].Location = new System.Drawing.Point(i * 155);
                prodLine1[i].Size = new System.Drawing.Size(150, 90);
                prodLine1[i].Multiline = true;
                prodLine1[i].ReadOnly = true;
                pnlLine1.Controls.Add(prodLine1[i]);
            }

            // SET UP PRODUCTION LINE 2
            for (int i = 0; i < pop.ProdLine2.Count; i++)
            {
                prodLine2.Add(new TextBox());
                prodLine2[i].Location = new System.Drawing.Point(i * 155);
                prodLine2[i].Size = new System.Drawing.Size(150, 90);
                prodLine2[i].Multiline = true;
                prodLine2[i].ReadOnly = true;
                pnlLine2.Controls.Add(prodLine2[i]);
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
                }
            }

            pnlBottom.SendToBack();

        }


        private void WorkOrderClick(object sender, EventArgs e, Population pop, WorkOrderCollection workOrders)
        {
            TextBox textBox = (TextBox) sender;

            for (int index = 0; index < workOrders.unallocated.Count; index++)
            {
                if (textBox.Name == ("txtprodUA" + index))
                {
                    frmUnallocatedOrderDetail unallocatedwoFrm = new frmUnallocatedOrderDetail(pop, workOrders, index);
                    unallocatedwoFrm.FormClosed += (send, f) => LoadUnallocated(pop, workOrders);
                    unallocatedwoFrm.Show();
                    break;
                }
            }
        }

        private void btnRunSchedule_Click(object sender, EventArgs e)
        {

        }
    }
}
