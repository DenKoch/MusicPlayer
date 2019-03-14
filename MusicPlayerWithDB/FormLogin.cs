using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace MusicPlayerWithDB
{
    public partial class FormInit : Form
    {
        private bool login = false;
        private bool signup = false;
        private FormMain objFormMain;
        private AuthController auth;
        private DataSetMain ds;

        //Constructors
        public FormInit()
        {
            InitializeComponent();
            ds = new DataSetMain();
            auth = new AuthController();

        }
        public FormInit(FormMain main)
        {
            InitializeComponent();
            objFormMain = main;
            auth = new AuthController();

        }

        //Log in
        private void CheckAuthLogin()
        {
            string usr = Username.Text.Trim();
            string pass = Password.Text.Trim();
            int user_id = auth.ConfirmLogin(usr, pass);

            //error if incorrect username or password
            if (user_id == -1)
            {
                MessageBox.Show("Incorrect username or password!");
                return;
            }

            this.Hide();
            var objFormMain = new FormMain(usr, user_id, this);
            objFormMain.Show();
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            if (login == false)
            {
                Username.Visible = true;
                Password.Visible = true;
                ConfirmPassword.Visible = false;

                bt_cancel.Location = new Point(639, 500);
                bt_cancel.Visible = true;
                bt_signup.Visible = false;

                login = true;
                return;
            }
            CheckAuthLogin();
        }
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckAuthLogin();
            }
        }

        //Sign up
        private void CheckAuthSignup()
        {
            passErrorImage.Visible = false;
            passNotMatch.Visible = false;
            passInvalidFormat.Visible = false;
            usrExists.Visible = false;

            string usr = Username.Text.Trim();
            string pass = Password.Text.Trim();
            string pass_confirmed = ConfirmPassword.Text.Trim();

            //check if passwords match
            if (pass != pass_confirmed)
            {
                passErrorImage.Location = new Point(651, 483);
                passNotMatch.Visible = true;
                passErrorImage.Visible = true;
                return;
            }

            //check if password has one number and one Upper letter
            if (!Regex.IsMatch(pass, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{1,20}$"))
            {
                passErrorImage.Location = new Point(651, 483);
                passInvalidFormat.Visible = true;
                passErrorImage.Visible = true;
                return;
            }

            int user_id = auth.ConfirmSignup(usr, pass);

            //error if user already exists
            if (user_id == -1)
            {
                passErrorImage.Location = new Point(651, 367);
                passErrorImage.Visible = true;
                usrExists.Visible = true;
                return;
            }

            this.Hide();
            var objFormMain = new FormMain(usr, user_id, this);
            objFormMain.Show();
        }
        private void bt_signup_Click(object sender, EventArgs e)
        {
            if (signup == false)
            {
                Username.Visible = true;
                Password.Visible = true;
                ConfirmPassword.Visible = true;

                bt_cancel.Location = new Point(639, 558);
                bt_cancel.Visible = true;
                bt_login.Visible = false;

                signup = true;
                return;
            }
            CheckAuthSignup();
        }

        //Cancel
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Username.Visible = false;
            Username.ForeColor = Color.Gray;
            Username.Text = "username";

            Password.Visible = false;
            Password.ForeColor = Color.Gray;
            Password.Text = "password";

            ConfirmPassword.Visible = false;
            ConfirmPassword.ForeColor = Color.Gray;
            ConfirmPassword.Text = "confirm password";

            login = false;
            signup = false;

            bt_login.Visible = true;
            bt_signup.Visible = true;
            bt_cancel.Visible = false;
        }

        //TextViews enter-leave
        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.ForeColor != Color.Black)
            {
                Password.ForeColor = Color.Black;
                Password.Text = "";
                Password.PasswordChar = '*';
            }

            if (signup == true)
                passFormat.Visible = true;
        }
        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.ForeColor = Color.Gray;
                Password.Text = "password";
            }

            if (signup == true)
                passFormat.Visible = false;
        }
        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.ForeColor != Color.Black)
            {
                Username.ForeColor = Color.Black;
                Username.Text = "";
            }
        }
        private void ConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (ConfirmPassword.ForeColor != Color.Black)
            {
                ConfirmPassword.ForeColor = Color.Black;
                ConfirmPassword.Text = "";
                ConfirmPassword.PasswordChar = '*';
            }
        }
        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.ForeColor = Color.Gray;
                Username.Text = "username";
            }
        }
        private void ConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (ConfirmPassword.Text == "")
            {
                ConfirmPassword.ForeColor = Color.Gray;
                ConfirmPassword.Text = "confirm password";
            }
        }

        //on form closing
        private void FormInit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (objFormMain != null)
                objFormMain.Close();
        }
    }
}
