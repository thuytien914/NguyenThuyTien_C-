namespace QuanLyQuanCafe
{
    partial class TableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgườToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.msTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.btTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.nmDisCount = new System.Windows.Forms.NumericUpDown();
            this.btnDisscount = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msHeThong,
            this.quảnLýToolStripMenuItem,
            this.msThongKe,
            this.msTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(6, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 55);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // msHeThong
            // 
            this.msHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.msHeThong.Image = global::QuanLyQuanCafe.Properties.Resources.settings;
            this.msHeThong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msHeThong.Name = "msHeThong";
            this.msHeThong.Size = new System.Drawing.Size(71, 51);
            this.msHeThong.Text = "Hệ Thống";
            this.msHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.msHeThong.Click += new System.EventHandler(this.msHeThong_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNgườToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Image = global::QuanLyQuanCafe.Properties.Resources.manager;
            this.quảnLýToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(62, 51);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            this.quảnLýToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // quảnLýNgườToolStripMenuItem
            // 
            this.quảnLýNgườToolStripMenuItem.Name = "quảnLýNgườToolStripMenuItem";
            this.quảnLýNgườToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýNgườToolStripMenuItem.Text = "Quản lý người dùng";
            this.quảnLýNgườToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgườToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // msThongKe
            // 
            this.msThongKe.Image = global::QuanLyQuanCafe.Properties.Resources.analytics;
            this.msThongKe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msThongKe.Name = "msThongKe";
            this.msThongKe.Size = new System.Drawing.Size(69, 51);
            this.msThongKe.Text = "Thống Kê";
            this.msThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // msTroGiup
            // 
            this.msTroGiup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.msTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btTroGiup});
            this.msTroGiup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTroGiup.Image = global::QuanLyQuanCafe.Properties.Resources.help;
            this.msTroGiup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msTroGiup.Name = "msTroGiup";
            this.msTroGiup.Size = new System.Drawing.Size(63, 51);
            this.msTroGiup.Text = "Trợ Giúp";
            this.msTroGiup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.msTroGiup.Click += new System.EventHandler(this.msTroGiup_Click);
            // 
            // btTroGiup
            // 
            this.btTroGiup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btTroGiup.Name = "btTroGiup";
            this.btTroGiup.Size = new System.Drawing.Size(180, 22);
            this.btTroGiup.Text = "Trợ giúp";
            this.btTroGiup.Click += new System.EventHandler(this.btTroGiup_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbSwitchTable);
            this.panel2.Controls.Add(this.btnSwitchTable);
            this.panel2.Controls.Add(this.nmDisCount);
            this.panel2.Controls.Add(this.btnDisscount);
            this.panel2.Controls.Add(this.btnCheckOut);
            this.panel2.Location = new System.Drawing.Point(367, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 54);
            this.panel2.TabIndex = 2;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(3, 30);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(100, 21);
            this.cbSwitchTable.TabIndex = 7;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(3, 0);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSwitchTable.Size = new System.Drawing.Size(100, 28);
            this.btnSwitchTable.TabIndex = 6;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nmDisCount
            // 
            this.nmDisCount.Location = new System.Drawing.Point(172, 31);
            this.nmDisCount.Name = "nmDisCount";
            this.nmDisCount.Size = new System.Drawing.Size(87, 20);
            this.nmDisCount.TabIndex = 5;
            this.nmDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDisscount
            // 
            this.btnDisscount.Location = new System.Drawing.Point(172, 0);
            this.btnDisscount.Name = "btnDisscount";
            this.btnDisscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDisscount.Size = new System.Drawing.Size(87, 28);
            this.btnDisscount.TabIndex = 4;
            this.btnDisscount.Text = "Giảm giá";
            this.btnDisscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(327, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(81, 48);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvBill);
            this.panel3.Location = new System.Drawing.Point(367, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 296);
            this.panel3.TabIndex = 3;
            // 
            // lvBill
            // 
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(3, 3);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(405, 290);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(367, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 54);
            this.panel4.TabIndex = 3;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(352, 19);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(56, 20);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btAddFood
            // 
            this.btAddFood.Location = new System.Drawing.Point(265, 1);
            this.btAddFood.Name = "btAddFood";
            this.btAddFood.Size = new System.Drawing.Size(81, 53);
            this.btAddFood.TabIndex = 2;
            this.btAddFood.Text = "Thêm món";
            this.btAddFood.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 30);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(247, 21);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(247, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(9, 60);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(352, 413);
            this.flpTable.TabIndex = 4;
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(785, 478);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManager";
            this.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.Text = "Phần Mềm Quản Lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msHeThong;
        private System.Windows.Forms.ToolStripMenuItem msThongKe;
        private System.Windows.Forms.ToolStripMenuItem msTroGiup;
        private System.Windows.Forms.ToolStripMenuItem btTroGiup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btAddFood;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.NumericUpDown nmDisCount;
        private System.Windows.Forms.Button btnDisscount;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}