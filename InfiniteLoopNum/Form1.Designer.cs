namespace InfiniteLoopNum
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbNumSqaured = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNumSquared = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Location = new System.Drawing.Point(118, 81);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(174, 23);
            this.btnStartProcess.TabIndex = 0;
            this.btnStartProcess.Text = "StartProcess";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(138, 146);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 22);
            this.tbNum.TabIndex = 1;
            // 
            // tbNumSqaured
            // 
            this.tbNumSqaured.Location = new System.Drawing.Point(138, 199);
            this.tbNumSqaured.Name = "tbNumSqaured";
            this.tbNumSqaured.Size = new System.Drawing.Size(100, 22);
            this.tbNumSqaured.TabIndex = 2;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(74, 146);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(58, 17);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Number";
            // 
            // lblNumSquared
            // 
            this.lblNumSquared.AutoSize = true;
            this.lblNumSquared.Location = new System.Drawing.Point(16, 199);
            this.lblNumSquared.Name = "lblNumSquared";
            this.lblNumSquared.Size = new System.Drawing.Size(116, 17);
            this.lblNumSquared.TabIndex = 4;
            this.lblNumSquared.Text = "Number Squared";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(488, 342);
            this.Controls.Add(this.lblNumSquared);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.tbNumSqaured);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.btnStartProcess);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnStartProcess;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbNumSqaured;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNumSquared;
    }
}

