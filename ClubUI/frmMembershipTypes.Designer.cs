namespace ClubUI
{
    partial class frmMembershipTypes
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxBasePrice = new TextBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 248);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(575, 211);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 43);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "نوع العضوية";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 81);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "الوصف";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 116);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "السعر";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(204, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(256, 27);
            textBoxName.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(204, 78);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(256, 27);
            textBoxDescription.TabIndex = 5;
            // 
            // textBoxBasePrice
            // 
            textBoxBasePrice.Location = new Point(204, 116);
            textBoxBasePrice.Name = "textBoxBasePrice";
            textBoxBasePrice.Size = new Size(256, 27);
            textBoxBasePrice.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(95, 176);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 42);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "إضافة";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(211, 176);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(105, 42);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "تعديل";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(329, 176);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(105, 42);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "حذف";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(447, 176);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(105, 42);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "مسح";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // frmMembershipTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 510);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxBasePrice);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "frmMembershipTypes";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "أنواع العضوية";
            Load += frmMembershipTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxBasePrice;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonClear;
    }
}