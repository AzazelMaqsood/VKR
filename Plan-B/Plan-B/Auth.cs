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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6GTJNQE\SQLEXPRESS;Initial Catalog=PROFINTERES;" + "Integrated Security=true;");
            sqlcon.Open();
            string query = "SELECT * FROM Sotr WHERE Login_sotr = '" + txtLogin.Text.Trim() + "' and Password_sotr = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
 
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Перепроверьте введеный вами логин и пароль");
            }
        }


        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
            this.Hide();
        }
    }
}
