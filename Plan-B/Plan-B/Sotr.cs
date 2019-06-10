using System;
using System.Data;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Plan_B
{
    public partial class Sotr : MaterialSkin.Controls.MaterialForm
    {

        private readonly string TemlpateFileName = @"M:\test.docx";
        string ResourseName;
        string TaskName;
        string AppointmentDate;
        string CompletionDate;

        public Sotr()
        {
            //Кастоматизация дизайна при помощи MaterialSkin.dll
            MaterialSkin.MaterialSkinManager SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            InitializeComponent();
            LoadData();
        }

        //Выгрузка в таблицу данных о сотрудниках из БД
        private void LoadData()
        {
            DbConnector dbConnector = new DbConnector();
            DataTable dtbl = new DataTable();
            dtbl = dbConnector.GetTable("SELECT Id_postavl_zadachi, Status_vipoln, Name_zadacha, Opis_zadacha, Name_resourse, Data_naznach from Postavl_zadachi INNER JOIN Zadacha on Id_zadacha = Zadacha_ID INNER JOIN Resourse on Id_resourse = Resourse_ID");
            dgv.DataSource = dtbl;
        }




        private void BtnMakeOtchet_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((saveFileDialog.OpenFile()) != null)
                {
                    
                }
            }

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                TaskName = "SEO-оптимизация";
                ResourseName = "Техническое задание";
                AppointmentDate = "20 мая 2019 года";
                CompletionDate = "27 мая 2019 года";
                var wordDocument = wordApp.Documents.Open(TemlpateFileName);
                ReplaceWordStub("{TaskName}", TaskName, wordDocument);
                ReplaceWordStub("{ResourseName}", ResourseName, wordDocument);
                ReplaceWordStub("{AppointmentDate}", AppointmentDate, wordDocument);
                ReplaceWordStub("{CompletionDate}", CompletionDate, wordDocument);

                wordDocument.SaveAs(@"M:\result.docx");
                wordDocument.Close();
                MaterialMessageBox.Show("Отчет успешно сформирован","Оповещение", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                MaterialMessageBox.Show("Произошла ошибка", "Что-то пошло не так", MessageBoxButtons.OK);
            }
            
            finally
            {
                wordApp.Quit();
            }


        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content; //Получаем содержимое всего документа
            range.Find.ClearFormatting();//Очишаем от предидущих форматирований
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ResourseName = dgv.CurrentRow.Cells[3].Value.ToString();
            //TaskName = dgv.CurrentRow.Cells[1].Value.ToString();
            //AppointmentDate = dgv.CurrentRow.Cells[4].Value.ToString();
            //CompletionDate = dgv.CurrentRow.Cells[5].Value.ToString();  
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            DbConnector dbConnector = new DbConnector();
            DataTable dtbl = new DataTable();
            //dtbl = dbConnector.GetTable("UPDATE Postavl_zadachi SET Sost_sotr = ");
            dgv.DataSource = dtbl;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
