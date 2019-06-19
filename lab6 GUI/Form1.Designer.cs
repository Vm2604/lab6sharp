namespace lab6_GUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.Digit = new System.Windows.Forms.TextBox();
            this.Main_thread = new System.Windows.Forms.RichTextBox();
            this.Diapason = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Digit
            // 
            this.Digit.Location = new System.Drawing.Point(342, 53);
            this.Digit.Name = "Digit";
            this.Digit.Size = new System.Drawing.Size(111, 22);
            this.Digit.TabIndex = 1;
            // 
            // Main_thread
            // 
            this.Main_thread.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Main_thread.Location = new System.Drawing.Point(409, 161);
            this.Main_thread.Name = "Main_thread";
            this.Main_thread.ReadOnly = true;
            this.Main_thread.Size = new System.Drawing.Size(368, 120);
            this.Main_thread.TabIndex = 2;
            this.Main_thread.Text = "";
            this.Main_thread.TextChanged += new System.EventHandler(this.Main_thread_TextChanged);
            // 
            // Diapason
            // 
            this.Diapason.AutoSize = true;
            this.Diapason.Location = new System.Drawing.Point(362, 22);
            this.Diapason.Name = "Diapason";
            this.Diapason.Size = new System.Drawing.Size(68, 17);
            this.Diapason.TabIndex = 3;
            this.Diapason.Text = "Diapason";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.Location = new System.Drawing.Point(21, 161);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(359, 120);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "От 0 до половины указаного диапазона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Во всем диапазоне";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Diapason);
            this.Controls.Add(this.Main_thread);
            this.Controls.Add(this.Digit);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(818, 340);
            this.MinimumSize = new System.Drawing.Size(818, 340);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Digit;
        private System.Windows.Forms.RichTextBox Main_thread;
        private System.Windows.Forms.Label Diapason;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

