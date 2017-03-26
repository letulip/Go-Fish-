namespace Chapter_8___Long_Exercise_Go_Fish_
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxYourName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbxYourHand = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxGameProgress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxBooks = new System.Windows.Forms.TextBox();
            this.btnCardAsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            // 
            // tbxYourName
            // 
            this.tbxYourName.Location = new System.Drawing.Point(13, 30);
            this.tbxYourName.Name = "tbxYourName";
            this.tbxYourName.Size = new System.Drawing.Size(100, 20);
            this.tbxYourName.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(120, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(176, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start the game!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbxYourHand
            // 
            this.lbxYourHand.FormattingEnabled = true;
            this.lbxYourHand.Location = new System.Drawing.Point(303, 30);
            this.lbxYourHand.Name = "lbxYourHand";
            this.lbxYourHand.Size = new System.Drawing.Size(181, 433);
            this.lbxYourHand.TabIndex = 3;
            this.lbxYourHand.DoubleClick += new System.EventHandler(this.btnCardAsk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your hand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Game progress";
            // 
            // tbxGameProgress
            // 
            this.tbxGameProgress.Location = new System.Drawing.Point(13, 70);
            this.tbxGameProgress.Multiline = true;
            this.tbxGameProgress.Name = "tbxGameProgress";
            this.tbxGameProgress.ReadOnly = true;
            this.tbxGameProgress.Size = new System.Drawing.Size(283, 295);
            this.tbxGameProgress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Books";
            // 
            // tbxBooks
            // 
            this.tbxBooks.Location = new System.Drawing.Point(16, 389);
            this.tbxBooks.Multiline = true;
            this.tbxBooks.Name = "tbxBooks";
            this.tbxBooks.ReadOnly = true;
            this.tbxBooks.Size = new System.Drawing.Size(280, 108);
            this.tbxBooks.TabIndex = 8;
            // 
            // btnCardAsk
            // 
            this.btnCardAsk.Enabled = false;
            this.btnCardAsk.Location = new System.Drawing.Point(303, 474);
            this.btnCardAsk.Name = "btnCardAsk";
            this.btnCardAsk.Size = new System.Drawing.Size(181, 23);
            this.btnCardAsk.TabIndex = 9;
            this.btnCardAsk.Text = "Ask for a card";
            this.btnCardAsk.UseVisualStyleBackColor = true;
            this.btnCardAsk.Click += new System.EventHandler(this.btnCardAsk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 509);
            this.Controls.Add(this.btnCardAsk);
            this.Controls.Add(this.tbxBooks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxGameProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxYourHand);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxYourName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxYourName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbxYourHand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxGameProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxBooks;
        private System.Windows.Forms.Button btnCardAsk;
    }
}

