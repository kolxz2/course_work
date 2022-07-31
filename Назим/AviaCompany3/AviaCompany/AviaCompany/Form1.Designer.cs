namespace AviaCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butAddSur = new System.Windows.Forms.Button();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textCost = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.butChSurn = new System.Windows.Forms.Button();
            this.butDelSur = new System.Windows.Forms.Button();
            this.butAddPol = new System.Windows.Forms.Button();
            this.butChPol = new System.Windows.Forms.Button();
            this.butDelPol = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butUpload = new System.Windows.Forms.Button();
            this.butInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname});
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(252, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.HeaderText = "Surname BOOM";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Cost});
            this.dataGridView2.Location = new System.Drawing.Point(270, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(458, 317);
            this.dataGridView2.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // butAddSur
            // 
            this.butAddSur.Location = new System.Drawing.Point(12, 383);
            this.butAddSur.Name = "butAddSur";
            this.butAddSur.Size = new System.Drawing.Size(252, 44);
            this.butAddSur.TabIndex = 2;
            this.butAddSur.Text = "Add Surname";
            this.butAddSur.UseVisualStyleBackColor = true;
            this.butAddSur.Click += new System.EventHandler(this.butAddSur_Click);
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(12, 344);
            this.textSurname.Multiline = true;
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(252, 33);
            this.textSurname.TabIndex = 3;
            this.textSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSurname_KeyPress);
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(493, 344);
            this.textCost.Multiline = true;
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(235, 33);
            this.textCost.TabIndex = 4;
            this.textCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCost_KeyPress);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Highlight;
            this.monthCalendar.Location = new System.Drawing.Point(270, 344);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 5;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // butChSurn
            // 
            this.butChSurn.Location = new System.Drawing.Point(12, 445);
            this.butChSurn.Name = "butChSurn";
            this.butChSurn.Size = new System.Drawing.Size(252, 44);
            this.butChSurn.TabIndex = 6;
            this.butChSurn.Text = "Change Surname";
            this.butChSurn.UseVisualStyleBackColor = true;
            this.butChSurn.Click += new System.EventHandler(this.butChSurn_Click);
            // 
            // butDelSur
            // 
            this.butDelSur.Location = new System.Drawing.Point(12, 507);
            this.butDelSur.Name = "butDelSur";
            this.butDelSur.Size = new System.Drawing.Size(252, 44);
            this.butDelSur.TabIndex = 7;
            this.butDelSur.Text = "Delete Surname";
            this.butDelSur.UseVisualStyleBackColor = true;
            this.butDelSur.Click += new System.EventHandler(this.butDelSur_Click);
            // 
            // butAddPol
            // 
            this.butAddPol.Location = new System.Drawing.Point(493, 383);
            this.butAddPol.Name = "butAddPol";
            this.butAddPol.Size = new System.Drawing.Size(235, 44);
            this.butAddPol.TabIndex = 8;
            this.butAddPol.Text = "Add Polet";
            this.butAddPol.UseVisualStyleBackColor = true;
            this.butAddPol.Click += new System.EventHandler(this.butAddPol_Click);
            // 
            // butChPol
            // 
            this.butChPol.Location = new System.Drawing.Point(493, 445);
            this.butChPol.Name = "butChPol";
            this.butChPol.Size = new System.Drawing.Size(235, 44);
            this.butChPol.TabIndex = 9;
            this.butChPol.Text = "Change Polet";
            this.butChPol.UseVisualStyleBackColor = true;
            this.butChPol.Click += new System.EventHandler(this.butChPol_Click);
            // 
            // butDelPol
            // 
            this.butDelPol.Location = new System.Drawing.Point(493, 507);
            this.butDelPol.Name = "butDelPol";
            this.butDelPol.Size = new System.Drawing.Size(235, 44);
            this.butDelPol.TabIndex = 10;
            this.butDelPol.Text = "Delete Polet";
            this.butDelPol.UseVisualStyleBackColor = true;
            this.butDelPol.Click += new System.EventHandler(this.butDelPol_Click);
            // 
            // butSave
            // 
            this.butSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSave.BackgroundImage")));
            this.butSave.ForeColor = System.Drawing.Color.Red;
            this.butSave.Location = new System.Drawing.Point(734, 91);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(148, 50);
            this.butSave.TabIndex = 11;
            this.butSave.Text = "Save File";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butUpload
            // 
            this.butUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butUpload.BackgroundImage")));
            this.butUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butUpload.ForeColor = System.Drawing.Color.Red;
            this.butUpload.Location = new System.Drawing.Point(734, 147);
            this.butUpload.Name = "butUpload";
            this.butUpload.Size = new System.Drawing.Size(148, 50);
            this.butUpload.TabIndex = 12;
            this.butUpload.Text = "Upload File";
            this.butUpload.UseVisualStyleBackColor = true;
            this.butUpload.Click += new System.EventHandler(this.butUpload_Click);
            // 
            // butInfo
            // 
            this.butInfo.Location = new System.Drawing.Point(734, 279);
            this.butInfo.Name = "butInfo";
            this.butInfo.Size = new System.Drawing.Size(235, 44);
            this.butInfo.TabIndex = 13;
            this.butInfo.Text = "Info";
            this.butInfo.UseVisualStyleBackColor = true;
            this.butInfo.Click += new System.EventHandler(this.butInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 556);
            this.Controls.Add(this.butInfo);
            this.Controls.Add(this.butUpload);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butDelPol);
            this.Controls.Add(this.butChPol);
            this.Controls.Add(this.butAddPol);
            this.Controls.Add(this.butDelSur);
            this.Controls.Add(this.butChSurn);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.butAddSur);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Button butAddSur;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button butChSurn;
        private System.Windows.Forms.Button butDelSur;
        private System.Windows.Forms.Button butAddPol;
        private System.Windows.Forms.Button butChPol;
        private System.Windows.Forms.Button butDelPol;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butUpload;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.Button butInfo;
    }
}

