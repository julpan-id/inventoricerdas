using InventoriCerdas.Forms.Kabel;
using System.Windows.Forms;

namespace InventoriCerdas.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CableToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            KabelForm kabelForm = new KabelForm();
            kabelForm.ShowDialog();
        }
    }
}
