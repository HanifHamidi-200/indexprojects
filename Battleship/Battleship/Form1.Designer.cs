namespace Battleship
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnQNext = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picForward3 = new System.Windows.Forms.PictureBox();
            this.picForward2 = new System.Windows.Forms.PictureBox();
            this.picForward1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAcross7 = new System.Windows.Forms.PictureBox();
            this.picAcross6 = new System.Windows.Forms.PictureBox();
            this.picAcross5 = new System.Windows.Forms.PictureBox();
            this.picAcross4 = new System.Windows.Forms.PictureBox();
            this.picAcross3 = new System.Windows.Forms.PictureBox();
            this.picAcross2 = new System.Windows.Forms.PictureBox();
            this.picAcross1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDrop1 = new System.Windows.Forms.Button();
            this.btnDrop2 = new System.Windows.Forms.Button();
            this.btnDrop3 = new System.Windows.Forms.Button();
            this.btnLookup = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picForward3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(104, 400);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(131, 41);
            this.btnLeft.TabIndex = 23;
            this.btnLeft.Text = "[TURN LEFT]";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click_1);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(378, 400);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(131, 41);
            this.btnRight.TabIndex = 22;
            this.btnRight.Text = "[TURN RIGHT]";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(241, 400);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(131, 41);
            this.btnForward.TabIndex = 21;
            this.btnForward.Text = "[FORWARD]";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDirection.Location = new System.Drawing.Point(39, 167);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(77, 15);
            this.lblDirection.TabIndex = 20;
            this.lblDirection.Text = "Direction = (N)";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocation.Location = new System.Drawing.Point(39, 140);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 15);
            this.lblLocation.TabIndex = 19;
            this.lblLocation.Text = "Location = (1,1)";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Location = new System.Drawing.Point(39, 116);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 15);
            this.lblScore.TabIndex = 18;
            this.lblScore.Text = "Score = 0";
            // 
            // btnQNext
            // 
            this.btnQNext.Location = new System.Drawing.Point(30, 45);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(98, 41);
            this.btnQNext.TabIndex = 17;
            this.btnQNext.Text = "QNext";
            this.btnQNext.UseVisualStyleBackColor = true;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.picForward3);
            this.panel2.Controls.Add(this.picForward2);
            this.panel2.Controls.Add(this.picForward1);
            this.panel2.Location = new System.Drawing.Point(283, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 231);
            this.panel2.TabIndex = 16;
            // 
            // picForward3
            // 
            this.picForward3.Image = ((System.Drawing.Image)(resources.GetObject("picForward3.Image")));
            this.picForward3.Location = new System.Drawing.Point(12, 152);
            this.picForward3.Name = "picForward3";
            this.picForward3.Size = new System.Drawing.Size(57, 62);
            this.picForward3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForward3.TabIndex = 5;
            this.picForward3.TabStop = false;
            // 
            // picForward2
            // 
            this.picForward2.Image = ((System.Drawing.Image)(resources.GetObject("picForward2.Image")));
            this.picForward2.Location = new System.Drawing.Point(13, 84);
            this.picForward2.Name = "picForward2";
            this.picForward2.Size = new System.Drawing.Size(57, 62);
            this.picForward2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForward2.TabIndex = 4;
            this.picForward2.TabStop = false;
            // 
            // picForward1
            // 
            this.picForward1.Image = ((System.Drawing.Image)(resources.GetObject("picForward1.Image")));
            this.picForward1.Location = new System.Drawing.Point(12, 13);
            this.picForward1.Name = "picForward1";
            this.picForward1.Size = new System.Drawing.Size(57, 62);
            this.picForward1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForward1.TabIndex = 3;
            this.picForward1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.picAcross7);
            this.panel1.Controls.Add(this.picAcross6);
            this.panel1.Controls.Add(this.picAcross5);
            this.panel1.Controls.Add(this.picAcross4);
            this.panel1.Controls.Add(this.picAcross3);
            this.panel1.Controls.Add(this.picAcross2);
            this.panel1.Controls.Add(this.picAcross1);
            this.panel1.Location = new System.Drawing.Point(101, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 71);
            this.panel1.TabIndex = 15;
            // 
            // picAcross7
            // 
            this.picAcross7.Image = ((System.Drawing.Image)(resources.GetObject("picAcross7.Image")));
            this.picAcross7.Location = new System.Drawing.Point(381, 6);
            this.picAcross7.Name = "picAcross7";
            this.picAcross7.Size = new System.Drawing.Size(57, 62);
            this.picAcross7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAcross7.TabIndex = 8;
            this.picAcross7.TabStop = false;
            // 
            // picAcross6
            // 
            this.picAcross6.Image = ((System.Drawing.Image)(resources.GetObject("picAcross6.Image")));
            this.picAcross6.Location = new System.Drawing.Point(318, 6);
            this.picAcross6.Name = "picAcross6";
            this.picAcross6.Size = new System.Drawing.Size(57, 62);
            this.picAcross6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAcross6.TabIndex = 7;
            this.picAcross6.TabStop = false;
            // 
            // picAcross5
            // 
            this.picAcross5.Image = ((System.Drawing.Image)(resources.GetObject("picAcross5.Image")));
            this.picAcross5.Location = new System.Drawing.Point(255, 6);
            this.picAcross5.Name = "picAcross5";
            this.picAcross5.Size = new System.Drawing.Size(57, 62);
            this.picAcross5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAcross5.TabIndex = 6;
            this.picAcross5.TabStop = false;
            // 
            // picAcross4
            // 
            this.picAcross4.Image = ((System.Drawing.Image)(resources.GetObject("picAcross4.Image")));
            this.picAcross4.Location = new System.Drawing.Point(192, 6);
            this.picAcross4.Name = "picAcross4";
            this.picAcross4.Size = new System.Drawing.Size(57, 62);
            this.picAcross4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAcross4.TabIndex = 5;
            this.picAcross4.TabStop = false;
            // 
            // picAcross3
            // 
            this.picAcross3.Image = ((System.Drawing.Image)(resources.GetObject("picAcross3.Image")));
            this.picAcross3.Location = new System.Drawing.Point(129, 6);
            this.picAcross3.Name = "picAcross3";
            this.picAcross3.Size = new System.Drawing.Size(57, 62);
            this.picAcross3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAcross3.TabIndex = 4;
            this.picAcross3.TabStop = false;
            // 
            // picAcross2
            // 
            this.picAcross2.Image = ((System.Drawing.Image)(resources.GetObject("picAcross2.Image")));
            this.picAcross2.Location = new System.Drawing.Point(66, 6);
            this.picAcross2.Name = "picAcross2";
            this.picAcross2.Size = new System.Drawing.Size(57, 62);
            this.picAcross2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAcross2.TabIndex = 3;
            this.picAcross2.TabStop = false;
            // 
            // picAcross1
            // 
            this.picAcross1.Image = ((System.Drawing.Image)(resources.GetObject("picAcross1.Image")));
            this.picAcross1.Location = new System.Drawing.Point(3, 6);
            this.picAcross1.Name = "picAcross1";
            this.picAcross1.Size = new System.Drawing.Size(57, 62);
            this.picAcross1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAcross1.TabIndex = 2;
            this.picAcross1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "F land.png");
            this.imageList1.Images.SetKeyName(1, "F sea.png");
            this.imageList1.Images.SetKeyName(2, "F Exit.png");
            this.imageList1.Images.SetKeyName(3, "F landings1.png");
            this.imageList1.Images.SetKeyName(4, "F landings2.png");
            this.imageList1.Images.SetKeyName(5, "F landings3.png");
            this.imageList1.Images.SetKeyName(6, "F type1.png");
            this.imageList1.Images.SetKeyName(7, "F type2.png");
            this.imageList1.Images.SetKeyName(8, "F type3.png");
            this.imageList1.Images.SetKeyName(9, "F type4.png");
            this.imageList1.Images.SetKeyName(10, "F Nullgate.png");
            // 
            // btnDrop1
            // 
            this.btnDrop1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDrop1.Location = new System.Drawing.Point(104, 459);
            this.btnDrop1.Name = "btnDrop1";
            this.btnDrop1.Size = new System.Drawing.Size(89, 41);
            this.btnDrop1.TabIndex = 24;
            this.btnDrop1.Text = "dropOil";
            this.btnDrop1.UseVisualStyleBackColor = false;
            this.btnDrop1.Click += new System.EventHandler(this.btnDrop1_Click);
            // 
            // btnDrop2
            // 
            this.btnDrop2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDrop2.Location = new System.Drawing.Point(199, 459);
            this.btnDrop2.Name = "btnDrop2";
            this.btnDrop2.Size = new System.Drawing.Size(89, 41);
            this.btnDrop2.TabIndex = 25;
            this.btnDrop2.Text = "dropDam";
            this.btnDrop2.UseVisualStyleBackColor = false;
            // 
            // btnDrop3
            // 
            this.btnDrop3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDrop3.Location = new System.Drawing.Point(296, 459);
            this.btnDrop3.Name = "btnDrop3";
            this.btnDrop3.Size = new System.Drawing.Size(89, 41);
            this.btnDrop3.TabIndex = 26;
            this.btnDrop3.Text = "dropFactory";
            this.btnDrop3.UseVisualStyleBackColor = false;
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLookup.Location = new System.Drawing.Point(569, 45);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(98, 41);
            this.btnLookup.TabIndex = 27;
            this.btnLookup.Text = "(lookup)";
            this.btnLookup.UseVisualStyleBackColor = false;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.btnDrop3);
            this.Controls.Add(this.btnDrop2);
            this.Controls.Add(this.btnDrop1);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picForward3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAcross7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcross1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picForward3;
        private System.Windows.Forms.PictureBox picForward2;
        private System.Windows.Forms.PictureBox picForward1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAcross7;
        private System.Windows.Forms.PictureBox picAcross6;
        private System.Windows.Forms.PictureBox picAcross5;
        private System.Windows.Forms.PictureBox picAcross4;
        private System.Windows.Forms.PictureBox picAcross3;
        private System.Windows.Forms.PictureBox picAcross2;
        private System.Windows.Forms.PictureBox picAcross1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnDrop1;
        private System.Windows.Forms.Button btnDrop2;
        private System.Windows.Forms.Button btnDrop3;
        private System.Windows.Forms.Button btnLookup;
    }
}

