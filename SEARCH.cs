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
    public partial class SEARCH : Form
    {
        public SEARCH()
        {
            InitializeComponent();
           
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0P6JGIT\\SQLEXPRESS;Initial Catalog=DHMI_PHONE_DİRECTORY_SYSTEM;Integrated Security=True");      
        private void SEARCH_Load(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM DEPARTMENTS", connection);
            
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["DEPARTMENT_NAME"]);
            }
            connection.Close();               
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            int id = selectedIndex + 1;

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM PHONE_NUMBERS WHERE DEPARTMENT_ID="+id, connection);

            SqlDataReader reader = command.ExecuteReader();

            List<string> list = new List<string>();

            while (reader.Read())
            {
                list.Add(reader["PHONE_NUMBER"].ToString());
                
            }
           
            connection.Close();

            string sum = "";

            for (int i = 0; i < list.Count; i++)
            {
                sum = sum + list[i] + Environment.NewLine;
            }

            MessageBox.Show("Phone Numbers: " + Environment.NewLine + sum );    
        }     

        private void back_bttn_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();

            Form1 form1 = new Form1();

            form1.ShowDialog();
        }
    }
}
