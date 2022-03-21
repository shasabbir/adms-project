using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS_Project
{
    public partial class create1 : Form
    {
        public create1()
        {
            InitializeComponent();
        }

        private void AddCourse(object sender, EventArgs e)
        {
            string c_code = tbCCode.Text;
            string c_name = tbCName.Text;
            string connString = @"Server=DESKTOP-2JKGA1B\SQLEXPRESS;Database=database1;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = String.Format("INSERT INTO Courses VALUES ('{0}','{1}')", c_code, c_name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                Console.WriteLine("add value");
            }
            else
            {
                Console.WriteLine("value not added");
            }
            conn.Close();
        }

    }

    private void btnLoad_Click(object sender, EventArgs e)
        {
        string connString = @"Server=DESKTOP-2JKGA1B\SQLEXPRESS;Database=database1;Integrated Security=true";
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        string query = "select * from courses";
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader reader = cmd.ExecuteReader();
        // dtcourses.DataSource
        ArrayList list = new ArrayList();
        while (reader.Read())
        {
            course c = new course();
            c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
            c.Course = reader.GetString(reader.GetOrdinal("Course"));
            list.Add(c);




        }
        dtCourses.DataSource = list;
    }

}

private void SearchCourse(object sender, EventArgs e)
        {
    int cId = Int32.Parse(tbCId.Text);
    string connString = @"Server=DESKTOP-2JKGA1B\SQLEXPRESS;Database=database1;Integrated Security=true";
    SqlConnection conn = new SqlConnection(connString);
    conn.Open();
    string query = string.Format("select * from courses where Id={0}", cId);
    SqlCommand cmd = new SqlCommand(query, conn);
    SqlDataReader reader = cmd.ExecuteReader();

    course c = new course();
    while (reader.Read())
    {
        c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
        c.Course = reader.GetString(reader.GetOrdinal("Course"));
        c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
    }
    tbCCodeEdit.Text = c.CourseCode;
    tbCNameEdit.Text = c.Course;
    conn.Close();
}

        

        private void UpdateCourse(object sender, EventArgs e)
        {
    int cId = Int32.Parse(tbCId.Text);
    string cCode = tbCCodeEdit.Text;
    string cName = tbCNameEdit.Text;
    string connString = @"Server=DESKTOP-2JKGA1B\SQLEXPRESS;Database=database1;Integrated Security=true";
    SqlConnection conn = new SqlConnection(connString);
    conn.Open();
    string query = string.Format("update courses set CourseCode='{0}', Course='{1}'where Id={2}", cCode, cName, cId);
    SqlCommand cmd = new SqlCommand(query, conn);
    int r = cmd.ExecuteNonQuery();

    conn.Close();
    // dtCourses.DataSource =list;

}

        

        private void Delete(object sender, EventArgs e)
        {
    int cId = Int32.Parse(tbCId.Text);
    string connString = @"Server=DESKTOP-2JKGA1B\SQLEXPRESS;Database=database1;Integrated Security=true";
    SqlConnection conn = new SqlConnection(connString);
    conn.Open();
    string query = string.Format("delete from courses where Id={0}", cId);
    SqlCommand cmd = new SqlCommand(query, conn);
    SqlDataReader reader = cmd.ExecuteReader();

    course c = new course();
    while (reader.Read())
    {
        c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
        c.Course = reader.GetString(reader.GetOrdinal("Course"));
        c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
    }
    tbCCodeEdit.Text = c.CourseCode;
    tbCNameEdit.Text = c.Course;
    conn.Close();
}
    }
}
