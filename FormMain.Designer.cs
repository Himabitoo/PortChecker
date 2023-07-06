namespace PortChecker
{
    partial class FormMain
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.BtnChecking = new System.Windows.Forms.Button();
            this.LabelPort = new System.Windows.Forms.Label();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.LabelIpaddres = new System.Windows.Forms.Label();
            this.TextIPAddres = new System.Windows.Forms.TextBox();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(281, 53);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(43, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(197, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "PortChecker v1.0.0";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panelMain.Controls.Add(this.BtnChecking);
            this.panelMain.Controls.Add(this.LabelPort);
            this.panelMain.Controls.Add(this.TextPort);
            this.panelMain.Controls.Add(this.LabelIpaddres);
            this.panelMain.Controls.Add(this.TextIPAddres);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 53);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(281, 184);
            this.panelMain.TabIndex = 1;
            // 
            // BtnChecking
            // 
            this.BtnChecking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChecking.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnChecking.Location = new System.Drawing.Point(105, 107);
            this.BtnChecking.Name = "BtnChecking";
            this.BtnChecking.Size = new System.Drawing.Size(89, 34);
            this.BtnChecking.TabIndex = 4;
            this.BtnChecking.Text = "実行";
            this.BtnChecking.UseVisualStyleBackColor = true;
            this.BtnChecking.Click += new System.EventHandler(this.BtnChecking_Click);
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 10F, System.Drawing.FontStyle.Bold);
            this.LabelPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelPort.Location = new System.Drawing.Point(177, 31);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(48, 16);
            this.LabelPort.TabIndex = 3;
            this.LabelPort.Text = "PORT";
            // 
            // TextPort
            // 
            this.TextPort.Location = new System.Drawing.Point(194, 50);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(57, 19);
            this.TextPort.TabIndex = 2;
            // 
            // LabelIpaddres
            // 
            this.LabelIpaddres.AutoSize = true;
            this.LabelIpaddres.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 10F, System.Drawing.FontStyle.Bold);
            this.LabelIpaddres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelIpaddres.Location = new System.Drawing.Point(18, 31);
            this.LabelIpaddres.Name = "LabelIpaddres";
            this.LabelIpaddres.Size = new System.Drawing.Size(90, 16);
            this.LabelIpaddres.TabIndex = 1;
            this.LabelIpaddres.Text = "IP ADDRES";
            // 
            // TextIPAddres
            // 
            this.TextIPAddres.Location = new System.Drawing.Point(35, 50);
            this.TextIPAddres.Name = "TextIPAddres";
            this.TextIPAddres.Size = new System.Drawing.Size(133, 19);
            this.TextIPAddres.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(281, 237);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormMain";
            this.Text = "PortChecker v1.0.0";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox TextIPAddres;
        private System.Windows.Forms.Label LabelIpaddres;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.Button BtnChecking;
    }
}