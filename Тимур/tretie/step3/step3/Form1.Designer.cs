namespace step3
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
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButAddBefore = new System.Windows.Forms.RadioButton();
            this.radioButAddAfter = new System.Windows.Forms.RadioButton();
            this.butAddTax = new System.Windows.Forms.Button();
            this.textTAX = new System.Windows.Forms.TextBox();
            this.textSUM = new System.Windows.Forms.TextBox();
            this.butChTax = new System.Windows.Forms.Button();
            this.butDelTax = new System.Windows.Forms.Button();
            this.butDelSur = new System.Windows.Forms.Button();
            this.butChSur = new System.Windows.Forms.Button();
            this.butAddSur = new System.Windows.Forms.Button();
            this.textINN = new System.Windows.Forms.TextBox();
            this.textSUR = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butUpload = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.INN});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(361, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // INN
            // 
            this.INN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.INN.HeaderText = "INN";
            this.INN.MinimumWidth = 6;
            this.INN.Name = "INN";
            this.INN.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tax,
            this.Sum});
            this.dataGridView2.Location = new System.Drawing.Point(924, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(333, 365);
            this.dataGridView2.TabIndex = 1;
            // 
            // Tax
            // 
            this.Tax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tax.HeaderText = "Tax";
            this.Tax.MinimumWidth = 6;
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sum.HeaderText = "Sum Tax";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // radioButAddBefore
            // 
            this.radioButAddBefore.AutoSize = true;
            this.radioButAddBefore.Location = new System.Drawing.Point(1043, 383);
            this.radioButAddBefore.Name = "radioButAddBefore";
            this.radioButAddBefore.Size = new System.Drawing.Size(96, 20);
            this.radioButAddBefore.TabIndex = 2;
            this.radioButAddBefore.TabStop = true;
            this.radioButAddBefore.Text = "Add Before";
            this.radioButAddBefore.UseVisualStyleBackColor = true;
            // 
            // radioButAddAfter
            // 
            this.radioButAddAfter.AutoSize = true;
            this.radioButAddAfter.Location = new System.Drawing.Point(1043, 409);
            this.radioButAddAfter.Name = "radioButAddAfter";
            this.radioButAddAfter.Size = new System.Drawing.Size(83, 20);
            this.radioButAddAfter.TabIndex = 3;
            this.radioButAddAfter.TabStop = true;
            this.radioButAddAfter.Text = "Add After";
            this.radioButAddAfter.UseVisualStyleBackColor = true;
            // 
            // butAddTax
            // 
            this.butAddTax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butAddTax.Location = new System.Drawing.Point(924, 383);
            this.butAddTax.Name = "butAddTax";
            this.butAddTax.Size = new System.Drawing.Size(98, 46);
            this.butAddTax.TabIndex = 4;
            this.butAddTax.Text = "Add";
            this.butAddTax.UseVisualStyleBackColor = false;
            this.butAddTax.Click += new System.EventHandler(this.butAddTax_Click);
            // 
            // textTAX
            // 
            this.textTAX.Location = new System.Drawing.Point(1043, 435);
            this.textTAX.Multiline = true;
            this.textTAX.Name = "textTAX";
            this.textTAX.Size = new System.Drawing.Size(214, 46);
            this.textTAX.TabIndex = 5;
            this.textTAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTAX_KeyPress);
            // 
            // textSUM
            // 
            this.textSUM.Location = new System.Drawing.Point(1043, 487);
            this.textSUM.Multiline = true;
            this.textSUM.Name = "textSUM";
            this.textSUM.Size = new System.Drawing.Size(214, 46);
            this.textSUM.TabIndex = 6;
            this.textSUM.TextChanged += new System.EventHandler(this.textSUM_TextChanged);
            this.textSUM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSUM_KeyPress);
            // 
            // butChTax
            // 
            this.butChTax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butChTax.Location = new System.Drawing.Point(924, 435);
            this.butChTax.Name = "butChTax";
            this.butChTax.Size = new System.Drawing.Size(98, 46);
            this.butChTax.TabIndex = 7;
            this.butChTax.Text = "Change";
            this.butChTax.UseVisualStyleBackColor = false;
            this.butChTax.Click += new System.EventHandler(this.butChTax_Click);
            // 
            // butDelTax
            // 
            this.butDelTax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butDelTax.Location = new System.Drawing.Point(924, 487);
            this.butDelTax.Name = "butDelTax";
            this.butDelTax.Size = new System.Drawing.Size(98, 46);
            this.butDelTax.TabIndex = 8;
            this.butDelTax.Text = "Dalete";
            this.butDelTax.UseVisualStyleBackColor = false;
            this.butDelTax.Click += new System.EventHandler(this.butDelTax_Click);
            // 
            // butDelSur
            // 
            this.butDelSur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butDelSur.Location = new System.Drawing.Point(12, 487);
            this.butDelSur.Name = "butDelSur";
            this.butDelSur.Size = new System.Drawing.Size(141, 46);
            this.butDelSur.TabIndex = 11;
            this.butDelSur.Text = "Dalete";
            this.butDelSur.UseVisualStyleBackColor = false;
            this.butDelSur.Click += new System.EventHandler(this.butDelSur_Click);
            // 
            // butChSur
            // 
            this.butChSur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butChSur.Location = new System.Drawing.Point(12, 435);
            this.butChSur.Name = "butChSur";
            this.butChSur.Size = new System.Drawing.Size(141, 46);
            this.butChSur.TabIndex = 10;
            this.butChSur.Text = "Change";
            this.butChSur.UseVisualStyleBackColor = false;
            this.butChSur.Click += new System.EventHandler(this.butChSur_Click);
            // 
            // butAddSur
            // 
            this.butAddSur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butAddSur.Location = new System.Drawing.Point(12, 383);
            this.butAddSur.Name = "butAddSur";
            this.butAddSur.Size = new System.Drawing.Size(141, 46);
            this.butAddSur.TabIndex = 9;
            this.butAddSur.Text = "Add";
            this.butAddSur.UseVisualStyleBackColor = false;
            this.butAddSur.Click += new System.EventHandler(this.butAddSur_Click);
            // 
            // textINN
            // 
            this.textINN.Location = new System.Drawing.Point(159, 435);
            this.textINN.Multiline = true;
            this.textINN.Name = "textINN";
            this.textINN.Size = new System.Drawing.Size(214, 46);
            this.textINN.TabIndex = 13;
            this.textINN.TextChanged += new System.EventHandler(this.textINN_TextChanged);
            this.textINN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textINN_KeyPress);
            // 
            // textSUR
            // 
            this.textSUR.Location = new System.Drawing.Point(159, 383);
            this.textSUR.Multiline = true;
            this.textSUR.Name = "textSUR";
            this.textSUR.Size = new System.Drawing.Size(214, 46);
            this.textSUR.TabIndex = 12;
            this.textSUR.TextChanged += new System.EventHandler(this.textSUR_TextChanged);
            this.textSUR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSur_KeyPress);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butSave.Location = new System.Drawing.Point(537, 491);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(207, 45);
            this.butSave.TabIndex = 15;
            this.butSave.Text = "Save File";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butUpload
            // 
            this.butUpload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butUpload.Location = new System.Drawing.Point(537, 542);
            this.butUpload.Name = "butUpload";
            this.butUpload.Size = new System.Drawing.Size(207, 46);
            this.butUpload.TabIndex = 16;
            this.butUpload.Text = "Upload File";
            this.butUpload.UseVisualStyleBackColor = false;
            this.butUpload.Click += new System.EventHandler(this.butUpload_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(379, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(539, 469);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "Information";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1269, 600);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.butUpload);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.textINN);
            this.Controls.Add(this.textSUR);
            this.Controls.Add(this.butDelSur);
            this.Controls.Add(this.butChSur);
            this.Controls.Add(this.butAddSur);
            this.Controls.Add(this.butDelTax);
            this.Controls.Add(this.butChTax);
            this.Controls.Add(this.textSUM);
            this.Controls.Add(this.textTAX);
            this.Controls.Add(this.butAddTax);
            this.Controls.Add(this.radioButAddAfter);
            this.Controls.Add(this.radioButAddBefore);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn INN;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.RadioButton radioButAddBefore;
        private System.Windows.Forms.RadioButton radioButAddAfter;
        private System.Windows.Forms.Button butAddTax;
        private System.Windows.Forms.TextBox textTAX;
        private System.Windows.Forms.TextBox textSUM;
        private System.Windows.Forms.Button butChTax;
        private System.Windows.Forms.Button butDelTax;
        private System.Windows.Forms.Button butDelSur;
        private System.Windows.Forms.Button butChSur;
        private System.Windows.Forms.Button butAddSur;
        private System.Windows.Forms.TextBox textINN;
        private System.Windows.Forms.TextBox textSUR;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butUpload;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

