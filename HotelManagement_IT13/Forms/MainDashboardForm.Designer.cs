namespace HotelManagement_IT13.Forms
{
    partial class MainDashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.picHotelLogoSmall = new System.Windows.Forms.PictureBox();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnGuestManagement = new System.Windows.Forms.Button();
            this.btnReservationManagement = new System.Windows.Forms.Button();
            this.btnRoomManagement = new System.Windows.Forms.Button();
            this.btnBillingManagement = new System.Windows.Forms.Button();
            this.btnCheckInOut = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusDate = new System.Windows.Forms.ToolStrip();
            this.toolStripStatusUser = new System.Windows.Forms.ToolStrip();
            this.toolStripStatusNotifications = new System.Windows.Forms.ToolStrip();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHotelLogoSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelSidebar);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.toolStripStatusNotifications);
            this.splitContainerMain.Panel2.Controls.Add(this.toolStripStatusUser);
            this.splitContainerMain.Panel2.Controls.Add(this.toolStripStatusDate);
            this.splitContainerMain.Panel2.Controls.Add(this.statusStripMain);
            this.splitContainerMain.Panel2.Controls.Add(this.btnLogout);
            this.splitContainerMain.Panel2.Controls.Add(this.btnUserManagement);
            this.splitContainerMain.Panel2.Controls.Add(this.btnCheckInOut);
            this.splitContainerMain.Panel2.Controls.Add(this.btnBillingManagement);
            this.splitContainerMain.Panel2.Controls.Add(this.btnRoomManagement);
            this.splitContainerMain.Panel2.Controls.Add(this.btnReservationManagement);
            this.splitContainerMain.Panel2.Controls.Add(this.btnGuestManagement);
            this.splitContainerMain.Panel2.Controls.Add(this.btnDashboard);
            this.splitContainerMain.Panel2.Controls.Add(this.lblWelcomeUser);
            this.splitContainerMain.Panel2.Controls.Add(this.picHotelLogoSmall);
            this.splitContainerMain.Panel2.Controls.Add(this.panelMainContent);
            this.splitContainerMain.Size = new System.Drawing.Size(800, 450);
            this.splitContainerMain.SplitterDistance = 266;
            this.splitContainerMain.TabIndex = 0;
            // 
            // panelSidebar
            // 
            this.panelSidebar.Location = new System.Drawing.Point(80, 103);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 100);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelMainContent
            // 
            this.panelMainContent.Location = new System.Drawing.Point(139, 81);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(200, 100);
            this.panelMainContent.TabIndex = 0;
            // 
            // picHotelLogoSmall
            // 
            this.picHotelLogoSmall.Location = new System.Drawing.Point(116, 232);
            this.picHotelLogoSmall.Name = "picHotelLogoSmall";
            this.picHotelLogoSmall.Size = new System.Drawing.Size(100, 50);
            this.picHotelLogoSmall.TabIndex = 1;
            this.picHotelLogoSmall.TabStop = false;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Location = new System.Drawing.Point(395, 81);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(44, 16);
            this.lblWelcomeUser.TabIndex = 2;
            this.lblWelcomeUser.Text = "label1";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(247, 213);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "button1";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnGuestManagement
            // 
            this.btnGuestManagement.Location = new System.Drawing.Point(247, 301);
            this.btnGuestManagement.Name = "btnGuestManagement";
            this.btnGuestManagement.Size = new System.Drawing.Size(75, 23);
            this.btnGuestManagement.TabIndex = 4;
            this.btnGuestManagement.Text = "button1";
            this.btnGuestManagement.UseVisualStyleBackColor = true;
            // 
            // btnReservationManagement
            // 
            this.btnReservationManagement.Location = new System.Drawing.Point(389, 213);
            this.btnReservationManagement.Name = "btnReservationManagement";
            this.btnReservationManagement.Size = new System.Drawing.Size(75, 23);
            this.btnReservationManagement.TabIndex = 5;
            this.btnReservationManagement.Text = "button1";
            this.btnReservationManagement.UseVisualStyleBackColor = true;
            // 
            // btnRoomManagement
            // 
            this.btnRoomManagement.Location = new System.Drawing.Point(376, 145);
            this.btnRoomManagement.Name = "btnRoomManagement";
            this.btnRoomManagement.Size = new System.Drawing.Size(75, 23);
            this.btnRoomManagement.TabIndex = 6;
            this.btnRoomManagement.Text = "button1";
            this.btnRoomManagement.UseVisualStyleBackColor = true;
            // 
            // btnBillingManagement
            // 
            this.btnBillingManagement.Location = new System.Drawing.Point(279, 356);
            this.btnBillingManagement.Name = "btnBillingManagement";
            this.btnBillingManagement.Size = new System.Drawing.Size(75, 23);
            this.btnBillingManagement.TabIndex = 7;
            this.btnBillingManagement.Text = "button1";
            this.btnBillingManagement.UseVisualStyleBackColor = true;
            // 
            // btnCheckInOut
            // 
            this.btnCheckInOut.Location = new System.Drawing.Point(367, 282);
            this.btnCheckInOut.Name = "btnCheckInOut";
            this.btnCheckInOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckInOut.TabIndex = 8;
            this.btnCheckInOut.Text = "button1";
            this.btnCheckInOut.UseVisualStyleBackColor = true;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(140, 406);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(75, 23);
            this.btnUserManagement.TabIndex = 9;
            this.btnUserManagement.Text = "button1";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(155, 328);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "button1";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Location = new System.Drawing.Point(0, 428);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(530, 22);
            this.statusStripMain.TabIndex = 11;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusDate
            // 
            this.toolStripStatusDate.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatusDate.Location = new System.Drawing.Point(0, 0);
            this.toolStripStatusDate.Name = "toolStripStatusDate";
            this.toolStripStatusDate.Size = new System.Drawing.Size(530, 25);
            this.toolStripStatusDate.TabIndex = 12;
            this.toolStripStatusDate.Text = "toolStrip1";
            // 
            // toolStripStatusUser
            // 
            this.toolStripStatusUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatusUser.Location = new System.Drawing.Point(0, 25);
            this.toolStripStatusUser.Name = "toolStripStatusUser";
            this.toolStripStatusUser.Size = new System.Drawing.Size(530, 25);
            this.toolStripStatusUser.TabIndex = 13;
            this.toolStripStatusUser.Text = "toolStrip1";
            // 
            // toolStripStatusNotifications
            // 
            this.toolStripStatusNotifications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatusNotifications.Location = new System.Drawing.Point(0, 50);
            this.toolStripStatusNotifications.Name = "toolStripStatusNotifications";
            this.toolStripStatusNotifications.Size = new System.Drawing.Size(530, 25);
            this.toolStripStatusNotifications.TabIndex = 14;
            this.toolStripStatusNotifications.Text = "toolStrip1";
            // 
            // MainDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "MainDashboardForm";
            this.Text = "MainDashboardForm";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHotelLogoSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnBillingManagement;
        private System.Windows.Forms.Button btnRoomManagement;
        private System.Windows.Forms.Button btnReservationManagement;
        private System.Windows.Forms.Button btnGuestManagement;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.PictureBox picHotelLogoSmall;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.ToolStrip toolStripStatusNotifications;
        private System.Windows.Forms.ToolStrip toolStripStatusUser;
        private System.Windows.Forms.ToolStrip toolStripStatusDate;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnCheckInOut;
        private System.Windows.Forms.Timer timerDateTime;
    }
}