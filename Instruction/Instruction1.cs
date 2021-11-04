using System.Windows.Forms;

namespace Course_project
{
    public partial class instruction1 : Form
    {
        public instruction1()
        {
            InitializeComponent();
        }
        private void instruction1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                Close();                
        }
    }
}