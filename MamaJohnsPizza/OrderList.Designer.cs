namespace MamaJohn_sPizza
{
    partial class OrderList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnExitOrderList = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 20;
            this.lstOrders.Location = new System.Drawing.Point(62, 29);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(360, 224);
            this.lstOrders.TabIndex = 0;
            // 
            // btnExitOrderList
            // 
            this.btnExitOrderList.Location = new System.Drawing.Point(62, 291);
            this.btnExitOrderList.Name = "btnExitOrderList";
            this.btnExitOrderList.Size = new System.Drawing.Size(127, 61);
            this.btnExitOrderList.TabIndex = 1;
            this.btnExitOrderList.Text = "Exit";
            this.btnExitOrderList.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(295, 291);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(127, 61);
            this.btnDeleteOrder.TabIndex = 2;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 374);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnExitOrderList);
            this.Controls.Add(this.lstOrders);
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstOrders;
        private Button btnExitOrderList;
        private Button btnDeleteOrder;
    }
}