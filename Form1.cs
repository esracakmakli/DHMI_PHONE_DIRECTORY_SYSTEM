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
using System.Data.Common;

namespace DHMI_PHONE_DİRECTORY_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0P6JGIT\\SQLEXPRESS;Initial Catalog=DHMI_PHONE_DİRECTORY_SYSTEM;Integrated Security=True");      
        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
        }
        private void search_bttn_Click(object sender, EventArgs e)
        {
            SEARCH search = new SEARCH();
            BringForm(search);
        }
        //I described BringForm() Method for open other forms into form1.
        private void BringForm(Form form)
        {
            panel1.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
        }
        private void listing_bttn_Click(object sender, EventArgs e)
        {
            LISTING listing = new LISTING();
            BringForm(listing);         
        }

        private void adding_bttn_Click(object sender, EventArgs e)
        {
            ADDING adding = new ADDING();
            BringForm(adding);
        }
        private void update_bttn_Click(object sender, EventArgs e)
        {
            UPDATE update = new UPDATE();
            BringForm(update);
        }
        private void deletion_bttn_Click(object sender, EventArgs e)
        {
            DELETE delete = new DELETE();
            BringForm(delete);
        }
    }
}
