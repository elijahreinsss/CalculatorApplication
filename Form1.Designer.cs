namespace CalculatorApplication
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            enter_firstnum_label = new Label();
            enter_secondnum_label = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            btnEqual = new Button();
            label1 = new Label();
            lblDisplayTotal = new Label();
            cbOperator = new ComboBox();
            SuspendLayout();
            // 
            // enter_firstnum_label
            // 
            enter_firstnum_label.AutoSize = true;
            enter_firstnum_label.Font = new Font("Segoe UI", 12F);
            enter_firstnum_label.Location = new Point(387, 137);
            enter_firstnum_label.Margin = new Padding(4, 0, 4, 0);
            enter_firstnum_label.Name = "enter_firstnum_label";
            enter_firstnum_label.Size = new Size(145, 21);
            enter_firstnum_label.TabIndex = 0;
            enter_firstnum_label.Text = "Enter First Number:";
            // 
            // enter_secondnum_label
            // 
            enter_secondnum_label.AutoSize = true;
            enter_secondnum_label.Font = new Font("Segoe UI", 12F);
            enter_secondnum_label.Location = new Point(366, 239);
            enter_secondnum_label.Margin = new Padding(4, 0, 4, 0);
            enter_secondnum_label.Name = "enter_secondnum_label";
            enter_secondnum_label.Size = new Size(166, 21);
            enter_secondnum_label.TabIndex = 1;
            enter_secondnum_label.Text = "Enter Second Number:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.Location = new Point(560, 137);
            txtBoxInput1.Margin = new Padding(4, 4, 4, 4);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(127, 29);
            txtBoxInput1.TabIndex = 3;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.Location = new Point(560, 239);
            txtBoxInput2.Margin = new Padding(4, 4, 4, 4);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(127, 29);
            txtBoxInput2.TabIndex = 4;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14F);
            btnEqual.Location = new Point(433, 383);
            btnEqual.Margin = new Padding(4, 4, 4, 4);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(165, 50);
            btnEqual.TabIndex = 6;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(446, 315);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 7;
            label1.Text = "Answer: ";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F);
            lblDisplayTotal.Location = new Point(542, 315);
            lblDisplayTotal.Margin = new Padding(4, 0, 4, 0);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(69, 21);
            lblDisplayTotal.TabIndex = 8;
            lblDisplayTotal.Text = "Answer: ";
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(582, 195);
            cbOperator.Margin = new Padding(4, 4, 4, 4);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(82, 27);
            cbOperator.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(cbOperator);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label1);
            Controls.Add(btnEqual);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(enter_secondnum_label);
            Controls.Add(enter_firstnum_label);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "FrmCalculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enter_firstnum_label;
        private Label enter_secondnum_label;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private Button btnEqual;
        private Label label1;
        private Label lblDisplayTotal;
        private ComboBox cbOperator;
    }
}
