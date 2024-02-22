namespace D31
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 243);
            this.label1.TabIndex = 0;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label4_MouseClick);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 31);
            this.label3.TabIndex = 2;
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label4_MouseClick);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 31);
            this.label4.TabIndex = 3;
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label4_MouseClick);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(36, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 190);
            this.panel1.TabIndex = 4;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(352, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 244);
            this.label5.TabIndex = 5;
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label4_MouseClick);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}

