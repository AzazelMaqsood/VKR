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
    public partial class Auth : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6GTJNQE\SQLEXPRESS;Initial Catalog=PROFINTERES;" + "Integrated Security=true;");

        public Auth()
        {
            InitializeComponent();
            //Кастоматизация дизайна при помощи MaterialSkin.dll
            MaterialSkin.MaterialSkinManager SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }





        private void Auth_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string CPass = Bcrypt.HashPassword(txtPassword.Text, "$2a$11$fhmmGItQBp5ncDeCSnDPG/");
                string query = "SELECT * FROM Sotr WHERE Login_sotr = '" + txtLogin.Text.Trim() + "' and Password_sotr = '" + CPass.Remove(50, 10) + "'";
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            sqlcon.Close();
            Registration rg = new Registration();
            rg.Show();
            this.Hide();
        }


    }
}

