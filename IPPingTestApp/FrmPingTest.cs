using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace IPPingTestApp
{
    public partial class FrmPingTest : Form
    {
        public FrmPingTest()
        {
            InitializeComponent();
        }

        private Ping pingSender = new Ping();


        private void btnStartPing_Click(object sender, EventArgs e)
        {
            string ipaddr = this.txtlblAddr.Text.Trim();
            if (ValidateIPAddr(ipaddr))
            {
                PingOptions pingOpt = new PingOptions();
                pingOpt.DontFragment = true;
                string sendData = @"test";
                byte[] buffer = Encoding.ASCII.GetBytes(sendData);
                int timeout = 120;
                PingReply reply = pingSender.Send(ipaddr, timeout, buffer, pingOpt);
                if (reply.Status == IPStatus.Success)
                {
                    MessageBox.Show("网络ping的通");
                }
                else
                {
                    MessageBox.Show("网络ping不通，存在问题");
                }
            }
        }

        /// <summary>
        /// IP地址正则验证
        /// </summary>
        /// <param name="ipaddr">IP地址</param>
        /// <returns>是否正确的IP地址</returns>
        private bool ValidateIPAddr(string ipaddr)
        {
            Regex ipregex = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            return (ipaddr.Trim() != "" && ipregex.IsMatch(ipaddr.Trim())) ? true : false;
        }

        private void FrmPingTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
