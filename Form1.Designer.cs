using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            lbl_appointment_panel = new Label();
            lbl_tc = new Label();
            lbl_full_name = new Label();
            lbl_gender = new Label();
            lbl_doctor = new Label();
            label6 = new Label();
            lbl_complaint = new Label();
            lbl_all_appointments = new Label();
            dataGridView1 = new DataGridView();
            cmbx_doctor = new ComboBox();
            cmbx_specialty = new ComboBox();
            txtbx_tc = new TextBox();
            txtbx_fullname = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            lbl_date = new Label();
            richtxtbx_complaint = new RichTextBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(895, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(179, 378);
            button1.Name = "button1";
            button1.Size = new Size(242, 49);
            button1.TabIndex = 1;
            button1.Text = "Book Appointment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl_appointment_panel
            // 
            lbl_appointment_panel.AutoSize = true;
            lbl_appointment_panel.BackColor = SystemColors.ActiveCaptionText;
            lbl_appointment_panel.Font = new Font("Cambria", 27.75F);
            lbl_appointment_panel.ForeColor = SystemColors.ButtonFace;
            lbl_appointment_panel.Location = new Point(157, 49);
            lbl_appointment_panel.Name = "lbl_appointment_panel";
            lbl_appointment_panel.Size = new Size(264, 43);
            lbl_appointment_panel.TabIndex = 2;
            lbl_appointment_panel.Text = "Appointment Panel";
            // 
            // lbl_tc
            // 
            lbl_tc.AutoSize = true;
            lbl_tc.BackColor = SystemColors.ActiveCaptionText;
            lbl_tc.Font = new Font("Cambria", 14.25F);
            lbl_tc.ForeColor = SystemColors.ButtonFace;
            lbl_tc.Location = new Point(39, 132);
            lbl_tc.Name = "lbl_tc";
            lbl_tc.Size = new Size(64, 22);
            lbl_tc.TabIndex = 3;
            lbl_tc.Text = "National ID:";
            // 
            // lbl_full_name
            // 
            lbl_full_name.AutoSize = true;
            lbl_full_name.BackColor = SystemColors.ActiveCaptionText;
            lbl_full_name.Font = new Font("Cambria", 14.25F);
            lbl_full_name.ForeColor = SystemColors.ButtonFace;
            lbl_full_name.Location = new Point(12, 181);
            lbl_full_name.Name = "lbl_full_name";
            lbl_full_name.Size = new Size(91, 22);
            lbl_full_name.TabIndex = 4;
            lbl_full_name.Text = "Full Name:";
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.BackColor = SystemColors.ActiveCaptionText;
            lbl_gender.Font = new Font("Cambria", 14.25F);
            lbl_gender.ForeColor = SystemColors.ButtonFace;
            lbl_gender.Location = new Point(23, 231);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(80, 22);
            lbl_gender.TabIndex = 5;
            lbl_gender.Text = "Gender:";
            // 
            // lbl_doctor
            // 
            lbl_doctor.AutoSize = true;
            lbl_doctor.BackColor = SystemColors.ActiveCaptionText;
            lbl_doctor.Font = new Font("Cambria", 14.25F);
            lbl_doctor.ForeColor = SystemColors.ButtonFace;
            lbl_doctor.Location = new Point(313, 132);
            lbl_doctor.Name = "lbl_doctor";
            lbl_doctor.Size = new Size(72, 22);
            lbl_doctor.TabIndex = 6;
            lbl_doctor.Text = "Doctor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Cambria", 14.25F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(328, 180);
            label6.Name = "label6";
            label6.Size = new Size(57, 22);
            label6.TabIndex = 7;
            label6.Text = "Specialty:";
            // 
            // lbl_complaint
            // 
            lbl_complaint.AutoSize = true;
            lbl_complaint.BackColor = SystemColors.ActiveCaptionText;
            lbl_complaint.Font = new Font("Cambria", 14.25F);
            lbl_complaint.ForeColor = SystemColors.ButtonFace;
            lbl_complaint.Location = new Point(282, 231);
            lbl_complaint.Name = "lbl_complaint";
            lbl_complaint.Size = new Size(103, 22);
            lbl_complaint.TabIndex = 8;
            lbl_complaint.Text = "Complaint:";
            // 
            // lbl_all_appointments
            // 
            lbl_all_appointments.AutoSize = true;
            lbl_all_appointments.BackColor = SystemColors.ActiveCaptionText;
            lbl_all_appointments.Font = new Font("Cambria", 27.75F);
            lbl_all_appointments.ForeColor = SystemColors.ButtonFace;
            lbl_all_appointments.Location = new Point(563, 49);
            lbl_all_appointments.Name = "lbl_all_appointments";
            lbl_all_appointments.Size = new Size(290, 43);
            lbl_all_appointments.TabIndex = 9;
            lbl_all_appointments.Text = "All Appointments";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(563, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(299, 331);
            dataGridView1.TabIndex = 10;
            // 
            // cmbx_doctor
            // 
            cmbx_doctor.FormattingEnabled = true;
            cmbx_doctor.Location = new Point(397, 131);
            cmbx_doctor.Name = "cmbx_doctor";
            cmbx_doctor.Size = new Size(145, 23);
            cmbx_doctor.TabIndex = 11;
            // 
            // cmbx_specialty
            // 
            cmbx_specialty.FormattingEnabled = true;
            cmbx_specialty.Location = new Point(397, 180);
            cmbx_specialty.Name = "cmbx_specialty";
            cmbx_specialty.Size = new Size(145, 23);
            cmbx_specialty.TabIndex = 12;
            // 
            // txtbx_tc
            // 
            txtbx_tc.Location = new Point(119, 131);
            txtbx_tc.Name = "txtbx_tc";
            txtbx_tc.Size = new Size(145, 23);
            txtbx_tc.TabIndex = 14;
            // 
            // txtbx_fullname
            // 
            txtbx_fullname.Location = new Point(119, 184);
            txtbx_fullname.Name = "txtbx_fullname";
            txtbx_fullname.Size = new Size(145, 23);
            txtbx_fullname.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(119, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(119, 280);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.BackColor = SystemColors.ActiveCaptionText;
            lbl_date.Font = new Font("Cambria", 14.25F);
            lbl_date.ForeColor = SystemColors.ButtonFace;
            lbl_date.Location = new Point(46, 280);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(57, 22);
            lbl_date.TabIndex = 20;
            lbl_date.Text = "Date:";
            // 
            // richtxtbx_complaint
            // 
            richtxtbx_complaint.Location = new Point(397, 231);
            richtxtbx_complaint.Name = "richtxtbx_complaint";
            richtxtbx_complaint.Size = new Size(145, 72);
            richtxtbx_complaint.TabIndex = 21;
            richtxtbx_complaint.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 507);
            Controls.Add(richtxtbx_complaint);
            Controls.Add(lbl_date);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(txtbx_fullname);
            Controls.Add(txtbx_tc);
            Controls.Add(cmbx_specialty);
            Controls.Add(cmbx_doctor);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_all_appointments);
            Controls.Add(lbl_complaint);
            Controls.Add(label6);
            Controls.Add(lbl_doctor);
            Controls.Add(lbl_gender);
            Controls.Add(lbl_full_name);
            Controls.Add(lbl_tc);
            Controls.Add(lbl_appointment_panel);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label lbl_appointment_panel;
        private Label lbl_tc;
        private Label lbl_full_name;
        private Label lbl_gender;
        private Label lbl_doctor;
        private Label label6;
        private Label lbl_complaint;
        private Label lbl_all_appointments;
        private DataGridView dataGridView1;
        private ComboBox cmbx_doctor;
        private ComboBox cmbx_specialty;
        private TextBox txtbx_tc;
        private TextBox txtbx_fullname;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label lbl_date;
        private RichTextBox richtxtbx_complaint;
    }
}
