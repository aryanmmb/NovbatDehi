namespace NovbatDehi
{
    partial class frmSetting
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.backupPath = new System.Windows.Forms.TextBox();
            this.numberofNovbat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckAutoBAckup = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.timeUntil = new System.Windows.Forms.MaskedTextBox();
            this.timeFrom = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.SmsUsername = new System.Windows.Forms.TextBox();
            this.SmsPassword = new System.Windows.Forms.TextBox();
            this.SmsLine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.PaternSend = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PaternResend = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Controls.Add(this.EmailAddress);
            this.groupPanel1.Controls.Add(this.backupPath);
            this.groupPanel1.Controls.Add(this.numberofNovbat);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.CheckAutoBAckup);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.btnLogin);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.timeUntil);
            this.groupPanel1.Controls.Add(this.timeFrom);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.LblCount);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.groupPanel1.Location = new System.Drawing.Point(5, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(596, 323);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 25;
            this.groupPanel1.Text = "مدیریت";
            // 
            // EmailAddress
            // 
            this.EmailAddress.Location = new System.Drawing.Point(4, 65);
            this.EmailAddress.MaxLength = 1000;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(408, 26);
            this.EmailAddress.TabIndex = 23;
            // 
            // backupPath
            // 
            this.backupPath.Location = new System.Drawing.Point(201, 33);
            this.backupPath.MaxLength = 1000;
            this.backupPath.Name = "backupPath";
            this.backupPath.Size = new System.Drawing.Size(211, 26);
            this.backupPath.TabIndex = 22;
            // 
            // numberofNovbat
            // 
            this.numberofNovbat.Location = new System.Drawing.Point(140, 1);
            this.numberofNovbat.MaxLength = 1;
            this.numberofNovbat.Name = "numberofNovbat";
            this.numberofNovbat.Size = new System.Drawing.Size(36, 26);
            this.numberofNovbat.TabIndex = 21;
            this.numberofNovbat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.label3.Location = new System.Drawing.Point(182, 4);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "تعداد نوبت اولیه";
            // 
            // CheckAutoBAckup
            // 
            this.CheckAutoBAckup.AutoSize = true;
            this.CheckAutoBAckup.Location = new System.Drawing.Point(4, 33);
            this.CheckAutoBAckup.Name = "CheckAutoBAckup";
            this.CheckAutoBAckup.Size = new System.Drawing.Size(192, 23);
            this.CheckAutoBAckup.TabIndex = 19;
            this.CheckAutoBAckup.Text = "پشتیبان گیری خودکار با خروج از برنامه";
            this.CheckAutoBAckup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.label2.Location = new System.Drawing.Point(418, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "آدرس ایمیل برای ارسال نسخه پشتیبان";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.buttonX1.Location = new System.Drawing.Point(418, 33);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(143, 26);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.Green;
            this.buttonX1.SymbolSize = 12F;
            this.buttonX1.TabIndex = 16;
            this.buttonX1.Text = "انتخاب مسیر پشتیبان گیری";
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.btnLogin.Location = new System.Drawing.Point(4, 253);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(580, 40);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.Symbol = "";
            this.btnLogin.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.SymbolSize = 12F;
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "بروز رسانی";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.label1.Location = new System.Drawing.Point(318, 4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "تا ساعت";
            // 
            // timeUntil
            // 
            this.timeUntil.Location = new System.Drawing.Point(267, 1);
            this.timeUntil.Mask = "00:00";
            this.timeUntil.Name = "timeUntil";
            this.timeUntil.Size = new System.Drawing.Size(45, 26);
            this.timeUntil.TabIndex = 11;
            this.timeUntil.Text = "1600";
            this.timeUntil.ValidatingType = typeof(System.DateTime);
            // 
            // timeFrom
            // 
            this.timeFrom.Location = new System.Drawing.Point(371, 1);
            this.timeFrom.Mask = "00:00";
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Size = new System.Drawing.Size(41, 26);
            this.timeFrom.TabIndex = 1;
            this.timeFrom.Text = "0800";
            this.timeFrom.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.label4.Location = new System.Drawing.Point(418, 8);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "بازه زمانی ایجاد نوبت از ساعت";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("B Compset", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblCount.Location = new System.Drawing.Point(16, 167);
            this.LblCount.Name = "LblCount";
            this.LblCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblCount.Size = new System.Drawing.Size(0, 23);
            this.LblCount.TabIndex = 6;
            // 
            // SmsUsername
            // 
            this.SmsUsername.Location = new System.Drawing.Point(13, 3);
            this.SmsUsername.MaxLength = 200;
            this.SmsUsername.Name = "SmsUsername";
            this.SmsUsername.Size = new System.Drawing.Size(127, 26);
            this.SmsUsername.TabIndex = 24;
            // 
            // SmsPassword
            // 
            this.SmsPassword.Location = new System.Drawing.Point(13, 35);
            this.SmsPassword.MaxLength = 200;
            this.SmsPassword.Name = "SmsPassword";
            this.SmsPassword.Size = new System.Drawing.Size(127, 26);
            this.SmsPassword.TabIndex = 25;
            // 
            // SmsLine
            // 
            this.SmsLine.Location = new System.Drawing.Point(12, 67);
            this.SmsLine.MaxLength = 100;
            this.SmsLine.Name = "SmsLine";
            this.SmsLine.Size = new System.Drawing.Size(127, 26);
            this.SmsLine.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.label5.Location = new System.Drawing.Point(149, 7);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "نام کاربری (SMS)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.label6.Location = new System.Drawing.Point(149, 39);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "رمز عبور (SMS)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.label7.Location = new System.Drawing.Point(149, 71);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "خط ارسال (SMS)";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.PaternResend);
            this.groupPanel2.Controls.Add(this.label9);
            this.groupPanel2.Controls.Add(this.PaternSend);
            this.groupPanel2.Controls.Add(this.label8);
            this.groupPanel2.Controls.Add(this.SmsUsername);
            this.groupPanel2.Controls.Add(this.label7);
            this.groupPanel2.Controls.Add(this.SmsPassword);
            this.groupPanel2.Controls.Add(this.label6);
            this.groupPanel2.Controls.Add(this.SmsLine);
            this.groupPanel2.Controls.Add(this.label5);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(4, 101);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(580, 132);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 30;
            this.groupPanel2.Text = "تنظیمات پنل پیامک";
            // 
            // PaternSend
            // 
            this.PaternSend.Location = new System.Drawing.Point(321, 7);
            this.PaternSend.MaxLength = 200;
            this.PaternSend.Name = "PaternSend";
            this.PaternSend.Size = new System.Drawing.Size(127, 26);
            this.PaternSend.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.label8.Location = new System.Drawing.Point(457, 11);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "پترن ارسال";
            // 
            // PaternResend
            // 
            this.PaternResend.Location = new System.Drawing.Point(321, 42);
            this.PaternResend.MaxLength = 200;
            this.PaternResend.Name = "PaternResend";
            this.PaternResend.Size = new System.Drawing.Size(127, 26);
            this.PaternResend.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.label9.Location = new System.Drawing.Point(457, 46);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "پترن یاد آوری";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 328);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSetting";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنظیمات";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.MaskedTextBox timeFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox timeUntil;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckAutoBAckup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberofNovbat;
        private System.Windows.Forms.TextBox EmailAddress;
        private System.Windows.Forms.TextBox backupPath;
        private System.Windows.Forms.TextBox SmsLine;
        private System.Windows.Forms.TextBox SmsPassword;
        private System.Windows.Forms.TextBox SmsUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.TextBox PaternResend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PaternSend;
        private System.Windows.Forms.Label label8;
    }
}
