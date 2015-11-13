using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;

namespace UI
{
    public partial class FormWelcome : Form
    {
        private const string k_AppID = "189097148095083";
        private static readonly string[] permissions = { "user_about_me" };
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login(k_AppID, permissions);
        }
    }
}
