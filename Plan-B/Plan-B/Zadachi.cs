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
    public partial class Zadachi : MaterialSkin.Controls.MaterialForm
    {
        public Zadachi()
        {
            //Кастоматизация дизайна при помощи MaterialSkin.dll
            MaterialSkin.MaterialSkinManager SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DbConnector dbConnector = new DbConnector();
            DataTable dtbl = new DataTable();
            dtbl = dbConnector.GetTable("SELECT Id_sotr, I_sotr, F_sotr, O_sotr, Staj_sotr, Name_dolzhn from Sotr INNER JOIN Dolzhn on Id_sotr  = Sotr_ID FULL OUTER JOIN Postavl_zadachi on Id_sotr = Postavl_zadachi.Sotr_ID");
            //dtbl = dbConnector.GetTable("SELECT Id_sotr, I_sotr, F_sotr, O_sotr, Staj_sotr, Name_dolzhn, Sost_sotrud from Sotr, Dolzhn, Postavl_zadachi");
            DGV1.DataSource = dtbl;
            DataTable dtbl2 = new DataTable();
            //dtbl2 = dbConnector.GetTable("SELECT Id_postavl_zadachi, Name_zadacha, Opis_zadacha, Name_resourse, Data_naznach, Data_vipoln, Status_vipoln from Zadacha, Dolzhn, Postavl_zadachi, Resourse where Id_zadacha = Id_postavl_zadachi ");
            dtbl2 = dbConnector.GetTable("SELECT Id_postavl_zadachi, Name_zadacha, Opis_zadacha, Name_resourse, Data_naznach, Data_vipoln, Status_vipoln from Postavl_zadachi INNER JOIN Zadacha on Id_zadacha = Zadacha_ID INNER JOIN Resourse on Id_resourse = Resourse_ID");
            DGV2.DataSource = dtbl2;
            


            //dtbl = dbConnector.GetTable("SELECT Id_sotr, I_sotr, F_sotr, O_sotr, Staj_sotr, Name_dolzhn from Sotr INNER JOIN Dolzhn on Id_sotr  = Sotr_ID INNER JOIN Postavl_zadachi on Id_sotr != Postavl_zadachi.Sotr_ID");
            //dgv.DataSource = dtbl;

        }



        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }



        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string CurSotr = DGV1.CurrentRow.Cells[0].Value.ToString();
            TxtNameSotr.Text = DGV1.CurrentRow.Cells[1].Value.ToString();
            TxtIdSotr.Text = CurSotr;
            DbConnector dbConnector = new DbConnector();
            DataTable dtbl = new DataTable();
            dtbl = dbConnector.GetTable("SELECT Id_postavl_zadachi, Name_zadacha, Opis_zadacha, Name_resourse, Data_naznach, Data_vipoln, Status_vipoln from Zadacha, Resourse INNER JOIN Postavl_zadachi on "+ CurSotr + " = Postavl_zadachi.Sotr_ID INNER JOIN Dolzhn on Dolzhn.Sotr_ID = "+ CurSotr + "");
            DGV2.DataSource = dtbl;
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNameResourse.Text == "" || TxtNameSotr.Text == "" || TxtOpisZadacha.Text == "" || TxtIdSotr.Text == "" || TxtNameZadacha.Text == "")
                {
                    MaterialMessageBox.Show("Пожалуйста заполните информацию о задачах и ресурсах", "Упс...Что-то пропустили", MessageBoxButtons.OK);
                }
                else
                {
                    string CurDate = DateTime.Now.ToLongDateString();//Заносим в переменную текущую дату и время
                    string connectionString = @"Data Source=DESKTOP-6GTJNQE\SQLEXPRESS;Initial Catalog=Profinteres_db;" + "Integrated Security=true;";
                    SqlConnection sqlcon = new SqlConnection(connectionString);
                    sqlcon.Open();
                    SqlCommand sqlCmd1 = new SqlCommand("SELECT MAX(Id_zadacha) FROM dbo.Zadacha", sqlcon); //Определяем максимальное значение Id
                    int result = ((int)sqlCmd1.ExecuteScalar()); //Результат запроса заносим в переменную
                    int FK = result++; //Формируем значение для внешнего ключа

                    SqlCommand sqlCmd = new SqlCommand("ZadachiAdd", sqlcon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("Id_postavl_zadachi", 0);
                    sqlCmd.Parameters.AddWithValue("Id_zadacha", 0);
                    sqlCmd.Parameters.AddWithValue("Id_resourse", 0);
                    sqlCmd.Parameters.AddWithValue("Resourse_ID", FK);
                    sqlCmd.Parameters.AddWithValue("Zadacha_ID", FK);
                    sqlCmd.Parameters.AddWithValue("Sotr_ID", TxtIdSotr.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("Sost_sotr", "Занят");
                    sqlCmd.Parameters.AddWithValue("Data_naznach", CurDate);
                    sqlCmd.Parameters.AddWithValue("Data_vipoln", "");
                    sqlCmd.Parameters.AddWithValue("Status_vipoln", "Задача назначена");
                    sqlCmd.Parameters.AddWithValue("Name_zadacha", TxtNameZadacha.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("Opis_zadacha", TxtOpisZadacha.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("Name_resourse", TxtNameResourse.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MaterialMessageBox.Show("Задача и ресурс назначены", "Поздравляем", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("Не удалось назначить задачу и ресурс", "Ошибка", MessageBoxButtons.OK);
            }
    }

        private void BtnFreeSotr_Click(object sender, EventArgs e)
        {
            DbConnector dbConnector = new DbConnector();
            //string noll = "";
            //DataTable dtbl1 = new DataTable();
            //dtbl1 = dbConnector.GetTable("/*SELECT Id_sotr, I_sotr, F_sotr, O_sotr, Staj_sotr, Name_dolzhn from Sotr INNER JOIN Dolzhn on Id_sotr  = Sotr_ID inner JOIN Postavl_zadachi on Id_postavl_zadachi = "+noll+"*/");
            //DGV1.DataSource = dtbl1;
        }

        private void BtnAllSotr_Click(object sender, EventArgs e)
        {
            DbConnector dbConnector = new DbConnector();
            DataTable dtbl = new DataTable();
            dtbl = dbConnector.GetTable("SELECT Id_sotr, I_sotr, F_sotr, O_sotr, Staj_sotr, Name_dolzhn from Sotr INNER JOIN Dolzhn on Id_sotr  = Sotr_ID FULL OUTER JOIN Postavl_zadachi on Id_sotr = Postavl_zadachi.Sotr_ID");
            DGV1.DataSource = dtbl;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }


    }
}
