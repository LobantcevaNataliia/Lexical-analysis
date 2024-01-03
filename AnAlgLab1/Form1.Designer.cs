namespace AnAlgLab1
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxProgram = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLex = new System.Windows.Forms.RichTextBox();
            this.dataGridViewLex = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxErr = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLex)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(26, 12);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.Text = "Download";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(119, 12);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 3;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBoxProgram
            // 
            this.richTextBoxProgram.Location = new System.Drawing.Point(12, 42);
            this.richTextBoxProgram.Name = "richTextBoxProgram";
            this.richTextBoxProgram.Size = new System.Drawing.Size(334, 478);
            this.richTextBoxProgram.TabIndex = 4;
            this.richTextBoxProgram.Text = "";
            // 
            // richTextBoxLex
            // 
            this.richTextBoxLex.Location = new System.Drawing.Point(352, 14);
            this.richTextBoxLex.Name = "richTextBoxLex";
            this.richTextBoxLex.Size = new System.Drawing.Size(343, 418);
            this.richTextBoxLex.TabIndex = 5;
            this.richTextBoxLex.Text = "";
            // 
            // dataGridViewLex
            // 
            this.dataGridViewLex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewLex.Location = new System.Drawing.Point(701, 14);
            this.dataGridViewLex.Name = "dataGridViewLex";
            this.dataGridViewLex.RowHeadersVisible = false;
            this.dataGridViewLex.Size = new System.Drawing.Size(293, 506);
            this.dataGridViewLex.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Word";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Class Lexem";
            this.Column2.Name = "Column2";
            // 
            // richTextBoxErr
            // 
            this.richTextBoxErr.Location = new System.Drawing.Point(352, 438);
            this.richTextBoxErr.Name = "richTextBoxErr";
            this.richTextBoxErr.Size = new System.Drawing.Size(343, 82);
            this.richTextBoxErr.TabIndex = 7;
            this.richTextBoxErr.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 532);
            this.Controls.Add(this.richTextBoxErr);
            this.Controls.Add(this.dataGridViewLex);
            this.Controls.Add(this.richTextBoxLex);
            this.Controls.Add(this.richTextBoxProgram);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.OpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBoxProgram;
        private System.Windows.Forms.RichTextBox richTextBoxLex;
        private System.Windows.Forms.DataGridView dataGridViewLex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.RichTextBox richTextBoxErr;
    }
}

