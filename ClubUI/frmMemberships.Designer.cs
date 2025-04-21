namespace ClubUI
{
    partial class frmMemberships
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
            comboBoxMemberShipType = new ComboBox();
            comboBoxMember = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            dataGridView1 = new DataGridView();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMemberShipType
            // 
            comboBoxMemberShipType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMemberShipType.FormattingEnabled = true;
            comboBoxMemberShipType.Location = new Point(546, 47);
            comboBoxMemberShipType.Name = "comboBoxMemberShipType";
            comboBoxMemberShipType.Size = new Size(151, 28);
            comboBoxMemberShipType.TabIndex = 0;
            // 
            // comboBoxMember
            // 
            comboBoxMember.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMember.FormattingEnabled = true;
            comboBoxMember.Location = new Point(154, 47);
            comboBoxMember.Name = "comboBoxMember";
            comboBoxMember.Size = new Size(151, 28);
            comboBoxMember.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 50);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "اسم المشترك:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 50);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "نوع الاشتراك:";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(506, 198);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(105, 42);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "مسح";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(388, 198);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(105, 42);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "حذف";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(270, 198);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(105, 42);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "تعديل";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(154, 198);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 42);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "إضافة";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 259);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(778, 220);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(154, 93);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(151, 27);
            dateTimePickerStart.TabIndex = 16;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(546, 93);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(151, 27);
            dateTimePickerEnd.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 93);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 18;
            label3.Text = "بداية الاشتراك:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 98);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 19;
            label4.Text = "نهاية الاشتراك:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 137);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 20;
            label5.Text = "القيمة:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(154, 134);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(151, 27);
            textBoxPrice.TabIndex = 21;
            // 
            // frmMemberships
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(textBoxPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dataGridView1);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMember);
            Controls.Add(comboBoxMemberShipType);
            Name = "frmMemberships";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الاشتراكات";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMemberShipType;
        private ComboBox comboBoxMember;
        private Label label1;
        private Label label2;
        private Button buttonClear;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxPrice;
    }
}