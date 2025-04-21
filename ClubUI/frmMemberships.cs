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
using ClubUI.ViewModels;

namespace ClubUI
{
    public partial class frmMemberships : Form
    {



        MemberRepository repoMember = new MemberRepository();
        MembershipTypeRepository repoMembershipType = new MembershipTypeRepository();
        MembershipRepository repoMembership = new MembershipRepository();



        private int selected_id;

        public frmMemberships()
        {
            InitializeComponent();
            LoadMembers();
            LoadMembershipTypes();
            LoadMemberships();
        }

        //to fill  members combobox
        private void LoadMembers()
        {
            comboBoxMember.DataSource = repoMember.GetAllMembers();
            comboBoxMember.ValueMember = "Id";
            comboBoxMember.DisplayMember = "Name";
        }

        //to fill  membership types combobox
        private void LoadMembershipTypes()
        {
            comboBoxMemberShipType.DataSource = repoMembershipType.GetAllMembershipTypes();
            comboBoxMemberShipType.ValueMember = "Id";
            comboBoxMemberShipType.DisplayMember = "Name";
        }

        //to fill the grid with memberships
        private void LoadMemberships()
        {
            var data = repoMembership.GetAll();
            dataGridView1.DataSource = data.Select(m => new MembershipViewModel
            {
                Id = m.Id,
                MemberName = m.Member.Name,
                MembershipTypeName = m.MembershipType.Name,
                StartDate = m.StartDate,
                EndDate = m.EndDate,
                Price = m.Price
            }).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "اسم المشترك";
            dataGridView1.Columns[2].HeaderText = "نوع الاشتراك";
            dataGridView1.Columns[3].HeaderText = "تاريخ البدء";
            dataGridView1.Columns[4].HeaderText = "تاريخ الانتهاء";
            dataGridView1.Columns[5].HeaderText = "القيمة";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a real cell was clicked
            {
                int Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                var item = repoMembership.GetById(Id);
                comboBoxMember.SelectedValue = item.MemberId;
                comboBoxMemberShipType.SelectedValue = item.MembershipTypeId;
                dateTimePickerStart.Value = item.StartDate;
                dateTimePickerEnd.Value = item.EndDate;
                textBoxPrice.Text = item.Price.ToString();
                selected_id = Id;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            repoMembership.Add(new Membership
            {
                MemberId = Convert.ToInt32(comboBoxMember.SelectedValue),
                MembershipTypeId = Convert.ToInt32(comboBoxMemberShipType.SelectedValue),
                StartDate = dateTimePickerStart.Value,
                EndDate = dateTimePickerEnd.Value,
                Price = Convert.ToDecimal(textBoxPrice.Text)
            });

            MessageBox.Show("Added");
            LoadMemberships();
            Clear();
        }

        private void Clear()
        {
            comboBoxMember.SelectedIndex = 0;
            comboBoxMemberShipType.SelectedIndex = 0;
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
            textBoxPrice.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var item = repoMembership.GetById(selected_id);
            item.MemberId = Convert.ToInt32(comboBoxMember.SelectedValue);
            item.MembershipTypeId = Convert.ToInt32(comboBoxMemberShipType.SelectedValue);
            item.StartDate = dateTimePickerStart.Value;
            item.EndDate = dateTimePickerEnd.Value;
            item.Price = Convert.ToDecimal(textBoxPrice.Text);
            repoMembership.Update(item);
            MessageBox.Show("Updated");
            LoadMemberships();
            Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            repoMembership.Delete(selected_id);
            MessageBox.Show("Deleted");
            LoadMemberships();
            Clear();

        }
    }
}
