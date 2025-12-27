namespace HotelManagement_IT13.Forms
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLoginContainer = new System.Windows.Forms.Panel();
            this.panelLoginBox = new System.Windows.Forms.Panel();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.picHotelLogo = new System.Windows.Forms.PictureBox();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelLoginContainer.SuspendLayout();
            this.panelLoginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHotelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.panelLoginContainer);
            this.panelMain.Controls.Add(this.picHotelLogo);
            this.panelMain.Controls.Add(this.lblHotelName);
            this.panelMain.Controls.Add(this.lblSystemTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 550);
            this.panelMain.TabIndex = 0;
            // 
            // panelLoginContainer
            // 
            this.panelLoginContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoginContainer.Controls.Add(this.panelLoginBox);
            this.panelLoginContainer.Controls.Add(this.lblLoginTitle);
            this.panelLoginContainer.Location = new System.Drawing.Point(450, 150);
            this.panelLoginContainer.Name = "panelLoginContainer";
            this.panelLoginContainer.Size = new System.Drawing.Size(400, 300);
            this.panelLoginContainer.TabIndex = 3;
            // 
            // panelLoginBox
            // 
            this.panelLoginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoginBox.BackColor = System.Drawing.SystemColors.Window;
            this.panelLoginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoginBox.Controls.Add(this.lnkForgotPassword);
            this.panelLoginBox.Controls.Add(this.btnCancel);
            this.panelLoginBox.Controls.Add(this.btnLogin);
            this.panelLoginBox.Controls.Add(this.txtPassword);
            this.panelLoginBox.Controls.Add(this.lblPassword);
            this.panelLoginBox.Controls.Add(this.txtUsername);
            this.panelLoginBox.Controls.Add(this.lblUsername);
            this.panelLoginBox.Location = new System.Drawing.Point(0, 70);
            this.panelLoginBox.Name = "panelLoginBox";
            this.panelLoginBox.Padding = new System.Windows.Forms.Padding(30);
            this.panelLoginBox.Size = new System.Drawing.Size(400, 230);
            this.panelLoginBox.TabIndex = 1;
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Location = new System.Drawing.Point(120, 170);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(118, 19);
            this.lnkForgotPassword.TabIndex = 4;
            this.lnkForgotPassword.TabStop = true;
            this.lnkForgotPassword.Text = "Forgot Password?";
            this.lnkForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgotPassword_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(210, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(90, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(90, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(220, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(90, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(90, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(90, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.Location = new System.Drawing.Point(150, 20);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(156, 37);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "Staff Login";
            this.lblLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picHotelLogo
            // 
            this.picHotelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picHotelLogo.Location = new System.Drawing.Point(150, 150);
            this.picHotelLogo.Name = "picHotelLogo";
            this.picHotelLogo.Size = new System.Drawing.Size(150, 150);
            this.picHotelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHotelLogo.TabIndex = 2;
            this.picHotelLogo.TabStop = false;
            // 
            // lblHotelName
            // 
            this.lblHotelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.Location = new System.Drawing.Point(100, 320);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(193, 46);
            this.lblHotelName.TabIndex = 1;
            this.lblHotelName.Text = "GMS Hotel";
            this.lblHotelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHotelName.Click += new System.EventHandler(this.lblHotelName_Click);
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTitle.Location = new System.Drawing.Point(200, 50);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(537, 54);
            this.lblSystemTitle.TabIndex = 0;
            this.lblSystemTitle.Text = "Hotel Management System";
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(918, 597);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - Login";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelLoginContainer.ResumeLayout(false);
            this.panelLoginContainer.PerformLayout();
            this.panelLoginBox.ResumeLayout(false);
            this.panelLoginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHotelLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelLoginContainer;
        private System.Windows.Forms.Panel panelLoginBox;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.PictureBox picHotelLogo;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label lblSystemTitle;
    }
}