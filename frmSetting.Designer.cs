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
            this.CheckAutoBAckup = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.timeUntil = new System.Windows.Forms.MaskedTextBox();
            this.timeFrom = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberofNovbat = new System.Windows.Forms.TextBox();
            this.backupPath = new System.Windows.Forms.TextBox();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.groupPanel1.SuspendLayout();
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
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPanel1.Size = new System.Drawing.Size(596, 268);
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
            // CheckAutoBAckup
            // 
            this.CheckAutoBAckup.AutoSize = true;
            this.CheckAutoBAckup.Location = new System.Drawing.Point(392, 107);
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
            this.btnLogin.Location = new System.Drawing.Point(4, 198);
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
            // numberofNovbat
            // 
            this.numberofNovbat.Location = new System.Drawing.Point(140, 1);
            this.numberofNovbat.MaxLength = 1;
            this.numberofNovbat.Name = "numberofNovbat";
            this.numberofNovbat.Size = new System.Drawing.Size(36, 26);
            this.numberofNovbat.TabIndex = 21;
            this.numberofNovbat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // backupPath
            // 
            this.backupPath.Location = new System.Drawing.Point(4, 33);
            this.backupPath.MaxLength = 1;
            this.backupPath.Name = "backupPath";
            this.backupPath.Size = new System.Drawing.Size(408, 26);
            this.backupPath.TabIndex = 22;
            // 
            // EmailAddress
            // 
            this.EmailAddress.Location = new System.Drawing.Point(4, 65);
            this.EmailAddress.MaxLength = 1;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(408, 26);
            this.EmailAddress.TabIndex = 23;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 273);
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
    }
}
