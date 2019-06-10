using System;
using System.Windows.Forms;

namespace Plan_B
{
    public partial class About : MaterialSkin.Controls.MaterialForm
    {
        public About()
        {
            //Кастоматизация дизайна при помощи MaterialSkin.dll
            MaterialSkin.MaterialSkinManager SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //Возвращение в главное меню
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
