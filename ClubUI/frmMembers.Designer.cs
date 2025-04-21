namespace ClubUI
{
    partial class frmMembers
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
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            textBoxAddress = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePickerJoinDate = new DateTimePicker();
            dateTimePickerBirthDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(524, 257);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(105, 42);
            buttonClear.TabIndex = 21;
            buttonClear.Text = "مسح";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(406, 257);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(105, 42);
            buttonDelete.TabIndex = 20;
            buttonDelete.Text = "حذف";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(288, 257);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(105, 42);
            buttonUpdate.TabIndex = 19;
            buttonUpdate.Text = "تعديل";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(172, 257);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 42);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "إضافة";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(308, 114);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(256, 27);
            textBoxAddress.TabIndex = 17;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(308, 76);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(256, 27);
            textBoxPhoneNumber.TabIndex = 16;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(308, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(256, 27);
            textBoxName.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 117);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 14;
            label3.Text = "العنوان:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 79);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 13;
            label2.Text = "رقم الهاتف:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 41);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 12;
            label1.Text = "اسم المشترك:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(120, 326);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(559, 208);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dateTimePickerJoinDate
            // 
            dateTimePickerJoinDate.Location = new Point(308, 192);
            dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            dateTimePickerJoinDate.Size = new Size(256, 27);
            dateTimePickerJoinDate.TabIndex = 22;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(308, 154);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(256, 27);
            dateTimePickerBirthDate.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 159);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 24;
            label4.Text = "تاريخ الميلاد:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 197);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 25;
            label5.Text = "تاريخ الانضمام:";
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 545);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(dateTimePickerJoinDate);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmMembers";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "المشتركين";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClear;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerJoinDate;
        private DateTimePicker dateTimePickerBirthDate;
        private Label label4;
        private Label label5;
    }
}