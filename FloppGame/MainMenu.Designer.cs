namespace FloppGame
{
    partial class MainMenu
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
            this.lblStartGame = new System.Windows.Forms.Label();
            this.lblQuitGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStartGame.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.Location = new System.Drawing.Point(171, 142);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(183, 37);
            this.lblStartGame.TabIndex = 0;
            this.lblStartGame.Text = "Start game";
            this.lblStartGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblStartGame_MouseClick);
            this.lblStartGame.MouseEnter += new System.EventHandler(this.lblStartMouseEnter);
            this.lblStartGame.MouseLeave += new System.EventHandler(this.lblStartMouseLeave);
            // 
            // lblQuitGame
            // 
            this.lblQuitGame.AutoSize = true;
            this.lblQuitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitGame.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitGame.Location = new System.Drawing.Point(213, 222);
            this.lblQuitGame.Name = "lblQuitGame";
            this.lblQuitGame.Size = new System.Drawing.Size(81, 37);
            this.lblQuitGame.TabIndex = 1;
            this.lblQuitGame.Text = "Quit";
            this.lblQuitGame.Click += new System.EventHandler(this.lblQuitGame_Click);
            this.lblQuitGame.MouseEnter += new System.EventHandler(this.lblQuitMouseEnter);
            this.lblQuitGame.MouseLeave += new System.EventHandler(this.lblQuitMouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(516, 440);
            this.Controls.Add(this.lblQuitGame);
            this.Controls.Add(this.lblStartGame);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Label lblQuitGame;
    }
}