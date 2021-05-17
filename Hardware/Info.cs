using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;

namespace Hardware
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main page = new Main();
            page.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
          //IPclick  //mojno sdelat perehod po ssilke ipshnika
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher myMotherBoard = new ManagementObjectSearcher("select * from Win32_BaseBoard");

            foreach (ManagementObject obj in myMotherBoard.Get())
            {
               label7.Text= (string)obj["Product"];
            }

            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                label6.Text = (string)obj["Name"];
            }

            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject obj in myVideoObject.Get())
            {
                    label5.Text = (string)obj["Name"];  
            }

           
            ManagementObjectSearcher myDesktopMonitor = new ManagementObjectSearcher("select * from Win32_DesktopMonitor");

            foreach (ManagementObject obj in myDesktopMonitor.Get())
            {
                label10.Text = (string)obj["Name"];
            }


            string GetLocalIPv4(NetworkInterfaceType _type)
            {
                string output = "";
                foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                    {
                        foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                output = ip.Address.ToString();
                            }
                        }
                    }
                }
                return output;
            }
            label9.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно добавлено!");
        }
    }
}
