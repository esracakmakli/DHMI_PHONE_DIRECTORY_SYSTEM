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
    public partial class ADDING : Form
    {
        public ADDING()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0P6JGIT\\SQLEXPRESS;Initial Catalog=DHMI_PHONE_DİRECTORY_SYSTEM;Integrated Security=True");
        //I described these methods for only write number to texts
        private void number_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void number_txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //when click on add button, datas are saved to database.
        private void add_bttn_Click(object sender, EventArgs e)
        {
            int selectedIndex = department_select.SelectedIndex;

            int departmentid = selectedIndex + 1;

            connection.Open();

            SqlCommand command = new SqlCommand("insert into PHONE_NUMBERS(DEPARTMENT_ID,PHONE_NUMBER)  values('"+departmentid+"','"+232+' '+274+' '+number_txt.Text+' '+number_txt2.Text+"')", connection);

            command.ExecuteNonQuery();

            MessageBox.Show("Record Added!");

            connection.Close();
        }
        //when form load, datas appear on combobox
        private void ADDING_Load(object sender, EventArgs e)
        {          
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM DEPARTMENTS", connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                department_select.Items.Add(reader["DEPARTMENT_NAME"]);
            }
            connection.Close();
        }
        //when click back button, form1 will open 
        private void back_bttn_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();

            Form1 form1 = new Form1();

            form1.ShowDialog();
        }
    }
}
