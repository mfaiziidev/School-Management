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
    public partial class FrmStudent : Form
    {
        public int id { get; set; }
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
               GridDataView();

            SqlConnection con = new SqlConnection(clsConnection.connection);
            List<clsClass> list = new List<clsClass>();
            string sql = "Select * From Class";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                clsClass cl = new clsClass();

                cl.ClassID = Convert.ToInt32(sdr["ClassID"]);
                cl.ClassName = Convert.ToString(sdr["ClassName"]);
                
                list.Add(cl);
            }
            list.Insert(0, new clsClass() { ClassName = "--SELECT--" });

            cmbClassID.DataSource = list;
            cmbClassID.ValueMember = "ClassID";
            cmbClassID.DisplayMember = "ClassName";
            con.Close();

         //======================================================================================

            con.Open();
            List<clsSubjects> lst = new List<clsSubjects>();
            string str = "Select * From Subjects";
            
            SqlCommand cmnd = new SqlCommand(str, con);
            SqlDataReader dr = cmnd.ExecuteReader();
            while (dr.Read())
            {
                clsSubjects sub = new clsSubjects();

                sub.SubjectID = Convert.ToInt32(dr["SubjectID"]);
                sub.SubjectName = Convert.ToString(dr["SubjectName"]);

                lst.Add(sub);
            }
            cmbSubjectID.DataSource = lst;
            cmbSubjectID.ValueMember = "SubjectID";
            cmbSubjectID.DisplayMember = "SubjectName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                SqlConnection con = new SqlConnection(clsConnection.connection);
                SqlCommand cmd = new SqlCommand("SP_InsertStudents", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();


                cmd.Parameters.AddWithValue("@StudentName", txtName.Text);
                cmd.Parameters.AddWithValue("@RollNo", txtRollNo.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@ClassID", cmbClassID.SelectedValue);
                cmd.Parameters.AddWithValue("@SubjectID", cmbSubjectID.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved successfully");
            }

            else if (id > 0)
            {
                SqlConnection con = new SqlConnection(clsConnection.connection);
                SqlCommand cmd = new SqlCommand("SP_UpdateStudents", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                cmd.Parameters.AddWithValue("@StudentID", id);
                cmd.Parameters.AddWithValue("@StudentName", txtName.Text);
                cmd.Parameters.AddWithValue("@RollNo", txtRollNo.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@ClassID", cmbClassID.SelectedValue);
                cmd.Parameters.AddWithValue("@SubjectID", cmbSubjectID.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated successfully");
            }
            GridDataView();
            txtName.Text = txtRollNo.Text = txtEmail.Text = txtAddress.Text = "";
            id = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = txtRollNo.Text = txtEmail.Text = txtAddress.Text = "";
            id = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(clsConnection.connection);
            SqlCommand cmd = new SqlCommand("SP_DeleteStudents", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            cmd.Parameters.AddWithValue("@StudentID", id);
            cmd.Parameters.AddWithValue("@StudentName", txtName.Text);
            cmd.Parameters.AddWithValue("@RollNo", txtRollNo.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@ClassID", cmbClassID.SelectedValue);
            cmd.Parameters.AddWithValue("@SubjectID", cmbSubjectID.SelectedValue);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted successfully");
            GridDataView();
            txtName.Text = txtRollNo.Text = txtEmail.Text = txtAddress.Text = "";
            id = 0;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmStudentList frm = new FrmStudentList();
            frm.Show();
            this.Hide();
         
            frm.DataGridView();
        }

        List<clsStudents> GetData()
        {
            SqlConnection con = new SqlConnection(clsConnection.connection);
            List<clsStudents> lst = new List<clsStudents>();
            SqlCommand cmd = new SqlCommand("SP_GetStudents", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                clsStudents cls = new clsStudents();

                cls.StudentID = Convert.ToInt32(dr["StudentID"]);
                cls.StudentName = Convert.ToString(dr["StudentName"]);
                cls.RollNo = Convert.ToString(dr["RollNo"]);
                cls.Email = Convert.ToString(dr["Email"]);
                cls.Address = Convert.ToString(dr["Address"]);
                cls.ClassName = Convert.ToString(dr["ClassName"]);
                cls.SubjectName = Convert.ToString(dr["SubjectName"]);

                lst.Add(cls);
            }
            return lst;
        }

        public void GridDataView()
        {
            dataGridStudents.Rows.Clear();

            var sublist = GetData();
            foreach(var n in sublist)
            {
                int rowindex = dataGridStudents.Rows.Add();

                dataGridStudents.Rows[rowindex].Cells["StudentID"].Value = n.StudentID;
                dataGridStudents.Rows[rowindex].Cells["StudentName"].Value = n.StudentName;
                dataGridStudents.Rows[rowindex].Cells["RollNo"].Value = n.RollNo;
                dataGridStudents.Rows[rowindex].Cells["Email"].Value = n.Email;
                dataGridStudents.Rows[rowindex].Cells["Address"].Value = n.Address;
                dataGridStudents.Rows[rowindex].Cells["ClassID"].Value = n.ClassName;
                dataGridStudents.Rows[rowindex].Cells["SubjectID"].Value = n.SubjectName;
            }
        }

        private void dataGridStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dataGridStudents.SelectedRows[0].Cells["StudentName"].Value.ToString();
                txtRollNo.Text = dataGridStudents.SelectedRows[0].Cells["RollNo"].Value.ToString();
                txtEmail.Text = dataGridStudents.SelectedRows[0].Cells["Email"].Value.ToString();
                txtAddress.Text = dataGridStudents.SelectedRows[0].Cells["Address"].Value.ToString();
                cmbClassID.Text = dataGridStudents.SelectedRows[0].Cells["ClassID"].Value.ToString();
                cmbSubjectID.Text = dataGridStudents.SelectedRows[0].Cells["SubjectID"].Value.ToString();

                id = Convert.ToInt32(dataGridStudents.SelectedRows[0].Cells["StudentID"].Value.ToString());
            }
        }

        private void txtName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ');
        }

        private void txtRollNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtAddress_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != '.') && (e.KeyChar != ',');
        }

        private void cmbClassID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(clsConnection.connection);
            SqlCommand cmd = new SqlCommand("SP_GetCombo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clsStudents> lsst = new List<clsStudents>();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
           

            con.Open();

            if(cmbClassID.SelectedIndex == 0)
            {
                return;
            }

            cmd.Parameters.AddWithValue("@ClassID", cmbClassID.SelectedValue);

            sda.Fill(dt);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                clsStudents stu = new clsStudents();

                stu.SubjectID = Convert.ToInt32(dr["SubjectID"]);
                stu.SubjectName = Convert.ToString(dr["SubjectName"]);

                lsst.Add(stu);
            }

            cmbSubjectID.DataSource = lsst;
            cmbSubjectID.DisplayMember = "SubjectName";
            cmbSubjectID.ValueMember = "SubjectID";

           
        }
    }
}
