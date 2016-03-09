using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class WorkOrderCollection
    {
        public List<WorkOrder> orders = new List<WorkOrder>();

        public void AssociateWorkOrders()
        {
            orders.Add(new WorkOrder("100", "ProductA", "Joe", new DateTime(2016, 3, 09), 2000));
            orders.Add(new WorkOrder("101", "ProductC", "John", new DateTime(2016, 3, 10), 5000));
            orders.Add(new WorkOrder("102", "ProductC", "George", new DateTime(2016, 3, 11), 3000));
            orders.Add(new WorkOrder("103", "ProductC", "Josh", new DateTime(2016, 3, 13), 10000));
            orders.Add(new WorkOrder("104", "ProductB", "Gareth", new DateTime(2016, 3, 10), 5000));
            orders.Add(new WorkOrder("105", "ProductA", "David", new DateTime(2016, 3, 11), 3000));
            orders.Add(new WorkOrder("106", "ProductB", "Tom", new DateTime(2016, 3, 20), 7000));
            orders.Add(new WorkOrder("107", "ProductB", "Eric", new DateTime(2016, 3, 10), 3000));
            orders.Add(new WorkOrder("108", "ProductA", "Ross", new DateTime(2016, 3, 29), 10000));
            orders.Add(new WorkOrder("109", "ProductD", "Ellie", new DateTime(2016, 3, 25), 10000));
        }
    }
}
