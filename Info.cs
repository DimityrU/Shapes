using System.Windows.Forms;

namespace Course_project
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        private void Info_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                Close();
        }
    }
}