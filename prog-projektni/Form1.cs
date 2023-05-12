using System.Text;

namespace prog_projektni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSolve_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text;
            int offset = trbOffset.Value;
            StringBuilder nString = new StringBuilder();

            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] == ' ')
                {
                    nString.Append(" ");
                }
                else if ((int)input[i] >= 65 && (int)input[i] <= 90)
                {
                    if ((int)input[i] + offset > 90)
                    {
                        nString.Append((char)((int)input[i] - 25 + offset));
                    }
                    else 
                    {
                        nString.Append((char)((int)input[i] + offset));
                    }
                }
                else if ((int)input[i] >= 97 && (int)input[i] <= 122)
                {
                    if ((int)input[i] + offset > 122)
                    {
                        nString.Append((char)((int)input[i] - 25 + offset));
                    }
                    else
                    {
                        nString.Append((char)((int)input[i] + offset));
                    }
                }              
            }

            tbResult.Text = nString.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trbOffset_Scroll(object sender, EventArgs e)
        {
            lNum.Text = trbOffset.Value.ToString();
        }
    }
}