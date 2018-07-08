namespace BusinessApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.lst3 = new System.Windows.Forms.ListBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.lst4 = new System.Windows.Forms.ListBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn1.Location = new System.Drawing.Point(76, 57);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(130, 108);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "newstrings";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lst1
            // 
            this.lst1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(259, 57);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(225, 108);
            this.lst1.TabIndex = 1;
            // 
            // lst2
            // 
            this.lst2.BackColor = System.Drawing.Color.Lime;
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(259, 185);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(225, 108);
            this.lst2.TabIndex = 3;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Lime;
            this.btn2.Location = new System.Drawing.Point(76, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(130, 108);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "temper";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lst3
            // 
            this.lst3.BackColor = System.Drawing.Color.Green;
            this.lst3.FormattingEnabled = true;
            this.lst3.Location = new System.Drawing.Point(259, 319);
            this.lst3.Name = "lst3";
            this.lst3.Size = new System.Drawing.Size(225, 108);
            this.lst3.TabIndex = 5;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Green;
            this.btn3.Location = new System.Drawing.Point(76, 319);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(130, 108);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "vocals";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lst4
            // 
            this.lst4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lst4.FormattingEnabled = true;
            this.lst4.Location = new System.Drawing.Point(259, 454);
            this.lst4.Name = "lst4";
            this.lst4.Size = new System.Drawing.Size(225, 108);
            this.lst4.TabIndex = 7;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn4.Location = new System.Drawing.Point(76, 454);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(130, 108);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "golf";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.lst4);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.lst3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "BusinessApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.ListBox lst3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.ListBox lst4;
        private System.Windows.Forms.Button btn4;
    }
}

