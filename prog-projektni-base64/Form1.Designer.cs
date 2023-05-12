namespace prog_projektni_base64
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
            this.bSolve = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
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
            this.tbInput.Size = new System.Drawing.Size(299, 23);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "Unesite tekst";
            // 
            // bSolve
            // 
            this.bSolve.Location = new System.Drawing.Point(12, 56);
            this.bSolve.Name = "bSolve";
            this.bSolve.Size = new System.Drawing.Size(299, 47);
            this.bSolve.TabIndex = 2;
            this.bSolve.Text = "Šifruj tekst";
            this.bSolve.UseVisualStyleBackColor = true;
            this.bSolve.Click += new System.EventHandler(this.bSolve_Click);
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(12, 106);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(52, 15);
            this.lResult.TabIndex = 3;
            this.lResult.Text = "Rezultat:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 124);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(299, 23);
            this.tbResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 162);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.bSolve);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lInput);
            this.Name = "Form1";
            this.Text = "Aplikacija za Base64 enkodovanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lInput;
        private TextBox tbInput;
        private Button bSolve;
        private Label lResult;
        private TextBox tbResult;
    }
}