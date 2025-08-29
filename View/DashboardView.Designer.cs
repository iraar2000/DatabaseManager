namespace DatabaseManager.View
{
    partial class DashboardView
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PDFButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.DashboardButton = new FontAwesome.Sharp.IconButton();
            this.settingIconButton = new FontAwesome.Sharp.IconButton();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.MainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.addButton);
            this.MainPanel.Controls.Add(this.DeleteButton);
            this.MainPanel.Controls.Add(this.EditButton);
            this.MainPanel.Controls.Add(this.PDFButton);
            this.MainPanel.Controls.Add(this.SearchButton);
            this.MainPanel.Controls.Add(this.SearchTextBox);
            this.MainPanel.Location = new System.Drawing.Point(277, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(907, 562);
            this.MainPanel.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(133, 10);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(478, 34);
            this.SearchTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoEllipsis = true;
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(617, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(178, 34);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // PDFButton
            // 
            this.PDFButton.AutoEllipsis = true;
            this.PDFButton.BackColor = System.Drawing.Color.White;
            this.PDFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDFButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PDFButton.Location = new System.Drawing.Point(651, 50);
            this.PDFButton.Name = "PDFButton";
            this.PDFButton.Size = new System.Drawing.Size(178, 34);
            this.PDFButton.TabIndex = 2;
            this.PDFButton.Text = "PDF";
            this.PDFButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            this.EditButton.AutoEllipsis = true;
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(467, 50);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(178, 34);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoEllipsis = true;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(283, 50);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(178, 34);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.AutoEllipsis = true;
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(99, 50);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(178, 34);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add New";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataTable);
            this.panel3.Location = new System.Drawing.Point(3, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 472);
            this.panel3.TabIndex = 6;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.menuPanel.Controls.Add(this.settingIconButton);
            this.menuPanel.Controls.Add(this.DashboardButton);
            this.menuPanel.Controls.Add(this.LogoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(278, 562);
            this.menuPanel.TabIndex = 2;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(278, 100);
            this.LogoPanel.TabIndex = 0;
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.DashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.DashboardButton.IconColor = System.Drawing.Color.White;
            this.DashboardButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.Location = new System.Drawing.Point(0, 100);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(278, 60);
            this.DashboardButton.TabIndex = 3;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardButton.UseVisualStyleBackColor = false;
            // 
            // settingIconButton
            // 
            this.settingIconButton.BackColor = System.Drawing.Color.Transparent;
            this.settingIconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingIconButton.FlatAppearance.BorderSize = 0;
            this.settingIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.settingIconButton.ForeColor = System.Drawing.Color.White;
            this.settingIconButton.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.settingIconButton.IconColor = System.Drawing.Color.White;
            this.settingIconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.settingIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingIconButton.Location = new System.Drawing.Point(0, 160);
            this.settingIconButton.Name = "settingIconButton";
            this.settingIconButton.Size = new System.Drawing.Size(278, 60);
            this.settingIconButton.TabIndex = 4;
            this.settingIconButton.Text = "Settings";
            this.settingIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingIconButton.UseVisualStyleBackColor = false;
            // 
            // DataTable
            // 
            this.DataTable.BackgroundColor = System.Drawing.Color.White;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTable.Location = new System.Drawing.Point(0, 0);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.Size = new System.Drawing.Size(904, 472);
            this.DataTable.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button PDFButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private FontAwesome.Sharp.IconButton DashboardButton;
        private FontAwesome.Sharp.IconButton settingIconButton;
        private System.Windows.Forms.DataGridView DataTable;
    }
}