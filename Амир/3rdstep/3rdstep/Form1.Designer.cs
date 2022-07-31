namespace _3rdstep
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.News = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddTheme = new System.Windows.Forms.Button();
            this.TextTheme = new System.Windows.Forms.TextBox();
            this.TextNews1 = new System.Windows.Forms.TextBox();
            this.ChTheme = new System.Windows.Forms.Button();
            this.DelTheme = new System.Windows.Forms.Button();
            this.AddNews = new System.Windows.Forms.Button();
            this.TextNews2 = new System.Windows.Forms.TextBox();
            this.ChNews = new System.Windows.Forms.Button();
            this.DelNews = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Section,
            this.Count});
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(399, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Section
            // 
            this.Section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Section.HeaderText = "Theme Section";
            this.Section.MinimumWidth = 6;
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.HeaderText = "Count of the news";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.News,
            this.Date});
            this.dataGridView2.Location = new System.Drawing.Point(465, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(399, 377);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // News
            // 
            this.News.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.News.HeaderText = "News";
            this.News.MinimumWidth = 6;
            this.News.Name = "News";
            this.News.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date of publishing";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // AddTheme
            // 
            this.AddTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTheme.Location = new System.Drawing.Point(0, 446);
            this.AddTheme.Name = "AddTheme";
            this.AddTheme.Size = new System.Drawing.Size(99, 38);
            this.AddTheme.TabIndex = 2;
            this.AddTheme.Text = "Add\r\n";
            this.AddTheme.UseVisualStyleBackColor = true;
            this.AddTheme.Click += new System.EventHandler(this.AddTheme_Click);
            // 
            // TextTheme
            // 
            this.TextTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTheme.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TextTheme.Location = new System.Drawing.Point(106, 446);
            this.TextTheme.Multiline = true;
            this.TextTheme.Name = "TextTheme";
            this.TextTheme.Size = new System.Drawing.Size(293, 38);
            this.TextTheme.TabIndex = 8;
            this.TextTheme.Text = "Add theme section...";
            this.TextTheme.Click += new System.EventHandler(this.TextTheme_Click);
            this.TextTheme.TextChanged += new System.EventHandler(this.TextTheme_TextChanged);
            this.TextTheme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTheme_KeyPress);
            // 
            // TextNews1
            // 
            this.TextNews1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNews1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TextNews1.Location = new System.Drawing.Point(571, 446);
            this.TextNews1.Multiline = true;
            this.TextNews1.Name = "TextNews1";
            this.TextNews1.Size = new System.Drawing.Size(293, 38);
            this.TextNews1.TabIndex = 10;
            this.TextNews1.Text = "Add some news...";
            this.TextNews1.Click += new System.EventHandler(this.TextNews1_Click);
            this.TextNews1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNews1_KeyPress);
            // 
            // ChTheme
            // 
            this.ChTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChTheme.Location = new System.Drawing.Point(0, 490);
            this.ChTheme.Name = "ChTheme";
            this.ChTheme.Size = new System.Drawing.Size(99, 38);
            this.ChTheme.TabIndex = 9;
            this.ChTheme.Text = "Change";
            this.ChTheme.UseVisualStyleBackColor = true;
            this.ChTheme.Click += new System.EventHandler(this.ChTheme_Click);
            // 
            // DelTheme
            // 
            this.DelTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelTheme.Location = new System.Drawing.Point(0, 534);
            this.DelTheme.Name = "DelTheme";
            this.DelTheme.Size = new System.Drawing.Size(99, 38);
            this.DelTheme.TabIndex = 11;
            this.DelTheme.Text = "Delete";
            this.DelTheme.UseVisualStyleBackColor = true;
            this.DelTheme.Click += new System.EventHandler(this.DelTheme_Click);
            // 
            // AddNews
            // 
            this.AddNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNews.Location = new System.Drawing.Point(465, 446);
            this.AddNews.Name = "AddNews";
            this.AddNews.Size = new System.Drawing.Size(99, 38);
            this.AddNews.TabIndex = 12;
            this.AddNews.Text = "Add";
            this.AddNews.UseVisualStyleBackColor = true;
            this.AddNews.Click += new System.EventHandler(this.AddNews_Click);
            // 
            // TextNews2
            // 
            this.TextNews2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNews2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TextNews2.Location = new System.Drawing.Point(571, 490);
            this.TextNews2.Multiline = true;
            this.TextNews2.Name = "TextNews2";
            this.TextNews2.Size = new System.Drawing.Size(293, 38);
            this.TextNews2.TabIndex = 14;
            this.TextNews2.Text = "Change date...";
            this.TextNews2.Click += new System.EventHandler(this.TextNews2_Click);
            this.TextNews2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNews2_KeyPress);
            // 
            // ChNews
            // 
            this.ChNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChNews.Location = new System.Drawing.Point(465, 490);
            this.ChNews.Name = "ChNews";
            this.ChNews.Size = new System.Drawing.Size(99, 38);
            this.ChNews.TabIndex = 13;
            this.ChNews.Text = "Change";
            this.ChNews.UseVisualStyleBackColor = true;
            this.ChNews.Click += new System.EventHandler(this.ChNews_Click);
            // 
            // DelNews
            // 
            this.DelNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelNews.Location = new System.Drawing.Point(465, 534);
            this.DelNews.Name = "DelNews";
            this.DelNews.Size = new System.Drawing.Size(99, 38);
            this.DelNews.TabIndex = 15;
            this.DelNews.Text = "Delete";
            this.DelNews.UseVisualStyleBackColor = true;
            this.DelNews.Click += new System.EventHandler(this.DelNews_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.uploadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 585);
            this.Controls.Add(this.DelNews);
            this.Controls.Add(this.TextNews2);
            this.Controls.Add(this.ChNews);
            this.Controls.Add(this.AddNews);
            this.Controls.Add(this.DelTheme);
            this.Controls.Add(this.TextNews1);
            this.Controls.Add(this.ChTheme);
            this.Controls.Add(this.TextTheme);
            this.Controls.Add(this.AddTheme);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country.News";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn News;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button AddTheme;
        private System.Windows.Forms.TextBox TextTheme;
        private System.Windows.Forms.TextBox TextNews1;
        private System.Windows.Forms.Button ChTheme;
        private System.Windows.Forms.Button DelTheme;
        private System.Windows.Forms.Button AddNews;
        private System.Windows.Forms.TextBox TextNews2;
        private System.Windows.Forms.Button ChNews;
        private System.Windows.Forms.Button DelNews;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
    }
}

