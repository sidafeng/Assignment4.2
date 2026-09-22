namespace Assignment4._2
{
    partial class AddForm
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
            lblID = new Label();
            lblStudentName = new Label();
            lblGPA = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtGPA = new TextBox();
            btnAddStudent = new Button();
            gridStudentList = new DataGridView();
            btnDel = new Button();
            ((System.ComponentModel.ISupportInitialize)gridStudentList).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblID.Location = new Point(87, 317);
            lblID.Name = "lblID";
            lblID.Size = new Size(97, 23);
            lblID.TabIndex = 0;
            lblID.Text = "Student ID";
            lblID.Click += lblID_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblStudentName.Location = new Point(230, 317);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(126, 23);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name";
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGPA.Location = new Point(398, 317);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(112, 23);
            lblGPA.TabIndex = 2;
            lblGPA.Text = "Student GPA";
            // 
            // txtID
            // 
            txtID.Location = new Point(70, 355);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(230, 355);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(394, 355);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(125, 27);
            txtGPA.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(563, 317);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(175, 65);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // gridStudentList
            // 
            gridStudentList.AllowUserToAddRows = false;
            gridStudentList.AllowUserToDeleteRows = false;
            gridStudentList.AllowUserToResizeColumns = false;
            gridStudentList.AllowUserToResizeRows = false;
            gridStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudentList.Location = new Point(58, 35);
            gridStudentList.Name = "gridStudentList";
            gridStudentList.RowHeadersWidth = 51;
            gridStudentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridStudentList.Size = new Size(642, 239);
            gridStudentList.TabIndex = 5;
            gridStudentList.CellClick += gridStudentList_CellClick;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Red;
            btnDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(706, 53);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(66, 29);
            btnDel.TabIndex = 6;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDel);
            Controls.Add(gridStudentList);
            Controls.Add(btnAddStudent);
            Controls.Add(txtGPA);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblGPA);
            Controls.Add(lblStudentName);
            Controls.Add(lblID);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddForm";
            Load += AddForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridStudentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblStudentName;
        private Label lblGPA;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtGPA;
        private Button btnAddStudent;
        private DataGridView gridStudentList;
        private Button btnDel;
    }
}