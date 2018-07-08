namespace Trendsetter
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
            this.btnCard1 = new System.Windows.Forms.Button();
            this.btnCard2 = new System.Windows.Forms.Button();
            this.btnCard3 = new System.Windows.Forms.Button();
            this.btnCard4 = new System.Windows.Forms.Button();
            this.btnCard5 = new System.Windows.Forms.Button();
            this.btnTwist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lstCards = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCard1
            // 
            this.btnCard1.BackColor = System.Drawing.Color.Yellow;
            this.btnCard1.Location = new System.Drawing.Point(33, 57);
            this.btnCard1.Name = "btnCard1";
            this.btnCard1.Size = new System.Drawing.Size(110, 41);
            this.btnCard1.TabIndex = 0;
            this.btnCard1.Text = "4SPADES";
            this.btnCard1.UseVisualStyleBackColor = false;
            this.btnCard1.Click += new System.EventHandler(this.btnCard1_Click);
            // 
            // btnCard2
            // 
            this.btnCard2.BackColor = System.Drawing.Color.Yellow;
            this.btnCard2.Location = new System.Drawing.Point(149, 57);
            this.btnCard2.Name = "btnCard2";
            this.btnCard2.Size = new System.Drawing.Size(110, 41);
            this.btnCard2.TabIndex = 1;
            this.btnCard2.Text = "4SPADES";
            this.btnCard2.UseVisualStyleBackColor = false;
            this.btnCard2.Click += new System.EventHandler(this.btnCard2_Click);
            // 
            // btnCard3
            // 
            this.btnCard3.BackColor = System.Drawing.Color.Yellow;
            this.btnCard3.Location = new System.Drawing.Point(265, 57);
            this.btnCard3.Name = "btnCard3";
            this.btnCard3.Size = new System.Drawing.Size(110, 41);
            this.btnCard3.TabIndex = 2;
            this.btnCard3.Text = "4SPADES";
            this.btnCard3.UseVisualStyleBackColor = false;
            this.btnCard3.Click += new System.EventHandler(this.btnCard3_Click);
            // 
            // btnCard4
            // 
            this.btnCard4.BackColor = System.Drawing.Color.Yellow;
            this.btnCard4.Location = new System.Drawing.Point(381, 57);
            this.btnCard4.Name = "btnCard4";
            this.btnCard4.Size = new System.Drawing.Size(110, 41);
            this.btnCard4.TabIndex = 3;
            this.btnCard4.Text = "4SPADES";
            this.btnCard4.UseVisualStyleBackColor = false;
            this.btnCard4.Click += new System.EventHandler(this.btnCard4_Click);
            // 
            // btnCard5
            // 
            this.btnCard5.BackColor = System.Drawing.Color.Yellow;
            this.btnCard5.Location = new System.Drawing.Point(497, 57);
            this.btnCard5.Name = "btnCard5";
            this.btnCard5.Size = new System.Drawing.Size(110, 41);
            this.btnCard5.TabIndex = 4;
            this.btnCard5.Text = "4SPADES";
            this.btnCard5.UseVisualStyleBackColor = false;
            this.btnCard5.Click += new System.EventHandler(this.btnCard5_Click);
            // 
            // btnTwist
            // 
            this.btnTwist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTwist.Location = new System.Drawing.Point(22, 33);
            this.btnTwist.Name = "btnTwist";
            this.btnTwist.Size = new System.Drawing.Size(77, 67);
            this.btnTwist.TabIndex = 5;
            this.btnTwist.Text = "twist";
            this.btnTwist.UseVisualStyleBackColor = false;
            this.btnTwist.Click += new System.EventHandler(this.btnTwist_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnReady);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnTwist);
            this.groupBox1.Location = new System.Drawing.Point(627, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 311);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReady.Location = new System.Drawing.Point(22, 179);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(77, 67);
            this.btnReady.TabIndex = 6;
            this.btnReady.Text = "[READY]";
            this.btnReady.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.Location = new System.Drawing.Point(22, 106);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 67);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lstCards
            // 
            this.lstCards.FormattingEnabled = true;
            this.lstCards.Location = new System.Drawing.Point(33, 142);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(265, 121);
            this.lstCards.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCards);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCard5);
            this.Controls.Add(this.btnCard4);
            this.Controls.Add(this.btnCard3);
            this.Controls.Add(this.btnCard2);
            this.Controls.Add(this.btnCard1);
            this.Name = "Form1";
            this.Text = "Trendsetter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCard1;
        private System.Windows.Forms.Button btnCard2;
        private System.Windows.Forms.Button btnCard3;
        private System.Windows.Forms.Button btnCard4;
        private System.Windows.Forms.Button btnCard5;
        private System.Windows.Forms.Button btnTwist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstCards;
    }
}

