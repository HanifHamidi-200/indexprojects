namespace OriginSays
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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPush = new System.Windows.Forms.Button();
            this.btnCollect = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnComply = new System.Windows.Forms.Button();
            this.lblQuadrant = new System.Windows.Forms.Label();
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
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDirection.Location = new System.Drawing.Point(50, 170);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(77, 15);
            this.lblDirection.TabIndex = 26;
            this.lblDirection.Text = "Direction = (N)";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocation.Location = new System.Drawing.Point(50, 143);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 15);
            this.lblLocation.TabIndex = 25;
            this.lblLocation.Text = "Location = (1,1)";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Location = new System.Drawing.Point(50, 119);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 15);
            this.lblScore.TabIndex = 24;
            this.lblScore.Text = "Score = 0";
            // 
            // btnQNext
            // 
            this.btnQNext.Location = new System.Drawing.Point(41, 48);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(98, 41);
            this.btnQNext.TabIndex = 23;
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
            this.panel2.Location = new System.Drawing.Point(294, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 231);
            this.panel2.TabIndex = 22;
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
            this.panel1.Location = new System.Drawing.Point(112, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 71);
            this.panel1.TabIndex = 21;
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
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(112, 386);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(131, 41);
            this.btnLeft.TabIndex = 29;
            this.btnLeft.Text = "[TURN LEFT]";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(386, 386);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(131, 41);
            this.btnRight.TabIndex = 28;
            this.btnRight.Text = "[TURN RIGHT]";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(249, 386);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(131, 41);
            this.btnForward.TabIndex = 27;
            this.btnForward.Text = "[FORWARD]";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "F BoxDoa.png");
            this.imageList1.Images.SetKeyName(1, "F Caves.png");
            this.imageList1.Images.SetKeyName(2, "F Exit.png");
            this.imageList1.Images.SetKeyName(3, "F HelplessPerson.png");
            this.imageList1.Images.SetKeyName(4, "F house.png");
            this.imageList1.Images.SetKeyName(5, "F money.png");
            this.imageList1.Images.SetKeyName(6, "F Nullgate.png");
            this.imageList1.Images.SetKeyName(7, "F road.png");
            this.imageList1.Images.SetKeyName(8, "F tile1.png");
            this.imageList1.Images.SetKeyName(9, "F tile2.png");
            // 
            // btnPush
            // 
            this.btnPush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPush.Location = new System.Drawing.Point(112, 433);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(99, 41);
            this.btnPush.TabIndex = 30;
            this.btnPush.Text = "push";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnCollect
            // 
            this.btnCollect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCollect.Location = new System.Drawing.Point(217, 433);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(99, 41);
            this.btnCollect.TabIndex = 31;
            this.btnCollect.Text = "collect";
            this.btnCollect.UseVisualStyleBackColor = false;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuild.Location = new System.Drawing.Point(322, 433);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(99, 41);
            this.btnBuild.TabIndex = 32;
            this.btnBuild.Text = "build";
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnComply
            // 
            this.btnComply.BackColor = System.Drawing.Color.Red;
            this.btnComply.Location = new System.Drawing.Point(629, 117);
            this.btnComply.Name = "btnComply";
            this.btnComply.Size = new System.Drawing.Size(99, 41);
            this.btnComply.TabIndex = 33;
            this.btnComply.Text = "comply";
            this.btnComply.UseVisualStyleBackColor = false;
            this.btnComply.Click += new System.EventHandler(this.btnComply_Click);
            // 
            // lblQuadrant
            // 
            this.lblQuadrant.AutoSize = true;
            this.lblQuadrant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuadrant.Location = new System.Drawing.Point(50, 194);
            this.lblQuadrant.Name = "lblQuadrant";
            this.lblQuadrant.Size = new System.Drawing.Size(86, 15);
            this.lblQuadrant.TabIndex = 34;
            this.lblQuadrant.Text = "Quadrant = (NE)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.lblQuadrant);
            this.Controls.Add(this.btnComply);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnCollect);
            this.Controls.Add(this.btnPush);
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
            this.Text = "OriginSays";
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
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnComply;
        private System.Windows.Forms.Label lblQuadrant;
    }
}

