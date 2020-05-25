using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHMI_PHONE_DİRECTORY_SYSTEM
{
    public partial class UPDATE : Form
    {
        public UPDATE()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0P6JGIT\\SQLEXPRESS;Initial Catalog=DHMI_PHONE_DİRECTORY_SYSTEM;Integrated Security=True");           
        private void UPDATE_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM DEPARTMENTS", con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                department_select.Items.Add(reader["DEPARTMENT_NAME"]);
            }
            con.Close();
        }
        private void update_bttn_Click(object sender, EventArgs e)
        {           
            //holds id and phone number of clicked data
            string selectedid = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            string updatenumber = dataGridView1.CurrentRow.Cells["PHONE_NUMBER"].Value.ToString();

            con.Open();
            
            SqlCommand command = new SqlCommand("update PHONE_NUMBERS set PHONE_NUMBER='" + updatenumber + "' where ID="+selectedid, con);
            
            command.ExecuteNonQuery();
            
            con.Close();

            dataGridView1.DataSource = refresh();

            MessageBox.Show("Record Added!");
        }
        private void department_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = refresh();
        }
        DataTable refresh()
        {
            int selectedIndex = department_select.SelectedIndex;

            int id = selectedIndex + 1;

            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID,PHONE_NUMBER FROM PHONE_NUMBERS WHERE DEPARTMENT_ID=" + id,con);
            
            DataTable table = new DataTable();
            
            adapter.Fill(table);
            
            con.Close();
            
            return table;
        }
        private void back_bttn_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();

            Form1 form1 = new Form1();

            form1.ShowDialog();
        }
    }
}
