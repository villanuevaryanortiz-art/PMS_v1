using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Crypto.Generators;
using PMS_v1.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace PMS_v1.Forms
{

    public partial class Login : Form
    {
        private bool _passwordVisible = false;
        public Login()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            btnShowHidePass.Image = Resources.Resources.LoginEye;

            btnShowHidePass.Click += btnShowHidePass_Click;

            btnLogin.StateNormal.Content.ShortText.Color1 = Color.White;
            btnLogin.StateTracking.Content.ShortText.Color1 = Color.FromArgb(116, 219, 219);   // hover
            btnLogin.StatePressed.Content.ShortText.Color1 = Color.White;     // clicked
        }

        private void btnShowHidePass_Click(object sender, EventArgs e)
        {
            _passwordVisible = !_passwordVisible;
            txtPassword.UseSystemPasswordChar = !_passwordVisible;
            btnShowHidePass.Image = _passwordVisible
                ? Resources.Resources.EyeClose : Resources.Resources.LoginEye;
        }

        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            const string sql = @"SELECT u.USER_ID, u.PERSONNEL_ID, u.PASSWORD, u.ROLE, u.ACCOUNT_STATUS,
                                 p.FIRST_NAME, p.LAST_NAME, p.POSITION, p.EMPLOYEE_NO
                                 FROM `SYSTEM_USER` u
                                 JOIN PERSONNEL p ON p.PERSONNEL_ID = u.PERSONNEL_ID
                                 WHERE u.USERNAME = @user";

            try
            {
                using (var conn = Db.GetConnection())
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read() || !BCrypt.Net.BCrypt.Verify(password, reader.GetString("PASSWORD")))
                        {
                            MessageBox.Show("INVALID USERNAME OR PASSWORD.");
                            return;
                        }
                        //Session.Role = reader.GetString("ROLE");

                        string fullName = reader.GetString("FIRST_NAME") + " " + reader.GetString("LAST_NAME");
                        string position = reader.IsDBNull(reader.GetOrdinal("POSITION"))
                                                   ? "" : reader.GetString("POSITION");
                        string employeeNo = reader.GetString("EMPLOYEE_NO");

                        MessageBox.Show($"Welcome, {fullName}.\nPosition: {position}.\nNo. : {employeeNo}", "Login Successful");

                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
