﻿namespace DatabaseUPSKILL
{
    partial class FrmClubRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            cmbProgram = new ComboBox();
            cmbGender = new ComboBox();
            txtMiddleName = new TextBox();
            txtFirstName = new TextBox();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 90);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 149);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 90);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 149);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 29);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "Program:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 90);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 6;
            label7.Text = "Middle Name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbProgram);
            groupBox1.Controls.Add(cmbGender);
            groupBox1.Controls.Add(txtMiddleName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 218);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // cmbProgram
            // 
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(187, 50);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(217, 23);
            cmbProgram.TabIndex = 15;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(137, 167);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(133, 23);
            cmbGender.TabIndex = 14;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(381, 108);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(100, 23);
            txtMiddleName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(223, 108);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(152, 23);
            txtFirstName.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(28, 167);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(28, 108);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(187, 23);
            txtLastName.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(43, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(636, 154);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "List Of Club Members";
            // 
            // button3
            // 
            button3.Location = new Point(555, 22);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 12;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(540, 126);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(604, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 10;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(604, 77);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 417);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "FrmClubRegistration";
            Text = "FrmClubRegistration";
            Load += FrmClubRegistration_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cmbProgram;
        private ComboBox cmbGender;
        private TextBox txtMiddleName;
        private TextBox txtFirstName;
        private TextBox txtAge;
        private TextBox txtLastName;
        private TextBox textBox1;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
