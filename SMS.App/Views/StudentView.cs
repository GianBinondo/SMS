using Microsoft.EntityFrameworkCore;
using SMS.Domain.ViewModels;
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
    public partial class StudentView : Form
    {
        private readonly AppDbContext _context;
        public StudentView()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadStudents();
        }

        private void LoadStudents()
        {
            var studentVM = _context.Students
                .Include(s => s.Program)
                .Select(c => new StudentViewModel
                {
                    StudentId = c.StudentId,
                    StudentName = c.StudentName,
                    Email = c.Email,
                    Program = c.Program.ProgramName
                })
                .ToList();
            dataGridViewStudents.DataSource = studentVM;
        }

        private void buttonAddNewStudents_Click(object sender, EventArgs e)
        {
            using (var addStudents = new AddStudentView())
            {
                if(addStudents.ShowDialog() == DialogResult.OK)
                    LoadStudents();
            }
        }
    }
}
