using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubClassLibrary.Repositories;
using ClubClassLibrary.Models;

namespace ClubUI
{
    public partial class frmMembershipTypes : Form
    {
        MembershipTypeRepository repoMembershipType = new MembershipTypeRepository();
        private int selected_id;

        public frmMembershipTypes()
        {
            InitializeComponent();
        }

        private async void LoadMembershipTypes()
        {
            var data = await repoMembershipType.GetAllMembershipTypesAsync();
            dataGridView1.DataSource = data.Select(mt => new
            {
                mt.Id,
                mt.Name,
                mt.BasePrice
            }).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "اسم العضوية";
            dataGridView1.Columns[2].HeaderText = "السعر";
        }

        private async void frmMembershipTypes_Load(object sender, EventArgs e)
        {
            // get the membership types data and display them in the dataGridView
            LoadMembershipTypes();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            //validation

            await repoMembershipType.AddMembershipTypeAsync(new MembershipType
            {
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
                BasePrice = Convert.ToDecimal(textBoxBasePrice.Text)
            });

            MessageBox.Show("Added");
            LoadMembershipTypes();
            Clear();
        }


        private void Clear()
        {
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            textBoxBasePrice.Text = "";
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
                var item = await repoMembershipType.GetMembershipTypeByIdAsync(Id);
                textBoxName.Text = item.Name;
                textBoxDescription.Text = item.Description;
                textBoxBasePrice.Text = item.BasePrice.ToString();
                selected_id = Id;

            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            var itemToUpdate = await repoMembershipType.GetMembershipTypeByIdAsync(selected_id);
            itemToUpdate.Name = textBoxName.Text;
            itemToUpdate.Description = textBoxName.Text;
            itemToUpdate.BasePrice = Convert.ToDecimal(textBoxBasePrice.Text);
            await repoMembershipType.UpdateMembershipTypeAsync(itemToUpdate);

            MessageBox.Show("Updated");
            LoadMembershipTypes();
            Clear();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await repoMembershipType.DeleteMembershipTypeAsync(selected_id);

            MessageBox.Show("Deleted");
            LoadMembershipTypes();
            Clear();
        }
    }
}
