namespace NovbatDehi
{
    partial class frmGetReserverReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
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
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.key);
            this.groupPanel1.Controls.Add(this.DbGrideReserv);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            this.groupPanel1.Location = new System.Drawing.Point(1, 5);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPanel1.Size = new System.Drawing.Size(766, 496);
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
            this.groupPanel1.Text = "گزارش از رزرو ها";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(693, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = "متن جستجو";
            // 
            // key
            // 
            this.key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.key.Location = new System.Drawing.Point(8, 16);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(679, 26);
            this.key.TabIndex = 98;
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dirooz FD", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DbGrideReserv.DefaultCellStyle = dataGridViewCellStyle2;
            this.DbGrideReserv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DbGrideReserv.Location = new System.Drawing.Point(8, 55);
            this.DbGrideReserv.MultiSelect = false;
            this.DbGrideReserv.Name = "DbGrideReserv";
            this.DbGrideReserv.ReadOnly = true;
            this.DbGrideReserv.RowHeadersVisible = false;
            this.DbGrideReserv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DbGrideReserv.Size = new System.Drawing.Size(746, 407);
            this.DbGrideReserv.TabIndex = 97;
            this.DbGrideReserv.Resize += new System.EventHandler(this.DbGrideReserv_Resize);
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
            this._Radif.Width = 41;
            // 
            // _date
            // 
            this._date.DataPropertyName = "date";
            this._date.HeaderText = "تاریخ";
            this._date.Name = "_date";
            this._date.ReadOnly = true;
            this._date.Width = 55;
            // 
            // _Time
            // 
            this._Time.DataPropertyName = "Time";
            this._Time.HeaderText = "ساعت";
            this._Time.Name = "_Time";
            this._Time.ReadOnly = true;
            this._Time.Width = 62;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "code";
            this.customer_id.HeaderText = "کد بیمار";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Width = 68;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "fullname";
            this.customer_name.HeaderText = "نام بیمار";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 70;
            // 
            // customerMobile
            // 
            this.customerMobile.DataPropertyName = "mobile";
            this.customerMobile.HeaderText = "شماره بیمار";
            this.customerMobile.Name = "customerMobile";
            this.customerMobile.ReadOnly = true;
            this.customerMobile.Width = 83;
            // 
            // FirstCome
            // 
            this.FirstCome.DataPropertyName = "FirstCome";
            this.FirstCome.HeaderText = "بیمار مراجعه اول";
            this.FirstCome.Name = "FirstCome";
            this.FirstCome.ReadOnly = true;
            this.FirstCome.Width = 106;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "شرح";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 55;
            // 
            // tozihat
            // 
            this.tozihat.DataPropertyName = "tozihat";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tozihat.DefaultCellStyle = dataGridViewCellStyle1;
            this.tozihat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tozihat.HeaderText = "توضیحات";
            this.tozihat.Name = "tozihat";
            this.tozihat.ReadOnly = true;
            this.tozihat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tozihat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tozihat.Width = 75;
            // 
            // frmGetReserverReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 503);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmGetReserverReport";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "رزور";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewButtonColumn tozihat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox key;
    }
}
