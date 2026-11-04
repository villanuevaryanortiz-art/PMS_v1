using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Crypto.Generators;
using PMS_v1.Database;
using PMS_v1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using System.Xml.Linq;

namespace PMS_v1.Forms
{
    public partial class SignUp : Form
    {
        private const int minPassLen = 6;
        private const int maxAttempts = 5;
        private static int failedAttempts = 0;

        public SignUp()
        {
            InitializeComponent();

            PasswordToggle.Attach(txtPassword, btnShowHidePass1);
            PasswordToggle.Attach(txtRePassword, btnShowHidePass2);

            btnSignUp.StateNormal.Content.ShortText.Color1 = Color.White;
            btnSignUp.StateTracking.Content.ShortText.Color1 = Color.FromArgb(116, 219, 219);   // hover
            btnSignUp.StatePressed.Content.ShortText.Color1 = Color.White;     // clicked
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(failedAttempts >= maxAttempts)
            { MessageBox.Show("Maximum sign-up attempts exceeded. Please try again later."); return; }

            string empNo = txtEmployeeNumber.Text.Trim();
            string lName = txtLastName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(empNo) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            { MessageBox.Show("Please fill in all fields."); return; }

            if (!Regex.IsMatch(empNo, @"^\d{4}-\d{5}$"))
            { MessageBox.Show("Employee No. looks like 2026-12345."); return; }

            if (!Regex.IsMatch(username, @"^[A-Za-z0-9_]{4,20}$"))
            { MessageBox.Show("Username must be 4-20 letters, numbers, or underscores."); return; }

            if (password.Length < minPassLen)
            { MessageBox.Show($"Password must be at least {minPassLen} characters."); return; }

            if (password != txtRePassword.Text)
            { MessageBox.Show("Passwords do not match."); return; }

            const string sqlFind = @"SELECT p.PERSONNEL_ID, p.EMPLOYMENT_STATUS, u.USER_ID
                FROM personnel p
                LEFT JOIN `system_user` u ON u.PERSONNEL_ID = p.PERSONNEL_ID
                WHERE p.EMPLOYEE_NO = @no AND p.LAST_NAME = @ln";

            const string sqlInsert = @"INSERT INTO `system_user`
                (PERSONNEL_ID, USERNAME, PASSWORD, ROLE)
                VALUES (@pid, @user, @pass, 'Staff')";

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    int personnelId;

                    // checking if employee is in db
                    using (var cmd = new MySqlCommand(sqlFind, conn))
                    {
                        cmd.Parameters.AddWithValue("@no", empNo);
                        cmd.Parameters.AddWithValue("@ln", lName);

                        using (var r = cmd.ExecuteReader())
                        {
                            if (!r.Read())
                            {
                                failedAttempts++;
                                MessageBox.Show("Employee No. and last name do not match our records.\n" +
                                                "Contact your administrator.");
                                return;
                            }
                            if (r.GetString("EMPLOYMENT_STATUS") != "Active")
                            {
                                MessageBox.Show("This employee record is not active.");
                                return;
                            }
                            if (!r.IsDBNull(r.GetOrdinal("USER_ID")))
                            {
                                MessageBox.Show("This employee already has an account. Please log in.");
                                return;
                            }
                            personnelId = r.GetInt32("PERSONNEL_ID");
                        }
                    }

                    // create the account
                    using (var cmd = new MySqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", personnelId);
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", BCrypt.Net.BCrypt.HashPassword(password));
                        cmd.ExecuteNonQuery();
                    }
                }

                failedAttempts = 0;
                MessageBox.Show("Account created.\nYou can now log in.");
                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062 && ex.Message.Contains("uq_system_user_username"))
            {
                MessageBox.Show("That username is already taken.");
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("This employee already has an account.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
