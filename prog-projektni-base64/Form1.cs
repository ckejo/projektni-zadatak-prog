using System.Text;

namespace prog_projektni_base64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSolve_Click(object sender, EventArgs e)
        {
            string inputText = tbInput.Text;
            byte[] itBytes = Encoding.UTF8.GetBytes(inputText);
            tbResult.Text = Convert.ToBase64String(itBytes);
        }
    }
}