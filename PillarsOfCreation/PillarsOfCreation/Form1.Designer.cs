namespace PillarsOfCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.btnQNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.Lime;
            this.txt1.Location = new System.Drawing.Point(87, 242);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(115, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.Lime;
            this.txt2.Location = new System.Drawing.Point(134, 125);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(115, 20);
            this.txt2.TabIndex = 2;
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.Color.Lime;
            this.txt3.Location = new System.Drawing.Point(217, 151);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(115, 20);
            this.txt3.TabIndex = 3;
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.Color.Lime;
            this.txt4.Location = new System.Drawing.Point(366, 228);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(115, 20);
            this.txt4.TabIndex = 4;
            // 
            // btnQNext
            // 
            this.btnQNext.Location = new System.Drawing.Point(721, 61);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(114, 60);
            this.btnQNext.TabIndex = 5;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = true;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "PillarsOfCreation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button btnQNext;
    }
}

