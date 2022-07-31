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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butAddOrg = new System.Windows.Forms.Button();
            this.textOrg = new System.Windows.Forms.TextBox();
            this.butChOrg = new System.Windows.Forms.Button();
            this.butDelOrg = new System.Windows.Forms.Button();
            this.butDelSer = new System.Windows.Forms.Button();
            this.butChSer = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.butAddSer = new System.Windows.Forms.Button();
            this.textSal = new System.Windows.Forms.TextBox();
            this.textWork = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.butUpload = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameOrg});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(277, 553);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Work,
            this.Salary});
            this.dataGridView2.Location = new System.Drawing.Point(295, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(442, 553);
            this.dataGridView2.TabIndex = 1;
            // 
            // nameOrg
            // 
            this.nameOrg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameOrg.HeaderText = "Name Organization";
            this.nameOrg.MinimumWidth = 6;
            this.nameOrg.Name = "nameOrg";
            this.nameOrg.ReadOnly = true;
            // 
            // butAddOrg
            // 
            this.butAddOrg.Location = new System.Drawing.Point(1026, 106);
            this.butAddOrg.Name = "butAddOrg";
            this.butAddOrg.Size = new System.Drawing.Size(181, 38);
            this.butAddOrg.TabIndex = 2;
            this.butAddOrg.Text = "Add";
            this.butAddOrg.UseVisualStyleBackColor = true;
            this.butAddOrg.Click += new System.EventHandler(this.butAddOrg_Click);
            // 
            // textOrg
            // 
            this.textOrg.Location = new System.Drawing.Point(1026, 62);
            this.textOrg.Multiline = true;
            this.textOrg.Name = "textOrg";
            this.textOrg.Size = new System.Drawing.Size(181, 38);
            this.textOrg.TabIndex = 5;
            // 
            // butChOrg
            // 
            this.butChOrg.Location = new System.Drawing.Point(1026, 150);
            this.butChOrg.Name = "butChOrg";
            this.butChOrg.Size = new System.Drawing.Size(181, 38);
            this.butChOrg.TabIndex = 6;
            this.butChOrg.Text = "Change";
            this.butChOrg.UseVisualStyleBackColor = true;
            this.butChOrg.Click += new System.EventHandler(this.butChOrg_Click);
            // 
            // butDelOrg
            // 
            this.butDelOrg.Location = new System.Drawing.Point(1026, 194);
            this.butDelOrg.Name = "butDelOrg";
            this.butDelOrg.Size = new System.Drawing.Size(181, 38);
            this.butDelOrg.TabIndex = 7;
            this.butDelOrg.Text = "Delete";
            this.butDelOrg.UseVisualStyleBackColor = true;
            this.butDelOrg.Click += new System.EventHandler(this.butDelOrg_Click);
            // 
            // butDelSer
            // 
            this.butDelSer.Location = new System.Drawing.Point(1026, 506);
            this.butDelSer.Name = "butDelSer";
            this.butDelSer.Size = new System.Drawing.Size(181, 38);
            this.butDelSer.TabIndex = 11;
            this.butDelSer.Text = "Delete";
            this.butDelSer.UseVisualStyleBackColor = true;
            this.butDelSer.Click += new System.EventHandler(this.butDelSer_Click);
            // 
            // butChSer
            // 
            this.butChSer.Location = new System.Drawing.Point(1026, 462);
            this.butChSer.Name = "butChSer";
            this.butChSer.Size = new System.Drawing.Size(181, 38);
            this.butChSer.TabIndex = 10;
            this.butChSer.Text = "Change";
            this.butChSer.UseVisualStyleBackColor = true;
            this.butChSer.Click += new System.EventHandler(this.butChSer_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(1026, 283);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(181, 38);
            this.textName.TabIndex = 9;
            // 
            // butAddSer
            // 
            this.butAddSer.Location = new System.Drawing.Point(1026, 418);
            this.butAddSer.Name = "butAddSer";
            this.butAddSer.Size = new System.Drawing.Size(181, 38);
            this.butAddSer.TabIndex = 8;
            this.butAddSer.Text = "Add";
            this.butAddSer.UseVisualStyleBackColor = true;
            this.butAddSer.Click += new System.EventHandler(this.butAddSer_Click);
            // 
            // textSal
            // 
            this.textSal.Location = new System.Drawing.Point(1026, 371);
            this.textSal.Multiline = true;
            this.textSal.Name = "textSal";
            this.textSal.Size = new System.Drawing.Size(181, 38);
            this.textSal.TabIndex = 12;
            // 
            // textWork
            // 
            this.textWork.Location = new System.Drawing.Point(1026, 327);
            this.textWork.Multiline = true;
            this.textWork.Name = "textWork";
            this.textWork.Size = new System.Drawing.Size(181, 38);
            this.textWork.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(771, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Input Name Organization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(896, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Input Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(896, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Input Work";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(896, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Input Salary";
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(743, 12);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(181, 38);
            this.butSave.TabIndex = 18;
            this.butSave.Text = "Save file";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butUpload
            // 
            this.butUpload.Location = new System.Drawing.Point(930, 12);
            this.butUpload.Name = "butUpload";
            this.butUpload.Size = new System.Drawing.Size(181, 38);
            this.butUpload.TabIndex = 19;
            this.butUpload.Text = "Upload file";
            this.butUpload.UseVisualStyleBackColor = true;
            this.butUpload.Click += new System.EventHandler(this.butUpload_Click);
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Names.HeaderText = "Name";
            this.Names.MinimumWidth = 6;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // Work
            // 
            this.Work.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Work.HeaderText = "Work";
            this.Work.MinimumWidth = 6;
            this.Work.Name = "Work";
            this.Work.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 577);
            this.Controls.Add(this.butUpload);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textWork);
            this.Controls.Add(this.textSal);
            this.Controls.Add(this.butDelSer);
            this.Controls.Add(this.butChSer);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.butAddSer);
            this.Controls.Add(this.butDelOrg);
            this.Controls.Add(this.butChOrg);
            this.Controls.Add(this.textOrg);
            this.Controls.Add(this.butAddOrg);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOrg;
        private System.Windows.Forms.Button butAddOrg;
        private System.Windows.Forms.TextBox textOrg;
        private System.Windows.Forms.Button butChOrg;
        private System.Windows.Forms.Button butDelOrg;
        private System.Windows.Forms.Button butDelSer;
        private System.Windows.Forms.Button butChSer;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button butAddSer;
        private System.Windows.Forms.TextBox textSal;
        private System.Windows.Forms.TextBox textWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butUpload;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}

