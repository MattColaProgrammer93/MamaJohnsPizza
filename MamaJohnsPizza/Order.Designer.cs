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
            this.rdoSquareShape = new System.Windows.Forms.RadioButton();
            this.rdoCircleShape = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkBeef = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.grpCrustTypes = new System.Windows.Forms.GroupBox();
            this.rdoFlatbread = new System.Windows.Forms.RadioButton();
            this.rdoThinCrust = new System.Windows.Forms.RadioButton();
            this.rdoCrackerCrust = new System.Windows.Forms.RadioButton();
            this.rdoStuffedCrust = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpPizzaSize = new System.Windows.Forms.GroupBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.btnGoToList = new System.Windows.Forms.Button();
            this.grpPizzaShapes.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpCrustTypes.SuspendLayout();
            this.grpPizzaSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPizzaShapes
            // 
            this.grpPizzaShapes.Controls.Add(this.rdoSquareShape);
            this.grpPizzaShapes.Controls.Add(this.rdoCircleShape);
            this.grpPizzaShapes.Location = new System.Drawing.Point(34, 37);
            this.grpPizzaShapes.Name = "grpPizzaShapes";
            this.grpPizzaShapes.Size = new System.Drawing.Size(250, 97);
            this.grpPizzaShapes.TabIndex = 0;
            this.grpPizzaShapes.TabStop = false;
            this.grpPizzaShapes.Text = "Pizza Shapes";
            // 
            // rdoSquareShape
            // 
            this.rdoSquareShape.AutoSize = true;
            this.rdoSquareShape.Location = new System.Drawing.Point(19, 56);
            this.rdoSquareShape.Name = "rdoSquareShape";
            this.rdoSquareShape.Size = new System.Drawing.Size(125, 24);
            this.rdoSquareShape.TabIndex = 1;
            this.rdoSquareShape.TabStop = true;
            this.rdoSquareShape.Text = "Square ($8.00)";
            this.rdoSquareShape.UseVisualStyleBackColor = true;
            this.rdoSquareShape.CheckedChanged += new System.EventHandler(this.rdoSquareShape_CheckedChanged);
            // 
            // rdoCircleShape
            // 
            this.rdoCircleShape.AutoSize = true;
            this.rdoCircleShape.Location = new System.Drawing.Point(19, 26);
            this.rdoCircleShape.Name = "rdoCircleShape";
            this.rdoCircleShape.Size = new System.Drawing.Size(116, 24);
            this.rdoCircleShape.TabIndex = 0;
            this.rdoCircleShape.TabStop = true;
            this.rdoCircleShape.Text = "Circle ($7.25)";
            this.rdoCircleShape.UseVisualStyleBackColor = true;
            this.rdoCircleShape.CheckedChanged += new System.EventHandler(this.rdoCircleShape_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkHam);
            this.grpToppings.Controls.Add(this.chkBeef);
            this.grpToppings.Controls.Add(this.chkBlackOlives);
            this.grpToppings.Controls.Add(this.chkPineapple);
            this.grpToppings.Controls.Add(this.chkBacon);
            this.grpToppings.Controls.Add(this.chkMushrooms);
            this.grpToppings.Controls.Add(this.chkSausage);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Location = new System.Drawing.Point(330, 37);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(250, 176);
            this.grpToppings.TabIndex = 1;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings ($0.60)";
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(113, 117);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(63, 24);
            this.chkHam.TabIndex = 12;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkBeef
            // 
            this.chkBeef.AutoSize = true;
            this.chkBeef.Location = new System.Drawing.Point(113, 87);
            this.chkBeef.Name = "chkBeef";
            this.chkBeef.Size = new System.Drawing.Size(61, 24);
            this.chkBeef.TabIndex = 11;
            this.chkBeef.Text = "Beef";
            this.chkBeef.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Location = new System.Drawing.Point(113, 57);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(110, 24);
            this.chkBlackOlives.TabIndex = 10;
            this.chkBlackOlives.Text = "Black Olives";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(113, 27);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(97, 24);
            this.chkPineapple.TabIndex = 9;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(6, 117);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(72, 24);
            this.chkBacon.TabIndex = 8;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 87);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(108, 24);
            this.chkMushrooms.TabIndex = 7;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(6, 57);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(86, 24);
            this.chkSausage.TabIndex = 6;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(6, 27);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(98, 24);
            this.chkPepperoni.TabIndex = 5;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // grpCrustTypes
            // 
            this.grpCrustTypes.Controls.Add(this.rdoFlatbread);
            this.grpCrustTypes.Controls.Add(this.rdoThinCrust);
            this.grpCrustTypes.Controls.Add(this.rdoCrackerCrust);
            this.grpCrustTypes.Controls.Add(this.rdoStuffedCrust);
            this.grpCrustTypes.Location = new System.Drawing.Point(34, 165);
            this.grpCrustTypes.Name = "grpCrustTypes";
            this.grpCrustTypes.Size = new System.Drawing.Size(250, 152);
            this.grpCrustTypes.TabIndex = 2;
            this.grpCrustTypes.TabStop = false;
            this.grpCrustTypes.Text = "Crust Types ($0.50)";
            // 
            // rdoFlatbread
            // 
            this.rdoFlatbread.AutoSize = true;
            this.rdoFlatbread.Location = new System.Drawing.Point(19, 116);
            this.rdoFlatbread.Name = "rdoFlatbread";
            this.rdoFlatbread.Size = new System.Drawing.Size(130, 24);
            this.rdoFlatbread.TabIndex = 3;
            this.rdoFlatbread.TabStop = true;
            this.rdoFlatbread.Text = "Flatbread Crust";
            this.rdoFlatbread.UseVisualStyleBackColor = true;
            this.rdoFlatbread.CheckedChanged += new System.EventHandler(this.rdoFlatbread_CheckedChanged);
            // 
            // rdoThinCrust
            // 
            this.rdoThinCrust.AutoSize = true;
            this.rdoThinCrust.Location = new System.Drawing.Point(19, 86);
            this.rdoThinCrust.Name = "rdoThinCrust";
            this.rdoThinCrust.Size = new System.Drawing.Size(95, 24);
            this.rdoThinCrust.TabIndex = 2;
            this.rdoThinCrust.TabStop = true;
            this.rdoThinCrust.Text = "Thin Crust";
            this.rdoThinCrust.UseVisualStyleBackColor = true;
            this.rdoThinCrust.CheckedChanged += new System.EventHandler(this.rdoThinCrust_CheckedChanged);
            // 
            // rdoCrackerCrust
            // 
            this.rdoCrackerCrust.AutoSize = true;
            this.rdoCrackerCrust.Location = new System.Drawing.Point(19, 56);
            this.rdoCrackerCrust.Name = "rdoCrackerCrust";
            this.rdoCrackerCrust.Size = new System.Drawing.Size(116, 24);
            this.rdoCrackerCrust.TabIndex = 1;
            this.rdoCrackerCrust.TabStop = true;
            this.rdoCrackerCrust.Text = "Cracker Crust";
            this.rdoCrackerCrust.UseVisualStyleBackColor = true;
            this.rdoCrackerCrust.CheckedChanged += new System.EventHandler(this.rdoCrackerCrust_CheckedChanged);
            // 
            // rdoStuffedCrust
            // 
            this.rdoStuffedCrust.AutoSize = true;
            this.rdoStuffedCrust.Location = new System.Drawing.Point(19, 26);
            this.rdoStuffedCrust.Name = "rdoStuffedCrust";
            this.rdoStuffedCrust.Size = new System.Drawing.Size(115, 24);
            this.rdoStuffedCrust.TabIndex = 0;
            this.rdoStuffedCrust.TabStop = true;
            this.rdoStuffedCrust.Text = "Stuffed Crust";
            this.rdoStuffedCrust.UseVisualStyleBackColor = true;
            this.rdoStuffedCrust.CheckedChanged += new System.EventHandler(this.rdoStuffedCrust_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(631, 37);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(125, 48);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
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
            // grpPizzaSize
            // 
            this.grpPizzaSize.Controls.Add(this.rdoLarge);
            this.grpPizzaSize.Controls.Add(this.rdoMedium);
            this.grpPizzaSize.Controls.Add(this.rdoSmall);
            this.grpPizzaSize.Location = new System.Drawing.Point(330, 235);
            this.grpPizzaSize.Name = "grpPizzaSize";
            this.grpPizzaSize.Size = new System.Drawing.Size(250, 125);
            this.grpPizzaSize.TabIndex = 5;
            this.grpPizzaSize.TabStop = false;
            this.grpPizzaSize.Text = "Pizza Size";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(11, 86);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(116, 24);
            this.rdoLarge.TabIndex = 4;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large ($2.00)";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.CheckedChanged += new System.EventHandler(this.rdoLarge_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(11, 56);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(134, 24);
            this.rdoMedium.TabIndex = 3;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium ($1.50)";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoMedium_CheckedChanged);
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(11, 26);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(116, 24);
            this.rdoSmall.TabIndex = 2;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small ($1.00)";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // btnGoToList
            // 
            this.btnGoToList.Location = new System.Drawing.Point(631, 94);
            this.btnGoToList.Name = "btnGoToList";
            this.btnGoToList.Size = new System.Drawing.Size(125, 54);
            this.btnGoToList.TabIndex = 6;
            this.btnGoToList.Text = "Go to List of Orders";
            this.btnGoToList.UseVisualStyleBackColor = true;
            this.btnGoToList.Click += new System.EventHandler(this.btnGoToList_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToList);
            this.Controls.Add(this.grpPizzaSize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpCrustTypes);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpPizzaShapes);
            this.Name = "Order";
            this.Text = "Order";
            this.grpPizzaShapes.ResumeLayout(false);
            this.grpPizzaShapes.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpCrustTypes.ResumeLayout(false);
            this.grpCrustTypes.PerformLayout();
            this.grpPizzaSize.ResumeLayout(false);
            this.grpPizzaSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpPizzaShapes;
        private GroupBox grpToppings;
        private GroupBox grpCrustTypes;
        private Button btnOrder;
        private Button btnExit;
        private RadioButton rdoSquareShape;
        private RadioButton rdoCircleShape;
        private RadioButton rdoFlatbread;
        private RadioButton rdoThinCrust;
        private RadioButton rdoCrackerCrust;
        private RadioButton rdoStuffedCrust;
        private CheckBox chkHam;
        private CheckBox chkBeef;
        private CheckBox chkBlackOlives;
        private CheckBox chkPineapple;
        private CheckBox chkBacon;
        private CheckBox chkMushrooms;
        private CheckBox chkSausage;
        private CheckBox chkPepperoni;
        private GroupBox grpPizzaSize;
        private RadioButton rdoLarge;
        private RadioButton rdoMedium;
        private RadioButton rdoSmall;
        private Button btnGoToList;
    }
}