namespace Third
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
            this.SurnameCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textSurUrist = new System.Windows.Forms.TextBox();
            this.butAddUrist = new System.Windows.Forms.Button();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.butDelUr = new System.Windows.Forms.Button();
            this.butChUrist = new System.Windows.Forms.Button();
            this.textSurClient = new System.Windows.Forms.TextBox();
            this.textService = new System.Windows.Forms.TextBox();
            this.textCost = new System.Windows.Forms.TextBox();
            this.butAddCli = new System.Windows.Forms.Button();
            this.butChCli = new System.Windows.Forms.Button();
            this.butDelCli = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butUpload = new System.Windows.Forms.Button();
            this.butPrint = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameCl,
            this.Service,
            this.Cost});
            this.dataGridView1.Location = new System.Drawing.Point(558, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // SurnameCl
            // 
            this.SurnameCl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurnameCl.HeaderText = "Surname Client";
            this.SurnameCl.MinimumWidth = 6;
            this.SurnameCl.Name = "SurnameCl";
            // 
            // Service
            // 
            this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Service.HeaderText = "Service";
            this.Service.MinimumWidth = 6;
            this.Service.Name = "Service";
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cost.HeaderText = "Cost Service";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Number});
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(540, 277);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.HeaderText = "Surname Urist";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // textSurUrist
            // 
            this.textSurUrist.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSurUrist.Location = new System.Drawing.Point(12, 295);
            this.textSurUrist.Multiline = true;
            this.textSurUrist.Name = "textSurUrist";
            this.textSurUrist.Size = new System.Drawing.Size(265, 42);
            this.textSurUrist.TabIndex = 2;
            this.textSurUrist.Text = "Enter Surname";
            this.textSurUrist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSurUrist.Click += new System.EventHandler(this.textSurUrist_Click);
            this.textSurUrist.TextChanged += new System.EventHandler(this.textSurUrist_TextChanged);
            // 
            // butAddUrist
            // 
            this.butAddUrist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butAddUrist.BackgroundImage")));
            this.butAddUrist.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddUrist.Location = new System.Drawing.Point(12, 343);
            this.butAddUrist.Name = "butAddUrist";
            this.butAddUrist.Size = new System.Drawing.Size(175, 34);
            this.butAddUrist.TabIndex = 3;
            this.butAddUrist.Text = "Add Urist";
            this.butAddUrist.UseVisualStyleBackColor = true;
            this.butAddUrist.Click += new System.EventHandler(this.butAddUrist_Click);
            // 
            // textNumber
            // 
            this.textNumber.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNumber.Location = new System.Drawing.Point(287, 295);
            this.textNumber.Multiline = true;
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(265, 42);
            this.textNumber.TabIndex = 4;
            this.textNumber.Text = "Enter Number";
            this.textNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNumber.Click += new System.EventHandler(this.testNumber_Click);
            this.textNumber.TextChanged += new System.EventHandler(this.textNumber_TextChanged);
            this.textNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumber_KeyPress);
            // 
            // butDelUr
            // 
            this.butDelUr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butDelUr.BackgroundImage")));
            this.butDelUr.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelUr.Location = new System.Drawing.Point(377, 343);
            this.butDelUr.Name = "butDelUr";
            this.butDelUr.Size = new System.Drawing.Size(175, 34);
            this.butDelUr.TabIndex = 5;
            this.butDelUr.Text = "Delete Urist";
            this.butDelUr.UseVisualStyleBackColor = true;
            this.butDelUr.Click += new System.EventHandler(this.butDelUr_Click);
            // 
            // butChUrist
            // 
            this.butChUrist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butChUrist.BackgroundImage")));
            this.butChUrist.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butChUrist.Location = new System.Drawing.Point(192, 343);
            this.butChUrist.Name = "butChUrist";
            this.butChUrist.Size = new System.Drawing.Size(180, 34);
            this.butChUrist.TabIndex = 6;
            this.butChUrist.Text = "Change Urist";
            this.butChUrist.UseVisualStyleBackColor = true;
            this.butChUrist.Click += new System.EventHandler(this.butChUrist_Click);
            // 
            // textSurClient
            // 
            this.textSurClient.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSurClient.Location = new System.Drawing.Point(558, 295);
            this.textSurClient.Multiline = true;
            this.textSurClient.Name = "textSurClient";
            this.textSurClient.Size = new System.Drawing.Size(175, 42);
            this.textSurClient.TabIndex = 7;
            this.textSurClient.Text = "Enter Surname Client";
            this.textSurClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSurClient.Click += new System.EventHandler(this.textSurClient_Click);
            // 
            // textService
            // 
            this.textService.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textService.Location = new System.Drawing.Point(741, 295);
            this.textService.Multiline = true;
            this.textService.Name = "textService";
            this.textService.Size = new System.Drawing.Size(175, 42);
            this.textService.TabIndex = 8;
            this.textService.Text = "Enter Service";
            this.textService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textService.Click += new System.EventHandler(this.textService_Click);
            // 
            // textCost
            // 
            this.textCost.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCost.Location = new System.Drawing.Point(923, 295);
            this.textCost.Multiline = true;
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(175, 42);
            this.textCost.TabIndex = 9;
            this.textCost.Text = "Enter Cost";
            this.textCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCost.Click += new System.EventHandler(this.textCost_Click);
            this.textCost.TextChanged += new System.EventHandler(this.textCost_TextChanged);
            this.textCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCost_KeyPress);
            // 
            // butAddCli
            // 
            this.butAddCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butAddCli.BackgroundImage")));
            this.butAddCli.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddCli.Location = new System.Drawing.Point(558, 343);
            this.butAddCli.Name = "butAddCli";
            this.butAddCli.Size = new System.Drawing.Size(175, 34);
            this.butAddCli.TabIndex = 10;
            this.butAddCli.Text = "Add Client";
            this.butAddCli.UseVisualStyleBackColor = true;
            this.butAddCli.Click += new System.EventHandler(this.butAddCli_Click);
            // 
            // butChCli
            // 
            this.butChCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butChCli.BackgroundImage")));
            this.butChCli.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butChCli.Location = new System.Drawing.Point(741, 343);
            this.butChCli.Name = "butChCli";
            this.butChCli.Size = new System.Drawing.Size(175, 34);
            this.butChCli.TabIndex = 11;
            this.butChCli.Text = "Change Client";
            this.butChCli.UseVisualStyleBackColor = true;
            this.butChCli.Click += new System.EventHandler(this.butChCli_Click);
            // 
            // butDelCli
            // 
            this.butDelCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butDelCli.BackgroundImage")));
            this.butDelCli.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelCli.Location = new System.Drawing.Point(923, 343);
            this.butDelCli.Name = "butDelCli";
            this.butDelCli.Size = new System.Drawing.Size(175, 34);
            this.butDelCli.TabIndex = 12;
            this.butDelCli.Text = "Delete Client";
            this.butDelCli.UseVisualStyleBackColor = true;
            this.butDelCli.Click += new System.EventHandler(this.butDelCli_Click);
            // 
            // butSave
            // 
            this.butSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSave.BackgroundImage")));
            this.butSave.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.Location = new System.Drawing.Point(51, 391);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(321, 68);
            this.butSave.TabIndex = 13;
            this.butSave.Text = "Save File";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butUpload
            // 
            this.butUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butUpload.BackgroundImage")));
            this.butUpload.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpload.Location = new System.Drawing.Point(402, 391);
            this.butUpload.Name = "butUpload";
            this.butUpload.Size = new System.Drawing.Size(321, 68);
            this.butUpload.TabIndex = 14;
            this.butUpload.Text = "Upload File";
            this.butUpload.UseVisualStyleBackColor = true;
            this.butUpload.Click += new System.EventHandler(this.butUpload_Click);
            // 
            // butPrint
            // 
            this.butPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butPrint.BackgroundImage")));
            this.butPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butPrint.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPrint.Location = new System.Drawing.Point(756, 391);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(321, 68);
            this.butPrint.TabIndex = 15;
            this.butPrint.Text = "Print Information";
            this.butPrint.UseVisualStyleBackColor = true;
            this.butPrint.Click += new System.EventHandler(this.butPrint_Click);
            // 
            // butExit
            // 
            this.butExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butExit.BackgroundImage")));
            this.butExit.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(476, 481);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(175, 34);
            this.butExit.TabIndex = 16;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 527);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butPrint);
            this.Controls.Add(this.butUpload);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butDelCli);
            this.Controls.Add(this.butChCli);
            this.Controls.Add(this.butAddCli);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.textService);
            this.Controls.Add(this.textSurClient);
            this.Controls.Add(this.butChUrist);
            this.Controls.Add(this.butDelUr);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.butAddUrist);
            this.Controls.Add(this.textSurUrist);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.TextBox textSurUrist;
        private System.Windows.Forms.Button butAddUrist;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Button butDelUr;
        private System.Windows.Forms.Button butChUrist;
        private System.Windows.Forms.TextBox textSurClient;
        private System.Windows.Forms.TextBox textService;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Button butAddCli;
        private System.Windows.Forms.Button butChCli;
        private System.Windows.Forms.Button butDelCli;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butUpload;
        private System.Windows.Forms.Button butPrint;
        private System.Windows.Forms.Button butExit;
    }
}

