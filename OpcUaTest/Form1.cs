using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpcUaTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpcUaHelper.FormBrowseServer fbs = new OpcUaHelper.FormBrowseServer())
            {
                fbs.ShowDialog();
            }
        }




        private OpcUaHelper.OpcUaClient opcUaClient;

        private void Form1_Load(object sender, EventArgs e)
        {
            opcUaClient = new OpcUaHelper.OpcUaClient();
            opcUaClient.ConnectServer("http://117.48.203.204:62547/DataAccessServer");

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            float[] data = await opcUaClient.ReadNodeAsync<float[]>("ns=2;s=Robots/RobotA/UserFloat");
            ;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            opcUaClient.Disconnect();
        }
    }
}
