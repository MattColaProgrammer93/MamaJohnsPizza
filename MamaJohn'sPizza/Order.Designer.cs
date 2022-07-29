namespace MamaJohn_sPizza
{
    partial class Order
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPizzaShapes = new System.Windows.Forms.GroupBox();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.grpCrustTypes = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpPizzaShapes
            // 
            this.grpPizzaShapes.Location = new System.Drawing.Point(34, 37);
            this.grpPizzaShapes.Name = "grpPizzaShapes";
            this.grpPizzaShapes.Size = new System.Drawing.Size(250, 125);
            this.grpPizzaShapes.TabIndex = 0;
            this.grpPizzaShapes.TabStop = false;
            this.grpPizzaShapes.Text = "Pizza Shapes";
            // 
            // grpToppings
            // 
            this.grpToppings.Location = new System.Drawing.Point(330, 37);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(250, 176);
            this.grpToppings.TabIndex = 1;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // grpCrustTypes
            // 
            this.grpCrustTypes.Location = new System.Drawing.Point(34, 189);
            this.grpCrustTypes.Name = "grpCrustTypes";
            this.grpCrustTypes.Size = new System.Drawing.Size(250, 172);
            this.grpCrustTypes.TabIndex = 2;
            this.grpCrustTypes.TabStop = false;
            this.grpCrustTypes.Text = "Crusts";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(631, 37);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(125, 48);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(631, 165);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpCrustTypes);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpPizzaShapes);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpPizzaShapes;
        private GroupBox grpToppings;
        private GroupBox grpCrustTypes;
        private Button btnOrder;
        private Button btnExit;
    }
}