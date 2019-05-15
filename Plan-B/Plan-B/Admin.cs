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

namespace Plan_B
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = @"Data Source=DESKTOP-6GTJNQE\SQLEXPRESS;Initial Catalog=PROFINTERES;" + "Integrated Security=true;";
            SqlConnection sqlcon = new SqlConnection(connectionString);

            sqlcon.Open();

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT Id_sotr, I_sotr, F_sotr, O_sotr, Staj_sotr, Name_dolzhn, Sost_sotr from Sotr, Dolzhn, Postavl_zadachi where Id_sotr = Id_dolzhn ", sqlcon);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            dgv.DataSource = dtbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void btnOtchet_Click(object sender, EventArgs e)
        {

        }
    }
}
