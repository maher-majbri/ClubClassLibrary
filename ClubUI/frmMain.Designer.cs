namespace ClubUI
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            buttonMembershipTypes = new Button();
            panel1 = new Panel();
            buttonUsers = new Button();
            buttonReports = new Button();
            buttonPayments = new Button();
            buttonMemberships = new Button();
            buttonMembers = new Button();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1023, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(52, 24);
            fileToolStripMenuItem.Text = "ملف";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(122, 26);
            newToolStripMenuItem.Text = "جديد";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(122, 26);
            openToolStripMenuItem.Text = "فتح";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(74, 24);
            helpToolStripMenuItem.Text = "مساعدة";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(155, 26);
            aboutToolStripMenuItem.Text = "عن النظام";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // buttonMembershipTypes
            // 
            buttonMembershipTypes.FlatAppearance.BorderColor = Color.White;
            buttonMembershipTypes.FlatAppearance.BorderSize = 0;
            buttonMembershipTypes.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonMembershipTypes.FlatStyle = FlatStyle.Flat;
            buttonMembershipTypes.ForeColor = Color.White;
            buttonMembershipTypes.Image = Properties.Resources.membership_card_svgrepo_com__1_;
            buttonMembershipTypes.Location = new Point(2, 88);
            buttonMembershipTypes.Margin = new Padding(2);
            buttonMembershipTypes.Name = "buttonMembershipTypes";
            buttonMembershipTypes.Size = new Size(196, 50);
            buttonMembershipTypes.TabIndex = 1;
            buttonMembershipTypes.Text = "أنواع العضوية";
            buttonMembershipTypes.TextAlign = ContentAlignment.MiddleLeft;
            buttonMembershipTypes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMembershipTypes.UseVisualStyleBackColor = true;
            buttonMembershipTypes.Click += buttonMembershipTypes_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(buttonUsers);
            panel1.Controls.Add(buttonReports);
            panel1.Controls.Add(buttonPayments);
            panel1.Controls.Add(buttonMemberships);
            panel1.Controls.Add(buttonMembers);
            panel1.Controls.Add(buttonMembershipTypes);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 469);
            panel1.TabIndex = 2;
            // 
            // buttonUsers
            // 
            buttonUsers.FlatAppearance.BorderColor = Color.White;
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.ForeColor = Color.White;
            buttonUsers.Image = Properties.Resources.membership_card_svgrepo_com__1_;
            buttonUsers.Location = new Point(2, 370);
            buttonUsers.Margin = new Padding(2);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(196, 50);
            buttonUsers.TabIndex = 7;
            buttonUsers.Text = "المستخدمين";
            buttonUsers.TextAlign = ContentAlignment.MiddleLeft;
            buttonUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonReports
            // 
            buttonReports.FlatAppearance.BorderColor = Color.White;
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.ForeColor = Color.White;
            buttonReports.Image = Properties.Resources.membership_card_svgrepo_com__1_;
            buttonReports.Location = new Point(2, 316);
            buttonReports.Margin = new Padding(2);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(196, 50);
            buttonReports.TabIndex = 6;
            buttonReports.Text = "التقارير";
            buttonReports.TextAlign = ContentAlignment.MiddleLeft;
            buttonReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReports.UseVisualStyleBackColor = true;
            buttonReports.Click += button1_Click;
            // 
            // buttonPayments
            // 
            buttonPayments.FlatAppearance.BorderColor = Color.White;
            buttonPayments.FlatAppearance.BorderSize = 0;
            buttonPayments.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonPayments.FlatStyle = FlatStyle.Flat;
            buttonPayments.ForeColor = Color.White;
            buttonPayments.Image = Properties.Resources.membership_card_svgrepo_com__1_;
            buttonPayments.Location = new Point(2, 250);
            buttonPayments.Margin = new Padding(2);
            buttonPayments.Name = "buttonPayments";
            buttonPayments.Size = new Size(196, 50);
            buttonPayments.TabIndex = 5;
            buttonPayments.Text = "المدفوعات";
            buttonPayments.TextAlign = ContentAlignment.MiddleLeft;
            buttonPayments.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPayments.UseVisualStyleBackColor = true;
            buttonPayments.Click += buttonPayments_Click;
            // 
            // buttonMemberships
            // 
            buttonMemberships.FlatAppearance.BorderColor = Color.White;
            buttonMemberships.FlatAppearance.BorderSize = 0;
            buttonMemberships.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonMemberships.FlatStyle = FlatStyle.Flat;
            buttonMemberships.ForeColor = Color.White;
            buttonMemberships.Image = Properties.Resources.membership_card_svgrepo_com__1_;
            buttonMemberships.Location = new Point(2, 196);
            buttonMemberships.Margin = new Padding(2);
            buttonMemberships.Name = "buttonMemberships";
            buttonMemberships.Size = new Size(196, 50);
            buttonMemberships.TabIndex = 4;
            buttonMemberships.Text = "الاشتراكات";
            buttonMemberships.TextAlign = ContentAlignment.MiddleLeft;
            buttonMemberships.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMemberships.UseVisualStyleBackColor = true;
            buttonMemberships.Click += buttonMemberships_Click;
            // 
            // buttonMembers
            // 
            buttonMembers.FlatAppearance.BorderColor = Color.White;
            buttonMembers.FlatAppearance.BorderSize = 0;
            buttonMembers.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonMembers.FlatStyle = FlatStyle.Flat;
            buttonMembers.ForeColor = Color.White;
            buttonMembers.Image = Properties.Resources.membership_card_svgrepo_com__1_;
            buttonMembers.Location = new Point(2, 142);
            buttonMembers.Margin = new Padding(2);
            buttonMembers.Name = "buttonMembers";
            buttonMembers.Size = new Size(196, 50);
            buttonMembers.TabIndex = 2;
            buttonMembers.Text = "المشتركين";
            buttonMembers.TextAlign = ContentAlignment.MiddleLeft;
            buttonMembers.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMembers.UseVisualStyleBackColor = true;
            buttonMembers.Click += buttonMembers_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(199, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 40);
            panel2.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1023, 512);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نادي رياضي";
            WindowState = FormWindowState.Minimized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button buttonMembershipTypes;
        private Panel panel1;
        private Button buttonPayments;
        private Button buttonMemberships;
        private Button buttonMembers;
        private Panel panel2;
        private Button buttonReports;
        private Button buttonUsers;
    }
}
