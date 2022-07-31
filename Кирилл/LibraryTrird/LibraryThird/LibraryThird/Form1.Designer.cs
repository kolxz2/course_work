namespace LibraryThird
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
            this.ColSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAdd = new System.Windows.Forms.Button();
            this.BookShange = new System.Windows.Forms.Button();
            this.BookDelete = new System.Windows.Forms.Button();
            this.SurAdd = new System.Windows.Forms.Button();
            this.SurChange = new System.Windows.Forms.Button();
            this.SurDelete = new System.Windows.Forms.Button();
            this.textBoxBook = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSurname,
            this.ColDays});
            this.dataGridView1.Location = new System.Drawing.Point(380, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 544);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColSurname
            // 
            this.ColSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSurname.HeaderText = "Name book";
            this.ColSurname.MinimumWidth = 6;
            this.ColSurname.Name = "ColSurname";
            this.ColSurname.ReadOnly = true;
            // 
            // ColDays
            // 
            this.ColDays.HeaderText = "Author";
            this.ColDays.MinimumWidth = 6;
            this.ColDays.Name = "ColDays";
            this.ColDays.ReadOnly = true;
            this.ColDays.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBook,
            this.ColumnAuthor});
            this.dataGridView2.Location = new System.Drawing.Point(795, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(398, 544);
            this.dataGridView2.TabIndex = 1;
            // 
            // ColumnBook
            // 
            this.ColumnBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBook.HeaderText = "Surname Reader";
            this.ColumnBook.MinimumWidth = 6;
            this.ColumnBook.Name = "ColumnBook";
            this.ColumnBook.ReadOnly = true;
            // 
            // ColumnAuthor
            // 
            this.ColumnAuthor.HeaderText = "Days";
            this.ColumnAuthor.MinimumWidth = 6;
            this.ColumnAuthor.Name = "ColumnAuthor";
            this.ColumnAuthor.ReadOnly = true;
            this.ColumnAuthor.Width = 150;
            // 
            // BookAdd
            // 
            this.BookAdd.Location = new System.Drawing.Point(11, 65);
            this.BookAdd.Name = "BookAdd";
            this.BookAdd.Size = new System.Drawing.Size(99, 33);
            this.BookAdd.TabIndex = 2;
            this.BookAdd.Text = "Add";
            this.BookAdd.UseVisualStyleBackColor = true;
            this.BookAdd.Click += new System.EventHandler(this.BookAdd_Click);
            // 
            // BookShange
            // 
            this.BookShange.Location = new System.Drawing.Point(11, 104);
            this.BookShange.Name = "BookShange";
            this.BookShange.Size = new System.Drawing.Size(99, 33);
            this.BookShange.TabIndex = 3;
            this.BookShange.Text = "Change";
            this.BookShange.UseVisualStyleBackColor = true;
            this.BookShange.Click += new System.EventHandler(this.BookShange_Click);
            // 
            // BookDelete
            // 
            this.BookDelete.Location = new System.Drawing.Point(11, 143);
            this.BookDelete.Name = "BookDelete";
            this.BookDelete.Size = new System.Drawing.Size(99, 33);
            this.BookDelete.TabIndex = 4;
            this.BookDelete.Text = "Delete";
            this.BookDelete.UseVisualStyleBackColor = true;
            this.BookDelete.Click += new System.EventHandler(this.BookDelete_Click);
            // 
            // SurAdd
            // 
            this.SurAdd.Location = new System.Drawing.Point(11, 292);
            this.SurAdd.Name = "SurAdd";
            this.SurAdd.Size = new System.Drawing.Size(99, 36);
            this.SurAdd.TabIndex = 5;
            this.SurAdd.Text = "Add";
            this.SurAdd.UseVisualStyleBackColor = true;
            this.SurAdd.Click += new System.EventHandler(this.SurAdd_Click);
            // 
            // SurChange
            // 
            this.SurChange.Location = new System.Drawing.Point(11, 334);
            this.SurChange.Name = "SurChange";
            this.SurChange.Size = new System.Drawing.Size(99, 36);
            this.SurChange.TabIndex = 6;
            this.SurChange.Text = "Change";
            this.SurChange.UseVisualStyleBackColor = true;
            this.SurChange.Click += new System.EventHandler(this.SurChange_Click);
            // 
            // SurDelete
            // 
            this.SurDelete.Location = new System.Drawing.Point(11, 376);
            this.SurDelete.Name = "SurDelete";
            this.SurDelete.Size = new System.Drawing.Size(99, 41);
            this.SurDelete.TabIndex = 7;
            this.SurDelete.Text = "Delete";
            this.SurDelete.UseVisualStyleBackColor = true;
            this.SurDelete.Click += new System.EventHandler(this.SurDelete_Click);
            // 
            // textBoxBook
            // 
            this.textBoxBook.Location = new System.Drawing.Point(116, 65);
            this.textBoxBook.Multiline = true;
            this.textBoxBook.Name = "textBoxBook";
            this.textBoxBook.Size = new System.Drawing.Size(238, 33);
            this.textBoxBook.TabIndex = 8;
            this.textBoxBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBook_KeyPress);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(116, 143);
            this.textBoxAuthor.Multiline = true;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(239, 33);
            this.textBoxAuthor.TabIndex = 9;
            this.textBoxAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAuthor_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 292);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 36);
            this.textBox3.TabIndex = 10;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 376);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 36);
            this.textBox4.TabIndex = 11;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.uploadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(114, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Name Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(116, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Author";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(116, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter Surname Reader";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(116, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter Days Reading";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxBook);
            this.Controls.Add(this.SurDelete);
            this.Controls.Add(this.SurChange);
            this.Controls.Add(this.SurAdd);
            this.Controls.Add(this.BookDelete);
            this.Controls.Add(this.BookShange);
            this.Controls.Add(this.BookAdd);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button BookAdd;
        private System.Windows.Forms.Button BookShange;
        private System.Windows.Forms.Button BookDelete;
        private System.Windows.Forms.Button SurAdd;
        private System.Windows.Forms.Button SurChange;
        private System.Windows.Forms.Button SurDelete;
        private System.Windows.Forms.TextBox textBoxBook;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

