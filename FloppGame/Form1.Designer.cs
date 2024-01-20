namespace FloppGame
{
    partial class GameForm
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
            this.pictureBird = new System.Windows.Forms.PictureBox();
            this.pictureGround = new System.Windows.Forms.PictureBox();
            this.picturePipeDown = new System.Windows.Forms.PictureBox();
            this.picturePipeTop = new System.Windows.Forms.PictureBox();
            this.TimerGame = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBird
            // 
            this.pictureBird.Image = global::FloppGame.Properties.Resources.bird;
            this.pictureBird.Location = new System.Drawing.Point(33, 70);
            this.pictureBird.Name = "pictureBird";
            this.pictureBird.Size = new System.Drawing.Size(66, 41);
            this.pictureBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBird.TabIndex = 2;
            this.pictureBird.TabStop = false;
            // 
            // pictureGround
            // 
            this.pictureGround.Image = global::FloppGame.Properties.Resources.ground;
            this.pictureGround.Location = new System.Drawing.Point(-15, 398);
            this.pictureGround.Name = "pictureGround";
            this.pictureGround.Size = new System.Drawing.Size(650, 135);
            this.pictureGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGround.TabIndex = 4;
            this.pictureGround.TabStop = false;
            // 
            // picturePipeDown
            // 
            this.picturePipeDown.Image = global::FloppGame.Properties.Resources.pipe;
            this.picturePipeDown.Location = new System.Drawing.Point(388, 280);
            this.picturePipeDown.Name = "picturePipeDown";
            this.picturePipeDown.Size = new System.Drawing.Size(100, 121);
            this.picturePipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePipeDown.TabIndex = 6;
            this.picturePipeDown.TabStop = false;
            // 
            // picturePipeTop
            // 
            this.picturePipeTop.Image = global::FloppGame.Properties.Resources.pipedown;
            this.picturePipeTop.Location = new System.Drawing.Point(467, -4);
            this.picturePipeTop.Name = "picturePipeTop";
            this.picturePipeTop.Size = new System.Drawing.Size(100, 115);
            this.picturePipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePipeTop.TabIndex = 7;
            this.picturePipeTop.TabStop = false;
            // 
            // TimerGame
            // 
            this.TimerGame.Enabled = true;
            this.TimerGame.Interval = 20;
            this.TimerGame.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(233, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Score:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(579, 519);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturePipeTop);
            this.Controls.Add(this.picturePipeDown);
            this.Controls.Add(this.pictureGround);
            this.Controls.Add(this.pictureBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FloppyGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBird;
        private System.Windows.Forms.PictureBox pictureGround;
        private System.Windows.Forms.PictureBox picturePipeDown;
        private System.Windows.Forms.PictureBox picturePipeTop;
        private System.Windows.Forms.Timer TimerGame;
        private System.Windows.Forms.Label label1;
    }
}

