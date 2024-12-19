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
    public partial class FrmSubjects : Form
    {
        int id { get; set; }
        
        public FrmSubjects()
        {
            InitializeComponent();
        }

        private void FrmSubjects_Load(object sender, EventArgs e)
        {
            GetData();
            DataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if( id == 0)
            {
                SqlConnection con = new SqlConnection(clsConnection.connection);
                SqlCommand cmd = new SqlCommand("SP_InsertSubjects", con);
                cmd.CommandType = CommandType.StoredProcedure;  

                con.Open();
                cmd.Parameters.AddWithValue("@SubjectName", txtSubtName.Text);
                cmd.Parameters.AddWithValue("@SubjectStandard", txtSubStandard.Text);
                cmd.Parameters.AddWithValue("@SubjectCategory", txtSubCategory.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved successfully");
            }

            if (id > 0)
            {
                SqlConnection con = new SqlConnection(clsConnection.connection);
                SqlCommand cmd = new SqlCommand("SP_UpdateSubjects", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                cmd.Parameters.AddWithValue("@SubjectID", id);
                cmd.Parameters.AddWithValue("@SubjectName", txtSubtName.Text);
                cmd.Parameters.AddWithValue("@SubjectStandard", txtSubStandard.Text);
                cmd.Parameters.AddWithValue("@SubjectCategory", txtSubCategory.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated sucessfully");
            }

            id = 0;
            GetData();
            DataGridView();
            txtSubtName.Text = txtSubStandard.Text = txtSubCategory.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(clsConnection.connection);
            SqlCommand cmd = new SqlCommand("SP_DeleteSubjects", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            cmd.Parameters.AddWithValue("@SubjectID", id);
            cmd.Parameters.AddWithValue("@SubjectName", txtSubtName.Text);
            cmd.Parameters.AddWithValue("@SubjectStandard", txtSubStandard.Text);
            cmd.Parameters.AddWithValue("@SubjectCategory", txtSubCategory.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted successfully");

            id = 0;
            GetData();
            DataGridView();
            txtSubtName.Text = txtSubStandard.Text = txtSubCategory.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubtName.Text = txtSubStandard.Text = txtSubCategory.Text = "";
        }

        List<clsSubjects> GetData()
        {
            List<clsSubjects> lst = new List<clsSubjects>();

            SqlConnection con = new SqlConnection(clsConnection.connection);
            SqlCommand cmd = new SqlCommand("SP_GetSubjects", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                clsSubjects sub = new clsSubjects();

                sub.SubjectID = Convert.ToInt32(dr["SubjectID"]);
                sub.SubjectName = Convert.ToString(dr["SubjectName"]);
                sub.SubjectStandard = Convert.ToString(dr["SubjectStandard"]);
                sub.SubjectCategory = Convert.ToString(dr["SubjectCategory"]);

                lst.Add(sub);
            }

            return lst;
        }

        public void DataGridView()
        {
            dataGridsubjects.Rows.Clear();
            var sublist = GetData();
            foreach(var n in sublist)
            {
                int RowIndex = dataGridsubjects.Rows.Add();

                dataGridsubjects.Rows[RowIndex].Cells["SubjectID"].Value = n.SubjectID;
                dataGridsubjects.Rows[RowIndex].Cells["SubjectName"].Value = n.SubjectName;
                dataGridsubjects.Rows[RowIndex].Cells["SubjectStandard"].Value = n.SubjectStandard;
                dataGridsubjects.Rows[RowIndex].Cells["SubjectCategory"].Value = n.SubjectCategory;
            }  
        }

        private void dataGridsubjects_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtSubtName.Text = dataGridsubjects.SelectedRows[0].Cells["SubjectName"].Value.ToString();
                txtSubStandard.Text = dataGridsubjects.SelectedRows[0].Cells["SubjectStandard"].Value.ToString();
                txtSubCategory.Text = dataGridsubjects.SelectedRows[0].Cells["SubjectCategory"].Value.ToString();

                id = Convert.ToInt32(dataGridsubjects.SelectedRows[0].Cells["SubjectID"].Value);
            }
        }

        private void txtSubtName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
             e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != '.');
        }

        private void txtSubStandard_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar);
        }

        private void txtSubCategory_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

    }
}
