using SMS.Domain;
using SMS.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.App.Views
{
    public partial class AddStudentView : Form
    {
        public AddStudentView()
        {
            InitializeComponent();

            LoadPrograms();
            //LoadCourses();
        }

        //private void LoadCourses()
        //{
        //    using (var context = new AppDbContext())
        //    {
        //        var programs = context.Courses.Where(c => c.ProgramId == comboBoxPrograms.SelectedValue).ToList();
        //        comboBoxPrograms.DataSource = programs;
        //        comboBoxPrograms.DisplayMember = "ProgramName";
        //        comboBoxPrograms.ValueMember = "ProgramId";
        //    }
        //}

        private void LoadPrograms()
        {
            using (var context = new AppDbContext())
            {
                var programs = context.Programs.ToList();
                comboBoxPrograms.DataSource = programs;
                comboBoxPrograms.DisplayMember = "ProgramName";
                comboBoxPrograms.ValueMember = "ProgramId";
            }
        }

        private void comboBoxPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var student = new Student
                {
                    StudentName = textBoxName.Text,
                    Email = textBoxEmail.Text,
                    ProgramId = (int)comboBoxPrograms.SelectedValue
                };

                context.Students.Add(student);
                context.SaveChanges();

                DialogResult = DialogResult.OK;
                MessageBox.Show("Student Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
