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

        // The shape of the pizza
        string shape = "";
        double shapeCost = 0.00;

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
    }
}