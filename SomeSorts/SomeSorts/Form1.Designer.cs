namespace SomeSorts
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
            this.bt_gen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BubbleText = new System.Windows.Forms.Label();
            this.ShellText = new System.Windows.Forms.Label();
            this.QuickText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_gen
            // 
            this.bt_gen.Location = new System.Drawing.Point(218, 12);
            this.bt_gen.Name = "bt_gen";
            this.bt_gen.Size = new System.Drawing.Size(75, 23);
            this.bt_gen.TabIndex = 0;
            this.bt_gen.Text = "Generate";
            this.bt_gen.UseVisualStyleBackColor = true;
            this.bt_gen.Click += new System.EventHandler(this.bt_gen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // bt_run
            // 
            this.bt_run.Location = new System.Drawing.Point(218, 84);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(75, 23);
            this.bt_run.TabIndex = 0;
            this.bt_run.Text = "Run!";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.bt_run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "size of array";
            // 
            // BubbleText
            // 
            this.BubbleText.AutoSize = true;
            this.BubbleText.Location = new System.Drawing.Point(26, 148);
            this.BubbleText.Name = "BubbleText";
            this.BubbleText.Size = new System.Drawing.Size(39, 13);
            this.BubbleText.TabIndex = 3;
            this.BubbleText.Text = "bubble";
            // 
            // ShellText
            // 
            this.ShellText.AutoSize = true;
            this.ShellText.Location = new System.Drawing.Point(258, 148);
            this.ShellText.Name = "ShellText";
            this.ShellText.Size = new System.Drawing.Size(28, 13);
            this.ShellText.TabIndex = 4;
            this.ShellText.Text = "shell";
            this.ShellText.Click += new System.EventHandler(this.label3_Click);
            // 
            // QuickText
            // 
            this.QuickText.AutoSize = true;
            this.QuickText.Location = new System.Drawing.Point(481, 148);
            this.QuickText.Name = "QuickText";
            this.QuickText.Size = new System.Drawing.Size(33, 13);
            this.QuickText.TabIndex = 7;
            this.QuickText.Text = "quick";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.QuickText);
            this.Controls.Add(this.ShellText);
            this.Controls.Add(this.BubbleText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_run);
            this.Controls.Add(this.bt_gen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_gen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BubbleText;
        private System.Windows.Forms.Label ShellText;
        private System.Windows.Forms.Label QuickText;
    }
}

