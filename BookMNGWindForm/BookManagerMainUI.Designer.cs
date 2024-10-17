
namespace BookMNGWindForm
{
    partial class BookManagerMainUI
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
            lblHeader = new Label();
            grbSerachCriteria = new GroupBox();
            btnSearch = new Button();
            txtDescription = new TextBox();
            txtName = new TextBox();
            lblDescription = new Label();
            lblName = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvList = new DataGridView();
            lblList = new Label();
            label1 = new Label();
            grbSerachCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(12, 28);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(506, 96);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            lblHeader.Click += lblHeader_Click;
            // 
            // grbSerachCriteria
            // 
            grbSerachCriteria.Controls.Add(btnSearch);
            grbSerachCriteria.Controls.Add(txtDescription);
            grbSerachCriteria.Controls.Add(txtName);
            grbSerachCriteria.Controls.Add(lblDescription);
            grbSerachCriteria.Controls.Add(lblName);
            grbSerachCriteria.Location = new Point(13, 127);
            grbSerachCriteria.Name = "grbSerachCriteria";
            grbSerachCriteria.Size = new Size(1394, 152);
            grbSerachCriteria.TabIndex = 0;
            grbSerachCriteria.TabStop = false;
            grbSerachCriteria.Text = "Search Criteria";
            grbSerachCriteria.Enter += grbSerachCriteria_Enter;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1216, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 58);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(858, 78);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(252, 31);
            txtDescription.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 31);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(595, 71);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(228, 38);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Book Description";
            lblDescription.Click += lblDescription_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(6, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(161, 38);
            lblName.TabIndex = 3;
            lblName.Text = "Book Name";
            lblName.Click += lblName_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1229, 334);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(169, 58);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Add a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1229, 448);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(169, 58);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1229, 569);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 58);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete a book ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1229, 685);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(169, 58);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(19, 334);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 62;
            dgvList.Size = new Size(1110, 409);
            dgvList.TabIndex = 1;
            dgvList.CellContentClick += dgvList_CellContentClick;
            dgvList.SelectionChanged += dgvList_SelectionChanged;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblList.Location = new Point(19, 282);
            lblList.Name = "lblList";
            lblList.Size = new Size(128, 38);
            lblList.TabIndex = 6;
            lblList.Text = "Book List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 784);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 10;
            label1.Text = "© 2024 Phi.Long";
            label1.Click += lblCopyright_Click;
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 832);
            Controls.Add(label1);
            Controls.Add(lblList);
            Controls.Add(dgvList);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(grbSerachCriteria);
            Controls.Add(lblHeader);
            Name = "BookManagerMainUI";
            Text = "Book Manager";
            Load += Form1_Load;
            grbSerachCriteria.ResumeLayout(false);
            grbSerachCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Label lblHeader;
        private GroupBox grbSerachCriteria;
        private Label lblName;
        private Label lblDescription;
        private TextBox txtDescription;
        private TextBox txtName;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvList;
        private Label lblList;
        private Label label1;
    }
}
