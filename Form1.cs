using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace ChangeMAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetMAC_Click(object sender, EventArgs e)
        {
            RegistryKey rKey;
            string mac;

            rKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0008", true);
            mac = (string)rKey.GetValue("NetworkAddress");
            rKey.Close();

            lbMAC.Text = mac;
        }

        private void btnChangeMAC_Click(object sender, EventArgs e)
        {
            RegistryKey rKey;
            string mac = txtMAC.Text;

            rKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0008", true);
            rKey.SetValue("NetworkAddress",mac);
            rKey.Close();
            lbMAC.Text = "Da luu dia chi MAC";
            Thread.Sleep(3000);


            //disconnect wifi
            string strCmdText;
            strCmdText = "/C netsh interface set interface Wi-Fi disable";

            Process p = new Process();

            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = strCmdText;

            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            p.Start();
            lbMAC.Text = "Da ngat ket noi wifi";
            Thread.Sleep(3000);


            //connect wifi
            strCmdText = "/C netsh interface set interface Wi-Fi enable";

            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = strCmdText;

            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            p.Start();
            Thread.Sleep(3000);
            lbMAC.Text = "Da ket noi wifi";
        }

    }
}
