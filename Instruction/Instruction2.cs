using System.Windows.Forms;

namespace Course_project
{
    public partial class instruction2 : Form
    {
        public instruction2()
        {
            InitializeComponent();
        }
        private void instruction2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                Close();
        }
    }
}