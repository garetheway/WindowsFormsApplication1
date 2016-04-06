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
        // Create a new object of our new work order form.
        frmAddWorkOrder newwrkorderFrm = new frmAddWorkOrder();
        // Number of generations that our GA is going to run.
        public int numberOfGens = 5000;
        // Create objects of these. Had to be done for one function (a button click) annoyingly...
        public Population popp;
        public WorkOrderCollection worky;

        // Events that occur when the form is first loaded.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill our table adapter with information from the database.
            this.workOrdersTableAdapter.Fill(this.scheduleDatabaseDataSet.WorkOrders);
            // Update the colours of the background panels.
            panelTop.BackColor = Color.FromArgb(73, 129, 161);
            pnlBottom.BackColor = Color.FromArgb(0, 14, 60);
            // Send our panels to the back of the screen.
            panelTop.SendToBack();
            pnlBottom.SendToBack();
            // Update the background colours of the labels.
            lblSwinprod.BackColor = Color.FromArgb(73, 129, 161);
            lblProdLine1.BackColor = Color.FromArgb(0, 14, 60);
            lblProdLine2.BackColor = Color.FromArgb(0, 14, 60);
        }

        // Action that occurs when we call it, only once really when the program first launches.
        public Form1(Population pop, WorkOrderCollection workOrders)
        {
            InitializeComponent();
            popp = pop;
            worky = workOrders;
            List<TextBox> prodLine1 = new List<TextBox>();
            List<TextBox> prodLine2 = new List<TextBox>();


            // Set up the unallocated orders.
            LoadUnallocated(pop, workOrders);
            // Set up the production lines!
            LoadSchedule(pop, workOrders);

            workOrders.AssociateArchivedOrders();

            btnAddNew.MouseHover += new EventHandler(btnAddNew_Hover);
            btnAddNew.MouseLeave += new EventHandler(btnAddNew_Leave);
            // This line calls the 'LoadUnallocated' function whenever the new work form is closed.
            newwrkorderFrm.FormClosed += (sender, e) => LoadUnallocated(pop, workOrders);
        }

        // Function to refresh the unallocated orders list.
        private void LoadUnallocated(Population pop, WorkOrderCollection workOrders)
        {
            // Clear the list of unallocated work orders.
            workOrders.unallocated.Clear();
            // Refill the list of unallocated work orders with up-to-date information from the database.
            workOrders.AssociateUnallocatedOrders();
            // Clear the controls on the form.
            pnlUnallocated.Controls.Clear();
            // Create a list to hold the list of text boxes that make up the unallocated orders.
            List<TextBox> unallocatedOrders = new List<TextBox>();

            // Set up unallocated orders text boxes based on the total number of unallocated orders.
            for (int i = 0; i < workOrders.unallocated.Count; i++)
            {
                unallocatedOrders.Add(new TextBox());
                unallocatedOrders[i].Location = new System.Drawing.Point(i*125);
                unallocatedOrders[i].Size = new System.Drawing.Size(120, 80);
                unallocatedOrders[i].Multiline = true;
                unallocatedOrders[i].ReadOnly = true;
                // When an unallocated order is clicked, open the detailed view.
                unallocatedOrders[i].Click += (sender, e) => UnallocatedWorkOrderClick(sender, e, pop, workOrders);
                // Set the name so we know how to reference it later.
                unallocatedOrders[i].Name = "txtprodUA" + i.ToString();
                unallocatedOrders[i].BackColor = Color.FromArgb(165, 192, 208);
                // Add each text boxes to our panel controls.
                pnlUnallocated.Controls.Add(unallocatedOrders[i]);
            }

            // Create text boxes for each of the items in the unallocated list of work orders.
            foreach (WorkOrder workorder in workOrders.unallocated)
            {
                // Cycle through each of the text boxes.
                for (int index = 0; index < unallocatedOrders.Count; index++)
                {
                    // Create a textbox object.
                    TextBox wo = unallocatedOrders[index];
                    // If the object doesn't have text in...
                    if (wo.Text == String.Empty)
                    {
                        // Populate the textbox with information for a work order.
                        wo.AppendText("ID: " + workOrders.unallocated[index].WorkOrderID.ToString() +
                                      Environment.NewLine +
                                      "Customer: " + workOrders.unallocated[index].Customer + Environment.NewLine +
                                      "Product: " + workOrders.unallocated[index].Product + Environment.NewLine +
                                      "Qty: " +
                                      workOrders.unallocated[index].Quantity + Environment.NewLine + "Due: " +
                                      workOrders.unallocated[index].DueDate.Date.ToString("dd/MM/yyyy"));
                        // If the status of the current work order is 'READY', set the colour to distinguish it.
                        if (workOrders.unallocated[index].Status == "READY")
                        {
                            wo.BackColor = Color.Aquamarine;
                            break;
                        }
                    }
                }
            }
            // Refresh the panel for good measure!
            pnlUnallocated.Refresh();
        }

        // Function to schedule / reschedule.
        private void LoadSchedule(Population pop, WorkOrderCollection workOrders)
        {
           // Create our table adapter to interact with the database.
            this.workOrdersTableAdapter.Fill(this.scheduleDatabaseDataSet.WorkOrders);

            // Create lists for each of the production lines.
            List<TextBox> prodLine1 = new List<TextBox>();
            List<TextBox> prodLine2 = new List<TextBox>();

            // Clear any existing data from the orders list.
            workOrders.orders.Clear();
            // Clear any existing individuals (this having to be done in case this is a reschedule!)
            pop.individuals.Clear();
            // Clear the production line controls of any existing text boxes.
            pnlLine1.Controls.Clear();
            pnlLine2.Controls.Clear();

            // Update any orders that are 'READY' to be set to 'SCHED' so they are factored in to the schedule.
            foreach (DataRow row in workOrdersTableAdapter.GetReadyOrders().Rows)
            {
                int wid = int.Parse(row["WorkOrderID"].ToString());
                ScheduleDatabaseDataSet.WorkOrdersRow workorderrow;
                workorderrow =
                    scheduleDatabaseDataSet.WorkOrders.FindByWorkOrderID(wid);
                workorderrow.Status = "SCHED";
                this.workOrdersTableAdapter.Update(this.scheduleDatabaseDataSet.WorkOrders);
            }

            /*RUN THE GENETIC ALGORITHM*/
            // Reassociate data incase of updates.
            workOrders.AssociateWorkOrders();
            // Create a population for the algorithm to run.
            pop.GenerateRandomPopulation(workOrders.orders);
            // Evaluate initial population fitness.
            pop.EvaluateFitness(workOrders.orders);
            //Evolution of the population as part of the GA
            for (int i = 0; i < numberOfGens; i++)
            {
                pop = Algorithm.EvolvePopulation(pop);
                pop.EvaluateFitness(workOrders.orders);
            }
            // Allocate fittest individual to lines.
            pop.AllocateLines(workOrders.orders);

            // For each order, set the completion date in the database to be equal to the calculated one.
            for (int i = 0; i < workOrders.orders.Count; i++)
            {
                DateTime cd = workOrders.orders[i].CompletionDate;
                ScheduleDatabaseDataSet.WorkOrdersRow workorderrow;
                workorderrow =
                    scheduleDatabaseDataSet.WorkOrders.FindByWorkOrderID(int.Parse(workOrders.orders[i].WorkOrderID));
                workorderrow.CompletionDate = cd;
                this.workOrdersTableAdapter.Update(this.scheduleDatabaseDataSet.WorkOrders);
            }

            /*SET UP THE PRODUCTION LINE TEXT BOXES AND POPULATE*/
            // SET UP PRODUCTION LINE 1.
            for (int i = 0; i < pop.ProdLine1.Count; i++)
            {
                prodLine1.Add(new TextBox());
                prodLine1[i].Name = "PONE" + i;
                prodLine1[i].Location = new System.Drawing.Point(i*155);
                prodLine1[i].Size = new System.Drawing.Size(150, 90);
                prodLine1[i].Multiline = true;
                prodLine1[i].ReadOnly = true;
                prodLine1[i].Click += (sender, e) => AllocatedWorkOrderClick(sender, e, pop, workOrders);
                pnlLine1.Controls.Add(prodLine1[i]);
            }
            // SET UP PRODUCTION LINE 2
            for (int i = 0; i < pop.ProdLine2.Count; i++)
            {
                prodLine2.Add(new TextBox());
                prodLine2[i].Name = "PTWO" + i;
                prodLine2[i].Location = new System.Drawing.Point(i*155);
                prodLine2[i].Size = new System.Drawing.Size(150, 90);
                prodLine2[i].Multiline = true;
                prodLine2[i].ReadOnly = true;
                prodLine2[i].Click += (sender, e) => AllocatedWorkOrderClick(sender, e, pop, workOrders);
                pnlLine2.Controls.Add(prodLine2[i]);
            }
            // POPULATION OF LINE 1
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
            // POPULATION OF LINE 2
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
            // Load the Unallocated text boxes incase any orders have been changed from unallocated to on a production line.
            LoadUnallocated(pop, workOrders);
        }

        // Function to perform actions when an unallocated order has been clicked.
        private void UnallocatedWorkOrderClick(object sender, EventArgs e, Population pop, WorkOrderCollection workOrders)
        {
            // Create a textbox based on the ID of the object that was clicked.
            TextBox textBox = (TextBox) sender;

            // For each order in our unallocated list...
            for (int index = 0; index < workOrders.unallocated.Count; index++)
            {
                // Check the name of the text box... if matching, open the detailed view of it!
                if (textBox.Name == ("txtprodUA" + index))
                {
                    frmUnallocatedOrderDetail unallocatedwoFrm = new frmUnallocatedOrderDetail(pop, workOrders, index);
                    unallocatedwoFrm.FormClosed += (send, f) => LoadUnallocated(pop, workOrders);
                    unallocatedwoFrm.Show();
                    break;
                }
            }
        }

        // Function to perform actions when an allocated order has been clicked.
        private void AllocatedWorkOrderClick(object sender, EventArgs e, Population pop, WorkOrderCollection workOrders)
        {
            TextBox textBox = (TextBox)sender;

            for (int index = 0; index < workOrders.orders.Count; index++)
            {
                if (textBox.Name == ("PONE" + index))
                {
                    int num = pop.ProdLine1.ElementAt(index);
                    frmScheduleOrderDetail orderDetail = new frmScheduleOrderDetail(pop, workOrders, num);
                    orderDetail.FormClosed += (send, f) => ClearAllocatedTextbox(textBox, pop, workOrders, num);
                    orderDetail.Show();
                    break;
                }
                else if (textBox.Name == ("PTWO" + index))
                {
                    int num = pop.ProdLine2.ElementAt(index);
                    frmScheduleOrderDetail orderDetail = new frmScheduleOrderDetail(pop, workOrders, num);
                    orderDetail.FormClosed += (send, f) => ClearAllocatedTextbox(textBox, pop, workOrders, num);
                    orderDetail.Show();
                }
            }
        }

        // Function to reset the colour of an allocated textbox when the detailed view is closed.
        private void ClearAllocatedTextbox(object sender, Population pop, WorkOrderCollection workOrders, int num)
        {
            TextBox textBox = (TextBox)sender;
            int prearchive = workOrders.archived.Count();
            workOrders.orders.Clear();
            workOrders.AssociateWorkOrders();
            workOrders.AssociateArchivedOrders();
            int postarchive = workOrders.archived.Count();

            if (postarchive > prearchive)
            {
                LoadSchedule(pop, workOrders);
            }


            if (workOrders.orders[num].Status == "HOLD")
            {
                textBox.BackColor = Color.FromArgb(255, 76, 76);
            }
            else if (workOrders.orders[num].Status == "KITTING")
            {
                textBox.BackColor = Color.Yellow;
            }
            else if (workOrders.orders[num].Status == "WIP")
            {
                textBox.BackColor = Color.Chartreuse;
            }
            else if (workOrders.orders[num].Status == "SCHED")
            {
                textBox.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                textBox.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void btnRunSchedule_Click(object sender, EventArgs e)
        {
            LoadSchedule(popp, worky);
        }

        private void label1_Click(object sender, EventArgs e)
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
    }
}
