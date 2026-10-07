using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbx_specialty.SelectedIndexChanged += cmbx_specialty_SelectedIndexChanged;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";

            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Male");

            using (var db = new DatabaseContext())
            {
                try
                {
                    var experts = db.Experts
                        .Select(x => new Experts
                        {
                            Expertid = x.Expertid,
                            ExpertName = x.ExpertName.Trim()
                        })
                        .ToList();

                    cmbx_specialty.DataSource = experts;
                    cmbx_specialty.DisplayMember = "ExpertName";
                    cmbx_specialty.ValueMember = "Expertid";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading medical specialties:\n" + ex.Message);
                }

                try
                {
                    var appointments = db.Appointments
                        .Select(x => new
                        {
                            Date = x.AppointmentDate,
                            Doctor = x.AppointmentDoctor
                        })
                        .ToList();

                    dataGridView1.DataSource = appointments;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading appointments:\n" + ex.Message);
                }
            }
        }

        private void cmbx_specialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_specialty.SelectedIndex == -1 || cmbx_specialty.SelectedItem == null)
                return;

            var selectedExpert = cmbx_specialty.SelectedItem as Experts;
            if (selectedExpert == null)
                return;

            byte expertId = selectedExpert.Expertid; 

            using (var db = new DatabaseContext())
            {
                var doctors = db.Doctors
                    .Where(d => d.DoctorExpert == expertId)
                    .Select(d => new
                    {
                        d.Doctorid,
                        FullName = d.DoctorName.Trim() + " " + d.DoctorLastName.Trim()
                    })
                    .ToList();

                cmbx_doctor.DataSource = doctors;
                cmbx_doctor.DisplayMember = "FullName";
                cmbx_doctor.ValueMember = "Doctorid";
            }
        }

        private void RefreshAppointments()
        {
            using (var db = new DatabaseContext())
            {
                try
                {
                    var appointments = db.Appointments
                        .Select(x => new
                        {
                            Date = x.AppointmentDate,
                            Doctor = x.AppointmentDoctor
                        })
                        .ToList();

                    dataGridView1.DataSource = appointments;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data:\n" + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nationalId = txtbx_tc.Text.Trim();

            if (string.IsNullOrEmpty(nationalId))
            {
                MessageBox.Show("National ID number cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nationalId.Length != 11 || !nationalId.All(char.IsDigit))
            {
                MessageBox.Show("National ID number must be exactly 11 digits and contain numbers only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtbx_fullname.Text.Trim();
            if (string.IsNullOrEmpty(name) || name.All(char.IsDigit))
            {
                MessageBox.Show("Name cannot be empty or consist only of numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Gender cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = comboBox1.SelectedItem.ToString();
            string complaintMessage = richtxtbx_complaint.Text.Trim();

            if (string.IsNullOrEmpty(complaintMessage))
            {
                MessageBox.Show("Complaint field cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = dateTimePicker1.Value;
            if (selectedDate < DateTime.Now)
            {
                MessageBox.Show("Appointments cannot be scheduled for a past date or time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DatabaseContext())
            {
                try
                {
                    bool appointmentExists = db.Appointments.Any(a => a.AppointmentDate == dateTimePicker1.Value.ToString("dd.MM.yyyy HH:mm"));

                    if (appointmentExists)
                    {
                        MessageBox.Show("An appointment already exists for this date and time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newAppointment = new Appointments
                    {
                        AppointmentDate = dateTimePicker1.Value.ToString("dd.MM.yyyy HH:mm"),
                        AppointmentDoctor = cmbx_doctor.Text.Trim(),
                        AppointmentExpert = cmbx_specialty.SelectedValue.ToString(),
                        PatientTC = nationalId,
                        PatientComplaint = complaintMessage,
                        PatientName = name
                    };

                    db.Appointments.Add(newAppointment);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while creating your appointment:\n" + ex.Message);
                    return;
                }
            }

            RefreshAppointments();
            MessageBox.Show("Your appointment has been successfully created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Empty
        }
    }

    [Table("Tbl_Doctors")]
    public class Doctor
    {
        [Key]
        public byte Doctorid { get; set; }
        public string DoctorName { get; set; }
        public string DoctorLastName { get; set; }
        public byte DoctorExpert { get; set; } 
    }

    [Table("Tbl_Expert")]
    public class Experts
    {
        [Key]
        public byte Expertid { get; set; }
        public string ExpertName { get; set; }
    }

    [Table("Tbl_Appointments")]
    public class Appointments
    {
        [Key]
        public string AppointmentDate { get; set; }
        public string AppointmentDoctor { get; set; }
        public string AppointmentExpert { get; set; } 
        public string PatientTC { get; set; }
        public string PatientComplaint { get; set; }
        public string PatientName { get; set; }
    }

    public class DatabaseContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Experts> Experts { get; set; }
        public DbSet<Appointments> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = Environment.GetEnvironmentVariable("HOSPITAL_DB_CONNECTION")
                ?? @"Server=localhost;Database=HospitalProject;Trusted_Connection=True;TrustServerCertificate=True";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
