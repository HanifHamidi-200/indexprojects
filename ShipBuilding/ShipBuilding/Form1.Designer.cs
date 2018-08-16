namespace ShipBuilding
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
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lblM1 = new System.Windows.Forms.Label();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.lblM2 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.lblM3 = new System.Windows.Forms.Label();
            this.lbl23 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.lblM4 = new System.Windows.Forms.Label();
            this.lbl24 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnQNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.chk4);
            this.groupBox1.Controls.Add(this.lblM4);
            this.groupBox1.Controls.Add(this.lbl24);
            this.groupBox1.Controls.Add(this.lbl14);
            this.groupBox1.Controls.Add(this.chk3);
            this.groupBox1.Controls.Add(this.lblM3);
            this.groupBox1.Controls.Add(this.lbl23);
            this.groupBox1.Controls.Add(this.lbl13);
            this.groupBox1.Controls.Add(this.chk2);
            this.groupBox1.Controls.Add(this.lblM2);
            this.groupBox1.Controls.Add(this.lbl22);
            this.groupBox1.Controls.Add(this.lbl12);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Controls.Add(this.lblM1);
            this.groupBox1.Controls.Add(this.lbl21);
            this.groupBox1.Controls.Add(this.lbl11);
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.BackColor = System.Drawing.Color.Yellow;
            this.lbl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl11.Location = new System.Drawing.Point(25, 45);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(44, 15);
            this.lbl11.TabIndex = 0;
            this.lbl11.Text = "PART1";
            this.lbl11.Click += new System.EventHandler(this.lbl11_Click);
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.BackColor = System.Drawing.Color.Yellow;
            this.lbl21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl21.Location = new System.Drawing.Point(213, 45);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(44, 15);
            this.lbl21.TabIndex = 1;
            this.lbl21.Text = "PART2";
            this.lbl21.Click += new System.EventHandler(this.lbl21_Click);
            // 
            // lblM1
            // 
            this.lblM1.AutoSize = true;
            this.lblM1.BackColor = System.Drawing.Color.Yellow;
            this.lblM1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblM1.Location = new System.Drawing.Point(127, 45);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(50, 15);
            this.lblM1.TabIndex = 2;
            this.lblM1.Text = "MIDDLE";
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(315, 45);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(50, 17);
            this.chk1.TabIndex = 3;
            this.chk1.Text = "done";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(315, 82);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(50, 17);
            this.chk2.TabIndex = 7;
            this.chk2.Text = "done";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.BackColor = System.Drawing.Color.Yellow;
            this.lblM2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblM2.Location = new System.Drawing.Point(127, 82);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(50, 15);
            this.lblM2.TabIndex = 6;
            this.lblM2.Text = "MIDDLE";
            // 
            // lbl22
            // 
            this.lbl22.AutoSize = true;
            this.lbl22.BackColor = System.Drawing.Color.Yellow;
            this.lbl22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl22.Location = new System.Drawing.Point(213, 82);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(44, 15);
            this.lbl22.TabIndex = 5;
            this.lbl22.Text = "PART2";
            this.lbl22.Click += new System.EventHandler(this.lbl22_Click);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.Yellow;
            this.lbl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl12.Location = new System.Drawing.Point(25, 82);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(44, 15);
            this.lbl12.TabIndex = 4;
            this.lbl12.Text = "PART1";
            this.lbl12.Click += new System.EventHandler(this.lbl12_Click);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(315, 121);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(50, 17);
            this.chk3.TabIndex = 11;
            this.chk3.Text = "done";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // lblM3
            // 
            this.lblM3.AutoSize = true;
            this.lblM3.BackColor = System.Drawing.Color.Yellow;
            this.lblM3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblM3.Location = new System.Drawing.Point(127, 121);
            this.lblM3.Name = "lblM3";
            this.lblM3.Size = new System.Drawing.Size(50, 15);
            this.lblM3.TabIndex = 10;
            this.lblM3.Text = "MIDDLE";
            // 
            // lbl23
            // 
            this.lbl23.AutoSize = true;
            this.lbl23.BackColor = System.Drawing.Color.Yellow;
            this.lbl23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl23.Location = new System.Drawing.Point(213, 121);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(44, 15);
            this.lbl23.TabIndex = 9;
            this.lbl23.Text = "PART2";
            this.lbl23.Click += new System.EventHandler(this.lbl23_Click);
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.BackColor = System.Drawing.Color.Yellow;
            this.lbl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl13.Location = new System.Drawing.Point(25, 121);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(44, 15);
            this.lbl13.TabIndex = 8;
            this.lbl13.Text = "PART1";
            this.lbl13.Click += new System.EventHandler(this.lbl13_Click);
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(315, 162);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(50, 17);
            this.chk4.TabIndex = 15;
            this.chk4.Text = "done";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // lblM4
            // 
            this.lblM4.AutoSize = true;
            this.lblM4.BackColor = System.Drawing.Color.Yellow;
            this.lblM4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblM4.Location = new System.Drawing.Point(127, 162);
            this.lblM4.Name = "lblM4";
            this.lblM4.Size = new System.Drawing.Size(50, 15);
            this.lblM4.TabIndex = 14;
            this.lblM4.Text = "MIDDLE";
            // 
            // lbl24
            // 
            this.lbl24.AutoSize = true;
            this.lbl24.BackColor = System.Drawing.Color.Yellow;
            this.lbl24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl24.Location = new System.Drawing.Point(213, 162);
            this.lbl24.Name = "lbl24";
            this.lbl24.Size = new System.Drawing.Size(44, 15);
            this.lbl24.TabIndex = 13;
            this.lbl24.Text = "PART2";
            this.lbl24.Click += new System.EventHandler(this.lbl24_Click);
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.BackColor = System.Drawing.Color.Yellow;
            this.lbl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl14.Location = new System.Drawing.Point(25, 162);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(44, 15);
            this.lbl14.TabIndex = 12;
            this.lbl14.Text = "PART1";
            this.lbl14.Click += new System.EventHandler(this.lbl14_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Location = new System.Drawing.Point(23, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Yellow;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Location = new System.Drawing.Point(25, 36);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(62, 15);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(483, 33);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(96, 83);
            this.btnQNext.TabIndex = 2;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ShipBuilding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.Label lblM4;
        private System.Windows.Forms.Label lbl24;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.Label lblM3;
        private System.Windows.Forms.Label lbl23;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.Label lbl22;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Label lblM1;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnQNext;
    }
}

