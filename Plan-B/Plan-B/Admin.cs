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
    public partial class Admin : MaterialSkin.Controls.MaterialForm
    {

        string IdCurSotr;
        

        public Admin()
        {
            InitializeComponent();
            //Кастоматизация дизайна при помощи MaterialSkin.dll
            MaterialSkin.MaterialSkinManager SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            LoadData();
        }

        //Выгрузка в таблицу данных о сотрудниках из БД
        private void LoadData()
        {
            DbConnector dbConnector = new DbConnector();
            DataTable dtbl = new DataTable();
            dtbl = dbConnector.GetTable("SELECT Id_sotr, I_sotr, F_sotr, O_sotr, Staj_sotr, Name_dolzhn, Sost_sotr from Sotr full outer join Dolzhn on Sotr_ID = Id_sotr where Id_sotr != 1");
            dgv.DataSource = dtbl;
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            //Возврат в главное меню
            Main main = new Main();
            main.Show();
            this.Hide();
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Проверка пустоты 
            if (txtSearch.Text == "")
            {
                MaterialMessageBox.Show("Укажите параметр для поиска", "Упс... Кажется что-то забыли", MessageBoxButtons.OK);
            }
            else
            {
                //Используем флаг для выхода из вложенного массива
                var flag = true;
                //Выбор строк содержащих параметр поиска
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    dgv.Rows[i].Selected = false;
                    for (int j = 0; flag && j < dgv.ColumnCount; j++)
                        if (dgv.Rows[i].Cells[j].Value != null)
                        {
                            if (dgv.Rows[i].Cells[j].Value.ToString().Contains(txtSearch.Text))
                            {
                                dgv.Rows[i].Selected = true;
                                break;
                            }
                            else
                            {
                                MaterialMessageBox.Show("Ничего не найдено", "Уведомление", MessageBoxButtons.OK);
                                flag = false;
                                break;
                            }
                        }
                }
            }

        }

        private void BtnNaznachDolzhn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string IdCurSotr = dgv.CurrentRow.Cells[1].Value.ToString();
            txtSearch.Text = IdCurSotr;

        }
    }
}
