using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_registration
{
    public partial class login : Form
    {
        List<User> userss = new List<User>();
        public login()
        {
            InitializeComponent();
            User user = new User("Mata","pass2023");
            userss.Add(user);
            


        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            foreach (User item in userss)
            {

                if (userBox.Text == item.Name && passBox.Text == item.Pass)
                {

                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else if (userBox.Text == "" || passBox.Text == "" )
                {
                    MessageBox.Show("ERROR, please write all data");
                }
                else
                {
                    MessageBox.Show("Username or Password wrong, please trey again");
                }
                

            }
            

        }
    }
    class User
    {
        
        public string Name { get; set; }
        public string Pass { get; set; }
        public User(string n,string pass)
        {
            Name = n;
            Pass = pass;
        }
    }
   
}
