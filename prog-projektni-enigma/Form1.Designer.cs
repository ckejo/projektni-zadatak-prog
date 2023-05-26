namespace prog_projektni_enigma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lInput = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbRotors = new System.Windows.Forms.Label();
            this.dRotorI = new System.Windows.Forms.DomainUpDown();
            this.dRotorIII = new System.Windows.Forms.DomainUpDown();
            this.dRotorII = new System.Windows.Forms.DomainUpDown();
            this.cbRotorI = new System.Windows.Forms.ComboBox();
            this.cbRotorII = new System.Windows.Forms.ComboBox();
            this.cbRotorIII = new System.Windows.Forms.ComboBox();
            this.gbPlugboard = new System.Windows.Forms.GroupBox();
            this.rbZ = new System.Windows.Forms.RadioButton();
            this.rbY = new System.Windows.Forms.RadioButton();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.rbW = new System.Windows.Forms.RadioButton();
            this.rbV = new System.Windows.Forms.RadioButton();
            this.rbU = new System.Windows.Forms.RadioButton();
            this.rbT = new System.Windows.Forms.RadioButton();
            this.rbS = new System.Windows.Forms.RadioButton();
            this.rbR = new System.Windows.Forms.RadioButton();
            this.rbQ = new System.Windows.Forms.RadioButton();
            this.rbP = new System.Windows.Forms.RadioButton();
            this.rbO = new System.Windows.Forms.RadioButton();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbL = new System.Windows.Forms.RadioButton();
            this.rbK = new System.Windows.Forms.RadioButton();
            this.rbJ = new System.Windows.Forms.RadioButton();
            this.rbI = new System.Windows.Forms.RadioButton();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.rbG = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbE = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.bSolve = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.gbPlugboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lInput
            // 
            this.lInput.AutoSize = true;
            this.lInput.Location = new System.Drawing.Point(12, 9);
            this.lInput.Name = "lInput";
            this.lInput.Size = new System.Drawing.Size(104, 15);
            this.lInput.TabIndex = 0;
            this.lInput.Text = "Tekst za šifrovanje:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 27);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(442, 23);
            this.tbInput.TabIndex = 1;
            // 
            // lbRotors
            // 
            this.lbRotors.AutoSize = true;
            this.lbRotors.Location = new System.Drawing.Point(12, 61);
            this.lbRotors.Name = "lbRotors";
            this.lbRotors.Size = new System.Drawing.Size(42, 15);
            this.lbRotors.TabIndex = 2;
            this.lbRotors.Text = "Rotori:";
            // 
            // dRotorI
            // 
            this.dRotorI.Items.Add("A");
            this.dRotorI.Items.Add("B");
            this.dRotorI.Items.Add("C");
            this.dRotorI.Items.Add("D");
            this.dRotorI.Items.Add("E");
            this.dRotorI.Items.Add("F");
            this.dRotorI.Items.Add("G");
            this.dRotorI.Items.Add("H");
            this.dRotorI.Items.Add("I");
            this.dRotorI.Items.Add("J");
            this.dRotorI.Items.Add("K");
            this.dRotorI.Items.Add("L");
            this.dRotorI.Items.Add("M");
            this.dRotorI.Items.Add("N");
            this.dRotorI.Items.Add("O");
            this.dRotorI.Items.Add("P");
            this.dRotorI.Items.Add("Q");
            this.dRotorI.Items.Add("R");
            this.dRotorI.Items.Add("S");
            this.dRotorI.Items.Add("T");
            this.dRotorI.Items.Add("U");
            this.dRotorI.Items.Add("V");
            this.dRotorI.Items.Add("W");
            this.dRotorI.Items.Add("X");
            this.dRotorI.Items.Add("Y");
            this.dRotorI.Items.Add("Z");
            this.dRotorI.Location = new System.Drawing.Point(12, 80);
            this.dRotorI.Name = "dRotorI";
            this.dRotorI.Size = new System.Drawing.Size(42, 23);
            this.dRotorI.TabIndex = 3;
            this.dRotorI.Text = "A";
            // 
            // dRotorIII
            // 
            this.dRotorIII.Items.Add("A");
            this.dRotorIII.Items.Add("B");
            this.dRotorIII.Items.Add("C");
            this.dRotorIII.Items.Add("D");
            this.dRotorIII.Items.Add("E");
            this.dRotorIII.Items.Add("F");
            this.dRotorIII.Items.Add("G");
            this.dRotorIII.Items.Add("H");
            this.dRotorIII.Items.Add("I");
            this.dRotorIII.Items.Add("J");
            this.dRotorIII.Items.Add("K");
            this.dRotorIII.Items.Add("L");
            this.dRotorIII.Items.Add("M");
            this.dRotorIII.Items.Add("N");
            this.dRotorIII.Items.Add("O");
            this.dRotorIII.Items.Add("P");
            this.dRotorIII.Items.Add("Q");
            this.dRotorIII.Items.Add("R");
            this.dRotorIII.Items.Add("S");
            this.dRotorIII.Items.Add("T");
            this.dRotorIII.Items.Add("U");
            this.dRotorIII.Items.Add("V");
            this.dRotorIII.Items.Add("W");
            this.dRotorIII.Items.Add("X");
            this.dRotorIII.Items.Add("Y");
            this.dRotorIII.Items.Add("Z");
            this.dRotorIII.Location = new System.Drawing.Point(349, 80);
            this.dRotorIII.Name = "dRotorIII";
            this.dRotorIII.Size = new System.Drawing.Size(42, 23);
            this.dRotorIII.TabIndex = 4;
            this.dRotorIII.Text = "A";
            // 
            // dRotorII
            // 
            this.dRotorII.Items.Add("A");
            this.dRotorII.Items.Add("B");
            this.dRotorII.Items.Add("C");
            this.dRotorII.Items.Add("D");
            this.dRotorII.Items.Add("E");
            this.dRotorII.Items.Add("F");
            this.dRotorII.Items.Add("G");
            this.dRotorII.Items.Add("H");
            this.dRotorII.Items.Add("I");
            this.dRotorII.Items.Add("J");
            this.dRotorII.Items.Add("K");
            this.dRotorII.Items.Add("L");
            this.dRotorII.Items.Add("M");
            this.dRotorII.Items.Add("N");
            this.dRotorII.Items.Add("O");
            this.dRotorII.Items.Add("P");
            this.dRotorII.Items.Add("Q");
            this.dRotorII.Items.Add("R");
            this.dRotorII.Items.Add("S");
            this.dRotorII.Items.Add("T");
            this.dRotorII.Items.Add("U");
            this.dRotorII.Items.Add("V");
            this.dRotorII.Items.Add("W");
            this.dRotorII.Items.Add("X");
            this.dRotorII.Items.Add("Y");
            this.dRotorII.Items.Add("Z");
            this.dRotorII.Location = new System.Drawing.Point(180, 80);
            this.dRotorII.Name = "dRotorII";
            this.dRotorII.Size = new System.Drawing.Size(42, 23);
            this.dRotorII.TabIndex = 5;
            this.dRotorII.Text = "A";
            // 
            // cbRotorI
            // 
            this.cbRotorI.FormattingEnabled = true;
            this.cbRotorI.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.cbRotorI.Location = new System.Drawing.Point(60, 80);
            this.cbRotorI.Name = "cbRotorI";
            this.cbRotorI.Size = new System.Drawing.Size(56, 23);
            this.cbRotorI.TabIndex = 6;
            this.cbRotorI.Text = "I";
            this.cbRotorI.TextUpdate += new System.EventHandler(this.cbRotorI_TextUpdate);
            // 
            // cbRotorII
            // 
            this.cbRotorII.FormattingEnabled = true;
            this.cbRotorII.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.cbRotorII.Location = new System.Drawing.Point(228, 80);
            this.cbRotorII.Name = "cbRotorII";
            this.cbRotorII.Size = new System.Drawing.Size(56, 23);
            this.cbRotorII.TabIndex = 7;
            this.cbRotorII.Text = "I";
            this.cbRotorII.TextUpdate += new System.EventHandler(this.cbRotorII_TextUpdate);
            // 
            // cbRotorIII
            // 
            this.cbRotorIII.FormattingEnabled = true;
            this.cbRotorIII.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.cbRotorIII.Location = new System.Drawing.Point(398, 80);
            this.cbRotorIII.Name = "cbRotorIII";
            this.cbRotorIII.Size = new System.Drawing.Size(56, 23);
            this.cbRotorIII.TabIndex = 8;
            this.cbRotorIII.Text = "I";
            this.cbRotorIII.TextUpdate += new System.EventHandler(this.cbRotorIII_TextUpdate);
            // 
            // gbPlugboard
            // 
            this.gbPlugboard.Controls.Add(this.rbZ);
            this.gbPlugboard.Controls.Add(this.rbY);
            this.gbPlugboard.Controls.Add(this.rbX);
            this.gbPlugboard.Controls.Add(this.rbW);
            this.gbPlugboard.Controls.Add(this.rbV);
            this.gbPlugboard.Controls.Add(this.rbU);
            this.gbPlugboard.Controls.Add(this.rbT);
            this.gbPlugboard.Controls.Add(this.rbS);
            this.gbPlugboard.Controls.Add(this.rbR);
            this.gbPlugboard.Controls.Add(this.rbQ);
            this.gbPlugboard.Controls.Add(this.rbP);
            this.gbPlugboard.Controls.Add(this.rbO);
            this.gbPlugboard.Controls.Add(this.rbN);
            this.gbPlugboard.Controls.Add(this.rbM);
            this.gbPlugboard.Controls.Add(this.rbL);
            this.gbPlugboard.Controls.Add(this.rbK);
            this.gbPlugboard.Controls.Add(this.rbJ);
            this.gbPlugboard.Controls.Add(this.rbI);
            this.gbPlugboard.Controls.Add(this.rbH);
            this.gbPlugboard.Controls.Add(this.rbG);
            this.gbPlugboard.Controls.Add(this.rbF);
            this.gbPlugboard.Controls.Add(this.rbE);
            this.gbPlugboard.Controls.Add(this.rbD);
            this.gbPlugboard.Controls.Add(this.rbC);
            this.gbPlugboard.Controls.Add(this.rbB);
            this.gbPlugboard.Controls.Add(this.rbA);
            this.gbPlugboard.Location = new System.Drawing.Point(12, 124);
            this.gbPlugboard.Name = "gbPlugboard";
            this.gbPlugboard.Size = new System.Drawing.Size(442, 100);
            this.gbPlugboard.TabIndex = 9;
            this.gbPlugboard.TabStop = false;
            this.gbPlugboard.Text = "Plugboard";
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(121, 72);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(32, 19);
            this.rbZ.TabIndex = 25;
            this.rbZ.TabStop = true;
            this.rbZ.Text = "Z";
            this.rbZ.UseVisualStyleBackColor = true;
            this.rbZ.CheckedChanged += new System.EventHandler(this.rbZ_CheckedChanged);
            // 
            // rbY
            // 
            this.rbY.AutoSize = true;
            this.rbY.Location = new System.Drawing.Point(82, 72);
            this.rbY.Name = "rbY";
            this.rbY.Size = new System.Drawing.Size(32, 19);
            this.rbY.TabIndex = 24;
            this.rbY.TabStop = true;
            this.rbY.Text = "Y";
            this.rbY.UseVisualStyleBackColor = true;
            this.rbY.CheckedChanged += new System.EventHandler(this.rbY_CheckedChanged);
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Location = new System.Drawing.Point(47, 72);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(32, 19);
            this.rbX.TabIndex = 23;
            this.rbX.TabStop = true;
            this.rbX.Text = "X";
            this.rbX.UseVisualStyleBackColor = true;
            this.rbX.CheckedChanged += new System.EventHandler(this.rbX_CheckedChanged);
            // 
            // rbW
            // 
            this.rbW.AutoSize = true;
            this.rbW.Location = new System.Drawing.Point(9, 72);
            this.rbW.Name = "rbW";
            this.rbW.Size = new System.Drawing.Size(36, 19);
            this.rbW.TabIndex = 22;
            this.rbW.TabStop = true;
            this.rbW.Text = "W";
            this.rbW.UseVisualStyleBackColor = true;
            this.rbW.CheckedChanged += new System.EventHandler(this.rbW_CheckedChanged);
            // 
            // rbV
            // 
            this.rbV.AutoSize = true;
            this.rbV.Location = new System.Drawing.Point(381, 47);
            this.rbV.Name = "rbV";
            this.rbV.Size = new System.Drawing.Size(32, 19);
            this.rbV.TabIndex = 21;
            this.rbV.TabStop = true;
            this.rbV.Text = "V";
            this.rbV.UseVisualStyleBackColor = true;
            this.rbV.CheckedChanged += new System.EventHandler(this.rbV_CheckedChanged);
            // 
            // rbU
            // 
            this.rbU.AutoSize = true;
            this.rbU.Location = new System.Drawing.Point(346, 47);
            this.rbU.Name = "rbU";
            this.rbU.Size = new System.Drawing.Size(33, 19);
            this.rbU.TabIndex = 20;
            this.rbU.TabStop = true;
            this.rbU.Text = "U";
            this.rbU.UseVisualStyleBackColor = true;
            this.rbU.CheckedChanged += new System.EventHandler(this.rbU_CheckedChanged);
            // 
            // rbT
            // 
            this.rbT.AutoSize = true;
            this.rbT.Location = new System.Drawing.Point(312, 47);
            this.rbT.Name = "rbT";
            this.rbT.Size = new System.Drawing.Size(31, 19);
            this.rbT.TabIndex = 19;
            this.rbT.TabStop = true;
            this.rbT.Text = "T";
            this.rbT.UseVisualStyleBackColor = true;
            this.rbT.CheckedChanged += new System.EventHandler(this.rbT_CheckedChanged);
            // 
            // rbS
            // 
            this.rbS.AutoSize = true;
            this.rbS.Location = new System.Drawing.Point(272, 47);
            this.rbS.Name = "rbS";
            this.rbS.Size = new System.Drawing.Size(31, 19);
            this.rbS.TabIndex = 18;
            this.rbS.TabStop = true;
            this.rbS.Text = "S";
            this.rbS.UseVisualStyleBackColor = true;
            this.rbS.CheckedChanged += new System.EventHandler(this.rbS_CheckedChanged);
            // 
            // rbR
            // 
            this.rbR.AutoSize = true;
            this.rbR.Location = new System.Drawing.Point(234, 47);
            this.rbR.Name = "rbR";
            this.rbR.Size = new System.Drawing.Size(32, 19);
            this.rbR.TabIndex = 17;
            this.rbR.TabStop = true;
            this.rbR.Text = "R";
            this.rbR.UseVisualStyleBackColor = true;
            this.rbR.CheckedChanged += new System.EventHandler(this.rbR_CheckedChanged);
            // 
            // rbQ
            // 
            this.rbQ.AutoSize = true;
            this.rbQ.Location = new System.Drawing.Point(197, 47);
            this.rbQ.Name = "rbQ";
            this.rbQ.Size = new System.Drawing.Size(34, 19);
            this.rbQ.TabIndex = 16;
            this.rbQ.TabStop = true;
            this.rbQ.Text = "Q";
            this.rbQ.UseVisualStyleBackColor = true;
            this.rbQ.CheckedChanged += new System.EventHandler(this.rbQ_CheckedChanged);
            // 
            // rbP
            // 
            this.rbP.AutoSize = true;
            this.rbP.Location = new System.Drawing.Point(160, 47);
            this.rbP.Name = "rbP";
            this.rbP.Size = new System.Drawing.Size(32, 19);
            this.rbP.TabIndex = 15;
            this.rbP.TabStop = true;
            this.rbP.Text = "P";
            this.rbP.UseVisualStyleBackColor = true;
            this.rbP.CheckedChanged += new System.EventHandler(this.rbP_CheckedChanged);
            // 
            // rbO
            // 
            this.rbO.AutoSize = true;
            this.rbO.Location = new System.Drawing.Point(121, 47);
            this.rbO.Name = "rbO";
            this.rbO.Size = new System.Drawing.Size(34, 19);
            this.rbO.TabIndex = 14;
            this.rbO.TabStop = true;
            this.rbO.Text = "O";
            this.rbO.UseVisualStyleBackColor = true;
            this.rbO.CheckedChanged += new System.EventHandler(this.rbO_CheckedChanged);
            // 
            // rbN
            // 
            this.rbN.AutoSize = true;
            this.rbN.Location = new System.Drawing.Point(82, 47);
            this.rbN.Name = "rbN";
            this.rbN.Size = new System.Drawing.Size(34, 19);
            this.rbN.TabIndex = 13;
            this.rbN.TabStop = true;
            this.rbN.Text = "N";
            this.rbN.UseVisualStyleBackColor = true;
            this.rbN.CheckedChanged += new System.EventHandler(this.rbN_CheckedChanged);
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(47, 47);
            this.rbM.Name = "rbM";
            this.rbM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbM.Size = new System.Drawing.Size(36, 19);
            this.rbM.TabIndex = 12;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            this.rbM.CheckedChanged += new System.EventHandler(this.rbM_CheckedChanged);
            // 
            // rbL
            // 
            this.rbL.AutoSize = true;
            this.rbL.Location = new System.Drawing.Point(9, 47);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(31, 19);
            this.rbL.TabIndex = 11;
            this.rbL.TabStop = true;
            this.rbL.Text = "L";
            this.rbL.UseVisualStyleBackColor = true;
            this.rbL.CheckedChanged += new System.EventHandler(this.rbL_CheckedChanged);
            // 
            // rbK
            // 
            this.rbK.AutoSize = true;
            this.rbK.Location = new System.Drawing.Point(381, 22);
            this.rbK.Name = "rbK";
            this.rbK.Size = new System.Drawing.Size(32, 19);
            this.rbK.TabIndex = 10;
            this.rbK.TabStop = true;
            this.rbK.Text = "K";
            this.rbK.UseVisualStyleBackColor = true;
            this.rbK.CheckedChanged += new System.EventHandler(this.rbK_CheckedChanged);
            // 
            // rbJ
            // 
            this.rbJ.AutoSize = true;
            this.rbJ.Location = new System.Drawing.Point(346, 22);
            this.rbJ.Name = "rbJ";
            this.rbJ.Size = new System.Drawing.Size(29, 19);
            this.rbJ.TabIndex = 9;
            this.rbJ.TabStop = true;
            this.rbJ.Text = "J";
            this.rbJ.UseVisualStyleBackColor = true;
            this.rbJ.CheckedChanged += new System.EventHandler(this.rbJ_CheckedChanged);
            // 
            // rbI
            // 
            this.rbI.AutoSize = true;
            this.rbI.Location = new System.Drawing.Point(312, 22);
            this.rbI.Name = "rbI";
            this.rbI.Size = new System.Drawing.Size(28, 19);
            this.rbI.TabIndex = 8;
            this.rbI.TabStop = true;
            this.rbI.Text = "I";
            this.rbI.UseVisualStyleBackColor = true;
            this.rbI.CheckedChanged += new System.EventHandler(this.rbI_CheckedChanged);
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.Location = new System.Drawing.Point(272, 22);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(34, 19);
            this.rbH.TabIndex = 7;
            this.rbH.TabStop = true;
            this.rbH.Text = "H";
            this.rbH.UseVisualStyleBackColor = true;
            this.rbH.CheckedChanged += new System.EventHandler(this.rbH_CheckedChanged);
            // 
            // rbG
            // 
            this.rbG.AutoSize = true;
            this.rbG.Location = new System.Drawing.Point(234, 22);
            this.rbG.Name = "rbG";
            this.rbG.Size = new System.Drawing.Size(33, 19);
            this.rbG.TabIndex = 6;
            this.rbG.TabStop = true;
            this.rbG.Text = "G";
            this.rbG.UseVisualStyleBackColor = true;
            this.rbG.CheckedChanged += new System.EventHandler(this.rbG_CheckedChanged);
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(197, 22);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(31, 19);
            this.rbF.TabIndex = 5;
            this.rbF.TabStop = true;
            this.rbF.Text = "F";
            this.rbF.UseVisualStyleBackColor = true;
            this.rbF.CheckedChanged += new System.EventHandler(this.rbF_CheckedChanged);
            // 
            // rbE
            // 
            this.rbE.AutoSize = true;
            this.rbE.Location = new System.Drawing.Point(160, 22);
            this.rbE.Name = "rbE";
            this.rbE.Size = new System.Drawing.Size(31, 19);
            this.rbE.TabIndex = 4;
            this.rbE.TabStop = true;
            this.rbE.Text = "E";
            this.rbE.UseVisualStyleBackColor = true;
            this.rbE.CheckedChanged += new System.EventHandler(this.rbE_CheckedChanged);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(121, 22);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(33, 19);
            this.rbD.TabIndex = 3;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(82, 22);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(33, 19);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(47, 22);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(32, 19);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.rbB_CheckedChanged);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(9, 22);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(33, 19);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.rbA_CheckedChanged);
            // 
            // bSolve
            // 
            this.bSolve.Location = new System.Drawing.Point(12, 230);
            this.bSolve.Name = "bSolve";
            this.bSolve.Size = new System.Drawing.Size(442, 49);
            this.bSolve.TabIndex = 10;
            this.bSolve.Text = "Šifruj";
            this.bSolve.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 293);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(81, 15);
            this.lbResult.TabIndex = 11;
            this.lbResult.Text = "Šifrovan tekst:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 311);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(442, 23);
            this.tbResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 349);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.bSolve);
            this.Controls.Add(this.gbPlugboard);
            this.Controls.Add(this.cbRotorIII);
            this.Controls.Add(this.cbRotorII);
            this.Controls.Add(this.cbRotorI);
            this.Controls.Add(this.dRotorII);
            this.Controls.Add(this.dRotorIII);
            this.Controls.Add(this.dRotorI);
            this.Controls.Add(this.lbRotors);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lInput);
            this.Name = "Form1";
            this.Text = "Emulator Enigma mašine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPlugboard.ResumeLayout(false);
            this.gbPlugboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lInput;
        private TextBox tbInput;
        private Label lbRotors;
        private DomainUpDown dRotorI;
        private DomainUpDown dRotorIII;
        private DomainUpDown dRotorII;
        private ComboBox cbRotorI;
        private ComboBox cbRotorII;
        private ComboBox cbRotorIII;
        private GroupBox gbPlugboard;
        private RadioButton rbS;
        private RadioButton rbR;
        private RadioButton rbQ;
        private RadioButton rbP;
        private RadioButton rbO;
        private RadioButton rbN;
        private RadioButton rbM;
        private RadioButton rbL;
        private RadioButton rbK;
        private RadioButton rbJ;
        private RadioButton rbI;
        private RadioButton rbH;
        private RadioButton rbG;
        private RadioButton rbF;
        private RadioButton rbE;
        private RadioButton rbD;
        private RadioButton rbC;
        private RadioButton rbB;
        private RadioButton rbA;
        private RadioButton rbZ;
        private RadioButton rbY;
        private RadioButton rbX;
        private RadioButton rbW;
        private RadioButton rbV;
        private RadioButton rbU;
        private RadioButton rbT;
        private Button bSolve;
        private Label lbResult;
        private TextBox tbResult;
    }
}