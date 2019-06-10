

namespace Plan_B
{
    public partial class frmOK : MaterialSkin.Controls.MaterialForm
    {

        public frmOK()
        {
            InitializeComponent();     
            
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }
    }
}
