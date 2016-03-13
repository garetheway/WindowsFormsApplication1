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
        public Form1(Population pop, WorkOrderCollection workOrders)
        {
            InitializeComponent();
            List<TextBox> prodLine1 = new List<TextBox>();
            List<TextBox> prodLine2 = new List<TextBox>();
            
            // SET UP PRODUCTION LINE 1
            for (int i = 0; i < pop.ProdLine1.Count; i++)
            {
                prodLine1.Add(new TextBox());
                prodLine1[i].Location = new System.Drawing.Point(i * 155, 25);
                prodLine1[i].Size = new System.Drawing.Size(150,90);
                prodLine1[i].Multiline = true;
                prodLine1[i].Enabled = false;
                this.Controls.Add(prodLine1[i]);
            }

            // SET UP PRODUCTION LINE 2
            for (int i = 0; i < pop.ProdLine2.Count; i++)
            {
                prodLine2.Add(new TextBox());
                prodLine2[i].Location = new System.Drawing.Point(i * 155, 150);
                prodLine2[i].Size = new System.Drawing.Size(150, 90);
                prodLine2[i].Multiline = true;
                prodLine2[i].Enabled = false;
                this.Controls.Add(prodLine2[i]);
            }

            // ALLOCATION OF LINE 1
            foreach (int myInt in pop.ProdLine1)
            {
                //prodLine1txt.AppendText(workOrders.orders[myInt].WorkOrderID.ToString() + "\t");
                foreach (TextBox wo in prodLine1)
                {
                    //if (workOrders.orders[myInt].CompletionDate > workOrders.orders[myInt].DueDate)
                    //{
                    //    wo.BackColor = Color.Red;
                    //}

                    if (wo.Text == String.Empty)
                    {
                        wo.AppendText("ID: " + workOrders.orders[myInt].WorkOrderID.ToString() + Environment.NewLine + "Customer: " + workOrders.orders[myInt].Customer + Environment.NewLine + "Product: " + workOrders.orders[myInt].Product + Environment.NewLine + "Qty: " + workOrders.orders[myInt].Quantity + Environment.NewLine + "Due: " + workOrders.orders[myInt].DueDate.Date.ToString("dd/MM/yyyy") +Environment.NewLine + "CD: " + workOrders.orders[myInt].CompletionDate.Date.ToString("dd/MM/yyyy"));
                        break;
                    }
                }
            }

            // ALLOCATION OF LINE 2
            foreach (int myInt in pop.ProdLine2)
            {
                //prodLine1txt.AppendText(workOrders.orders[myInt].WorkOrderID.ToString() + "\t");
                foreach (TextBox wo in prodLine2)
                {
                    //if (workOrders.orders[myInt].CompletionDate > workOrders.orders[myInt].DueDate)
                    //{
                    //    wo.BackColor = Color.Red;
                    //}

                    if (wo.Text == String.Empty)
                    {
                        wo.AppendText("ID: " + workOrders.orders[myInt].WorkOrderID.ToString() + Environment.NewLine + "Customer: " + workOrders.orders[myInt].Customer + Environment.NewLine + "Product: " + workOrders.orders[myInt].Product + Environment.NewLine + "Qty: " + workOrders.orders[myInt].Quantity + Environment.NewLine + "Due: " + workOrders.orders[myInt].DueDate.Date.ToString("dd/MM/yyyy") + Environment.NewLine + "CD: " + workOrders.orders[myInt].CompletionDate.Date.ToString("dd/MM/yyyy"));
                        break;
                    }
                }
            }


            //prodLine1txt.Enabled = false;
            foreach (int myInt in pop.ProdLine2)
            {
             //   prodLine2txt.AppendText(workOrders.orders[myInt].WorkOrderID.ToString() + "\t");
            }
            //prodLine2txt.Enabled = false;



        }
    }
}
