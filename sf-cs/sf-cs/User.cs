﻿using System;
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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            String authkey = sf_cs.Properties.Settings.Default.AuthKey;

            WebrequestHandler webRequestHandler = new WebrequestHandler("http://localhost/supporter/supporter-backend/php/?act=getauthkey&authkey=" + authkey, "", 1);
            label1.Text = webRequestHandler.request();
        }

        private void checkMyUIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            String authkey = sf_cs.Properties.Settings.Default.AuthKey;

            WebrequestHandler webRequestHandler = new WebrequestHandler("http://localhost/supporter/supporter-backend/php/?act=getauthkey&authkey=" + authkey, "", 1);
            MessageBox.Show(webRequestHandler.request());
        }

        private void getListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            String authkey = sf_cs.Properties.Settings.Default.AuthKey;

            WebrequestHandler webRequestHandler = new WebrequestHandler("http://localhost/supporter/supporter-backend/php/?act=getitemlist&authkey=" + authkey, "", 1);
            MessageBox.Show(webRequestHandler.request());
        }
    }
}
