
namespace Этап3
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VivoDinf = new System.Windows.Forms.Button();
            this.AddEmpl = new System.Windows.Forms.Button();
            this.DeleteEmpl = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.SavEinFile = new System.Windows.Forms.Button();
            this.LoaDinGrid = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(330, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Имя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Должность";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Стаж";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Оклад";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // VivoDinf
            // 
            this.VivoDinf.AutoSize = true;
            this.VivoDinf.Location = new System.Drawing.Point(714, 460);
            this.VivoDinf.Name = "VivoDinf";
            this.VivoDinf.Size = new System.Drawing.Size(238, 43);
            this.VivoDinf.TabIndex = 1;
            this.VivoDinf.Text = "Вывод Всей Информации";
            this.VivoDinf.UseVisualStyleBackColor = true;
            this.VivoDinf.Click += new System.EventHandler(this.VivoDinf_Click);
            // 
            // AddEmpl
            // 
            this.AddEmpl.AutoSize = true;
            this.AddEmpl.Location = new System.Drawing.Point(278, 460);
            this.AddEmpl.Name = "AddEmpl";
            this.AddEmpl.Size = new System.Drawing.Size(238, 43);
            this.AddEmpl.TabIndex = 2;
            this.AddEmpl.Text = "Добавить Сотрудника ";
            this.AddEmpl.UseVisualStyleBackColor = true;
            this.AddEmpl.Click += new System.EventHandler(this.AddEmpl_Click);
            // 
            // DeleteEmpl
            // 
            this.DeleteEmpl.AutoSize = true;
            this.DeleteEmpl.Location = new System.Drawing.Point(522, 460);
            this.DeleteEmpl.Name = "DeleteEmpl";
            this.DeleteEmpl.Size = new System.Drawing.Size(186, 43);
            this.DeleteEmpl.TabIndex = 3;
            this.DeleteEmpl.Text = "Удалить Сотрудника";
            this.DeleteEmpl.UseVisualStyleBackColor = true;
            this.DeleteEmpl.Click += new System.EventHandler(this.DeleteEmpl_Click);
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(522, 509);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(186, 43);
            this.Change.TabIndex = 4;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // SavEinFile
            // 
            this.SavEinFile.AutoSize = true;
            this.SavEinFile.Location = new System.Drawing.Point(330, 509);
            this.SavEinFile.Name = "SavEinFile";
            this.SavEinFile.Size = new System.Drawing.Size(186, 43);
            this.SavEinFile.TabIndex = 5;
            this.SavEinFile.Text = "Сохранить";
            this.SavEinFile.UseVisualStyleBackColor = true;
            this.SavEinFile.Click += new System.EventHandler(this.SavEinFile_Click);
            // 
            // LoaDinGrid
            // 
            this.LoaDinGrid.AutoSize = true;
            this.LoaDinGrid.Location = new System.Drawing.Point(714, 509);
            this.LoaDinGrid.Name = "LoaDinGrid";
            this.LoaDinGrid.Size = new System.Drawing.Size(186, 43);
            this.LoaDinGrid.TabIndex = 6;
            this.LoaDinGrid.Text = "Загрузить";
            this.LoaDinGrid.UseVisualStyleBackColor = true;
            this.LoaDinGrid.Click += new System.EventHandler(this.LoaDinGrid_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(522, 433);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(689, 433);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(777, 433);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 22);
            this.textBox4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(403, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(532, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(701, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Стаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(799, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Оклад";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(76, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Организация \"Вова\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1236, 584);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoaDinGrid);
            this.Controls.Add(this.SavEinFile);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.DeleteEmpl);
            this.Controls.Add(this.AddEmpl);
            this.Controls.Add(this.VivoDinf);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button VivoDinf;
        private System.Windows.Forms.Button AddEmpl;
        private System.Windows.Forms.Button DeleteEmpl;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button SavEinFile;
        private System.Windows.Forms.Button LoaDinGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

