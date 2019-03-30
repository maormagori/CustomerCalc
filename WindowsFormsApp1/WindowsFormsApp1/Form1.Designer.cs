namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_customers = new System.Windows.Forms.ComboBox();
            this.comboBox_kids = new System.Windows.Forms.ComboBox();
            this.comboBox_soliders = new System.Windows.Forms.ComboBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_PricePerson = new System.Windows.Forms.Label();
            this.label_PriceKid = new System.Windows.Forms.Label();
            this.label_PriceSolider = new System.Windows.Forms.Label();
            this.checkBox_deposit = new System.Windows.Forms.CheckBox();
            this.checkBox_distance = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(512, 106);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "מספר משתתפים:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(548, 265);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "מספר ילדים:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(172, 265);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "מספר חיילים/סטודנטים:";
            // 
            // comboBox_customers
            // 
            this.comboBox_customers.FormattingEnabled = true;
            this.comboBox_customers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_customers.Location = new System.Drawing.Point(385, 106);
            this.comboBox_customers.Name = "comboBox_customers";
            this.comboBox_customers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_customers.Size = new System.Drawing.Size(121, 21);
            this.comboBox_customers.TabIndex = 3;
            this.comboBox_customers.Text = "0";
            this.comboBox_customers.SelectedIndexChanged += new System.EventHandler(this.comboBox_customers_SelectedIndexChanged);
            this.comboBox_customers.TextUpdate += new System.EventHandler(this.comboBox_customers_TextUpdate);
            // 
            // comboBox_kids
            // 
            this.comboBox_kids.FormattingEnabled = true;
            this.comboBox_kids.Items.AddRange(new object[] {
            "0"});
            this.comboBox_kids.Location = new System.Drawing.Point(410, 269);
            this.comboBox_kids.Name = "comboBox_kids";
            this.comboBox_kids.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_kids.Size = new System.Drawing.Size(121, 21);
            this.comboBox_kids.TabIndex = 4;
            this.comboBox_kids.Text = "0";
            this.comboBox_kids.SelectedIndexChanged += new System.EventHandler(this.change_price);
            this.comboBox_kids.TextUpdate += new System.EventHandler(this.comboBox_customers_TextUpdate);
            // 
            // comboBox_soliders
            // 
            this.comboBox_soliders.FormattingEnabled = true;
            this.comboBox_soliders.Items.AddRange(new object[] {
            "0"});
            this.comboBox_soliders.Location = new System.Drawing.Point(32, 269);
            this.comboBox_soliders.Name = "comboBox_soliders";
            this.comboBox_soliders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_soliders.Size = new System.Drawing.Size(121, 21);
            this.comboBox_soliders.TabIndex = 5;
            this.comboBox_soliders.Text = "0";
            this.comboBox_soliders.SelectedIndexChanged += new System.EventHandler(this.change_price);
            this.comboBox_soliders.TextUpdate += new System.EventHandler(this.comboBox_customers_TextUpdate);
            // 
            // textBox_price
            // 
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_price.Location = new System.Drawing.Point(32, 395);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_price.Size = new System.Drawing.Size(633, 116);
            this.textBox_price.TabIndex = 6;
            this.textBox_price.Text = "0₪";
            this.textBox_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_PricePerson
            // 
            this.label_PricePerson.AutoSize = true;
            this.label_PricePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_PricePerson.Location = new System.Drawing.Point(548, 527);
            this.label_PricePerson.Name = "label_PricePerson";
            this.label_PricePerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_PricePerson.Size = new System.Drawing.Size(122, 25);
            this.label_PricePerson.TabIndex = 7;
            this.label_PricePerson.Text = "מחיר לאדם: ";
            this.label_PricePerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_PriceKid
            // 
            this.label_PriceKid.AutoSize = true;
            this.label_PriceKid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_PriceKid.Location = new System.Drawing.Point(354, 527);
            this.label_PriceKid.Name = "label_PriceKid";
            this.label_PriceKid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_PriceKid.Size = new System.Drawing.Size(108, 25);
            this.label_PriceKid.TabIndex = 8;
            this.label_PriceKid.Text = "מחיר לילד:";
            this.label_PriceKid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_PriceSolider
            // 
            this.label_PriceSolider.AutoSize = true;
            this.label_PriceSolider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_PriceSolider.Location = new System.Drawing.Point(72, 527);
            this.label_PriceSolider.Name = "label_PriceSolider";
            this.label_PriceSolider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_PriceSolider.Size = new System.Drawing.Size(187, 25);
            this.label_PriceSolider.TabIndex = 9;
            this.label_PriceSolider.Text = "מחיר לחייל/סטודנט:";
            this.label_PriceSolider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_deposit
            // 
            this.checkBox_deposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_deposit.AutoSize = true;
            this.checkBox_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox_deposit.Location = new System.Drawing.Point(572, 352);
            this.checkBox_deposit.Name = "checkBox_deposit";
            this.checkBox_deposit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_deposit.Size = new System.Drawing.Size(93, 20);
            this.checkBox_deposit.TabIndex = 10;
            this.checkBox_deposit.Text = "לאחר פקדון";
            this.checkBox_deposit.UseVisualStyleBackColor = true;
            this.checkBox_deposit.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_distance
            // 
            this.checkBox_distance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_distance.AutoSize = true;
            this.checkBox_distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox_distance.Location = new System.Drawing.Point(579, 326);
            this.checkBox_distance.Name = "checkBox_distance";
            this.checkBox_distance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_distance.Size = new System.Drawing.Size(86, 20);
            this.checkBox_distance.TabIndex = 11;
            this.checkBox_distance.Text = "באו מרחוק";
            this.checkBox_distance.UseVisualStyleBackColor = true;
            this.checkBox_distance.CheckedChanged += new System.EventHandler(this.distanceDeposit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 599);
            this.Controls.Add(this.checkBox_distance);
            this.Controls.Add(this.checkBox_deposit);
            this.Controls.Add(this.label_PriceSolider);
            this.Controls.Add(this.label_PriceKid);
            this.Controls.Add(this.label_PricePerson);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.comboBox_soliders);
            this.Controls.Add(this.comboBox_kids);
            this.Controls.Add(this.comboBox_customers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_customers;
        private System.Windows.Forms.ComboBox comboBox_kids;
        private System.Windows.Forms.ComboBox comboBox_soliders;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_PricePerson;
        private System.Windows.Forms.Label label_PriceKid;
        private System.Windows.Forms.Label label_PriceSolider;
        private System.Windows.Forms.CheckBox checkBox_deposit;
        private System.Windows.Forms.CheckBox checkBox_distance;
    }
}

