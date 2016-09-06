using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MicroServiceApplication.Bean;

namespace MicroServiceApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.login(userNoTextBox.Text,passwordTextBox.Text);
        }

        private void login(String userNo,String password){
            if (userNo == null || userNo == "")
            {
                MessageBox.Show("请输入用户编号");
                return;
            }

          
            AuthClass authClass = new AuthClass();
            if (authClass.checkIn(userNo, password))
            {
                //登录成功
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //MessageBox.Show("用户名或密码错误。");
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
