using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace EscalationTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size((tabControl1.Width / tabControl1.TabPages.Count) - 1, tabControl1.ItemSize.Height);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size((tabControl1.Width / tabControl1.TabPages.Count) - 1, tabControl1.ItemSize.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var connString = System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

                var conn = new SqlConnection(connString);
                conn.Open();

                var command = new SqlCommand(
                    "INSERT INTO escalations VALUES (12345, 1, 'help', 'kusto', 'tsg', 'details', 1);", conn);

                SqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
