using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp14
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtBx1_TextChanged(object sender, EventArgs e)
        {
            //get user name and password from the textboxes, remove extra space
            string username = txtUsername.Text.Trim();
            string Password= txtPassword.Text.Trim();
            // check if username or password is empty
            if (username == "" || Password == "")
            {
                MessageBox.Show("please enter username and password.");
                    return; // stop the login process/program
            }
            // call connection string
            DBConnect db = new DBConnect();

            try
            {
                db.Open(); // open database connection
                // sql query to count matching username and password
                string query = "SELECT COUNT(*) FROM users " +
                "username=@username AND password=@password";

                // create mysql command
                MySql.Data.MySqlClient.MySqlCommand cmd = 
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                // add parameters to prevent sql injection
                cmd.Parameters.AddWithValue("username" , username);
                cmd.Parameters.AddWithValue("password" , Password);

                // execute query and get results
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    // if i record found , login succesful
                    MessageBox.Show("login succesful!");
                    // open dashboard
                   Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();

                }
                else 
                {
                    // no match found
                    MessageBox.Show("invalid username or password");
                }



            }
            catch (Exception ex)
            {
                // show error message message if something goes wrong
                MessageBox.Show(ex.Message);
            }
            finally
            {
               db.Close(); // close data base connection
            }
                    
        }
    }
}
