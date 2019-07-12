namespace FlappyBird
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.pcbFlappyBird = new System.Windows.Forms.PictureBox();
            this.pcbPipeTop1 = new System.Windows.Forms.PictureBox();
            this.pcbPipeBottom1 = new System.Windows.Forms.PictureBox();
            this.pcbPipeTop2 = new System.Windows.Forms.PictureBox();
            this.pcbPipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pcbGround = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblBoardBest = new System.Windows.Forms.Label();
            this.lblBoardBestText = new System.Windows.Forms.Label();
            this.lblBoardScore = new System.Windows.Forms.Label();
            this.lblBoardScoreText = new System.Windows.Forms.Label();
            this.lblGameScore = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).BeginInit();
            this.pnlBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbFlappyBird
            // 
            this.pcbFlappyBird.BackColor = System.Drawing.Color.Transparent;
            this.pcbFlappyBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.pcbFlappyBird.Location = new System.Drawing.Point(342, 271);
            this.pcbFlappyBird.Margin = new System.Windows.Forms.Padding(0);
            this.pcbFlappyBird.Name = "pcbFlappyBird";
            this.pcbFlappyBird.Size = new System.Drawing.Size(90, 64);
            this.pcbFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbFlappyBird.TabIndex = 0;
            this.pcbFlappyBird.TabStop = false;
            // 
            // pcbPipeTop1
            // 
            this.pcbPipeTop1.BackColor = System.Drawing.Color.Transparent;
            this.pcbPipeTop1.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pcbPipeTop1.Location = new System.Drawing.Point(602, -541);
            this.pcbPipeTop1.Margin = new System.Windows.Forms.Padding(0);
            this.pcbPipeTop1.Name = "pcbPipeTop1";
            this.pcbPipeTop1.Size = new System.Drawing.Size(138, 793);
            this.pcbPipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbPipeTop1.TabIndex = 0;
            this.pcbPipeTop1.TabStop = false;
            this.pcbPipeTop1.Visible = false;
            // 
            // pcbPipeBottom1
            // 
            this.pcbPipeBottom1.BackColor = System.Drawing.Color.Transparent;
            this.pcbPipeBottom1.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pcbPipeBottom1.Location = new System.Drawing.Point(602, 466);
            this.pcbPipeBottom1.Margin = new System.Windows.Forms.Padding(0);
            this.pcbPipeBottom1.Name = "pcbPipeBottom1";
            this.pcbPipeBottom1.Size = new System.Drawing.Size(138, 793);
            this.pcbPipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbPipeBottom1.TabIndex = 0;
            this.pcbPipeBottom1.TabStop = false;
            this.pcbPipeBottom1.Visible = false;
            // 
            // pcbPipeTop2
            // 
            this.pcbPipeTop2.BackColor = System.Drawing.Color.Transparent;
            this.pcbPipeTop2.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pcbPipeTop2.Location = new System.Drawing.Point(436, -541);
            this.pcbPipeTop2.Margin = new System.Windows.Forms.Padding(0);
            this.pcbPipeTop2.Name = "pcbPipeTop2";
            this.pcbPipeTop2.Size = new System.Drawing.Size(138, 793);
            this.pcbPipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbPipeTop2.TabIndex = 0;
            this.pcbPipeTop2.TabStop = false;
            this.pcbPipeTop2.Visible = false;
            // 
            // pcbPipeBottom2
            // 
            this.pcbPipeBottom2.BackColor = System.Drawing.Color.Transparent;
            this.pcbPipeBottom2.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pcbPipeBottom2.Location = new System.Drawing.Point(449, 466);
            this.pcbPipeBottom2.Margin = new System.Windows.Forms.Padding(0);
            this.pcbPipeBottom2.Name = "pcbPipeBottom2";
            this.pcbPipeBottom2.Size = new System.Drawing.Size(138, 793);
            this.pcbPipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbPipeBottom2.TabIndex = 0;
            this.pcbPipeBottom2.TabStop = false;
            this.pcbPipeBottom2.Visible = false;
            // 
            // pcbGround
            // 
            this.pcbGround.BackColor = System.Drawing.Color.Transparent;
            this.pcbGround.BackgroundImage = global::FlappyBird.Properties.Resources.ground;
            this.pcbGround.Location = new System.Drawing.Point(0, 895);
            this.pcbGround.Margin = new System.Windows.Forms.Padding(0);
            this.pcbGround.Name = "pcbGround";
            this.pcbGround.Size = new System.Drawing.Size(752, 94);
            this.pcbGround.TabIndex = 0;
            this.pcbGround.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 15;
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackgroundImage = global::FlappyBird.Properties.Resources.board;
            this.pnlBoard.Controls.Add(this.lblBoardBest);
            this.pnlBoard.Controls.Add(this.lblBoardBestText);
            this.pnlBoard.Controls.Add(this.lblBoardScore);
            this.pnlBoard.Controls.Add(this.lblBoardScoreText);
            this.pnlBoard.Location = new System.Drawing.Point(187, 271);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(418, 225);
            this.pnlBoard.TabIndex = 1;
            // 
            // lblBoardBest
            // 
            this.lblBoardBest.AutoSize = true;
            this.lblBoardBest.BackColor = System.Drawing.Color.Transparent;
            this.lblBoardBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBoardBest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBoardBest.Location = new System.Drawing.Point(215, 132);
            this.lblBoardBest.Name = "lblBoardBest";
            this.lblBoardBest.Size = new System.Drawing.Size(36, 39);
            this.lblBoardBest.TabIndex = 3;
            this.lblBoardBest.Text = "0";
            // 
            // lblBoardBestText
            // 
            this.lblBoardBestText.AutoSize = true;
            this.lblBoardBestText.BackColor = System.Drawing.Color.Transparent;
            this.lblBoardBestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBoardBestText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(46)))), ((int)(((byte)(1)))));
            this.lblBoardBestText.Location = new System.Drawing.Point(61, 132);
            this.lblBoardBestText.Name = "lblBoardBestText";
            this.lblBoardBestText.Size = new System.Drawing.Size(107, 39);
            this.lblBoardBestText.TabIndex = 2;
            this.lblBoardBestText.Text = "BEST";
            // 
            // lblBoardScore
            // 
            this.lblBoardScore.AutoSize = true;
            this.lblBoardScore.BackColor = System.Drawing.Color.Transparent;
            this.lblBoardScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBoardScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBoardScore.Location = new System.Drawing.Point(215, 43);
            this.lblBoardScore.Name = "lblBoardScore";
            this.lblBoardScore.Size = new System.Drawing.Size(36, 39);
            this.lblBoardScore.TabIndex = 1;
            this.lblBoardScore.Text = "0";
            // 
            // lblBoardScoreText
            // 
            this.lblBoardScoreText.AutoSize = true;
            this.lblBoardScoreText.BackColor = System.Drawing.Color.Transparent;
            this.lblBoardScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBoardScoreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(46)))), ((int)(((byte)(1)))));
            this.lblBoardScoreText.Location = new System.Drawing.Point(61, 43);
            this.lblBoardScoreText.Name = "lblBoardScoreText";
            this.lblBoardScoreText.Size = new System.Drawing.Size(139, 39);
            this.lblBoardScoreText.TabIndex = 0;
            this.lblBoardScoreText.Text = "SCORE";
            // 
            // lblGameScore
            // 
            this.lblGameScore.AutoSize = true;
            this.lblGameScore.BackColor = System.Drawing.Color.Transparent;
            this.lblGameScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGameScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGameScore.Location = new System.Drawing.Point(187, 161);
            this.lblGameScore.MinimumSize = new System.Drawing.Size(400, 0);
            this.lblGameScore.Name = "lblGameScore";
            this.lblGameScore.Size = new System.Drawing.Size(400, 73);
            this.lblGameScore.TabIndex = 2;
            this.lblGameScore.Text = "0";
            this.lblGameScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHelp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHelp.Location = new System.Drawing.Point(255, 539);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(307, 31);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.Text = "PRESS SPACE TO FLY";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.BackgroundImage = global::FlappyBird.Properties.Resources.start;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(287, 429);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(214, 75);
            this.btnStart.TabIndex = 4;
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = global::FlappyBird.Properties.Resources.restart;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(287, 525);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(214, 75);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblGameScore);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.pcbGround);
            this.Controls.Add(this.pcbPipeBottom2);
            this.Controls.Add(this.pcbPipeTop2);
            this.Controls.Add(this.pcbPipeBottom1);
            this.Controls.Add(this.pcbPipeTop1);
            this.Controls.Add(this.pcbFlappyBird);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.Text = "FlappyBird";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).EndInit();
            this.pnlBoard.ResumeLayout(false);
            this.pnlBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFlappyBird;
        private System.Windows.Forms.PictureBox pcbPipeTop1;
        private System.Windows.Forms.PictureBox pcbPipeBottom1;
        private System.Windows.Forms.PictureBox pcbPipeTop2;
        private System.Windows.Forms.PictureBox pcbPipeBottom2;
        private System.Windows.Forms.PictureBox pcbGround;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblBoardBest;
        private System.Windows.Forms.Label lblBoardBestText;
        private System.Windows.Forms.Label lblBoardScore;
        private System.Windows.Forms.Label lblBoardScoreText;
        private System.Windows.Forms.Label lblGameScore;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
    }
}

