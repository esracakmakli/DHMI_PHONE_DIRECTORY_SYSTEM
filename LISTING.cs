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
    public partial class LISTING : Form
    {
        public LISTING()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0P6JGIT\\SQLEXPRESS;Initial Catalog=DHMI_PHONE_DİRECTORY_SYSTEM;Integrated Security=True");
        //when open listing form, datas load to datagridview.
        private void LISTING_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = refresh();
        }               
        DataTable refresh()
        {        
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID,DEPARTMENT_NAME FROM DEPARTMENTS", con);

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
        //when double click to data on datagridview, you see to saved phone numbers.
        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            //holds the id of the data hovered over it
            string selectedid = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            con.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PHONE_NUMBERS WHERE DEPARTMENT_ID=" + selectedid, con);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<string> list = new List<string>();
            //it save readed data to list 
            while (reader.Read())
            {
                list.Add(reader["PHONE_NUMBER"].ToString());

            }

            con.Close();

            string sum = "";
            //this loop sum to list elements
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i] + Environment.NewLine;
            }

            MessageBox.Show("Phone Numbers: " + Environment.NewLine + sum);
        }
    }
}
