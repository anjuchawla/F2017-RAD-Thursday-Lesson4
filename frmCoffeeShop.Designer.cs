namespace Coffee_Sales
{
    partial class frmCoffeeShop
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkTakeout = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCoffee = new System.Windows.Forms.GroupBox();
            this.rdoIcedCappuccino = new System.Windows.Forms.RadioButton();
            this.rdoIcedLatte = new System.Windows.Forms.RadioButton();
            this.rdoLatte = new System.Windows.Forms.RadioButton();
            this.rdoEspresso = new System.Windows.Forms.RadioButton();
            this.rdoCappuccino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.csmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSummary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSummary = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpCoffee.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coffee Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anju Chawla";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtItemAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.chkTakeout);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.grpCoffee);
            this.groupBox1.Location = new System.Drawing.Point(27, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(110, 40);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtItemAmount
            // 
            this.txtItemAmount.Location = new System.Drawing.Point(135, 215);
            this.txtItemAmount.Name = "txtItemAmount";
            this.txtItemAmount.ReadOnly = true;
            this.txtItemAmount.Size = new System.Drawing.Size(172, 22);
            this.txtItemAmount.TabIndex = 7;
            this.txtItemAmount.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Item Amount";
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(135, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 53);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear for Next Item";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(29, 137);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 53);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate Selection";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chkTakeout
            // 
            this.chkTakeout.AutoSize = true;
            this.chkTakeout.Location = new System.Drawing.Point(29, 95);
            this.chkTakeout.Name = "chkTakeout";
            this.chkTakeout.Size = new System.Drawing.Size(90, 21);
            this.chkTakeout.TabIndex = 3;
            this.chkTakeout.Text = "Ta&keout?";
            this.chkTakeout.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Quantity";
            // 
            // grpCoffee
            // 
            this.grpCoffee.Controls.Add(this.rdoIcedCappuccino);
            this.grpCoffee.Controls.Add(this.rdoIcedLatte);
            this.grpCoffee.Controls.Add(this.rdoLatte);
            this.grpCoffee.Controls.Add(this.rdoEspresso);
            this.grpCoffee.Controls.Add(this.rdoCappuccino);
            this.grpCoffee.Location = new System.Drawing.Point(347, 43);
            this.grpCoffee.Name = "grpCoffee";
            this.grpCoffee.Size = new System.Drawing.Size(200, 194);
            this.grpCoffee.TabIndex = 2;
            this.grpCoffee.TabStop = false;
            this.grpCoffee.Text = "Coffee Selections";
            // 
            // rdoIcedCappuccino
            // 
            this.rdoIcedCappuccino.AutoSize = true;
            this.rdoIcedCappuccino.Location = new System.Drawing.Point(19, 139);
            this.rdoIcedCappuccino.Name = "rdoIcedCappuccino";
            this.rdoIcedCappuccino.Size = new System.Drawing.Size(133, 21);
            this.rdoIcedCappuccino.TabIndex = 4;
            this.rdoIcedCappuccino.TabStop = true;
            this.rdoIcedCappuccino.Text = "Iced Ca&ppuccino";
            this.rdoIcedCappuccino.UseVisualStyleBackColor = true;
            this.rdoIcedCappuccino.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoIcedLatte
            // 
            this.rdoIcedLatte.AutoSize = true;
            this.rdoIcedLatte.Location = new System.Drawing.Point(19, 110);
            this.rdoIcedLatte.Name = "rdoIcedLatte";
            this.rdoIcedLatte.Size = new System.Drawing.Size(91, 21);
            this.rdoIcedLatte.TabIndex = 3;
            this.rdoIcedLatte.TabStop = true;
            this.rdoIcedLatte.Text = "&Iced Latte";
            this.rdoIcedLatte.UseVisualStyleBackColor = true;
            this.rdoIcedLatte.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoLatte
            // 
            this.rdoLatte.AutoSize = true;
            this.rdoLatte.Location = new System.Drawing.Point(19, 81);
            this.rdoLatte.Name = "rdoLatte";
            this.rdoLatte.Size = new System.Drawing.Size(61, 21);
            this.rdoLatte.TabIndex = 2;
            this.rdoLatte.TabStop = true;
            this.rdoLatte.Text = "La&tte";
            this.rdoLatte.UseVisualStyleBackColor = true;
            this.rdoLatte.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoEspresso
            // 
            this.rdoEspresso.AutoSize = true;
            this.rdoEspresso.Location = new System.Drawing.Point(19, 52);
            this.rdoEspresso.Name = "rdoEspresso";
            this.rdoEspresso.Size = new System.Drawing.Size(88, 21);
            this.rdoEspresso.TabIndex = 1;
            this.rdoEspresso.TabStop = true;
            this.rdoEspresso.Text = "Espress&o";
            this.rdoEspresso.UseVisualStyleBackColor = true;
            this.rdoEspresso.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoCappuccino
            // 
            this.rdoCappuccino.AutoSize = true;
            this.rdoCappuccino.Location = new System.Drawing.Point(19, 23);
            this.rdoCappuccino.Name = "rdoCappuccino";
            this.rdoCappuccino.Size = new System.Drawing.Size(103, 21);
            this.rdoCappuccino.TabIndex = 0;
            this.rdoCappuccino.TabStop = true;
            this.rdoCappuccino.Text = "C&appuccino";
            this.rdoCappuccino.UseVisualStyleBackColor = true;
            this.rdoCappuccino.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalDue);
            this.groupBox3.Controls.Add(this.txtTax);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(27, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 159);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount Due";
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.Location = new System.Drawing.Point(209, 121);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.ReadOnly = true;
            this.txtTotalDue.Size = new System.Drawing.Size(165, 22);
            this.txtTotalDue.TabIndex = 5;
            this.txtTotalDue.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(209, 80);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(165, 22);
            this.txtTax.TabIndex = 4;
            this.txtTax.TabStop = false;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(209, 41);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(165, 22);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Due";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tax(if takeout)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subtotal";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(517, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(411, 561);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(100, 29);
            this.btnNewOrder.TabIndex = 1;
            this.btnNewOrder.Text = "&New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmiAbout,
            this.csmiExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 52);
            // 
            // csmiAbout
            // 
            this.csmiAbout.Name = "csmiAbout";
            this.csmiAbout.Size = new System.Drawing.Size(119, 24);
            this.csmiAbout.Text = "&About";
            this.csmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // csmiExit
            // 
            this.csmiExit.Name = "csmiExit";
            this.csmiExit.Size = new System.Drawing.Size(119, 24);
            this.csmiExit.Text = "E&xit";
            this.csmiExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.tsmiSummary,
            this.toolStripSeparator2,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 24);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCalculate,
            this.tsmiClear,
            this.toolStripSeparator1,
            this.tsmiFont,
            this.tsmiColor});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(47, 24);
            this.tsmiEdit.Text = "&Edit";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(53, 24);
            this.tsmiHelp.Text = "&Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(181, 26);
            this.tsmiAbout.Text = "&About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiCalculate
            // 
            this.tsmiCalculate.Name = "tsmiCalculate";
            this.tsmiCalculate.Size = new System.Drawing.Size(210, 26);
            this.tsmiCalculate.Text = "&Calculate Selection";
            this.tsmiCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(210, 26);
            this.tsmiClear.Text = "C&lear";
            this.tsmiClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(210, 26);
            this.tsmiFont.Text = "&Font...";
            // 
            // tsmiColor
            // 
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(210, 26);
            this.tsmiColor.Text = "C&olor...";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newOrderToolStripMenuItem.Text = "&New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // tsmiSummary
            // 
            this.tsmiSummary.Name = "tsmiSummary";
            this.tsmiSummary.Size = new System.Drawing.Size(181, 26);
            this.tsmiSummary.Text = "&Summary";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiExit.Size = new System.Drawing.Size(181, 26);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(305, 561);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(100, 29);
            this.btnSummary.TabIndex = 8;
            this.btnSummary.Text = "&Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // frmCoffeeShop
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(645, 621);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCoffeeShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Order Receipt";
            this.Load += new System.EventHandler(this.frmCoffeeShop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCoffee.ResumeLayout(false);
            this.grpCoffee.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkTakeout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpCoffee;
        private System.Windows.Forms.RadioButton rdoIcedCappuccino;
        private System.Windows.Forms.RadioButton rdoIcedLatte;
        private System.Windows.Forms.RadioButton rdoLatte;
        private System.Windows.Forms.RadioButton rdoEspresso;
        private System.Windows.Forms.RadioButton rdoCappuccino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem csmiAbout;
        private System.Windows.Forms.ToolStripMenuItem csmiExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSummary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalculate;
        private System.Windows.Forms.ToolStripMenuItem tsmiClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Button btnSummary;
    }
}

