namespace NovbatDehi
{
    partial class MsgBox
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
        /// the contents of ((this)) method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNo = new DevComponents.DotNetBar.ButtonX();
            this.Message = new DevComponents.DotNetBar.LabelX();
            this.btnYES = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.Confrim = new System.Windows.Forms.PictureBox();
            this.Error = new System.Windows.Forms.PictureBox();
            this.Warning = new System.Windows.Forms.PictureBox();
            this.Information = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Confrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNo.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.btnNo.Location = new System.Drawing.Point(57, 82);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(58, 25);
            this.btnNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNo.Symbol = "";
            this.btnNo.SymbolSize = 14F;
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "خیر";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // Message
            // 
            // 
            // 
            // 
            this.Message.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Message.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.Message.Location = new System.Drawing.Point(-3, 35);
            this.Message.Name = "Message";
            this.Message.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Message.Size = new System.Drawing.Size(383, 40);
            this.Message.TabIndex = 4;
            this.Message.Text = "نام کاربری یا کلمه عبور را اشتباه وارد کرده اید!";
            this.Message.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnYES
            // 
            this.btnYES.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYES.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnYES.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.btnYES.Location = new System.Drawing.Point(266, 82);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(58, 25);
            this.btnYES.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnYES.Symbol = "";
            this.btnYES.SymbolSize = 14F;
            this.btnYES.TabIndex = 6;
            this.btnYES.Text = "بله";
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.btnOK.Location = new System.Drawing.Point(162, 82);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 25);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.Symbol = "";
            this.btnOK.SymbolSize = 14F;
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "تایید";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Confrim
            // 
            this.Confrim.Image = global::NovbatDehi.Properties.Resources.Tik;
            this.Confrim.Location = new System.Drawing.Point(324, 8);
            this.Confrim.Name = "Confrim";
            this.Confrim.Size = new System.Drawing.Size(40, 38);
            this.Confrim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Confrim.TabIndex = 10;
            this.Confrim.TabStop = false;
            // 
            // Error
            // 
            this.Error.Image = global::NovbatDehi.Properties.Resources.error;
            this.Error.Location = new System.Drawing.Point(324, 8);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(40, 38);
            this.Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Error.TabIndex = 9;
            this.Error.TabStop = false;
            // 
            // Warning
            // 
            this.Warning.Image = global::NovbatDehi.Properties.Resources.warning;
            this.Warning.Location = new System.Drawing.Point(324, 8);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(40, 38);
            this.Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warning.TabIndex = 8;
            this.Warning.TabStop = false;
            // 
            // Information
            // 
            this.Information.Image = global::NovbatDehi.Properties.Resources.information;
            this.Information.InitialImage = global::NovbatDehi.Properties.Resources.information;
            this.Information.Location = new System.Drawing.Point(324, 8);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(40, 38);
            this.Information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Information.TabIndex = 5;
            this.Information.TabStop = false;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 115);
            this.Controls.Add(this.Confrim);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnYES);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.Message);
            this.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "توجه کنید!";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.Confrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.PictureBox Information;
        private DevComponents.DotNetBar.ButtonX btnNo;
        private DevComponents.DotNetBar.LabelX Message;
        private DevComponents.DotNetBar.ButtonX btnYES;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private System.Windows.Forms.PictureBox Warning;
        private System.Windows.Forms.PictureBox Error;
        private System.Windows.Forms.PictureBox Confrim;
    }
}
