namespace CMSFormsApp
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            lblCarNo = new Label();
            lblAddress = new Label();
            lblName = new Label();
            lblMake = new Label();
            btnSave = new Button();
            btnEdit = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnPrevious = new Button();
            btnNext = new Button();
            errorCustomer = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorCustomer).BeginInit();
            SuspendLayout();
            // 
            // lblCarNo
            // 
            lblCarNo.AutoSize = true;
            lblCarNo.Location = new Point(102, 107);
            lblCarNo.Name = "lblCarNo";
            lblCarNo.Size = new Size(59, 20);
            lblCarNo.TabIndex = 0;
            lblCarNo.Text = "Car No";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(446, 107);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 20);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(102, 218);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(446, 218);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(49, 20);
            lblMake.TabIndex = 3;
            lblMake.Text = "Make";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(159, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(282, 282);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(410, 282);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(524, 282);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(568, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 218);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(568, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(209, 338);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(362, 27);
            textBox5.TabIndex = 12;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(111, 338);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 13;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(577, 338);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 14;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // errorCustomer
            // 
            errorCustomer.ContainerControl = this;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(lblMake);
            Controls.Add(lblName);
            Controls.Add(lblAddress);
            Controls.Add(lblCarNo);
            Name = "Form3";
            Text = "CustomerForm";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)errorCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarNo;
        private Label lblAddress;
        private Label lblName;
        private Label lblMake;
        private Button btnSave;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnExit;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnPrevious;
        private Button btnNext;
        private ErrorProvider errorCustomer;
    }
}