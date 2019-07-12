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
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).BeginInit();
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
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(752, 985);
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
    }
}

