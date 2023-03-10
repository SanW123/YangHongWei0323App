namespace CMSFormsApp
{
    partial class Form2
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
            label1 = new Label();
            btnSave = new Button();
            btnEdit = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            WrokerId = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            objectDataProviderBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)objectDataProviderBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(187, 65);
            label1.Name = "label1";
            label1.Size = new Size(440, 26);
            label1.TabIndex = 0;
            label1.Text = "Click on the Edit Button to load the records";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(175, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(295, 375);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(416, 375);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(546, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { WrokerId, Name });
            dataGridView1.Location = new Point(187, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(440, 248);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // WrokerId
            // 
            WrokerId.HeaderText = "WorkerId";
            WrokerId.MinimumWidth = 6;
            WrokerId.Name = "WrokerId";
            WrokerId.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // objectDataProviderBindingSource1
            // 
            objectDataProviderBindingSource1.CurrentChanged += objectDataProviderBindingSource1_CurrentChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "Form2";
            Text = "WorkerForm";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)objectDataProviderBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnExit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn WrokerId;
        private DataGridViewTextBoxColumn Name;
        private BindingSource objectDataProviderBindingSource1;
    }
}