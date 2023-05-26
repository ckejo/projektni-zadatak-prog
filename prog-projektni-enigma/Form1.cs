namespace prog_projektni_enigma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<RadioButton> listOfRadioButtons = new List<RadioButton>();
        List<Tuple<char, char>> plugboardPairs = new List<Tuple<char, char>>();
        char fInput = ' ', sInput = ' ';
        Color[] listOfColors = new Color[13] { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Brown, Color.DarkBlue, Color.Cyan, Color.Purple, Color.PowderBlue, Color.Pink, Color.Navy, Color.Maroon};
        int lastUsedColor = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            listOfRadioButtons.Add(rbA);
            listOfRadioButtons.Add(rbB);
            listOfRadioButtons.Add(rbC);
            listOfRadioButtons.Add(rbD);
            listOfRadioButtons.Add(rbE);
            listOfRadioButtons.Add(rbF);
            listOfRadioButtons.Add(rbG);
            listOfRadioButtons.Add(rbH);
            listOfRadioButtons.Add(rbI);
            listOfRadioButtons.Add(rbJ);
            listOfRadioButtons.Add(rbK);
            listOfRadioButtons.Add(rbL);
            listOfRadioButtons.Add(rbM);
            listOfRadioButtons.Add(rbN);
            listOfRadioButtons.Add(rbO);
            listOfRadioButtons.Add(rbP);
            listOfRadioButtons.Add(rbQ);
            listOfRadioButtons.Add(rbR);
            listOfRadioButtons.Add(rbS);
            listOfRadioButtons.Add(rbT);
            listOfRadioButtons.Add(rbU);
            listOfRadioButtons.Add(rbV);
            listOfRadioButtons.Add(rbW);
            listOfRadioButtons.Add(rbX);
            listOfRadioButtons.Add(rbY);
            listOfRadioButtons.Add(rbZ);
        }

        //error-checking
        private void cbRotorI_TextUpdate(object sender, EventArgs e)
        {
            if (cbRotorI.Text != "I" && cbRotorI.Text != "II" && cbRotorI.Text != "III" && cbRotorI.Text != "IV" && cbRotorI.Text != "V")
            {
                MessageBox.Show("Nepravilan indeks rotora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbRotorI.SelectedIndex = 0;
            }
        }

        private void cbRotorII_TextUpdate(object sender, EventArgs e)
        {
            if (cbRotorII.Text != "I" && cbRotorII.Text != "II" && cbRotorII.Text != "III" && cbRotorII.Text != "IV" && cbRotorII.Text != "V")
            {
                MessageBox.Show("Nepravilan indeks rotora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbRotorII.SelectedIndex = 0;
            }
        }

        private void cbRotorIII_TextUpdate(object sender, EventArgs e)
        {
            if (cbRotorIII.Text != "I" && cbRotorIII.Text != "II" && cbRotorIII.Text != "III" && cbRotorIII.Text != "IV" && cbRotorIII.Text != "V")
            {
                MessageBox.Show("Nepravilan indeks rotora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbRotorIII.SelectedIndex = 0;
            }
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'A'; }
            else sInput = 'A';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'B'; }
            else sInput = 'B';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'C'; }
            else sInput = 'C';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'D'; }
            else sInput = 'D';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbE_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'E'; }
            else sInput = 'E';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbF_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'F'; }
            else sInput = 'F';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbG_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'G'; }
            else sInput = 'G';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbH_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'H'; }
            else sInput = 'H';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbI_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'I'; }
            else sInput = 'I';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbJ_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'J'; }
            else sInput = 'J';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbK_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'K'; }
            else sInput = 'K';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbL_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'L'; }
            else sInput = 'L';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbM_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'M'; }
            else sInput = 'M';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbN_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'N'; }
            else sInput = 'N';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbO_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'O'; }
            else sInput = 'O';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbP_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'P'; }
            else sInput = 'P';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbQ_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'Q'; }
            else sInput = 'Q';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbR_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'R'; }
            else sInput = 'R';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        
                    }
                }
            }
            ++lastUsedColor;
        }

        private void rbS_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'S'; }
            else sInput = 'S';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbT_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'T'; }
            else sInput = 'T';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbU_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'U'; }
            else sInput = 'U';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbV_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'V'; }
            else sInput = 'V';
            if(fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbW_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'W'; }
            else sInput = 'W';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbX_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'X'; }
            else sInput = 'X';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbY_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'Y'; }
            else sInput = 'Y';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }

        private void rbZ_CheckedChanged(object sender, EventArgs e)
        {
            if (fInput == ' ') { fInput = 'Z'; }
            else sInput = 'Z';
            if (fInput != ' ' && sInput != ' ')
            {
                foreach (RadioButton rb in listOfRadioButtons)
                {
                    if (rb.Checked && (!plugboardPairs.Any(c => c.Item1 == rb.Text.ToCharArray()[0]) || !plugboardPairs.Any(c => c.Item2 == rb.Text.ToCharArray()[0])))
                    {
                        plugboardPairs.Add(new Tuple<char, char>(fInput, sInput));
                        foreach (RadioButton rbt in listOfRadioButtons)
                        {
                            if (rbt.Text == plugboardPairs[lastUsedColor].Item1.ToString() || rbt.Text == plugboardPairs[lastUsedColor].Item2.ToString())
                            {
                                rbt.ForeColor = listOfColors[lastUsedColor];
                            }                        
                        }
                        fInput = ' ';
                        sInput = ' ';
                        ++lastUsedColor;
                    }
                }
            }
        }
    }
}