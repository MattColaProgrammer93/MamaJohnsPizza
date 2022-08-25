using MamaJohn_sPizza;

namespace MamaJohn_sPizza
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        // The variables for the entire form
        // The size of the pizza and price
        string size = "";
        double sizeCost = 0.00;

        // The shape of the pizza and price
        string shape = "";
        double shapeCost = 0.00;

        // The crust type of the pizza
        string crustType = "";
        double crustCost = 0.50;

        // The topping cost and number of toppings
        double toppingCost = 0.60;
        int numOfToppings = 0;


        // The Pizza Size Groupbox
        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmall.Checked)
            {
                size = "Small";
                sizeCost = 1.00;
            }
        }

        private void rdoMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMedium.Checked)
            {
                size = "Medium";
                sizeCost = 1.50;
            }
        }

        private void rdoLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLarge.Checked)
            {
                size = "Large";
                sizeCost = 2.00;
            }
        }

        // The Crust Type GroupBox
        private void rdoStuffedCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStuffedCrust.Checked)
            {
                crustType = "stuffed crust";
            }
        }

        private void rdoCrackerCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCrackerCrust.Checked)
            {
                crustType = "cracker crust";
            }
        }

        private void rdoThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThinCrust.Checked)
            {
                crustType = "thin crust";
            }
        }

        private void rdoFlatbread_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFlatbread.Checked)
            {
                crustType = "flatbeard crust";
            }
        }

        // The Shapes GroupBox
        private void rdoCircleShape_CheckedChanged(object sender, EventArgs e)
        {
            shape = "circular";
            shapeCost = 7.25;
        }

        private void rdoSquareShape_CheckedChanged(object sender, EventArgs e)
        {
            shape = "sqaure";
            shapeCost = 8.00;
        }

        // The Toppings GroupBox
        private double toppingTotalCost()
        {
            // Adding the costPerAddon together so there will be no negative number
            double totalAddonAmount = 0;
            // Number of topping checked
            int numTopChecked = 0;

            foreach (Control currControl in grpToppings.Controls)
            {
                if (currControl is CheckBox)
                {
                    CheckBox currCheckBox = currControl as CheckBox;
                    if (currCheckBox.Checked)
                    {
                        totalAddonAmount += toppingCost;
                        numTopChecked++;
                    }
                }
            }
            numOfToppings = numTopChecked;
            return totalAddonAmount;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            double toppingGrandTotal = toppingTotalCost();
            double grandTotal = sizeCost + shapeCost + crustCost + toppingCost;

            Pizza p = new()
            {
                Shape = shape,
                NumOfToppings = numOfToppings,
                CrustType = crustType,
                Size = size,
                TotalCost = grandTotal
            };

            using PizzaOrderContext dbContext = new();
            dbContext.Pizzas.Add(p); 
            dbContext.SaveChanges();
        }

        private void btnGoToList_Click(object sender, EventArgs e)
        {
            OrderList secondForm = new();
            secondForm.Show();
        }
    }
}