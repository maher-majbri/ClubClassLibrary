namespace ClubUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void buttonMembershipTypes_Click(object sender, EventArgs e)
        {
            frmMembershipTypes frm = new frmMembershipTypes();
            frm.ShowDialog();
        }

        private void buttonMembers_Click(object sender, EventArgs e)
        {
            frmMembers frm = new frmMembers();
            frm.ShowDialog();
        }

        private void buttonMemberships_Click(object sender, EventArgs e)
        {
            frmMemberships frm = new frmMemberships();
            frm.ShowDialog();
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            frmPayments frm = new frmPayments();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQueries frm = new frmQueries();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm= new frmLogin();
            frm.ShowDialog();
            if (!frm.LoggedIn)
            {
                Application.Exit();
            }
            else
            {
                this.WindowState= FormWindowState.Maximized;
            }
            ShowHidePermissions();
        }

        private void ShowHidePermissions()
        {
            buttonMembers.Enabled = App.CurrentUser.MembersPermission;
            buttonReports.Enabled = App.CurrentUser.ReportsPermission;
            buttonUsers.Enabled = App.CurrentUser.UsersPermission;

        }

    }
}
