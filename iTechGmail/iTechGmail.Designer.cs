namespace iTechGmail
{
    partial class ITechGmail
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.messagesDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btPreviousPage = new System.Windows.Forms.Button();
            this.btNextPage = new System.Windows.Forms.Button();
            this.btGoToPage = new System.Windows.Forms.Button();
            this.pageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.messagesDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesDataGridView
            // 
            this.messagesDataGridView.AllowUserToAddRows = false;
            this.messagesDataGridView.AllowUserToDeleteRows = false;
            this.messagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.messagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messagesDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.messagesDataGridView.Location = new System.Drawing.Point(0, 24);
            this.messagesDataGridView.Name = "messagesDataGridView";
            this.messagesDataGridView.ReadOnly = true;
            this.messagesDataGridView.Size = new System.Drawing.Size(984, 463);
            this.messagesDataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorizationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autorizationToolStripMenuItem
            // 
            this.autorizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.changeUserToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.autorizationToolStripMenuItem.Name = "autorizationToolStripMenuItem";
            this.autorizationToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.autorizationToolStripMenuItem.Text = "Autorization";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.changeUserToolStripMenuItem.Text = "Change user";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btPreviousPage
            // 
            this.btPreviousPage.Location = new System.Drawing.Point(368, 491);
            this.btPreviousPage.Name = "btPreviousPage";
            this.btPreviousPage.Size = new System.Drawing.Size(107, 23);
            this.btPreviousPage.TabIndex = 2;
            this.btPreviousPage.Text = "Previous page";
            this.btPreviousPage.UseVisualStyleBackColor = true;
            this.btPreviousPage.Click += new System.EventHandler(this.btPreviousPage_Click);
            // 
            // btNextPage
            // 
            this.btNextPage.Location = new System.Drawing.Point(508, 491);
            this.btNextPage.Name = "btNextPage";
            this.btNextPage.Size = new System.Drawing.Size(107, 23);
            this.btNextPage.TabIndex = 3;
            this.btNextPage.Text = "Next page";
            this.btNextPage.UseVisualStyleBackColor = true;
            this.btNextPage.Click += new System.EventHandler(this.btNextPage_Click);
            // 
            // btGoToPage
            // 
            this.btGoToPage.Location = new System.Drawing.Point(739, 491);
            this.btGoToPage.Name = "btGoToPage";
            this.btGoToPage.Size = new System.Drawing.Size(107, 23);
            this.btGoToPage.TabIndex = 4;
            this.btGoToPage.Text = "Go to page";
            this.btGoToPage.UseVisualStyleBackColor = true;
            this.btGoToPage.Click += new System.EventHandler(this.btGoToPage_Click);
            // 
            // pageNumericUpDown
            // 
            this.pageNumericUpDown.Location = new System.Drawing.Point(852, 492);
            this.pageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNumericUpDown.Name = "pageNumericUpDown";
            this.pageNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.pageNumericUpDown.TabIndex = 5;
            this.pageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ITechGmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.pageNumericUpDown);
            this.Controls.Add(this.btGoToPage);
            this.Controls.Add(this.btNextPage);
            this.Controls.Add(this.btPreviousPage);
            this.Controls.Add(this.messagesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ITechGmail";
            this.Text = "ITech Gmail";
            ((System.ComponentModel.ISupportInitialize)(this.messagesDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView messagesDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autorizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btPreviousPage;
        private System.Windows.Forms.Button btNextPage;
        private System.Windows.Forms.Button btGoToPage;
        private System.Windows.Forms.NumericUpDown pageNumericUpDown;
    }
}

