using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubjects frm = new FrmSubjects();
            frm.Show();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClass frm = new FrmClass();
            frm.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudent frm = new FrmStudent();
            frm.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentList frm = new FrmStudentList();
            frm.Show();
        }
    }
}
