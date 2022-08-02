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
            this.rdoCircleShape = new System.Windows.Forms.RadioButton();
            this.rdoSquareShape = new System.Windows.Forms.RadioButton();
            this.rdoStuffedCrust = new System.Windows.Forms.RadioButton();
            this.rdoCrackerCrust = new System.Windows.Forms.RadioButton();
            this.rdoThinCrust = new System.Windows.Forms.RadioButton();
            this.rdoFlatbread = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.grpPizzaShapes.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpCrustTypes.SuspendLayout();
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
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.checkBox8);
            this.grpToppings.Controls.Add(this.checkBox7);
            this.grpToppings.Controls.Add(this.checkBox6);
            this.grpToppings.Controls.Add(this.checkBox5);
            this.grpToppings.Controls.Add(this.checkBox4);
            this.grpToppings.Controls.Add(this.checkBox3);
            this.grpToppings.Controls.Add(this.checkBox2);
            this.grpToppings.Controls.Add(this.checkBox1);
            this.grpToppings.Location = new System.Drawing.Point(330, 37);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(250, 176);
            this.grpToppings.TabIndex = 1;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
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
            this.grpCrustTypes.Text = "Crust Types";
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
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 57);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 24);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 87);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 24);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 117);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(101, 24);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(113, 27);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(101, 24);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(113, 57);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(101, 24);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(113, 87);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(101, 24);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(113, 117);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(101, 24);
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
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
            this.grpPizzaShapes.ResumeLayout(false);
            this.grpPizzaShapes.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpCrustTypes.ResumeLayout(false);
            this.grpCrustTypes.PerformLayout();
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
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}