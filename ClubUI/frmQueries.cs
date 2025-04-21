using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubClassLibrary.Models;
using ClubClassLibrary.Repositories;
using Microsoft.Reporting.WinForms;

namespace ClubUI
{
    public partial class frmQueries : Form
    {
        MemberRepository repoMember = new MemberRepository();
        List<Member> data = new List<Member>();

        public frmQueries()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (radioButtonMembers.Checked)
            {
                data = repoMember.GetMembersByJoinDate(dateTimePickerJoinDateFrom.Value, dateTimePickerJoinDateTo.Value).ToList(); // Call the async function

                //
            }

            dataGridView1.DataSource = data;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer f = new frmReportViewer();
            f.reportViewer1.LocalReport.ReportEmbeddedResource = "ClubUI.Reports.ReportMembers.rdlc";
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetMembers", data)
                );
            f.reportViewer1.RefreshReport();
            f.ShowDialog();
        }
    }
}
