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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lInput);
            this.Name = "Form1";
            this.Text = "Emulator Enigma mašine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lInput;
        private TextBox tbInput;
    }
}