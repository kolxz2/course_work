
namespace Urist3этап
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textFamUrist = new System.Windows.Forms.TextBox();
            this.AddUrist = new System.Windows.Forms.Button();
            this.DeleteUrist = new System.Windows.Forms.Button();
            this.ChangeUrist = new System.Windows.Forms.Button();
            this.AddClient = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.textNameClient = new System.Windows.Forms.TextBox();
            this.textServiceClient = new System.Windows.Forms.TextBox();
            this.ChangeClient = new System.Windows.Forms.Button();
            this.SaVeinFile = new System.Windows.Forms.Button();
            this.LoaDinFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textClientCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(7, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(426, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column2});
            this.dataGridView2.Location = new System.Drawing.Point(714, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(421, 348);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Surname";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Service";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cost";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // textFamUrist
            // 
            this.textFamUrist.Location = new System.Drawing.Point(7, 380);
            this.textFamUrist.Name = "textFamUrist";
            this.textFamUrist.Size = new System.Drawing.Size(426, 22);
            this.textFamUrist.TabIndex = 1;
            this.textFamUrist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFamUrist_KeyPress);
            // 
            // AddUrist
            // 
            this.AddUrist.Location = new System.Drawing.Point(7, 408);
            this.AddUrist.Name = "AddUrist";
            this.AddUrist.Size = new System.Drawing.Size(159, 46);
            this.AddUrist.TabIndex = 3;
            this.AddUrist.Text = "Добавить Юриста";
            this.AddUrist.UseVisualStyleBackColor = true;
            this.AddUrist.Click += new System.EventHandler(this.AddUrist_Click);
            // 
            // DeleteUrist
            // 
            this.DeleteUrist.Location = new System.Drawing.Point(279, 408);
            this.DeleteUrist.Name = "DeleteUrist";
            this.DeleteUrist.Size = new System.Drawing.Size(154, 46);
            this.DeleteUrist.TabIndex = 4;
            this.DeleteUrist.Text = "Удалить Юриста";
            this.DeleteUrist.UseVisualStyleBackColor = true;
            this.DeleteUrist.Click += new System.EventHandler(this.DeleteUrist_Click);
            // 
            // ChangeUrist
            // 
            this.ChangeUrist.Location = new System.Drawing.Point(172, 408);
            this.ChangeUrist.Name = "ChangeUrist";
            this.ChangeUrist.Size = new System.Drawing.Size(101, 46);
            this.ChangeUrist.TabIndex = 5;
            this.ChangeUrist.Text = "Изменить";
            this.ChangeUrist.UseVisualStyleBackColor = true;
            this.ChangeUrist.Click += new System.EventHandler(this.ChangeUrist_Click);
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(714, 408);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(155, 46);
            this.AddClient.TabIndex = 6;
            this.AddClient.Text = "Добавить Клиента";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.Location = new System.Drawing.Point(982, 408);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(155, 46);
            this.DeleteClient.TabIndex = 7;
            this.DeleteClient.Text = "Удалить Клиента";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // textNameClient
            // 
            this.textNameClient.Location = new System.Drawing.Point(714, 380);
            this.textNameClient.Name = "textNameClient";
            this.textNameClient.Size = new System.Drawing.Size(199, 22);
            this.textNameClient.TabIndex = 8;
            this.textNameClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNameClient_KeyPress);
            // 
            // textServiceClient
            // 
            this.textServiceClient.Location = new System.Drawing.Point(919, 380);
            this.textServiceClient.Name = "textServiceClient";
            this.textServiceClient.Size = new System.Drawing.Size(125, 22);
            this.textServiceClient.TabIndex = 9;
            this.textServiceClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textServiceClient_KeyPress);
            // 
            // ChangeClient
            // 
            this.ChangeClient.Location = new System.Drawing.Point(875, 408);
            this.ChangeClient.Name = "ChangeClient";
            this.ChangeClient.Size = new System.Drawing.Size(101, 46);
            this.ChangeClient.TabIndex = 10;
            this.ChangeClient.Text = "Изменить ";
            this.ChangeClient.UseVisualStyleBackColor = true;
            this.ChangeClient.Click += new System.EventHandler(this.ChangeClient_Click);
            // 
            // SaVeinFile
            // 
            this.SaVeinFile.AutoSize = true;
            this.SaVeinFile.Location = new System.Drawing.Point(498, 349);
            this.SaVeinFile.Name = "SaVeinFile";
            this.SaVeinFile.Size = new System.Drawing.Size(158, 44);
            this.SaVeinFile.TabIndex = 11;
            this.SaVeinFile.Text = "Сохранить";
            this.SaVeinFile.UseVisualStyleBackColor = true;
            this.SaVeinFile.Click += new System.EventHandler(this.SaVeinFile_Click);
            // 
            // LoaDinFile
            // 
            this.LoaDinFile.AutoSize = true;
            this.LoaDinFile.Location = new System.Drawing.Point(498, 406);
            this.LoaDinFile.Name = "LoaDinFile";
            this.LoaDinFile.Size = new System.Drawing.Size(158, 51);
            this.LoaDinFile.TabIndex = 12;
            this.LoaDinFile.Text = "Загрузить";
            this.LoaDinFile.UseVisualStyleBackColor = true;
            this.LoaDinFile.Click += new System.EventHandler(this.LoaDinFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(922, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Услуга";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // textClientCost
            // 
            this.textClientCost.Location = new System.Drawing.Point(1050, 380);
            this.textClientCost.Name = "textClientCost";
            this.textClientCost.Size = new System.Drawing.Size(85, 22);
            this.textClientCost.TabIndex = 18;
            this.textClientCost.TextChanged += new System.EventHandler(this.textClientCost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1054, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Стоимость";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1150, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textClientCost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoaDinFile);
            this.Controls.Add(this.SaVeinFile);
            this.Controls.Add(this.ChangeClient);
            this.Controls.Add(this.textServiceClient);
            this.Controls.Add(this.textNameClient);
            this.Controls.Add(this.DeleteClient);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.ChangeUrist);
            this.Controls.Add(this.DeleteUrist);
            this.Controls.Add(this.AddUrist);
            this.Controls.Add(this.textFamUrist);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textFamUrist;
        private System.Windows.Forms.Button AddUrist;
        private System.Windows.Forms.Button DeleteUrist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button ChangeUrist;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.TextBox textNameClient;
        private System.Windows.Forms.TextBox textServiceClient;
        private System.Windows.Forms.Button ChangeClient;
        private System.Windows.Forms.Button SaVeinFile;
        private System.Windows.Forms.Button LoaDinFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textClientCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

