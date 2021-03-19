
namespace PersonLogIn
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTheme = new System.Windows.Forms.Button();
            this.lstBoxDetails = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimerHour = new System.Windows.Forms.Label();
            this.lblTimerSeconds = new System.Windows.Forms.Label();
            this.lblTimerMinutes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(184, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "label2";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(352, 378);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 44);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome home..";
            // 
            // btnTheme
            // 
            this.btnTheme.Location = new System.Drawing.Point(231, 378);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(97, 44);
            this.btnTheme.TabIndex = 7;
            this.btnTheme.Text = "Theme";
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // lstBoxDetails
            // 
            this.lstBoxDetails.FormattingEnabled = true;
            this.lstBoxDetails.ItemHeight = 16;
            this.lstBoxDetails.Location = new System.Drawing.Point(244, 91);
            this.lstBoxDetails.Name = "lstBoxDetails";
            this.lstBoxDetails.Size = new System.Drawing.Size(221, 228);
            this.lstBoxDetails.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTimerHour
            // 
            this.lblTimerHour.AutoSize = true;
            this.lblTimerHour.Location = new System.Drawing.Point(64, 487);
            this.lblTimerHour.Name = "lblTimerHour";
            this.lblTimerHour.Size = new System.Drawing.Size(32, 17);
            this.lblTimerHour.TabIndex = 11;
            this.lblTimerHour.Text = "00 :";
            // 
            // lblTimerSeconds
            // 
            this.lblTimerSeconds.AutoSize = true;
            this.lblTimerSeconds.Location = new System.Drawing.Point(121, 487);
            this.lblTimerSeconds.Name = "lblTimerSeconds";
            this.lblTimerSeconds.Size = new System.Drawing.Size(24, 17);
            this.lblTimerSeconds.TabIndex = 12;
            this.lblTimerSeconds.Text = "00";
            // 
            // lblTimerMinutes
            // 
            this.lblTimerMinutes.AutoSize = true;
            this.lblTimerMinutes.Location = new System.Drawing.Point(93, 487);
            this.lblTimerMinutes.Name = "lblTimerMinutes";
            this.lblTimerMinutes.Size = new System.Drawing.Size(32, 17);
            this.lblTimerMinutes.TabIndex = 13;
            this.lblTimerMinutes.Text = "00 :";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.lblTimerMinutes);
            this.Controls.Add(this.lblTimerSeconds);
            this.Controls.Add(this.lblTimerHour);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.lstBoxDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.ListBox lstBoxDetails;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimerHour;
        private System.Windows.Forms.Label lblTimerSeconds;
        private System.Windows.Forms.Label lblTimerMinutes;
    }
}