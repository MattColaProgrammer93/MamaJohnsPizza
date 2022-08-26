using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MamaJohn_sPizza
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
        }

        Pizza currSelectedOrder = null!;
        int currId = 0;

        private void btnExitOrderList_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = lstOrders.SelectedIndex;

            if (id != -1 || currId != id) {
                using PizzaOrderContext dbContext = new();
                var selectedOrder = dbContext.Pizzas
                          .Where(selectedOrder => selectedOrder.Id == id).SingleOrDefault();
                currSelectedOrder = (Pizza)selectedOrder;

                if (currSelectedOrder != null) {
                    txtDisplay.Text = DisplayOrder();
                }
            }
            else if (currId == id)
            {
                MessageBox.Show("The order is already selected");
            }
            else
            {
                MessageBox.Show("The order is not available");
            }
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            PopulatePizzaOrderList();
        }

        /// <summary>
        /// Populates the listBox with orders from the database
        /// </summary>
        private void PopulatePizzaOrderList()
        {
            using PizzaOrderContext dbContext = new();
            List<Pizza> list = dbContext.Pizzas.ToList();

            foreach (Pizza currOrder in list)
            {
                // Add pizza object to lstOrders
                lstOrders.Items.Add(AddOrder(currOrder));
            }
        }

        /// <summary>
        /// Fully displays the order with full details.
        /// </summary>
        private string DisplayOrder()
        {
            string newLine = Environment.NewLine;
            return $"Pizza Size: {currSelectedOrder.Size}" + newLine + $"Pizza Shape: {currSelectedOrder.Shape}" + newLine + 
                $"Number of Different Toppings: {currSelectedOrder.NumOfToppings}" +
                newLine + $"Crust: {currSelectedOrder.CrustType}" + newLine + $"Total Cost: {currSelectedOrder.TotalCost}";
        }

        /// <summary>
        /// Adds the item to the list with custom message.
        /// </summary>
        /// <param name="currOrder">The order item from database</param>
        /// <returns>Returns the custom message/string</returns>
        private string AddOrder(Pizza currOrder)
        {
            return $"Pizza Size: {currOrder.Size} Total Cost: {currOrder.TotalCost} Click to see more ";
        }
    }
}
