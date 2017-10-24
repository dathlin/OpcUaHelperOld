using Opc.Ua.Client.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpcUaHelper
{
    /// <summary>
    /// 允许用户输入用户名和密码的窗口
    /// </summary>
    public partial class FormInputNamePassword : Form
    {
        /// <summary>
        /// 实例化一个窗口对象
        /// </summary>
        public FormInputNamePassword()
        {
            InitializeComponent();
            Icon = ClientUtils.GetAppIcon();
        }

        private void FormInputNamePassword_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }


        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassword { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            UserName = textBox1.Text;
            UserPassword = textBox2.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
