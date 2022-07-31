namespace Tretie
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
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butAddPat = new System.Windows.Forms.Button();
            this.butChaPat = new System.Windows.Forms.Button();
            this.butDelPat = new System.Windows.Forms.Button();
            this.butAddVis = new System.Windows.Forms.Button();
            this.butChVis = new System.Windows.Forms.Button();
            this.butDelVis = new System.Windows.Forms.Button();
            this.textPat = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textServ = new System.Windows.Forms.TextBox();
            this.textCost = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butUpload = new System.Windows.Forms.Button();
            this.butChek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patient,
            this.ColVo});
            this.dataGridView1.Location = new System.Drawing.Point(18, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(393, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Patient
            // 
            this.Patient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Patient.HeaderText = "Patient Surname";
            this.Patient.MinimumWidth = 6;
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            // 
            // ColVo
            // 
            this.ColVo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColVo.HeaderText = "Count Visiting";
            this.ColVo.MinimumWidth = 6;
            this.ColVo.Name = "ColVo";
            this.ColVo.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Service,
            this.Cost});
            this.dataGridView2.Location = new System.Drawing.Point(417, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(410, 453);
            this.dataGridView2.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date Visiting";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Service
            // 
            this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Service.HeaderText = "Service";
            this.Service.MinimumWidth = 6;
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добро пожаловать в клинику Доктора Бубновского!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отображение пациентов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Посещения пациентов";
            // 
            // butAddPat
            // 
            this.butAddPat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butAddPat.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.butAddPat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butAddPat.Location = new System.Drawing.Point(847, 149);
            this.butAddPat.Name = "butAddPat";
            this.butAddPat.Size = new System.Drawing.Size(193, 46);
            this.butAddPat.TabIndex = 5;
            this.butAddPat.Text = "Press for Add Patient";
            this.butAddPat.UseVisualStyleBackColor = false;
            this.butAddPat.Click += new System.EventHandler(this.butAddPat_Click);
            // 
            // butChaPat
            // 
            this.butChaPat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butChaPat.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.butChaPat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butChaPat.Location = new System.Drawing.Point(847, 201);
            this.butChaPat.Name = "butChaPat";
            this.butChaPat.Size = new System.Drawing.Size(193, 46);
            this.butChaPat.TabIndex = 6;
            this.butChaPat.Text = "Press for Change Patient";
            this.butChaPat.UseVisualStyleBackColor = false;
            this.butChaPat.Click += new System.EventHandler(this.butChaPat_Click);
            // 
            // butDelPat
            // 
            this.butDelPat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butDelPat.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.butDelPat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butDelPat.Location = new System.Drawing.Point(847, 253);
            this.butDelPat.Name = "butDelPat";
            this.butDelPat.Size = new System.Drawing.Size(193, 46);
            this.butDelPat.TabIndex = 7;
            this.butDelPat.Text = "Press for Delete Patient";
            this.butDelPat.UseVisualStyleBackColor = false;
            this.butDelPat.Click += new System.EventHandler(this.butDelPat_Click);
            // 
            // butAddVis
            // 
            this.butAddVis.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butAddVis.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.butAddVis.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butAddVis.Location = new System.Drawing.Point(847, 379);
            this.butAddVis.Name = "butAddVis";
            this.butAddVis.Size = new System.Drawing.Size(193, 46);
            this.butAddVis.TabIndex = 8;
            this.butAddVis.Text = "Press for Add Visit";
            this.butAddVis.UseVisualStyleBackColor = false;
            this.butAddVis.Click += new System.EventHandler(this.butAddVis_Click);
            // 
            // butChVis
            // 
            this.butChVis.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butChVis.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.butChVis.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butChVis.Location = new System.Drawing.Point(847, 431);
            this.butChVis.Name = "butChVis";
            this.butChVis.Size = new System.Drawing.Size(193, 46);
            this.butChVis.TabIndex = 9;
            this.butChVis.Text = "Press for Change Visit";
            this.butChVis.UseVisualStyleBackColor = false;
            this.butChVis.Click += new System.EventHandler(this.butChVis_Click);
            // 
            // butDelVis
            // 
            this.butDelVis.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butDelVis.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.butDelVis.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butDelVis.Location = new System.Drawing.Point(847, 483);
            this.butDelVis.Name = "butDelVis";
            this.butDelVis.Size = new System.Drawing.Size(193, 46);
            this.butDelVis.TabIndex = 10;
            this.butDelVis.Text = "Press for Delete Visit";
            this.butDelVis.UseVisualStyleBackColor = false;
            this.butDelVis.Click += new System.EventHandler(this.butDelVis_Click);
            // 
            // textPat
            // 
            this.textPat.Location = new System.Drawing.Point(847, 89);
            this.textPat.Multiline = true;
            this.textPat.Name = "textPat";
            this.textPat.Size = new System.Drawing.Size(193, 54);
            this.textPat.TabIndex = 11;
            this.textPat.Text = "\r\nEnter Surname Patient";
            this.textPat.Click += new System.EventHandler(this.textPat_Click);
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(847, 319);
            this.textDate.Multiline = true;
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(193, 54);
            this.textDate.TabIndex = 12;
            this.textDate.Text = "\r\nEnter Date of Visit";
            this.textDate.Click += new System.EventHandler(this.textDate_Click);
            // 
            // textServ
            // 
            this.textServ.Location = new System.Drawing.Point(1046, 319);
            this.textServ.Multiline = true;
            this.textServ.Name = "textServ";
            this.textServ.Size = new System.Drawing.Size(193, 54);
            this.textServ.TabIndex = 13;
            this.textServ.Text = "\r\nEnter Service for Patient";
            this.textServ.Click += new System.EventHandler(this.textServ_Click);
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(1245, 319);
            this.textCost.Multiline = true;
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(132, 54);
            this.textCost.TabIndex = 14;
            this.textCost.Text = "\r\nEnter Cost Service";
            this.textCost.Click += new System.EventHandler(this.textCost_Click);
            this.textCost.TextChanged += new System.EventHandler(this.textCost_TextChanged);
            this.textCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCost_KeyPress);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butSave.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.butSave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butSave.Location = new System.Drawing.Point(1046, 6);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(118, 34);
            this.butSave.TabIndex = 15;
            this.butSave.Text = "Save Table";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butUpload
            // 
            this.butUpload.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butUpload.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.butUpload.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butUpload.Location = new System.Drawing.Point(1170, 6);
            this.butUpload.Name = "butUpload";
            this.butUpload.Size = new System.Drawing.Size(118, 34);
            this.butUpload.TabIndex = 16;
            this.butUpload.Text = "Upload Table";
            this.butUpload.UseVisualStyleBackColor = false;
            this.butUpload.Click += new System.EventHandler(this.butUpload_Click);
            // 
            // butChek
            // 
            this.butChek.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butChek.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.butChek.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butChek.Location = new System.Drawing.Point(889, 6);
            this.butChek.Name = "butChek";
            this.butChek.Size = new System.Drawing.Size(151, 34);
            this.butChek.TabIndex = 17;
            this.butChek.Text = "Chek Information";
            this.butChek.UseVisualStyleBackColor = false;
            this.butChek.Click += new System.EventHandler(this.butChek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1409, 565);
            this.Controls.Add(this.butChek);
            this.Controls.Add(this.butUpload);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.textServ);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textPat);
            this.Controls.Add(this.butDelVis);
            this.Controls.Add(this.butChVis);
            this.Controls.Add(this.butAddVis);
            this.Controls.Add(this.butDelPat);
            this.Controls.Add(this.butChaPat);
            this.Controls.Add(this.butAddPat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Button butAddPat;
        private System.Windows.Forms.Button butChaPat;
        private System.Windows.Forms.Button butDelPat;
        private System.Windows.Forms.Button butAddVis;
        private System.Windows.Forms.Button butChVis;
        private System.Windows.Forms.Button butDelVis;
        private System.Windows.Forms.TextBox textPat;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textServ;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butUpload;
        private System.Windows.Forms.Button butChek;
    }
}

