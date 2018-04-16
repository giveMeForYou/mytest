using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace MyInternetTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
            //获取主机地址
            IPAddress[] ips = Dns.GetHostAddresses(textBox1.Text);
            //循环遍历IP地址
            foreach (IPAddress ip in ips) {
                //在lable2中显示IP的信息
                label2.Text = "网际协议地址：" + ip.Address + "\nIP地址的地址家族：" + ip.AddressFamily.ToString()+"\n是否ipv6连接本地地址："+ip.IsIPv6LinkLocal;
            }
        }
    }
}
