namespace YT2MP4
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.tResults = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatToggle1 = new FlatUI.FlatToggle();
            this.bConvert = new FlatUI.FlatButton();
            this.progressBar = new FlatUI.FlatProgressBar();
            this.tURL = new FlatUI.FlatTextBox();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.tResults);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.flatToggle1);
            this.formSkin1.Controls.Add(this.bConvert);
            this.formSkin1.Controls.Add(this.progressBar);
            this.formSkin1.Controls.Add(this.tURL);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.Red;
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(630, 389);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "YT2MP4";
            this.formSkin1.Click += new System.EventHandler(this.formSkin1_Click);
            // 
            // tResults
            // 
            this.tResults.BackColor = System.Drawing.Color.Transparent;
            this.tResults.FocusOnHover = false;
            this.tResults.Hint = "";
            this.tResults.Location = new System.Drawing.Point(12, 112);
            this.tResults.MaxLength = 32767;
            this.tResults.Multiline = true;
            this.tResults.Name = "tResults";
            this.tResults.ReadOnly = true;
            this.tResults.Size = new System.Drawing.Size(606, 129);
            this.tResults.TabIndex = 7;
            this.tResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tResults.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tResults.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(205, 249);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(139, 28);
            this.flatLabel1.TabIndex = 6;
            this.flatLabel1.Text = "Higher Quality";
            // 
            // flatToggle1
            // 
            this.flatToggle1.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle1.Checked = false;
            this.flatToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatToggle1.Location = new System.Drawing.Point(354, 247);
            this.flatToggle1.Name = "flatToggle1";
            this.flatToggle1.Options = FlatUI.FlatToggle._Options.Style3;
            this.flatToggle1.Size = new System.Drawing.Size(76, 33);
            this.flatToggle1.TabIndex = 5;
            this.flatToggle1.Text = "toggleHD";
            // 
            // bConvert
            // 
            this.bConvert.BackColor = System.Drawing.Color.Transparent;
            this.bConvert.BaseColor = System.Drawing.Color.Red;
            this.bConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConvert.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bConvert.Location = new System.Drawing.Point(262, 332);
            this.bConvert.Name = "bConvert";
            this.bConvert.Rounded = false;
            this.bConvert.Size = new System.Drawing.Size(106, 32);
            this.bConvert.TabIndex = 4;
            this.bConvert.Text = "Convert";
            this.bConvert.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bConvert.UseCustomColor = false;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.progressBar.DarkerProgress = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(12, 267);
            this.progressBar.Maximum = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.Pattern = true;
            this.progressBar.PercentSign = false;
            this.progressBar.ProgressColor = System.Drawing.Color.Red;
            this.progressBar.ShowBalloon = false;
            this.progressBar.Size = new System.Drawing.Size(606, 42);
            this.progressBar.TabIndex = 3;
            this.progressBar.Value = 0;
            // 
            // tURL
            // 
            this.tURL.BackColor = System.Drawing.Color.Transparent;
            this.tURL.FocusOnHover = false;
            this.tURL.Hint = "";
            this.tURL.Location = new System.Drawing.Point(12, 72);
            this.tURL.MaxLength = 32767;
            this.tURL.Multiline = false;
            this.tURL.Name = "tURL";
            this.tURL.ReadOnly = false;
            this.tURL.Size = new System.Drawing.Size(606, 34);
            this.tURL.TabIndex = 2;
            this.tURL.Text = "Input Youtube Video URL";
            this.tURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tURL.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tURL.UseSystemPasswordChar = false;
            this.tURL.Enter += new System.EventHandler(this.tURL_Enter);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(567, 13);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 1;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(600, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 389);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatTextBox tURL;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatButton bConvert;
        private FlatUI.FlatProgressBar progressBar;
        private FlatUI.FlatToggle flatToggle1;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatTextBox tResults;
    }
}

