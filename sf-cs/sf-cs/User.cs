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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void checkMyUIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String authkey = sf_cs.Properties.Settings.Default.AuthKey;

            WebrequestHandler webRequestHandler = new WebrequestHandler("http://localhost/supporter/supporter-backend/php/?act=getauthkey&authkey=" + authkey, "", 1);
            MessageBox.Show(webRequestHandler.request());
        }

        private void getListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticketList.Items.Clear();

            String authkey = sf_cs.Properties.Settings.Default.AuthKey;

            WebrequestHandler webRequestHandler = new WebrequestHandler("http://localhost/supporter/supporter-backend/php/?act=getitemlist&authkey=" + authkey, "", 1);
            //MessageBox.Show(webRequestHandler.request());
            String ticketsUnformatted = webRequestHandler.request();
            String[] ticketsFormatted = ticketsUnformatted.Split(',');

            for (int i = 0; i < ticketsUnformatted.Length-1; i++)
            {
                ticketList.Items.Add(ticketsFormatted[i]);
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            ticketList.Items.Clear();

            String authkey = sf_cs.Properties.Settings.Default.AuthKey;

            WebrequestHandler webRequestHandler = new WebrequestHandler("http://localhost/supporter/supporter-backend/php/?act=getitemlist&authkey=" + authkey, "", 1);
            //MessageBox.Show(webRequestHandler.request());
            String ticketsUnformatted = webRequestHandler.request();
            String[] ticketsFormatted = ticketsUnformatted.Split(',');

            for (int i = 0; i < ticketsUnformatted.Length; i++)
            {
                ticketList.Items.Add(ticketsFormatted[i]);
            }
        }
    }
}
