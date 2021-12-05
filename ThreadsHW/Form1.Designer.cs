namespace ThreadsHW
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
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.buttonStartPrime = new System.Windows.Forms.Button();
            this.buttonStartFibonacci = new System.Windows.Forms.Button();
            this.buttonStopPrime = new System.Windows.Forms.Button();
            this.buttonStopFibonacci = new System.Windows.Forms.Button();
            this.textBoxPrimeStart = new System.Windows.Forms.TextBox();
            this.textBoxPrimeFinish = new System.Windows.Forms.TextBox();
            this.buttonClearMain = new System.Windows.Forms.Button();
            this.buttonPausePrime = new System.Windows.Forms.Button();
            this.buttonContinuePrime = new System.Windows.Forms.Button();
            this.buttonPauseFibonacci = new System.Windows.Forms.Button();
            this.buttonContinueFibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMain
            // 
            this.textBoxMain.Location = new System.Drawing.Point(12, 126);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(662, 254);
            this.textBoxMain.TabIndex = 0;
            // 
            // buttonStartPrime
            // 
            this.buttonStartPrime.Location = new System.Drawing.Point(12, 64);
            this.buttonStartPrime.Name = "buttonStartPrime";
            this.buttonStartPrime.Size = new System.Drawing.Size(100, 23);
            this.buttonStartPrime.TabIndex = 1;
            this.buttonStartPrime.Text = "Start prime";
            this.buttonStartPrime.UseVisualStyleBackColor = true;
            this.buttonStartPrime.Click += new System.EventHandler(this.buttonStartPrime_Click);
            // 
            // buttonStartFibonacci
            // 
            this.buttonStartFibonacci.Location = new System.Drawing.Point(440, 11);
            this.buttonStartFibonacci.Name = "buttonStartFibonacci";
            this.buttonStartFibonacci.Size = new System.Drawing.Size(114, 20);
            this.buttonStartFibonacci.TabIndex = 2;
            this.buttonStartFibonacci.Text = "Start fibonacci";
            this.buttonStartFibonacci.UseVisualStyleBackColor = true;
            this.buttonStartFibonacci.Click += new System.EventHandler(this.buttonStartFibonacci_Click);
            // 
            // buttonStopPrime
            // 
            this.buttonStopPrime.Enabled = false;
            this.buttonStopPrime.Location = new System.Drawing.Point(12, 93);
            this.buttonStopPrime.Name = "buttonStopPrime";
            this.buttonStopPrime.Size = new System.Drawing.Size(100, 23);
            this.buttonStopPrime.TabIndex = 3;
            this.buttonStopPrime.Text = "Stop prime";
            this.buttonStopPrime.UseVisualStyleBackColor = true;
            this.buttonStopPrime.Click += new System.EventHandler(this.buttonStopPrime_Click);
            // 
            // buttonStopFibonacci
            // 
            this.buttonStopFibonacci.Location = new System.Drawing.Point(440, 37);
            this.buttonStopFibonacci.Name = "buttonStopFibonacci";
            this.buttonStopFibonacci.Size = new System.Drawing.Size(114, 20);
            this.buttonStopFibonacci.TabIndex = 4;
            this.buttonStopFibonacci.Text = "Stop fibonacci";
            this.buttonStopFibonacci.UseVisualStyleBackColor = true;
            this.buttonStopFibonacci.Click += new System.EventHandler(this.buttonStopFibonacci_Click);
            // 
            // textBoxPrimeStart
            // 
            this.textBoxPrimeStart.Location = new System.Drawing.Point(12, 12);
            this.textBoxPrimeStart.Name = "textBoxPrimeStart";
            this.textBoxPrimeStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrimeStart.TabIndex = 5;
            // 
            // textBoxPrimeFinish
            // 
            this.textBoxPrimeFinish.Location = new System.Drawing.Point(12, 38);
            this.textBoxPrimeFinish.Name = "textBoxPrimeFinish";
            this.textBoxPrimeFinish.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrimeFinish.TabIndex = 6;
            // 
            // buttonClearMain
            // 
            this.buttonClearMain.Location = new System.Drawing.Point(560, 97);
            this.buttonClearMain.Name = "buttonClearMain";
            this.buttonClearMain.Size = new System.Drawing.Size(114, 23);
            this.buttonClearMain.TabIndex = 7;
            this.buttonClearMain.Text = "Clear main textbox";
            this.buttonClearMain.UseVisualStyleBackColor = true;
            this.buttonClearMain.Click += new System.EventHandler(this.buttonClearMain_Click);
            // 
            // buttonPausePrime
            // 
            this.buttonPausePrime.Enabled = false;
            this.buttonPausePrime.Location = new System.Drawing.Point(118, 64);
            this.buttonPausePrime.Name = "buttonPausePrime";
            this.buttonPausePrime.Size = new System.Drawing.Size(101, 23);
            this.buttonPausePrime.TabIndex = 8;
            this.buttonPausePrime.Text = "Pause prime";
            this.buttonPausePrime.UseVisualStyleBackColor = true;
            this.buttonPausePrime.Click += new System.EventHandler(this.buttonPausePrime_Click);
            // 
            // buttonContinuePrime
            // 
            this.buttonContinuePrime.Enabled = false;
            this.buttonContinuePrime.Location = new System.Drawing.Point(118, 93);
            this.buttonContinuePrime.Name = "buttonContinuePrime";
            this.buttonContinuePrime.Size = new System.Drawing.Size(101, 23);
            this.buttonContinuePrime.TabIndex = 9;
            this.buttonContinuePrime.Text = "Continue prime";
            this.buttonContinuePrime.UseVisualStyleBackColor = true;
            this.buttonContinuePrime.Click += new System.EventHandler(this.buttonContinuePrime_Click);
            // 
            // buttonPauseFibonacci
            // 
            this.buttonPauseFibonacci.Location = new System.Drawing.Point(560, 12);
            this.buttonPauseFibonacci.Name = "buttonPauseFibonacci";
            this.buttonPauseFibonacci.Size = new System.Drawing.Size(114, 20);
            this.buttonPauseFibonacci.TabIndex = 10;
            this.buttonPauseFibonacci.Text = "Pause fibonacci";
            this.buttonPauseFibonacci.UseVisualStyleBackColor = true;
            this.buttonPauseFibonacci.Click += new System.EventHandler(this.buttonPauseFibonacci_Click);
            // 
            // buttonContinueFibonacci
            // 
            this.buttonContinueFibonacci.Location = new System.Drawing.Point(560, 38);
            this.buttonContinueFibonacci.Name = "buttonContinueFibonacci";
            this.buttonContinueFibonacci.Size = new System.Drawing.Size(114, 20);
            this.buttonContinueFibonacci.TabIndex = 11;
            this.buttonContinueFibonacci.Text = "Continue fibonacci";
            this.buttonContinueFibonacci.UseVisualStyleBackColor = true;
            this.buttonContinueFibonacci.Click += new System.EventHandler(this.buttonContinueFibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.buttonContinueFibonacci);
            this.Controls.Add(this.buttonPauseFibonacci);
            this.Controls.Add(this.buttonContinuePrime);
            this.Controls.Add(this.buttonPausePrime);
            this.Controls.Add(this.buttonClearMain);
            this.Controls.Add(this.textBoxPrimeFinish);
            this.Controls.Add(this.textBoxPrimeStart);
            this.Controls.Add(this.buttonStopFibonacci);
            this.Controls.Add(this.buttonStopPrime);
            this.Controls.Add(this.buttonStartFibonacci);
            this.Controls.Add(this.buttonStartPrime);
            this.Controls.Add(this.textBoxMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Button buttonStartPrime;
        private System.Windows.Forms.Button buttonStartFibonacci;
        private System.Windows.Forms.Button buttonStopPrime;
        private System.Windows.Forms.Button buttonStopFibonacci;
        private System.Windows.Forms.TextBox textBoxPrimeStart;
        private System.Windows.Forms.TextBox textBoxPrimeFinish;
        private System.Windows.Forms.Button buttonClearMain;
        private System.Windows.Forms.Button buttonPausePrime;
        private System.Windows.Forms.Button buttonContinuePrime;
        private System.Windows.Forms.Button buttonPauseFibonacci;
        private System.Windows.Forms.Button buttonContinueFibonacci;
    }
}
