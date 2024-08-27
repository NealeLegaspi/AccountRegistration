namespace AccountRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtStudentNo = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            txtAddress = new TextBox();
            cbProgram = new ComboBox();
            btn_Next = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(328, 19);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 1;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(25, 112);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(328, 111);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 3;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(25, 182);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 4;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(328, 182);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 5;
            label6.Text = "Contact No.:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(593, 111);
            label7.Name = "label7";
            label7.Size = new Size(104, 21);
            label7.TabIndex = 6;
            label7.Text = "Middle Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(25, 268);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 7;
            label8.Text = "Address";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(25, 43);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(252, 23);
            txtStudentNo.TabIndex = 8;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(593, 136);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(186, 23);
            txtMiddleName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(25, 136);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(252, 23);
            txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(328, 136);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(252, 23);
            txtFirstName.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(25, 206);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(164, 23);
            txtAge.TabIndex = 12;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(328, 206);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(252, 23);
            txtContactNo.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(25, 292);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(754, 155);
            txtAddress.TabIndex = 14;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Information Technology (BSIT)", "BS in Computer Science (BSCS)", "BS in Information Systems (BSIS)", "BS in Business Administration (BSBA)", "BS in Accountancy (BSA)", "BS in Accounting Information System (BSAIS)", "BS in Management Accounting (BSMA)" });
            cbProgram.Location = new Point(328, 43);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(369, 23);
            cbProgram.TabIndex = 15;
            // 
            // btn_Next
            // 
            btn_Next.Font = new Font("Segoe UI", 12F);
            btn_Next.Location = new Point(348, 453);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(88, 30);
            btn_Next.TabIndex = 16;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(btn_Next);
            Controls.Add(cbProgram);
            Controls.Add(txtAddress);
            Controls.Add(txtContactNo);
            Controls.Add(txtAge);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtStudentNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtStudentNo;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtAge;
        private TextBox txtContactNo;
        private TextBox txtAddress;
        private ComboBox cbProgram;
        private Button btn_Next;
    }
}
