namespace TimegapDifference
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKontrol1 = new System.Windows.Forms.Button();
            this.btnKontrol2 = new System.Windows.Forms.Button();
            this.btnKontrol3 = new System.Windows.Forms.Button();
            this.btnKontrol4 = new System.Windows.Forms.Button();
            this.btnKontrol5 = new System.Windows.Forms.Button();
            this.btnQNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnQNext);
            this.groupBox1.Controls.Add(this.lst1);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Board";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(35, 67);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(70, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(123, 67);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(70, 20);
            this.txt2.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(213, 67);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(70, 20);
            this.txt3.TabIndex = 2;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(303, 67);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(70, 20);
            this.txt4.TabIndex = 3;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(303, 107);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(168, 108);
            this.lst1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.btnKontrol5);
            this.groupBox2.Controls.Add(this.btnKontrol4);
            this.groupBox2.Controls.Add(this.btnKontrol3);
            this.groupBox2.Controls.Add(this.btnKontrol2);
            this.groupBox2.Controls.Add(this.btnKontrol1);
            this.groupBox2.Location = new System.Drawing.Point(531, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "kontrol";
            // 
            // btnKontrol1
            // 
            this.btnKontrol1.Location = new System.Drawing.Point(28, 47);
            this.btnKontrol1.Name = "btnKontrol1";
            this.btnKontrol1.Size = new System.Drawing.Size(46, 40);
            this.btnKontrol1.TabIndex = 0;
            this.btnKontrol1.Text = "A";
            this.btnKontrol1.UseVisualStyleBackColor = true;
            this.btnKontrol1.Click += new System.EventHandler(this.btnKontrol1_Click);
            // 
            // btnKontrol2
            // 
            this.btnKontrol2.Location = new System.Drawing.Point(80, 47);
            this.btnKontrol2.Name = "btnKontrol2";
            this.btnKontrol2.Size = new System.Drawing.Size(46, 40);
            this.btnKontrol2.TabIndex = 1;
            this.btnKontrol2.Text = "B";
            this.btnKontrol2.UseVisualStyleBackColor = true;
            this.btnKontrol2.Click += new System.EventHandler(this.btnKontrol2_Click);
            // 
            // btnKontrol3
            // 
            this.btnKontrol3.Location = new System.Drawing.Point(132, 46);
            this.btnKontrol3.Name = "btnKontrol3";
            this.btnKontrol3.Size = new System.Drawing.Size(46, 40);
            this.btnKontrol3.TabIndex = 2;
            this.btnKontrol3.Text = "C";
            this.btnKontrol3.UseVisualStyleBackColor = true;
            this.btnKontrol3.Click += new System.EventHandler(this.btnKontrol3_Click);
            // 
            // btnKontrol4
            // 
            this.btnKontrol4.Location = new System.Drawing.Point(184, 46);
            this.btnKontrol4.Name = "btnKontrol4";
            this.btnKontrol4.Size = new System.Drawing.Size(46, 40);
            this.btnKontrol4.TabIndex = 3;
            this.btnKontrol4.Text = "D";
            this.btnKontrol4.UseVisualStyleBackColor = true;
            this.btnKontrol4.Click += new System.EventHandler(this.btnKontrol4_Click);
            // 
            // btnKontrol5
            // 
            this.btnKontrol5.Location = new System.Drawing.Point(184, 92);
            this.btnKontrol5.Name = "btnKontrol5";
            this.btnKontrol5.Size = new System.Drawing.Size(46, 40);
            this.btnKontrol5.TabIndex = 4;
            this.btnKontrol5.Text = "GO";
            this.btnKontrol5.UseVisualStyleBackColor = true;
            this.btnKontrol5.Click += new System.EventHandler(this.btnKontrol5_Click);
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(35, 19);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(158, 32);
            this.btnQNext.TabIndex = 5;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TimegapDifference";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKontrol5;
        private System.Windows.Forms.Button btnKontrol4;
        private System.Windows.Forms.Button btnKontrol3;
        private System.Windows.Forms.Button btnKontrol2;
        private System.Windows.Forms.Button btnKontrol1;
    }
}

