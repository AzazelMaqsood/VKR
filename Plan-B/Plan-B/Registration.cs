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
using BCrypt.Net;
using Bcrypt = BCrypt.Net.BCrypt;

namespace Plan_B
{
    public partial class Registration : Form
    {

        string connectionString = @"Data Source=DESKTOP-6GTJNQE\SQLEXPRESS;Initial Catalog=PROFINTERES;" + "Integrated Security=true;";

        public Registration()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPass.Text == "" || txtName.Text == "" || txtF.Text == "" || txtMail.Text == "" || txtStaj.Text == "" || txtPass2.Text == "")
                MessageBox.Show("Пожалуйста саполните все поля");
            else if (txtPass.Text != txtPass2.Text)
                MessageBox.Show("Пароль не совпадают");
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlCmd = new SqlCommand("SotrAdd", sqlcon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("Id_sotr", 0);
                    sqlCmd.Parameters.AddWithValue("I_sotr", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("F_sotr", txtF.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("O_sotr", txtO.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("Mail_sotr", txtMail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("Staj_sotr", txtStaj.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("Login_sotr", txtLogin.Text.Trim());
                    string CPass = Bcrypt.HashPassword(txtPass.Text, "$2a$11$fhmmGItQBp5ncDeCSnDPG/");
                    sqlCmd.Parameters.AddWithValue("Password_sotr", CPass);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Регистрация прошла успешно");
                    Clear();
                    Auth auth = new Auth();
                    this.Hide();
                    auth.Show();
                }
            }
        }

        void Clear()
        {
            txtName.Text = txtF.Text = txtO.Text = txtMail.Text = txtStaj.Text = txtLogin.Text = txtPass.Text = txtPass2.Text = "";
        }

    }
}
