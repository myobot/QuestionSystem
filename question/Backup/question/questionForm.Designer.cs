namespace question
{
    partial class questionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(questionForm));
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboSubjectNumber = new System.Windows.Forms.ComboBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(20, 420);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAnswer.TabIndex = 25;
            this.btnCheckAnswer.Text = "检查试卷";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(349, 420);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(254, 420);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 23;
            this.btnLast.Text = "上一题";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboSubjectNumber);
            this.groupBox2.Controls.Add(this.rdb1);
            this.groupBox2.Controls.Add(this.rdb2);
            this.groupBox2.Controls.Add(this.rdb3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(20, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附加信息";
            // 
            // cboSubjectNumber
            // 
            this.cboSubjectNumber.FormattingEnabled = true;
            this.cboSubjectNumber.Location = new System.Drawing.Point(94, 74);
            this.cboSubjectNumber.Name = "cboSubjectNumber";
            this.cboSubjectNumber.Size = new System.Drawing.Size(65, 20);
            this.cboSubjectNumber.TabIndex = 19;
            this.cboSubjectNumber.SelectedIndexChanged += new System.EventHandler(this.cboSubjectNumber_SelectedIndexChanged);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(338, 33);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(29, 16);
            this.rdb1.TabIndex = 18;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "1";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(234, 33);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(29, 16);
            this.rdb2.TabIndex = 17;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "2";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(130, 33);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(29, 16);
            this.rdb3.TabIndex = 16;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "3";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "难度级别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "题号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbD);
            this.groupBox1.Controls.Add(this.rdbC);
            this.groupBox1.Controls.Add(this.rdbB);
            this.groupBox1.Controls.Add(this.rdbA);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.txtQuestion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 270);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "试题基本信息";
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(393, 241);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(29, 16);
            this.rdbD.TabIndex = 15;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D";
            this.rdbD.UseVisualStyleBackColor = true;
            this.rdbD.Click += new System.EventHandler(this.chooseAnswer_click);
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(289, 241);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(29, 16);
            this.rdbC.TabIndex = 14;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C";
            this.rdbC.UseVisualStyleBackColor = true;
            this.rdbC.Click += new System.EventHandler(this.chooseAnswer_click);
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(185, 241);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(29, 16);
            this.rdbB.TabIndex = 13;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B";
            this.rdbB.UseVisualStyleBackColor = true;
            this.rdbB.Click += new System.EventHandler(this.chooseAnswer_click);
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(81, 241);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(29, 16);
            this.rdbA.TabIndex = 12;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = true;
            this.rdbA.Click += new System.EventHandler(this.chooseAnswer_click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "A";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(128, 202);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(276, 21);
            this.txtD.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(128, 166);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(276, 21);
            this.txtC.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(128, 130);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(276, 21);
            this.txtB.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(128, 94);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(276, 21);
            this.txtA.TabIndex = 4;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(94, 20);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(310, 55);
            this.txtQuestion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "选择答案";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选项";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "问题";
            // 
            // questionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 456);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "questionForm";
            this.Text = "答题界面";
            this.Load += new System.EventHandler(this.questionForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboSubjectNumber;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}