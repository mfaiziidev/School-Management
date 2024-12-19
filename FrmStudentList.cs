using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Management
{
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
        }
        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            DataGridView();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FrmStudent frm = new FrmStudent();
            frm.Show();
            
          
            frm.txtName.Text = dataGridStuList.SelectedRows[0].Cells["StudentName"].Value.ToString();
            frm.txtRollNo.Text = dataGridStuList.SelectedRows[0].Cells["RollNo"].Value.ToString();
            frm.txtEmail.Text = dataGridStuList.SelectedRows[0].Cells["Email"].Value.ToString();
            frm.txtAddress.Text = dataGridStuList.SelectedRows[0].Cells["Address"].Value.ToString();
            frm.cmbClassID.Text = dataGridStuList.SelectedRows[0].Cells["ClassID"].Value.ToString();
            frm.cmbSubjectID.Text = dataGridStuList.SelectedRows[0].Cells["SubjectID"].Value.ToString();

            frm.id = Convert.ToInt32(dataGridStuList.SelectedRows[0].Cells["StudentID"].Value.ToString());
            this.Hide();
        }

        public List<clsStudents> GetData()
        {
            List<clsStudents> lst = new List<clsStudents>();
            SqlConnection con = new SqlConnection(clsConnection.connection);

            SqlCommand cmd = new SqlCommand("SP_GetStudents", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                clsStudents stu = new clsStudents();

                stu.StudentID = Convert.ToInt32(dr["StudentID"]);
                stu.StudentName = Convert.ToString(dr["StudentName"]);
                stu.RollNo = Convert.ToString(dr["RollNo"]);
                stu.Email = Convert.ToString(dr["Email"]);
                stu.Address = Convert.ToString(dr["Address"]);
                stu.ClassName = Convert.ToString(dr["ClassName"]);
                stu.SubjectName = Convert.ToString(dr["SubjectName"]);

                lst.Add(stu);
            }
            return lst;
        }

        public void DataGridView()
        {
            dataGridStuList.Rows.Clear();

            var sublist = GetData();
            foreach(var n in sublist)
            {
                int rowindex = dataGridStuList.Rows.Add();
                dataGridStuList.Rows[rowindex].Cells["StudentID"].Value = n.StudentID;
                dataGridStuList.Rows[rowindex].Cells["StudentName"].Value = n.StudentName;
                dataGridStuList.Rows[rowindex].Cells["RollNo"].Value = n.RollNo;
                dataGridStuList.Rows[rowindex].Cells["Email"].Value = n.Email;
                dataGridStuList.Rows[rowindex].Cells["Address"].Value = n.Address;
                dataGridStuList.Rows[rowindex].Cells["ClassID"].Value = n.ClassName;
                dataGridStuList.Rows[rowindex].Cells["SubjectID"].Value = n.SubjectName;
            }
        }
    }
}
