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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();


            var studentView = new StudentView();
            CallChildForm(studentView);
        }

        private void CallChildForm(Form childForm)
        {
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Parent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }
    }
}
