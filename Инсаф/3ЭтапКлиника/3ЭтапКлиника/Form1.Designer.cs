
namespace _3ЭтапКлиника
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPatient = new System.Windows.Forms.Button();
            this.Deletepatient = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.SaVeinFile = new System.Windows.Forms.Button();
            this.LoaDinFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AllData = new System.Windows.Forms.Button();
            this.AddVisit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(52, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(201, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Пациент";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(261, 28);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(781, 318);
            this.dataGridView2.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Услуги";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Дата";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Стоимость";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // AddPatient
            // 
            this.AddPatient.AutoSize = true;
            this.AddPatient.Location = new System.Drawing.Point(64, 427);
            this.AddPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Size = new System.Drawing.Size(159, 60);
            this.AddPatient.TabIndex = 2;
            this.AddPatient.Text = "Добавить ";
            this.AddPatient.UseVisualStyleBackColor = true;
            this.AddPatient.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // Deletepatient
            // 
            this.Deletepatient.AutoSize = true;
            this.Deletepatient.Location = new System.Drawing.Point(397, 427);
            this.Deletepatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Deletepatient.Name = "Deletepatient";
            this.Deletepatient.Size = new System.Drawing.Size(159, 60);
            this.Deletepatient.TabIndex = 3;
            this.Deletepatient.Text = "Удалить ";
            this.Deletepatient.UseVisualStyleBackColor = true;
            this.Deletepatient.Click += new System.EventHandler(this.Deletepatient_Click);
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(231, 427);
            this.Change.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(159, 60);
            this.Change.TabIndex = 4;
            this.Change.Text = "Изменить ";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // SaVeinFile
            // 
            this.SaVeinFile.AutoSize = true;
            this.SaVeinFile.Location = new System.Drawing.Point(857, 427);
            this.SaVeinFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaVeinFile.Name = "SaVeinFile";
            this.SaVeinFile.Size = new System.Drawing.Size(185, 55);
            this.SaVeinFile.TabIndex = 5;
            this.SaVeinFile.Text = "Сохранить";
            this.SaVeinFile.UseVisualStyleBackColor = true;
            this.SaVeinFile.Click += new System.EventHandler(this.SaVeinFile_Click);
            // 
            // LoaDinFile
            // 
            this.LoaDinFile.AutoSize = true;
            this.LoaDinFile.Location = new System.Drawing.Point(857, 490);
            this.LoaDinFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoaDinFile.Name = "LoaDinFile";
            this.LoaDinFile.Size = new System.Drawing.Size(185, 55);
            this.LoaDinFile.TabIndex = 6;
            this.LoaDinFile.Text = "Загрузить";
            this.LoaDinFile.UseVisualStyleBackColor = true;
            this.LoaDinFile.Click += new System.EventHandler(this.LoaDinFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 384);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(261, 384);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(560, 384);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(701, 384);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 22);
            this.textBox4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 364);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Услуга";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата посещения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Стоимость";
            // 
            // AllData
            // 
            this.AllData.AutoSize = true;
            this.AllData.Location = new System.Drawing.Point(285, 495);
            this.AllData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllData.Name = "AllData";
            this.AllData.Size = new System.Drawing.Size(208, 59);
            this.AllData.TabIndex = 16;
            this.AllData.Text = "Вывести Всю Информацию";
            this.AllData.UseVisualStyleBackColor = true;
            this.AllData.Click += new System.EventHandler(this.AllData_Click);
            // 
            // AddVisit
            // 
            this.AddVisit.AutoSize = true;
            this.AddVisit.Location = new System.Drawing.Point(560, 427);
            this.AddVisit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddVisit.Name = "AddVisit";
            this.AddVisit.Size = new System.Drawing.Size(159, 60);
            this.AddVisit.TabIndex = 17;
            this.AddVisit.Text = "Добавить Визит";
            this.AddVisit.UseVisualStyleBackColor = true;
            this.AddVisit.Click += new System.EventHandler(this.AddVisit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1075, 561);
            this.Controls.Add(this.AddVisit);
            this.Controls.Add(this.AllData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoaDinFile);
            this.Controls.Add(this.SaVeinFile);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Deletepatient);
            this.Controls.Add(this.AddPatient);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddPatient;
        private System.Windows.Forms.Button Deletepatient;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button SaVeinFile;
        private System.Windows.Forms.Button LoaDinFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AllData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button AddVisit;
    }
}

