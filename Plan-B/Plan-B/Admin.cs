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
            dtbl = dbConnector.GetTable("SELECT Id_sotr, I_sotr, F_sotr, O_sotr, Staj_sotr, Name_dolzhn, Sost_sotr from Sotr, Dolzhn, Postavl_zadachi where Id_sotr = Id_dolzhn ");
            dgv.DataSource = dtbl;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Selected = false;
                for (int j = 0; j < dgv.ColumnCount; j++)
                    if (dgv.Rows[i].Cells[j].Value != null)
                        if (dgv.Rows[i].Cells[j].Value.ToString().Contains(txtSearch.Text))
                        {
                            dgv.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    
    }
}
