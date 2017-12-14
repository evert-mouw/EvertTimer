namespace EvertTimer
{
    partial class timertoolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timertoolForm));
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.label_hours = new System.Windows.Forms.Label();
            this.label_minutes = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_author = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.lbl_freeware = new System.Windows.Forms.Label();
            this.lbl_seconds = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chk_beep = new System.Windows.Forms.CheckBox();
            this.chk_repeat = new System.Windows.Forms.CheckBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btn_5min = new System.Windows.Forms.Button();
            this.btn_15min = new System.Windows.Forms.Button();
            this.btn_30min = new System.Windows.Forms.Button();
            this.btn_1hour = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.progressbarSimple1 = new EvertTimer.progressbarSimple();
            this.SuspendLayout();
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.Color.White;
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(12, 85);
            this.txtHours.MaxLength = 2;
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(39, 35);
            this.txtHours.TabIndex = 0;
            this.txtHours.Text = "00";
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.White;
            this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutes.Location = new System.Drawing.Point(57, 85);
            this.txtMinutes.MaxLength = 2;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(39, 35);
            this.txtMinutes.TabIndex = 1;
            this.txtMinutes.Text = "01";
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinutes.TextChanged += new System.EventHandler(this.txtMinutes_TextChanged);
            // 
            // label_hours
            // 
            this.label_hours.AutoSize = true;
            this.label_hours.Location = new System.Drawing.Point(9, 69);
            this.label_hours.Name = "label_hours";
            this.label_hours.Size = new System.Drawing.Size(33, 13);
            this.label_hours.TabIndex = 2;
            this.label_hours.Text = "hours";
            // 
            // label_minutes
            // 
            this.label_minutes.AutoSize = true;
            this.label_minutes.Location = new System.Drawing.Point(54, 69);
            this.label_minutes.Name = "label_minutes";
            this.label_minutes.Size = new System.Drawing.Size(28, 13);
            this.label_minutes.TabIndex = 3;
            this.label_minutes.Text = "mins";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.LightGreen;
            this.btn_start.Location = new System.Drawing.Point(102, 95);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(53, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(161, 100);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(94, 13);
            this.lbl_author.TabIndex = 5;
            this.lbl_author.Text = "Evert Mouw, 2011";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel.Location = new System.Drawing.Point(162, 113);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(97, 13);
            this.linkLabel.TabIndex = 6;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "www.evertmouw.nl";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // lbl_freeware
            // 
            this.lbl_freeware.AutoSize = true;
            this.lbl_freeware.Location = new System.Drawing.Point(162, 87);
            this.lbl_freeware.Name = "lbl_freeware";
            this.lbl_freeware.Size = new System.Drawing.Size(93, 13);
            this.lbl_freeware.TabIndex = 7;
            this.lbl_freeware.Text = "freeware timer tool";
            // 
            // lbl_seconds
            // 
            this.lbl_seconds.AutoSize = true;
            this.lbl_seconds.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_seconds.Location = new System.Drawing.Point(102, 79);
            this.lbl_seconds.Name = "lbl_seconds";
            this.lbl_seconds.Size = new System.Drawing.Size(19, 13);
            this.lbl_seconds.TabIndex = 8;
            this.lbl_seconds.Text = "00";
            // 
            // chk_beep
            // 
            this.chk_beep.AutoSize = true;
            this.chk_beep.Checked = true;
            this.chk_beep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_beep.Location = new System.Drawing.Point(141, 12);
            this.chk_beep.Name = "chk_beep";
            this.chk_beep.Size = new System.Drawing.Size(106, 17);
            this.chk_beep.TabIndex = 9;
            this.chk_beep.Text = "3 beeps on finish";
            this.chk_beep.UseVisualStyleBackColor = true;
            this.chk_beep.CheckedChanged += new System.EventHandler(this.chk_beep_CheckedChanged);
            // 
            // chk_repeat
            // 
            this.chk_repeat.AutoSize = true;
            this.chk_repeat.Location = new System.Drawing.Point(141, 36);
            this.chk_repeat.Name = "chk_repeat";
            this.chk_repeat.Size = new System.Drawing.Size(109, 17);
            this.chk_repeat.TabIndex = 10;
            this.chk_repeat.Text = "repeated beeping";
            this.chk_repeat.UseVisualStyleBackColor = true;
            // 
            // btn_5min
            // 
            this.btn_5min.Location = new System.Drawing.Point(12, 12);
            this.btn_5min.Name = "btn_5min";
            this.btn_5min.Size = new System.Drawing.Size(50, 23);
            this.btn_5min.TabIndex = 12;
            this.btn_5min.Text = "5 min";
            this.btn_5min.UseVisualStyleBackColor = true;
            this.btn_5min.Click += new System.EventHandler(this.btn_5min_Click);
            // 
            // btn_15min
            // 
            this.btn_15min.Location = new System.Drawing.Point(12, 41);
            this.btn_15min.Name = "btn_15min";
            this.btn_15min.Size = new System.Drawing.Size(50, 23);
            this.btn_15min.TabIndex = 13;
            this.btn_15min.Text = "15 min";
            this.btn_15min.UseVisualStyleBackColor = true;
            this.btn_15min.Click += new System.EventHandler(this.btn_15min_Click);
            // 
            // btn_30min
            // 
            this.btn_30min.Location = new System.Drawing.Point(71, 12);
            this.btn_30min.Name = "btn_30min";
            this.btn_30min.Size = new System.Drawing.Size(50, 23);
            this.btn_30min.TabIndex = 14;
            this.btn_30min.Text = "30 min";
            this.btn_30min.UseVisualStyleBackColor = true;
            this.btn_30min.Click += new System.EventHandler(this.btn_30min_Click);
            // 
            // btn_1hour
            // 
            this.btn_1hour.Location = new System.Drawing.Point(71, 41);
            this.btn_1hour.Name = "btn_1hour";
            this.btn_1hour.Size = new System.Drawing.Size(50, 23);
            this.btn_1hour.TabIndex = 15;
            this.btn_1hour.Text = "1 hour";
            this.btn_1hour.UseVisualStyleBackColor = true;
            this.btn_1hour.Click += new System.EventHandler(this.btn_1hour_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "EvertTimer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_Restore);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_Restore);
            // 
            // progressbarSimple1
            // 
            this.progressbarSimple1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressbarSimple1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressbarSimple1.Location = new System.Drawing.Point(141, 59);
            this.progressbarSimple1.Maximum = 100;
            this.progressbarSimple1.Name = "progressbarSimple1";
            this.progressbarSimple1.Percentage = 0;
            this.progressbarSimple1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressbarSimple1.Size = new System.Drawing.Size(106, 23);
            this.progressbarSimple1.TabIndex = 17;
            this.progressbarSimple1.Value = 0;
            // 
            // timertoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 132);
            this.Controls.Add(this.progressbarSimple1);
            this.Controls.Add(this.btn_1hour);
            this.Controls.Add(this.btn_30min);
            this.Controls.Add(this.btn_15min);
            this.Controls.Add(this.btn_5min);
            this.Controls.Add(this.chk_repeat);
            this.Controls.Add(this.chk_beep);
            this.Controls.Add(this.lbl_seconds);
            this.Controls.Add(this.lbl_freeware);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label_minutes);
            this.Controls.Add(this.label_hours);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "timertoolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvertTimer";
            this.Resize += new System.EventHandler(this.timertoolForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label label_hours;
        private System.Windows.Forms.Label label_minutes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label lbl_freeware;
        private System.Windows.Forms.Label lbl_seconds;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox chk_beep;
        private System.Windows.Forms.CheckBox chk_repeat;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btn_5min;
        private System.Windows.Forms.Button btn_15min;
        private System.Windows.Forms.Button btn_30min;
        private System.Windows.Forms.Button btn_1hour;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private progressbarSimple progressbarSimple1;
    }
}

