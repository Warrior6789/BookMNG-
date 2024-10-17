namespace BookMNGWindForm
{
    partial class BookDetailForm
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
            grbBookInfo = new GroupBox();
            cbCatagory = new ComboBox();
            dtpDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtBookDescription = new TextBox();
            txtPrice = new TextBox();
            txtBookName = new TextBox();
            lblDescription = new Label();
            lblDate = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            label1 = new Label();
            txtBookID = new TextBox();
            lblBookName = new Label();
            lblBookID = new Label();
            btnSave = new Button();
            lblHeader = new Label();
            btnCancel = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cbCatagory);
            grbBookInfo.Controls.Add(dtpDate);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtBookDescription);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(lblDate);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(label1);
            grbBookInfo.Controls.Add(txtBookID);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Location = new Point(39, 146);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(1171, 612);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "Book Info";
            // 
            // cbCatagory
            // 
            cbCatagory.FormattingEnabled = true;
            cbCatagory.Location = new Point(243, 526);
            cbCatagory.Name = "cbCatagory";
            cbCatagory.Size = new Size(252, 33);
            cbCatagory.TabIndex = 7;
            cbCatagory.SelectedIndexChanged += cbCatagory_SelectedIndexChanged;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(243, 311);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(252, 31);
            dtpDate.TabIndex = 3;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(243, 455);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(899, 31);
            txtAuthor.TabIndex = 6;
            txtAuthor.TextChanged += textBox5_TextChanged;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(243, 189);
            txtBookDescription.Multiline = true;
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.ScrollBars = ScrollBars.Vertical;
            txtBookDescription.Size = new Size(899, 99);
            txtBookDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(991, 376);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 31);
            txtPrice.TabIndex = 5;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(243, 131);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(899, 31);
            txtBookName.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(0, 219);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(166, 38);
            lblDescription.TabIndex = 10;
            lblDescription.Text = " Description";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(6, 304);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(220, 38);
            lblDate.TabIndex = 9;
            lblDate.Text = "Publication Date";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(243, 383);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(252, 31);
            txtQuantity.TabIndex = 4;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(6, 376);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(123, 38);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Quantity";
            lblQuantity.Click += label4_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(6, 447);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(102, 38);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(6, 518);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(128, 38);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(859, 376);
            label1.Name = "label1";
            label1.Size = new Size(78, 38);
            label1.TabIndex = 5;
            label1.Text = "Price";
            label1.Click += label1_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(243, 78);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(899, 31);
            txtBookID.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookName.Location = new Point(0, 131);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(161, 38);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookID.Location = new Point(0, 71);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(110, 38);
            lblBookID.TabIndex = 3;
            lblBookID.Text = "Book Id";
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.SizeAll;
            btnSave.Location = new Point(1244, 159);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 58);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(39, 38);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(427, 60);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1244, 263);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(169, 58);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookDetailForm
            // 
            AccessibleDescription = "Add";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 816);
            Controls.Add(btnCancel);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            Controls.Add(btnSave);
            Name = "BookDetailForm";
            Text = "Add | Update a book";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbBookInfo;
        private Label lblDescription;
        private Label lblDate;
        private Label lblQuantity;
        private Label lblAuthor;
        private Label lblCategory;
        private Label label1;
        private Button btnSave;
        private TextBox txtQuantity;
        private TextBox txtBookID;
        private Label lblBookName;
        private Label lblBookID;
        private Label lblHeader;
        private TextBox txtBookName;
        private Button btnCancel;
        private TextBox txtBookDescription;
        private TextBox txtPrice;
        private TextBox txtAuthor;
        private ComboBox cbCatagory;
        private DateTimePicker dtpDate;
    }
}