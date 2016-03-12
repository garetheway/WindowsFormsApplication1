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

            // Work order IDS
            foreach (int myInt in pop.ProdLine1)
            {
                prodLine1txt.AppendText(workOrders.orders[myInt].WorkOrderID.ToString() + "\t");
            }

            foreach (int myInt in pop.ProdLine2)
            {
                prodLine2txt.AppendText(workOrders.orders[myInt].WorkOrderID.ToString() + "\t");
            }

        }
    }
}
