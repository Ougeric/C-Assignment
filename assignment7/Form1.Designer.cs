namespace assignment7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStartUrl = new System.Windows.Forms.TextBox();
            this.lstCrawled = new System.Windows.Forms.ListBox();
            this.lstErrors = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStartUrl
            // 
            this.txtStartUrl.Location = new System.Drawing.Point(55, 56);
            this.txtStartUrl.Name = "txtStartUrl";
            this.txtStartUrl.Size = new System.Drawing.Size(183, 28);
            this.txtStartUrl.TabIndex = 0;
            this.txtStartUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstCrawled
            // 
            this.lstCrawled.FormattingEnabled = true;
            this.lstCrawled.ItemHeight = 18;
            this.lstCrawled.Location = new System.Drawing.Point(55, 186);
            this.lstCrawled.Name = "lstCrawled";
            this.lstCrawled.Size = new System.Drawing.Size(253, 94);
            this.lstCrawled.TabIndex = 1;
            this.lstCrawled.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstErrors
            // 
            this.lstErrors.FormattingEnabled = true;
            this.lstErrors.ItemHeight = 18;
            this.lstErrors.Location = new System.Drawing.Point(55, 313);
            this.lstErrors.Name = "lstErrors";
            this.lstErrors.Size = new System.Drawing.Size(253, 94);
            this.lstErrors.TabIndex = 2;
            this.lstErrors.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(91, 116);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 37);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstErrors);
            this.Controls.Add(this.lstCrawled);
            this.Controls.Add(this.txtStartUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartUrl;
        private System.Windows.Forms.ListBox lstCrawled;
        private System.Windows.Forms.ListBox lstErrors;
        private System.Windows.Forms.Button btnStart;
    }
}

