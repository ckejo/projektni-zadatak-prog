namespace prog_projektni
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
            this.lResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.bSolve = new System.Windows.Forms.Button();
            this.lOffset = new System.Windows.Forms.Label();
            this.trbOffset = new System.Windows.Forms.TrackBar();
            this.lMin = new System.Windows.Forms.Label();
            this.lMax = new System.Windows.Forms.Label();
            this.lNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // lInput
            // 
            this.lInput.AutoSize = true;
            this.lInput.Location = new System.Drawing.Point(12, 18);
            this.lInput.Name = "lInput";
            this.lInput.Size = new System.Drawing.Size(104, 15);
            this.lInput.TabIndex = 0;
            this.lInput.Text = "Tekst za sifrovanje:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 36);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(221, 23);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "Unesite tekst";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(12, 205);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(52, 15);
            this.lResult.TabIndex = 4;
            this.lResult.Text = "Rezultat:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 223);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(221, 23);
            this.tbResult.TabIndex = 5;
            // 
            // bSolve
            // 
            this.bSolve.Location = new System.Drawing.Point(12, 137);
            this.bSolve.Name = "bSolve";
            this.bSolve.Size = new System.Drawing.Size(221, 44);
            this.bSolve.TabIndex = 6;
            this.bSolve.Text = "Šifruj poruku";
            this.bSolve.UseVisualStyleBackColor = true;
            this.bSolve.Click += new System.EventHandler(this.bSolve_Click);
            // 
            // lOffset
            // 
            this.lOffset.AutoSize = true;
            this.lOffset.Location = new System.Drawing.Point(12, 68);
            this.lOffset.Name = "lOffset";
            this.lOffset.Size = new System.Drawing.Size(84, 15);
            this.lOffset.TabIndex = 7;
            this.lOffset.Text = "Pomeraj slova:";
            // 
            // trbOffset
            // 
            this.trbOffset.Location = new System.Drawing.Point(12, 86);
            this.trbOffset.Maximum = 26;
            this.trbOffset.Minimum = 1;
            this.trbOffset.Name = "trbOffset";
            this.trbOffset.Size = new System.Drawing.Size(221, 45);
            this.trbOffset.TabIndex = 8;
            this.trbOffset.Value = 1;
            this.trbOffset.Scroll += new System.EventHandler(this.trbOffset_Scroll);
            // 
            // lMin
            // 
            this.lMin.AutoSize = true;
            this.lMin.Location = new System.Drawing.Point(12, 116);
            this.lMin.Name = "lMin";
            this.lMin.Size = new System.Drawing.Size(13, 15);
            this.lMin.TabIndex = 9;
            this.lMin.Text = "1";
            // 
            // lMax
            // 
            this.lMax.AutoSize = true;
            this.lMax.Location = new System.Drawing.Point(214, 116);
            this.lMax.Name = "lMax";
            this.lMax.Size = new System.Drawing.Size(19, 15);
            this.lMax.TabIndex = 10;
            this.lMax.Text = "26";
            // 
            // lNum
            // 
            this.lNum.AutoSize = true;
            this.lNum.Location = new System.Drawing.Point(102, 68);
            this.lNum.Name = "lNum";
            this.lNum.Size = new System.Drawing.Size(13, 15);
            this.lNum.TabIndex = 11;
            this.lNum.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 275);
            this.Controls.Add(this.lNum);
            this.Controls.Add(this.lMax);
            this.Controls.Add(this.lMin);
            this.Controls.Add(this.trbOffset);
            this.Controls.Add(this.lOffset);
            this.Controls.Add(this.bSolve);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lInput);
            this.Name = "Form1";
            this.Text = "Aplikacija za Cezarovu šifru";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lInput;
        private TextBox tbInput;
        private Label lResult;
        private TextBox tbResult;
        private Button bSolve;
        private Label lOffset;
        private TrackBar trbOffset;
        private Label lMin;
        private Label lMax;
        private Label lNum;
    }
}