namespace BookMNGWindForm
{
    partial class LoginForm
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
            btnLogin = new Button();
            lblHeader = new Label();
            gpInfo = new GroupBox();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            btnCancel = new Button();
            lblPass = new Label();
            lblEmail = new Label();
            gpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(143, 156);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(200, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(152, 60);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "LOGIN";
            // 
            // gpInfo
            // 
            gpInfo.Controls.Add(txtPass);
            gpInfo.Controls.Add(txtEmail);
            gpInfo.Controls.Add(btnCancel);
            gpInfo.Controls.Add(lblPass);
            gpInfo.Controls.Add(lblEmail);
            gpInfo.Controls.Add(btnLogin);
            gpInfo.Location = new Point(57, 101);
            gpInfo.Name = "gpInfo";
            gpInfo.Size = new Size(428, 216);
            gpInfo.TabIndex = 6;
            gpInfo.TabStop = false;
            gpInfo.Text = "Account info";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(143, 95);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(241, 31);
            txtPass.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 31);
            txtEmail.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(272, 156);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(27, 96);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(103, 30);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(36, 46);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 30);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 423);
            Controls.Add(gpInfo);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            gpInfo.ResumeLayout(false);
            gpInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnLogin;
        private Label lblHeader;
        private GroupBox gpInfo;
        private TextBox txtPass;
        private TextBox txtEmail;
        private Button btnCancel;
        private Label lblPass;
        private Label lblEmail;
        private GroupBox grbSerachCriteria;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label lblDescription;
        private Label lblName;
    }
}