using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace SerwerTCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener serwer = null;
        private TcpClient klient = null;

        private void start_Click(object sender, EventArgs e)
        {
            IPAddress adresIP = null;
            try
            {
                adresIP = IPAddress.Parse(adres.Text);
            }
            catch
            {
                MessageBox.Show("Błędny format adresu IP", "Błąd");
                adres.Text = string.Empty;
                return;
            }

            int port = Convert.ToInt32(port_p.Value);
            try
            {
                serwer = new TcpListener(adresIP, port);
            }

        }




    }

    }
