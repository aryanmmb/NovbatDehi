namespace NovbatDehi
{
    partial class FrmProfileCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DbGrideReserv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstCome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tozihat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_BimehCode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_IrCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBimar = new System.Windows.Forms.TextBox();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbGrideReserv)).BeginInit();
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
            this.groupPanel1.Controls.Add(this.lbl_BimehCode);
            this.groupPanel1.Controls.Add(this.label9);
            this.groupPanel1.Controls.Add(this.lbl_IrCode);
            this.groupPanel1.Controls.Add(this.label7);
            this.groupPanel1.Controls.Add(this.lbl_Mobile);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.txtBimar);
            this.groupPanel1.Controls.Add(this.DbGrideReserv);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.groupPanel1.Location = new System.Drawing.Point(1, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPanel1.Size = new System.Drawing.Size(905, 549);
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
            this.groupPanel1.TabIndex = 26;
            this.groupPanel1.Text = "مدیریت";
            // 
            // DbGrideReserv
            // 
            this.DbGrideReserv.AllowUserToAddRows = false;
            this.DbGrideReserv.AllowUserToDeleteRows = false;
            this.DbGrideReserv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbGrideReserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGrideReserv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this._Radif,
            this._date,
            this._Time,
            this.customer_id,
            this.customer_name,
            this.customerMobile,
            this.FirstCome,
            this.tozihat});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DbGrideReserv.DefaultCellStyle = dataGridViewCellStyle4;
            this.DbGrideReserv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DbGrideReserv.Location = new System.Drawing.Point(8, 85);
            this.DbGrideReserv.MultiSelect = false;
            this.DbGrideReserv.Name = "DbGrideReserv";
            this.DbGrideReserv.ReadOnly = true;
            this.DbGrideReserv.RowHeadersVisible = false;
            this.DbGrideReserv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DbGrideReserv.Size = new System.Drawing.Size(884, 428);
            this.DbGrideReserv.TabIndex = 97;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // _Radif
            // 
            this._Radif.DataPropertyName = "Radif";
            this._Radif.HeaderText = "#";
            this._Radif.Name = "_Radif";
            this._Radif.ReadOnly = true;
            this._Radif.Width = 60;
            // 
            // _date
            // 
            this._date.DataPropertyName = "date";
            this._date.HeaderText = "تاریخ";
            this._date.Name = "_date";
            this._date.ReadOnly = true;
            // 
            // _Time
            // 
            this._Time.DataPropertyName = "Time";
            this._Time.HeaderText = "ساعت";
            this._Time.Name = "_Time";
            this._Time.ReadOnly = true;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "code";
            this.customer_id.HeaderText = "کد بیمار";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "fullname";
            this.customer_name.HeaderText = "نام بیمار";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // customerMobile
            // 
            this.customerMobile.DataPropertyName = "mobile";
            this.customerMobile.HeaderText = "شماره بیمار";
            this.customerMobile.Name = "customerMobile";
            this.customerMobile.ReadOnly = true;
            this.customerMobile.Width = 150;
            // 
            // FirstCome
            // 
            this.FirstCome.DataPropertyName = "FirstCome";
            this.FirstCome.HeaderText = "بیمار مراجعه اول";
            this.FirstCome.Name = "FirstCome";
            this.FirstCome.ReadOnly = true;
            this.FirstCome.Width = 150;
            // 
            // tozihat
            // 
            this.tozihat.DataPropertyName = "tozihat";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tozihat.DefaultCellStyle = dataGridViewCellStyle3;
            this.tozihat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tozihat.HeaderText = "توضیحات";
            this.tozihat.Name = "tozihat";
            this.tozihat.ReadOnly = true;
            this.tozihat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tozihat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tozihat.Width = 120;
            // 
            // lbl_BimehCode
            // 
            this.lbl_BimehCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BimehCode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BimehCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_BimehCode.Location = new System.Drawing.Point(262, 38);
            this.lbl_BimehCode.Name = "lbl_BimehCode";
            this.lbl_BimehCode.Size = new System.Drawing.Size(204, 33);
            this.lbl_BimehCode.TabIndex = 105;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(481, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 104;
            this.label9.Text = "کد بیمه";
            // 
            // lbl_IrCode
            // 
            this.lbl_IrCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_IrCode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_IrCode.Location = new System.Drawing.Point(573, 38);
            this.lbl_IrCode.Name = "lbl_IrCode";
            this.lbl_IrCode.Size = new System.Drawing.Size(252, 33);
            this.lbl_IrCode.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(831, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 102;
            this.label7.Text = "شماره ملی";
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Mobile.Location = new System.Drawing.Point(262, 0);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(204, 33);
            this.lbl_Mobile.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(472, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 100;
            this.label5.Text = "شماره موبایل";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(831, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 98;
            this.label1.Text = "انتخاب بیمار";
            // 
            // txtBimar
            // 
            this.txtBimar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBimar.Location = new System.Drawing.Point(573, 3);
            this.txtBimar.Name = "txtBimar";
            this.txtBimar.ReadOnly = true;
            this.txtBimar.Size = new System.Drawing.Size(252, 26);
            this.txtBimar.TabIndex = 99;
            this.txtBimar.DoubleClick += new System.EventHandler(this.txtBimar_DoubleClick);
            // 
            // frmProfileCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 553);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FrmProfileCustomer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پروفایل بیمار";
            this.ThemeName = "ControlDefault";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbGrideReserv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX DbGrideReserv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn _date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstCome;
        private System.Windows.Forms.DataGridViewButtonColumn tozihat;
        private System.Windows.Forms.Label lbl_BimehCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_IrCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBimar;
    }
}
