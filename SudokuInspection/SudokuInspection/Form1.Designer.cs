namespace SudokuInspection
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
            this.lstShow1 = new System.Windows.Forms.ListBox();
            this.btnShow1 = new System.Windows.Forms.Button();
            this.txtShow1 = new System.Windows.Forms.TextBox();
            this.txtShow2 = new System.Windows.Forms.TextBox();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.lstShow2 = new System.Windows.Forms.ListBox();
            this.btnQNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstShow1
            // 
            this.lstShow1.FormattingEnabled = true;
            this.lstShow1.Location = new System.Drawing.Point(49, 88);
            this.lstShow1.Name = "lstShow1";
            this.lstShow1.Size = new System.Drawing.Size(337, 238);
            this.lstShow1.TabIndex = 0;
            // 
            // btnShow1
            // 
            this.btnShow1.Location = new System.Drawing.Point(34, 50);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(130, 32);
            this.btnShow1.TabIndex = 1;
            this.btnShow1.Text = "Show 1/1";
            this.btnShow1.UseVisualStyleBackColor = true;
            // 
            // txtShow1
            // 
            this.txtShow1.BackColor = System.Drawing.Color.Yellow;
            this.txtShow1.Location = new System.Drawing.Point(170, 50);
            this.txtShow1.Name = "txtShow1";
            this.txtShow1.Size = new System.Drawing.Size(73, 20);
            this.txtShow1.TabIndex = 2;
            // 
            // txtShow2
            // 
            this.txtShow2.BackColor = System.Drawing.Color.Yellow;
            this.txtShow2.Location = new System.Drawing.Point(559, 50);
            this.txtShow2.Name = "txtShow2";
            this.txtShow2.Size = new System.Drawing.Size(73, 20);
            this.txtShow2.TabIndex = 5;
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(423, 50);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(130, 32);
            this.btnShow2.TabIndex = 4;
            this.btnShow2.Text = "Show 1/1";
            this.btnShow2.UseVisualStyleBackColor = true;
            // 
            // lstShow2
            // 
            this.lstShow2.FormattingEnabled = true;
            this.lstShow2.Location = new System.Drawing.Point(438, 88);
            this.lstShow2.Name = "lstShow2";
            this.lstShow2.Size = new System.Drawing.Size(337, 238);
            this.lstShow2.TabIndex = 3;
            // 
            // btnQNext
            // 
            this.btnQNext.Location = new System.Drawing.Point(34, 12);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(130, 32);
            this.btnQNext.TabIndex = 6;
            this.btnQNext.Text = "QNext";
            this.btnQNext.UseVisualStyleBackColor = true;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 435);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.txtShow2);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.lstShow2);
            this.Controls.Add(this.txtShow1);
            this.Controls.Add(this.btnShow1);
            this.Controls.Add(this.lstShow1);
            this.Name = "Form1";
            this.Text = "SudokuInspection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstShow1;
        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.TextBox txtShow1;
        private System.Windows.Forms.TextBox txtShow2;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.ListBox lstShow2;
        private System.Windows.Forms.Button btnQNext;
    }
}

