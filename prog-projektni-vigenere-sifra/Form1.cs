using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace prog_projektni_vigenere_sifra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GenerateKey()
        {
            string input = tbInput.Text;
            string keyword = tbKeyword.Text;
            int x = input.Length;
            string nKey = keyword;

            for (int i = 0; ; ++i)
            {
                if (x == i) i = 0;
                if (nKey.Length == input.Length) break;
                nKey += keyword[i];
            }

            return nKey;
        }

        private void bSolve_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text;
            string keyword = GenerateKey();
            StringBuilder nString = new StringBuilder();

            for (int i = 0; i < input.Length; ++i)
            {
                int x = (input[i] + keyword[i]) % 26;
                x += 'A';
                nString.Append((char)x);
            }

            tbResult.Text = nString.ToString();
        }
    }
}