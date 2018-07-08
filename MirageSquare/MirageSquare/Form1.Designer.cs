namespace MirageSquare
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(68, 72);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 30);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(202, 72);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(219, 199);
            this.lst1.TabIndex = 1;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(446, 72);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(89, 30);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(559, 72);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(219, 199);
            this.lst2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "MirageSquare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.ListBox lst2;
    }
}

