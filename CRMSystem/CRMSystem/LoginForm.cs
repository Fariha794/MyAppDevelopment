using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            gatePanel.Visible = true;
            userLoginPanel.Visible = false;
            changeLoginInfoPanel.Visible = false;
            changeLoginInfoUserPanel.Visible = false;
            adminLoginPanel.Visible = false;
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AHLLogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userIdLabel_Click(object sender, EventArgs e)
        {

        }
        private static bool adminStatus = false;
        public static bool AdminStatus
        {
            get { return adminStatus; }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (adminTextBox.Text != "" && adminPasswordTextBox.Text != "")
            {
                //code
                //if all verification complete
                adminStatus = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Fill All the Field");
            }
        }

        private void adminGateButton_Click(object sender, EventArgs e)
        {
            gatePanel.Visible = false;
            userLoginPanel.Visible = false;
            changeLoginInfoPanel.Visible = false;
            changeLoginInfoUserPanel.Visible = false;
            adminLoginPanel.Visible = true;
        }

        private void changePasswordAdminButton_Click(object sender, EventArgs e)
        {
            gatePanel.Visible = false;
            changeLoginInfoUserPanel.Visible = false;
            userLoginPanel.Visible = false;
            changeLoginInfoPanel.Visible = true;
            adminLoginPanel.Visible = false;
        }

        private void goBackAdminButton_Click(object sender, EventArgs e)
        {
            gatePanel.Visible = true;
            changeLoginInfoUserPanel.Visible = false;
            userLoginPanel.Visible = false;
            changeLoginInfoPanel.Visible = false;
            adminLoginPanel.Visible = false;
        }

        private void userGateButton_Click(object sender, EventArgs e)
        {
            gatePanel.Visible = false;
            userLoginPanel.Visible=true;
            changeLoginInfoPanel.Visible = false;
            changeLoginInfoUserPanel.Visible = false;
            adminLoginPanel.Visible = false;
        }

        private static bool userLoginStatus = false;
        public static bool UserLoginStatus
        {
            get { return userLoginStatus; }
        }
        private void loginUserButton_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text != "" && userPassTextBox.Text != "")
            {
                //code

                //if all verification complete
                userLoginStatus = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Fill All the Field");
            }
        }

        private void chagnePassUserButton_Click(object sender, EventArgs e)
        {
            gatePanel.Visible = false;
            userLoginPanel.Visible = false;
            changeLoginInfoPanel.Visible = false;
            changeLoginInfoUserPanel.Visible = true;
            adminLoginPanel.Visible = false;
        }

        private void goBackUserButton_Click(object sender, EventArgs e)
        {
            gatePanel.Visible = true;
            userLoginPanel.Visible = false;
            changeLoginInfoPanel.Visible = false;
            changeLoginInfoUserPanel.Visible = false;
            adminLoginPanel.Visible = false;
        }

        private void goBackChangePassUserButton_Click(object sender, EventArgs e)
        {
            gatePanel.Visible = false;
            userLoginPanel.Visible = true;
            changeLoginInfoPanel.Visible = false;
            changeLoginInfoUserPanel.Visible = false;
            adminLoginPanel.Visible = false;
        }

        private void goBackChangePassButton_Click(object sender, EventArgs e)
        {
            gatePanel.Visible = false;
            userLoginPanel.Visible = false;
            changeLoginInfoPanel.Visible = false;
            changeLoginInfoUserPanel.Visible = false;
            adminLoginPanel.Visible = true;
        }
    }
}
