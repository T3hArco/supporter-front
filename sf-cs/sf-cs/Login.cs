using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility;

namespace sf_cs
{
    public partial class Login : Form
    {
        public const String authID = "";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authenticator authenticator = new Authenticator(username.Text, password.Text, "http://localhost/supporter/supporter-backend/php/?act=authenticate");
            String output = authenticator.authenticate();

            String[] outputArr = output.Split('-');

            if (outputArr[0] == "200")
            {
                MessageBox.Show("You've been successfully logged in!");

                var user = new User();
                user.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(output);
            }
        }
    }
}
