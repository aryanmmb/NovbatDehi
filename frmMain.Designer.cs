﻿
namespace NovbatDehi
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSendStp = new DevComponents.DotNetBar.ButtonX();
            this.Lb_Progress = new System.Windows.Forms.Label();
            this.BtnSendResend = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.DbGrideTodayFirstCom = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DbGrideReserv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstCome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tozihat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.PersianCalender = new BehComponents.MonthCalendarX();
            this.Sms_ResendSms = new System.ComponentModel.BackgroundWorker();
            this.todatedate = new BPersianCalender.BPersianCalenderTextBox();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbGrideTodayFirstCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbGrideReserv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.todatedate);
            this.groupPanel1.Controls.Add(this.btnSendStp);
            this.groupPanel1.Controls.Add(this.Lb_Progress);
            this.groupPanel1.Controls.Add(this.BtnSendResend);
            this.groupPanel1.Controls.Add(this.buttonX6);
            this.groupPanel1.Controls.Add(this.buttonX5);
            this.groupPanel1.Controls.Add(this.buttonX4);
            this.groupPanel1.Controls.Add(this.DbGrideTodayFirstCom);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.DbGrideReserv);
            this.groupPanel1.Controls.Add(this.buttonX3);
            this.groupPanel1.Controls.Add(this.buttonX2);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.PersianCalender);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(0, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPanel1.Size = new System.Drawing.Size(1221, 662);
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
            this.groupPanel1.TabIndex = 0;
            // 
            // btnSendStp
            // 
            this.btnSendStp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSendStp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendStp.BackColor = System.Drawing.Color.Transparent;
            this.btnSendStp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSendStp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendStp.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendStp.Location = new System.Drawing.Point(662, 8);
            this.btnSendStp.Name = "btnSendStp";
            this.btnSendStp.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.btnSendStp.Size = new System.Drawing.Size(147, 46);
            this.btnSendStp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSendStp.Symbol = "";
            this.btnSendStp.SymbolColor = System.Drawing.Color.Black;
            this.btnSendStp.SymbolSize = 15F;
            this.btnSendStp.TabIndex = 106;
            this.btnSendStp.Text = "ارسال بکاپ به سرور";
            this.btnSendStp.Click += new System.EventHandler(this.btnSendStp_Click);
            // 
            // Lb_Progress
            // 
            this.Lb_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Progress.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Progress.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Progress.Location = new System.Drawing.Point(9, 23);
            this.Lb_Progress.Name = "Lb_Progress";
            this.Lb_Progress.Size = new System.Drawing.Size(174, 17);
            this.Lb_Progress.TabIndex = 105;
            this.Lb_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSendResend
            // 
            this.BtnSendResend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSendResend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSendResend.BackColor = System.Drawing.Color.Transparent;
            this.BtnSendResend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSendResend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSendResend.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSendResend.Location = new System.Drawing.Point(189, 8);
            this.BtnSendResend.Name = "BtnSendResend";
            this.BtnSendResend.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.BtnSendResend.Size = new System.Drawing.Size(239, 46);
            this.BtnSendResend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSendResend.Symbol = "";
            this.BtnSendResend.SymbolColor = System.Drawing.Color.Fuchsia;
            this.BtnSendResend.SymbolSize = 15F;
            this.BtnSendResend.TabIndex = 104;
            this.BtnSendResend.Text = "ارسال پیام یاد آوری به بیماران فردا";
            this.BtnSendResend.Click += new System.EventHandler(this.BtnSendResend_Click);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX6.BackColor = System.Drawing.Color.Transparent;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX6.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX6.Location = new System.Drawing.Point(434, 8);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.buttonX6.Size = new System.Drawing.Size(138, 46);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.Symbol = "";
            this.buttonX6.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.buttonX6.SymbolSize = 15F;
            this.buttonX6.TabIndex = 102;
            this.buttonX6.Text = "چاپ بیماران امروز";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX5.BackColor = System.Drawing.Color.Transparent;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX5.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX5.Location = new System.Drawing.Point(578, 8);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.buttonX5.Size = new System.Drawing.Size(78, 46);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.Symbol = "";
            this.buttonX5.SymbolColor = System.Drawing.Color.Crimson;
            this.buttonX5.SymbolSize = 15F;
            this.buttonX5.TabIndex = 101;
            this.buttonX5.Text = "جستجو";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX4.BackColor = System.Drawing.Color.Transparent;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX4.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX4.Location = new System.Drawing.Point(811, 8);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.buttonX4.Size = new System.Drawing.Size(110, 46);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.Symbol = "";
            this.buttonX4.SymbolColor = System.Drawing.Color.DarkGreen;
            this.buttonX4.SymbolSize = 15F;
            this.buttonX4.TabIndex = 100;
            this.buttonX4.Text = "پشتیبان گیری";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // DbGrideTodayFirstCom
            // 
            this.DbGrideTodayFirstCom.AllowUserToAddRows = false;
            this.DbGrideTodayFirstCom.AllowUserToDeleteRows = false;
            this.DbGrideTodayFirstCom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbGrideTodayFirstCom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DbGrideTodayFirstCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGrideTodayFirstCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DbGrideTodayFirstCom.DefaultCellStyle = dataGridViewCellStyle6;
            this.DbGrideTodayFirstCom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DbGrideTodayFirstCom.Location = new System.Drawing.Point(896, 369);
            this.DbGrideTodayFirstCom.MultiSelect = false;
            this.DbGrideTodayFirstCom.Name = "DbGrideTodayFirstCom";
            this.DbGrideTodayFirstCom.ReadOnly = true;
            this.DbGrideTodayFirstCom.RowHeadersVisible = false;
            this.DbGrideTodayFirstCom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DbGrideTodayFirstCom.Size = new System.Drawing.Size(314, 287);
            this.DbGrideTodayFirstCom.TabIndex = 99;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn4.HeaderText = "ساعت";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn5.HeaderText = "کد بیمار";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fullname";
            this.dataGridViewTextBoxColumn6.HeaderText = "نام بیمار";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1013, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 98;
            this.label1.Text = "لیست مراجعه اولی های امروز";
            // 
            // DbGrideReserv
            // 
            this.DbGrideReserv.AllowUserToAddRows = false;
            this.DbGrideReserv.AllowUserToDeleteRows = false;
            this.DbGrideReserv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbGrideReserv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.Note,
            this.tozihat});
            this.DbGrideReserv.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DbGrideReserv.DefaultCellStyle = dataGridViewCellStyle10;
            this.DbGrideReserv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DbGrideReserv.Location = new System.Drawing.Point(3, 60);
            this.DbGrideReserv.MultiSelect = false;
            this.DbGrideReserv.Name = "DbGrideReserv";
            this.DbGrideReserv.ReadOnly = true;
            this.DbGrideReserv.RowHeadersVisible = false;
            this.DbGrideReserv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DbGrideReserv.Size = new System.Drawing.Size(887, 596);
            this.DbGrideReserv.TabIndex = 96;
            this.DbGrideReserv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // _Radif
            // 
            this._Radif.DataPropertyName = "Radif";
            this._Radif.HeaderText = "#";
            this._Radif.Name = "_Radif";
            this._Radif.ReadOnly = true;
            this._Radif.Width = 47;
            // 
            // _date
            // 
            this._date.DataPropertyName = "date";
            this._date.HeaderText = "تاریخ";
            this._date.Name = "_date";
            this._date.ReadOnly = true;
            this._date.Width = 71;
            // 
            // _Time
            // 
            this._Time.DataPropertyName = "Time";
            this._Time.HeaderText = "ساعت";
            this._Time.Name = "_Time";
            this._Time.ReadOnly = true;
            this._Time.Width = 77;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "code";
            this.customer_id.HeaderText = "کد بیمار";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Width = 86;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "fullname";
            this.customer_name.HeaderText = "نام بیمار";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 88;
            // 
            // customerMobile
            // 
            this.customerMobile.DataPropertyName = "mobile";
            this.customerMobile.HeaderText = "شماره بیمار";
            this.customerMobile.Name = "customerMobile";
            this.customerMobile.ReadOnly = true;
            this.customerMobile.Width = 106;
            // 
            // FirstCome
            // 
            this.FirstCome.DataPropertyName = "FirstCome";
            this.FirstCome.HeaderText = "بیمار مراجعه اول";
            this.FirstCome.Name = "FirstCome";
            this.FirstCome.ReadOnly = true;
            this.FirstCome.Width = 142;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "شرح";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 67;
            // 
            // tozihat
            // 
            this.tozihat.DataPropertyName = "tozihat";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tozihat.DefaultCellStyle = dataGridViewCellStyle9;
            this.tozihat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tozihat.HeaderText = "توضیحات";
            this.tozihat.Name = "tozihat";
            this.tozihat.ReadOnly = true;
            this.tozihat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tozihat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tozihat.Width = 99;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItem1.Text = "حذف نوبت";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX3.BackColor = System.Drawing.Color.Transparent;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX3.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.Location = new System.Drawing.Point(927, 8);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.buttonX3.Size = new System.Drawing.Size(80, 46);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolColor = System.Drawing.Color.DarkGreen;
            this.buttonX3.SymbolSize = 15F;
            this.buttonX3.TabIndex = 95;
            this.buttonX3.Text = "تنظیمات";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX2.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Location = new System.Drawing.Point(1013, 8);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.buttonX2.Size = new System.Drawing.Size(104, 46);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolColor = System.Drawing.Color.DarkGreen;
            this.buttonX2.SymbolSize = 15F;
            this.buttonX2.TabIndex = 94;
            this.buttonX2.Text = "لیست بیماران";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(1123, 8);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.buttonX1.Size = new System.Drawing.Size(87, 46);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.DarkGreen;
            this.buttonX1.SymbolSize = 15F;
            this.buttonX1.TabIndex = 93;
            this.buttonX1.Text = "بیمار جدید";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // PersianCalender
            // 
            this.PersianCalender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PersianCalender.BoldedDayForeColor = System.Drawing.Color.Blue;
            this.PersianCalender.BorderColor = System.Drawing.Color.CadetBlue;
            this.PersianCalender.CalendarType = BehComponents.CalendarTypes.Persian;
            this.PersianCalender.DayRectTickness = 2F;
            this.PersianCalender.DaysBackColor = System.Drawing.Color.White;
            this.PersianCalender.DaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersianCalender.DaysForeColor = System.Drawing.Color.Black;
            this.PersianCalender.EnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.PersianCalender.EnglishBoldedDates = new System.DateTime[0];
            this.PersianCalender.EnglishHolidayDates = new System.DateTime[0];
            this.PersianCalender.EnglishMonthlyBoldedDates = new System.DateTime[0];
            this.PersianCalender.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersianCalender.HolidayForeColor = System.Drawing.Color.Red;
            this.PersianCalender.HolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.PersianCalender.LineWeekColor = System.Drawing.Color.Black;
            this.PersianCalender.Location = new System.Drawing.Point(896, 60);
            this.PersianCalender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersianCalender.Name = "PersianCalender";
            this.PersianCalender.PersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.PersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.PersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.PersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.ShowToday = true;
            this.PersianCalender.ShowTodayRect = true;
            this.PersianCalender.ShowToolTips = false;
            this.PersianCalender.ShowTrailing = true;
            this.PersianCalender.Size = new System.Drawing.Size(314, 246);
            this.PersianCalender.Style_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.PersianCalender.Style_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.PersianCalender.Style_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.PersianCalender.Style_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.PersianCalender.Style_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.PersianCalender.Style_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.PersianCalender.TabIndex = 2;
            this.PersianCalender.TitleBackColor = System.Drawing.Color.White;
            this.PersianCalender.TitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.PersianCalender.TitleForeColor = System.Drawing.Color.Black;
            this.PersianCalender.TodayBackColor = System.Drawing.Color.White;
            this.PersianCalender.TodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PersianCalender.TodayForeColor = System.Drawing.Color.Black;
            this.PersianCalender.TodayRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PersianCalender.TodayRectTickness = 2F;
            this.PersianCalender.TrailingForeColor = System.Drawing.Color.DarkGray;
            this.PersianCalender.WeekDaysBackColor = System.Drawing.Color.White;
            this.PersianCalender.WeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.PersianCalender.WeekDaysForeColor = System.Drawing.Color.Blue;
            this.PersianCalender.WeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.PersianCalender.DayMouseClick += new BehComponents.MonthCalendarX.OnDayMouseClick(this.PersianCalender_DayMouseClick);
            // 
            // Sms_ResendSms
            // 
            this.Sms_ResendSms.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.Sms_ResendSms.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.Sms_ResendSms.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // todatedate
            // 
            this.todatedate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.todatedate.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.todatedate.Location = new System.Drawing.Point(896, 320);
            this.todatedate.Miladi = new System.DateTime(((long)(0)));
            this.todatedate.Name = "todatedate";
            this.todatedate.NowDateSelected = false;
            this.todatedate.ReadOnly = true;
            this.todatedate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.todatedate.SelectedDate = null;
            this.todatedate.Shamsi = null;
            this.todatedate.Size = new System.Drawing.Size(138, 30);
            this.todatedate.TabIndex = 96;
            this.todatedate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.todatedate.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 666);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FrmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم نوبت دهی";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbGrideTodayFirstCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbGrideReserv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private BehComponents.MonthCalendarX PersianCalender;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX DbGrideReserv;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX DbGrideTodayFirstCom;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn _date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstCome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewButtonColumn tozihat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker Sms_ResendSms;
        private DevComponents.DotNetBar.ButtonX BtnSendResend;
        private System.Windows.Forms.Label Lb_Progress;
        private DevComponents.DotNetBar.ButtonX btnSendStp;
        private BPersianCalender.BPersianCalenderTextBox todatedate;
    }
}