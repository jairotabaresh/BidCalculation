using System.Windows.Forms;

namespace BidCalculationExample
{
    partial class BidCalculationForm
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVehicleType = new System.Windows.Forms.ComboBox();
            this.nudVehicleBasePrice = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txttotalValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaddedCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleBasePrice)).BeginInit();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(291, 125);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 20);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Base Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle Type";
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Items.AddRange(new object[] {
            "Common",
            "Luxury"});
            this.cbVehicleType.Location = new System.Drawing.Point(291, 83);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(104, 21);
            this.cbVehicleType.TabIndex = 4;
            // 
            // nudVehicleBasePrice
            // 
            this.nudVehicleBasePrice.Location = new System.Drawing.Point(291, 46);
            this.nudVehicleBasePrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudVehicleBasePrice.Name = "nudVehicleBasePrice";
            this.nudVehicleBasePrice.Size = new System.Drawing.Size(103, 20);
            this.nudVehicleBasePrice.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 96);
            this.listBox1.TabIndex = 0;
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.label10);
            this.pnlResult.Controls.Add(this.txttotalValue);
            this.pnlResult.Controls.Add(this.label9);
            this.pnlResult.Controls.Add(this.txtStorage);
            this.pnlResult.Controls.Add(this.label8);
            this.pnlResult.Controls.Add(this.txtaddedCost);
            this.pnlResult.Controls.Add(this.label7);
            this.pnlResult.Controls.Add(this.label6);
            this.pnlResult.Controls.Add(this.txtSpecial);
            this.pnlResult.Controls.Add(this.txtBasic);
            this.pnlResult.Controls.Add(this.label5);
            this.pnlResult.Controls.Add(this.txtType);
            this.pnlResult.Controls.Add(this.label4);
            this.pnlResult.Controls.Add(this.txtPrice);
            this.pnlResult.Controls.Add(this.label3);
            this.pnlResult.Location = new System.Drawing.Point(178, 177);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(247, 190);
            this.pnlResult.TabIndex = 6;
            this.pnlResult.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total ($)";
            // 
            // txttotalValue
            // 
            this.txttotalValue.Enabled = false;
            this.txttotalValue.Location = new System.Drawing.Point(115, 160);
            this.txttotalValue.Name = "txttotalValue";
            this.txttotalValue.Size = new System.Drawing.Size(102, 20);
            this.txttotalValue.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Storage";
            // 
            // txtStorage
            // 
            this.txtStorage.Enabled = false;
            this.txtStorage.Location = new System.Drawing.Point(115, 135);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.Size = new System.Drawing.Size(102, 20);
            this.txtStorage.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Association";
            // 
            // txtaddedCost
            // 
            this.txtaddedCost.Enabled = false;
            this.txtaddedCost.Location = new System.Drawing.Point(115, 110);
            this.txtaddedCost.Name = "txtaddedCost";
            this.txtaddedCost.Size = new System.Drawing.Size(102, 20);
            this.txtaddedCost.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Special";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Basic";
            // 
            // txtSpecial
            // 
            this.txtSpecial.Enabled = false;
            this.txtSpecial.Location = new System.Drawing.Point(115, 85);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(102, 20);
            this.txtSpecial.TabIndex = 12;
            // 
            // txtBasic
            // 
            this.txtBasic.Enabled = false;
            this.txtBasic.Location = new System.Drawing.Point(115, 60);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(102, 20);
            this.txtBasic.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-77, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Basic";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(115, 36);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(102, 20);
            this.txtType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehicle Type";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(115, 10);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(102, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vehicle Price ($)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 390);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.nudVehicleBasePrice);
            this.Controls.Add(this.cbVehicleType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Bid Calculation";
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleBasePrice)).EndInit();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalculate;
        private Label label1;
        private Label label2;
        private ComboBox cbVehicleType;
        private NumericUpDown nudVehicleBasePrice;
        private ListBox listBox1;
        private Panel pnlResult;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtType;
        private Label label4;
        private TextBox txtBasic;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox txtSpecial;
        private TextBox txtaddedCost;
        private Label label8;
        private Label label9;
        private TextBox txtStorage;
        private Label label10;
        private TextBox txttotalValue;
    }
}