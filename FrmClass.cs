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
    public partial class FrmClass : Form
    {
        int id { get; set; }
        public FrmClass()
        {
            InitializeComponent();
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
            DataGridView();

            SqlConnection con = new SqlConnection(clsConnection.connection);
            string str = "SELECT * FROM Subjects";
            List<clsSubjects> list = new List<clsSubjects>();
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while(sdr.Read())
            {
                clsSubjects cls = new clsSubjects();

                cls.SubjectID = Convert.ToInt32(sdr["SubjectID"]);
                cls.SubjectName = Convert.ToString(sdr["SubjectName"]);

                list.Add(cls);
            }

            cmbSubject.DataSource = list;
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.DisplayMember = "SubjectName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                SqlConnection con = new SqlConnection(clsConnection.connection);
                SqlCommand cmd = new SqlCommand("SP_InsertClass", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                cmd.Parameters.AddWithValue("@ClassName", txtClassName.Text);
                cmd.Parameters.AddWithValue("@ClassSection", txtSection.Text);
                cmd.Parameters.AddWithValue("@ClassStandard", txtClassStandard.Text);
                cmd.Parameters.AddWithValue("@SubjectID", cmbSubject.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved successfully");
            }

            else if (id > 0)
            {
                SqlConnection con = new SqlConnection(clsConnection.connection);
                SqlCommand cmd = new SqlCommand("SP_UpdateClass", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                cmd.Parameters.AddWithValue("@ClassID", id);
                cmd.Parameters.AddWithValue("@ClassName", txtClassName.Text);
                cmd.Parameters.AddWithValue("@ClassSection", txtSection.Text);
                cmd.Parameters.AddWithValue("@ClassStandard", txtClassStandard.Text);
                cmd.Parameters.AddWithValue("@SubjectID", cmbSubject.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated successfully");
            }
            DataGridView();
            txtClassName.Text = txtSection.Text = txtClassStandard.Text = cmbSubject.Text = "";
            id = 0;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassName.Text = txtSection.Text = txtClassStandard.Text = cmbSubject.Text = "";
            id = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(clsConnection.connection);
            SqlCommand cmd = new SqlCommand("SP_DeleteClass", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            cmd.Parameters.AddWithValue("@ClassID", id);
            cmd.Parameters.AddWithValue("@ClassName", txtClassName.Text);
            cmd.Parameters.AddWithValue("@ClassSection", txtSection.Text);
            cmd.Parameters.AddWithValue("@ClassStandard", txtClassStandard.Text);
            cmd.Parameters.AddWithValue("@SubjectID", cmbSubject.SelectedValue);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted successfully");
            DataGridView();
            txtClassName.Text = txtSection.Text = txtClassStandard.Text = cmbSubject.Text = "";
            id = 0;
        }

        List <clsClass> GetData()
        {
            List<clsClass> list = new List<clsClass>();
            SqlConnection con = new SqlConnection(clsConnection.connection);
            SqlCommand cmd = new SqlCommand("SP_GetClass", con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                clsClass cls = new clsClass();

                cls.ClassID = Convert.ToInt32(dr["ClassID"]);
                cls.ClassName = dr["ClassName"].ToString();
                cls.ClassSection = dr["ClassSection"].ToString();
                cls.ClassStandard = dr["ClassStandard"].ToString();
                cls.SubjectName = dr["SubjectName"].ToString();

                list.Add(cls);
            }
            return list;
        }

        public void DataGridView()
        {
            dataGridClass.Rows.Clear();

            var sublist = GetData();
            foreach(var n in sublist)
            {
                int rowindex = dataGridClass.Rows.Add();
                dataGridClass.Rows[rowindex].Cells["ClassID"].Value = n.ClassID;
                dataGridClass.Rows[rowindex].Cells["ClassName"].Value = n.ClassName;
                dataGridClass.Rows[rowindex].Cells["ClassSection"].Value = n.ClassSection;
                dataGridClass.Rows[rowindex].Cells["ClassStandard"].Value = n.ClassStandard;
                dataGridClass.Rows[rowindex].Cells["SubjectID"].Value = n.SubjectName;
            }
        }

        private void dataGridClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtClassName.Text = dataGridClass.SelectedRows[0].Cells["ClassName"].Value.ToString();
                txtSection.Text = dataGridClass.SelectedRows[0].Cells["ClassSection"].Value.ToString();
                txtClassStandard.Text = dataGridClass.SelectedRows[0].Cells["ClassStandard"].Value.ToString();
                cmbSubject.Text = dataGridClass.SelectedRows[0].Cells["SubjectID"].Value.ToString();

                id = Convert.ToInt32(dataGridClass.SelectedRows[0].Cells["ClassID"].Value.ToString());
            }
        }

        private void txtClassName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.');
        }

        private void txtSection_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtClassStandard_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
