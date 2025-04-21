using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubClassLibrary.Models;
using ClubClassLibrary.Repositories;

namespace ClubUI
{
    public partial class frmMembers : Form
    {

        MemberRepository repoMember = new MemberRepository();
        private int selected_id;

        public frmMembers()
        {
            InitializeComponent();
        }

        private async void LoadMembers()
        {
            var data = await repoMember.GetAllMembersAsync();
            dataGridView1.DataSource = data.Select(m => new
            {
                m.Id,
                m.Name,
                m.PhoneNumber,
                m.JoinDate,
            }).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "اسم المشترك";
            dataGridView1.Columns[2].HeaderText = "رقم الهاتف";
            dataGridView1.Columns[3].HeaderText = "تاريخ الانضمام";
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }
        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            //validation

            await repoMember.AddMemberAsync(new Member
            {
                Name = textBoxName.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                BirthDate = dateTimePickerBirthDate.Value,
                Address = textBoxAddress.Text,
                JoinDate = dateTimePickerJoinDate.Value,
            });

            MessageBox.Show("Added");
            LoadMembers();
            Clear();
        }


        private void Clear()
        {
            textBoxName.Text = "";
            textBoxPhoneNumber.Text = "";
            dateTimePickerBirthDate.Value = DateTime.Now;
            textBoxAddress.Text = "";
            dateTimePickerJoinDate.Value = DateTime.Now;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a real cell was clicked
            {

                int Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                var item = await repoMember.GetMemberByIdAsync(Id);
                textBoxName.Text = item.Name;
                textBoxPhoneNumber.Text = item.PhoneNumber;
                dateTimePickerBirthDate.Value = item.BirthDate;
                textBoxAddress.Text = item.Address;
                dateTimePickerJoinDate.Value = item.JoinDate;
                selected_id = Id;

            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            var itemToUpdate = await repoMember.GetMemberByIdAsync(selected_id);
            itemToUpdate.Name = textBoxName.Text;
            itemToUpdate.PhoneNumber = textBoxPhoneNumber.Text;
            itemToUpdate.BirthDate = dateTimePickerBirthDate.Value;
            itemToUpdate.Address = textBoxAddress.Text;
            itemToUpdate.JoinDate = dateTimePickerJoinDate.Value;
            await repoMember.UpdateMemberAsync(itemToUpdate);

            MessageBox.Show("Updated");
            LoadMembers();
            Clear();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            //confirm before delete


            await repoMember.DeleteMemberAsync(selected_id);

            MessageBox.Show("Deleted");
            LoadMembers();
            Clear();
        }


    }
}
