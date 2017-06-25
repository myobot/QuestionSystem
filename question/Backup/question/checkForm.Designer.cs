namespace question
{
    partial class checkForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJiaoJuan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnJiaoJuan
            // 
            this.btnJiaoJuan.Location = new System.Drawing.Point(383, 339);
            this.btnJiaoJuan.Name = "btnJiaoJuan";
            this.btnJiaoJuan.Size = new System.Drawing.Size(75, 23);
            this.btnJiaoJuan.TabIndex = 1;
            this.btnJiaoJuan.Text = "交卷";
            this.btnJiaoJuan.UseVisualStyleBackColor = true;
            this.btnJiaoJuan.Click += new System.EventHandler(this.btnJiaoJuan_Click);
            // 
            // checkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 369);
            this.Controls.Add(this.btnJiaoJuan);
            this.Controls.Add(this.groupBox1);
            this.Name = "checkForm";
            this.Text = "checkForm";
            this.Load += new System.EventHandler(this.checkForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJiaoJuan;
    }
}