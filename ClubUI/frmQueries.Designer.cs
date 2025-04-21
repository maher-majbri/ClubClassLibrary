namespace ClubUI
{
    partial class frmQueries
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
            buttonShow = new Button();
            buttonPrint = new Button();
            dataGridView1 = new DataGridView();
            radioButtonMembers = new RadioButton();
            radioButtonMemberships = new RadioButton();
            radioButtonPayments = new RadioButton();
            label5 = new Label();
            dateTimePickerJoinDateFrom = new DateTimePicker();
            dateTimePickerJoinDateTo = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(674, 194);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(114, 36);
            buttonShow.TabIndex = 0;
            buttonShow.Text = "عرض";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Location = new Point(674, 458);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(114, 36);
            buttonPrint.TabIndex = 1;
            buttonPrint.Text = "طباعة";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 250);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(777, 193);
            dataGridView1.TabIndex = 12;
            // 
            // radioButtonMembers
            // 
            radioButtonMembers.AutoSize = true;
            radioButtonMembers.Checked = true;
            radioButtonMembers.Location = new Point(66, 47);
            radioButtonMembers.Name = "radioButtonMembers";
            radioButtonMembers.Size = new Size(94, 24);
            radioButtonMembers.TabIndex = 13;
            radioButtonMembers.TabStop = true;
            radioButtonMembers.Text = "المشتركين";
            radioButtonMembers.UseVisualStyleBackColor = true;
            // 
            // radioButtonMemberships
            // 
            radioButtonMemberships.AutoSize = true;
            radioButtonMemberships.Location = new Point(66, 92);
            radioButtonMemberships.Name = "radioButtonMemberships";
            radioButtonMemberships.Size = new Size(96, 24);
            radioButtonMemberships.TabIndex = 14;
            radioButtonMemberships.Text = "الاشتراكات";
            radioButtonMemberships.UseVisualStyleBackColor = true;
            // 
            // radioButtonPayments
            // 
            radioButtonPayments.AutoSize = true;
            radioButtonPayments.Location = new Point(66, 136);
            radioButtonPayments.Name = "radioButtonPayments";
            radioButtonPayments.Size = new Size(99, 24);
            radioButtonPayments.TabIndex = 15;
            radioButtonPayments.Text = "المدفوعات";
            radioButtonPayments.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 49);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 27;
            label5.Text = "تاريخ الانضمام:";
            // 
            // dateTimePickerJoinDateFrom
            // 
            dateTimePickerJoinDateFrom.Location = new Point(341, 44);
            dateTimePickerJoinDateFrom.Name = "dateTimePickerJoinDateFrom";
            dateTimePickerJoinDateFrom.Size = new Size(153, 27);
            dateTimePickerJoinDateFrom.TabIndex = 26;
            // 
            // dateTimePickerJoinDateTo
            // 
            dateTimePickerJoinDateTo.Location = new Point(562, 44);
            dateTimePickerJoinDateTo.Name = "dateTimePickerJoinDateTo";
            dateTimePickerJoinDateTo.Size = new Size(153, 27);
            dateTimePickerJoinDateTo.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(510, 49);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 29;
            label1.Text = "إلى";
            // 
            // frmQueries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(label1);
            Controls.Add(dateTimePickerJoinDateTo);
            Controls.Add(label5);
            Controls.Add(dateTimePickerJoinDateFrom);
            Controls.Add(radioButtonPayments);
            Controls.Add(radioButtonMemberships);
            Controls.Add(radioButtonMembers);
            Controls.Add(dataGridView1);
            Controls.Add(buttonPrint);
            Controls.Add(buttonShow);
            Name = "frmQueries";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "استفسارات";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShow;
        private Button buttonPrint;
        private DataGridView dataGridView1;
        private RadioButton radioButtonMembers;
        private RadioButton radioButtonMemberships;
        private RadioButton radioButtonPayments;
        private Label label5;
        private DateTimePicker dateTimePickerJoinDateFrom;
        private DateTimePicker dateTimePickerJoinDateTo;
        private Label label1;
    }
}