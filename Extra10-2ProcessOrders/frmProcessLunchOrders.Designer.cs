namespace Extra10_2ProcessOrders
{
    partial class frmProcessLunchOrders
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
            this.grpMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.grpAddOn = new System.Windows.Forms.GroupBox();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.chkKMM = new System.Windows.Forms.CheckBox();
            this.chkLTO = new System.Windows.Forms.CheckBox();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClearTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearAddOns = new System.Windows.Forms.Button();
            this.grpMainCourse.SuspendLayout();
            this.grpAddOn.SuspendLayout();
            this.grpTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainCourse
            // 
            this.grpMainCourse.Controls.Add(this.rdoSalad);
            this.grpMainCourse.Controls.Add(this.rdoPizza);
            this.grpMainCourse.Controls.Add(this.rdoHamburger);
            this.grpMainCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMainCourse.Location = new System.Drawing.Point(12, 12);
            this.grpMainCourse.Name = "grpMainCourse";
            this.grpMainCourse.Size = new System.Drawing.Size(200, 137);
            this.grpMainCourse.TabIndex = 0;
            this.grpMainCourse.TabStop = false;
            this.grpMainCourse.Text = "Main Course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSalad.Location = new System.Drawing.Point(18, 97);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(162, 24);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.TabStop = true;
            this.rdoSalad.Text = "Salad - $6.75";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPizza.Location = new System.Drawing.Point(18, 67);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(162, 24);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.TabStop = true;
            this.rdoPizza.Text = "Pizza - $6.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHamburger.Location = new System.Drawing.Point(18, 37);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(162, 24);
            this.rdoHamburger.TabIndex = 0;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $7.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.rdoHamburger_CheckedChanged);
            // 
            // grpAddOn
            // 
            this.grpAddOn.Controls.Add(this.chkFries);
            this.grpAddOn.Controls.Add(this.chkKMM);
            this.grpAddOn.Controls.Add(this.chkLTO);
            this.grpAddOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddOn.Location = new System.Drawing.Point(218, 12);
            this.grpAddOn.Name = "grpAddOn";
            this.grpAddOn.Size = new System.Drawing.Size(261, 137);
            this.grpAddOn.TabIndex = 1;
            this.grpAddOn.TabStop = false;
            this.grpAddOn.Text = "Add-on items ($1.25/each)";
            // 
            // chkFries
            // 
            this.chkFries.AutoSize = true;
            this.chkFries.Location = new System.Drawing.Point(21, 98);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(112, 24);
            this.chkFries.TabIndex = 2;
            this.chkFries.Text = "French fries";
            this.chkFries.UseVisualStyleBackColor = true;
            // 
            // chkKMM
            // 
            this.chkKMM.AutoSize = true;
            this.chkKMM.Location = new System.Drawing.Point(21, 68);
            this.chkKMM.Name = "chkKMM";
            this.chkKMM.Size = new System.Drawing.Size(199, 24);
            this.chkKMM.TabIndex = 1;
            this.chkKMM.Text = "Ketchup, mustard, mayo";
            this.chkKMM.UseVisualStyleBackColor = true;
            // 
            // chkLTO
            // 
            this.chkLTO.AutoSize = true;
            this.chkLTO.Location = new System.Drawing.Point(21, 38);
            this.chkLTO.Name = "chkLTO";
            this.chkLTO.Size = new System.Drawing.Size(195, 24);
            this.chkLTO.TabIndex = 0;
            this.chkLTO.Text = "Lettuce, tomato, onions";
            this.chkLTO.UseVisualStyleBackColor = true;
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.txtTotal);
            this.grpTotal.Controls.Add(this.txtTax);
            this.grpTotal.Controls.Add(this.txtSubtotal);
            this.grpTotal.Controls.Add(this.label2);
            this.grpTotal.Controls.Add(this.label1);
            this.grpTotal.Controls.Add(this.lblSubtotal);
            this.grpTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotal.Location = new System.Drawing.Point(12, 174);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(261, 143);
            this.grpTotal.TabIndex = 5;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Order Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(120, 98);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(117, 26);
            this.txtTotal.TabIndex = 2;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(120, 66);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(117, 26);
            this.txtTax.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(120, 34);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(117, 26);
            this.txtSubtotal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order Total:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tax (7.75%):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(14, 33);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 29);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(334, 176);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(128, 27);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClearTotal
            // 
            this.btnClearTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTotal.Location = new System.Drawing.Point(334, 250);
            this.btnClearTotal.Name = "btnClearTotal";
            this.btnClearTotal.Size = new System.Drawing.Size(128, 27);
            this.btnClearTotal.TabIndex = 3;
            this.btnClearTotal.Text = "Clear Total";
            this.btnClearTotal.UseVisualStyleBackColor = true;
            this.btnClearTotal.Click += new System.EventHandler(this.btnClearTotal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(334, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearAddOns
            // 
            this.btnClearAddOns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAddOns.Location = new System.Drawing.Point(334, 209);
            this.btnClearAddOns.Name = "btnClearAddOns";
            this.btnClearAddOns.Size = new System.Drawing.Size(128, 27);
            this.btnClearAddOns.TabIndex = 6;
            this.btnClearAddOns.Text = "Clear Add-ons";
            this.btnClearAddOns.UseVisualStyleBackColor = true;
            this.btnClearAddOns.Click += new System.EventHandler(this.btnClearAddOns_Click);
            // 
            // frmProcessLunchOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(506, 339);
            this.Controls.Add(this.btnClearAddOns);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearTotal);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.grpAddOn);
            this.Controls.Add(this.grpMainCourse);
            this.Name = "frmProcessLunchOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place order";
            this.grpMainCourse.ResumeLayout(false);
            this.grpAddOn.ResumeLayout(false);
            this.grpAddOn.PerformLayout();
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMainCourse;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.GroupBox grpAddOn;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.CheckBox chkKMM;
        private System.Windows.Forms.CheckBox chkLTO;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClearTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearAddOns;
    }
}

