using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
 
namespace ADMS_Project
{
    public partial class Registration : Form
    {
        
        public Registration()
        {
            InitializeComponent();
        }

       public void label4_Click(object sender, EventArgs e)
        {

        }

     public void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void addAdminRegisterButton_Click(object sender, EventArgs e)
        {
            string insertReg = $"insert into  admin(ADMINID,ADMINNAME,USERNAME,EMAIL ,PASSWORD,GENDER,AGE) values('{textBox1.Text}','{addAdminNameTextBox.Text}', '{addAdminUsernameTextBox.Text}', '{addAdminEmailTextBox.Text}','{addAdminPasswordTextBox.Text}', '{addAdminGenderComboBox.Text}','{addAdminAgeTextBox.Text}')";

            DbAccess.UpdateDeleteInsert(insertReg);
            DbAccess.Connection.Close();




            MessageBox.Show("User added successfully !!!");

        }
    }
}
