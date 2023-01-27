namespace ShoppingCart
{
    partial class frmShoppingCart
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.lblItem3 = new System.Windows.Forms.Label();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.lblItem1Price = new System.Windows.Forms.Label();
            this.lblItem3Price = new System.Windows.Forms.Label();
            this.lblItem2Price = new System.Windows.Forms.Label();
            this.txtQuantity1 = new System.Windows.Forms.TextBox();
            this.txtQuantity3 = new System.Windows.Forms.TextBox();
            this.txtQuantity2 = new System.Windows.Forms.TextBox();
            this.lblToatal1 = new System.Windows.Forms.Label();
            this.lblToatal2 = new System.Windows.Forms.Label();
            this.lblToatal3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.btnUpdateCart = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkRemove3 = new System.Windows.Forms.LinkLabel();
            this.linkRemove2 = new System.Windows.Forms.LinkLabel();
            this.linkRemove1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Shopping Cart";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "Description \tUnit Price \t\tQuantity\t\tTotal Price"});
            this.listBox1.Location = new System.Drawing.Point(12, 88);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(564, 25);
            this.listBox1.TabIndex = 3;
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem1.Location = new System.Drawing.Point(12, 117);
            this.lblItem1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(46, 21);
            this.lblItem1.TabIndex = 4;
            this.lblItem1.Text = "Shirt";
            // 
            // lblItem3
            // 
            this.lblItem3.AutoSize = true;
            this.lblItem3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem3.Location = new System.Drawing.Point(12, 188);
            this.lblItem3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem3.Name = "lblItem3";
            this.lblItem3.Size = new System.Drawing.Size(52, 21);
            this.lblItem3.TabIndex = 5;
            this.lblItem3.Text = "Pants";
            this.lblItem3.Click += new System.EventHandler(this.lblItem3_Click);
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem2.Location = new System.Drawing.Point(12, 153);
            this.lblItem2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(55, 21);
            this.lblItem2.TabIndex = 6;
            this.lblItem2.Text = "Shoes";
            // 
            // lblItem1Price
            // 
            this.lblItem1Price.AutoSize = true;
            this.lblItem1Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem1Price.Location = new System.Drawing.Point(173, 117);
            this.lblItem1Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem1Price.Name = "lblItem1Price";
            this.lblItem1Price.Size = new System.Drawing.Size(62, 21);
            this.lblItem1Price.TabIndex = 7;
            this.lblItem1Price.Text = "700 Rs.";
            // 
            // lblItem3Price
            // 
            this.lblItem3Price.AutoSize = true;
            this.lblItem3Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem3Price.Location = new System.Drawing.Point(173, 188);
            this.lblItem3Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem3Price.Name = "lblItem3Price";
            this.lblItem3Price.Size = new System.Drawing.Size(71, 21);
            this.lblItem3Price.TabIndex = 8;
            this.lblItem3Price.Text = "1500 Rs.";
            // 
            // lblItem2Price
            // 
            this.lblItem2Price.AutoSize = true;
            this.lblItem2Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem2Price.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblItem2Price.Location = new System.Drawing.Point(173, 153);
            this.lblItem2Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem2Price.Name = "lblItem2Price";
            this.lblItem2Price.Size = new System.Drawing.Size(71, 21);
            this.lblItem2Price.TabIndex = 9;
            this.lblItem2Price.Text = "1000 Rs.";
            // 
            // txtQuantity1
            // 
            this.txtQuantity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity1.Location = new System.Drawing.Point(321, 117);
            this.txtQuantity1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantity1.Name = "txtQuantity1";
            this.txtQuantity1.Size = new System.Drawing.Size(100, 21);
            this.txtQuantity1.TabIndex = 10;
            this.txtQuantity1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtQuantity3
            // 
            this.txtQuantity3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity3.Location = new System.Drawing.Point(321, 188);
            this.txtQuantity3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantity3.Name = "txtQuantity3";
            this.txtQuantity3.Size = new System.Drawing.Size(100, 21);
            this.txtQuantity3.TabIndex = 11;
            this.txtQuantity3.TextChanged += new System.EventHandler(this.txtQuantity3_TextChanged);
            // 
            // txtQuantity2
            // 
            this.txtQuantity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity2.Location = new System.Drawing.Point(321, 153);
            this.txtQuantity2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantity2.Name = "txtQuantity2";
            this.txtQuantity2.Size = new System.Drawing.Size(100, 21);
            this.txtQuantity2.TabIndex = 12;
            this.txtQuantity2.TextChanged += new System.EventHandler(this.txtQuantity2_TextChanged);
            // 
            // lblToatal1
            // 
            this.lblToatal1.AutoSize = true;
            this.lblToatal1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToatal1.Location = new System.Drawing.Point(498, 117);
            this.lblToatal1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToatal1.Name = "lblToatal1";
            this.lblToatal1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblToatal1.Size = new System.Drawing.Size(19, 21);
            this.lblToatal1.TabIndex = 13;
            this.lblToatal1.Text = "0";
            this.lblToatal1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblToatal1.Click += new System.EventHandler(this.lblToatal1_Click);
            // 
            // lblToatal2
            // 
            this.lblToatal2.AutoSize = true;
            this.lblToatal2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToatal2.Location = new System.Drawing.Point(498, 153);
            this.lblToatal2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToatal2.Name = "lblToatal2";
            this.lblToatal2.Size = new System.Drawing.Size(19, 21);
            this.lblToatal2.TabIndex = 14;
            this.lblToatal2.Text = "0";
            this.lblToatal2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblToatal3
            // 
            this.lblToatal3.AutoSize = true;
            this.lblToatal3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToatal3.Location = new System.Drawing.Point(498, 188);
            this.lblToatal3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToatal3.Name = "lblToatal3";
            this.lblToatal3.Size = new System.Drawing.Size(19, 21);
            this.lblToatal3.TabIndex = 15;
            this.lblToatal3.Text = "0";
            this.lblToatal3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.listBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Items.AddRange(new object[] {
            "\t\t\t\t\tTOTAL    "});
            this.listBox2.Location = new System.Drawing.Point(12, 227);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(564, 25);
            this.listBox2.TabIndex = 16;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.BackColor = System.Drawing.Color.LimeGreen;
            this.lblFinalTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalTotal.Location = new System.Drawing.Point(499, 227);
            this.lblFinalTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(18, 20);
            this.lblFinalTotal.TabIndex = 17;
            this.lblFinalTotal.Text = "0";
            this.lblFinalTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnUpdateCart
            // 
            this.btnUpdateCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCart.Location = new System.Drawing.Point(12, 269);
            this.btnUpdateCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateCart.Name = "btnUpdateCart";
            this.btnUpdateCart.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateCart.TabIndex = 18;
            this.btnUpdateCart.Text = "Update Cart";
            this.btnUpdateCart.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 70);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 15);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "< Back to Products";
            // 
            // linkRemove3
            // 
            this.linkRemove3.AutoSize = true;
            this.linkRemove3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.linkRemove3.Location = new System.Drawing.Point(173, 209);
            this.linkRemove3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRemove3.Name = "linkRemove3";
            this.linkRemove3.Size = new System.Drawing.Size(48, 15);
            this.linkRemove3.TabIndex = 20;
            this.linkRemove3.TabStop = true;
            this.linkRemove3.Text = "Remove";
            this.linkRemove3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemove3_LinkClicked);
            // 
            // linkRemove2
            // 
            this.linkRemove2.AutoSize = true;
            this.linkRemove2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.linkRemove2.Location = new System.Drawing.Point(173, 174);
            this.linkRemove2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRemove2.Name = "linkRemove2";
            this.linkRemove2.Size = new System.Drawing.Size(48, 15);
            this.linkRemove2.TabIndex = 21;
            this.linkRemove2.TabStop = true;
            this.linkRemove2.Text = "Remove";
            this.linkRemove2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemove2_LinkClicked);
            // 
            // linkRemove1
            // 
            this.linkRemove1.AutoSize = true;
            this.linkRemove1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.linkRemove1.Location = new System.Drawing.Point(173, 138);
            this.linkRemove1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRemove1.Name = "linkRemove1";
            this.linkRemove1.Size = new System.Drawing.Size(48, 15);
            this.linkRemove1.TabIndex = 22;
            this.linkRemove1.TabStop = true;
            this.linkRemove1.Text = "Remove";
            this.linkRemove1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemove1_LinkClicked);
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 361);
            this.Controls.Add(this.linkRemove1);
            this.Controls.Add(this.linkRemove2);
            this.Controls.Add(this.linkRemove3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnUpdateCart);
            this.Controls.Add(this.lblFinalTotal);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblToatal3);
            this.Controls.Add(this.lblToatal2);
            this.Controls.Add(this.lblToatal1);
            this.Controls.Add(this.txtQuantity2);
            this.Controls.Add(this.txtQuantity3);
            this.Controls.Add(this.txtQuantity1);
            this.Controls.Add(this.lblItem2Price);
            this.Controls.Add(this.lblItem3Price);
            this.Controls.Add(this.lblItem1Price);
            this.Controls.Add(this.lblItem2);
            this.Controls.Add(this.lblItem3);
            this.Controls.Add(this.lblItem1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmShoppingCart";
            this.Text = "Shopping Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private ListBox listBox1;
        private Label lblItem1;
        private Label lblItem3;
        private Label lblItem2;
        private Label lblItem1Price;
        private Label lblItem3Price;
        private Label lblItem2Price;
        private TextBox txtQuantity1;
        private TextBox txtQuantity3;
        private TextBox txtQuantity2;
        private Label lblToatal1;
        private Label lblToatal2;
        private Label lblToatal3;
        private ListBox listBox2;
        private Label lblFinalTotal;
        private Button btnUpdateCart;
        private LinkLabel linkLabel1;
        private LinkLabel linkRemove3;
        private LinkLabel linkRemove2;
        private LinkLabel linkRemove1;
    }
}