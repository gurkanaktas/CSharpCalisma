namespace WindowsFormsApp2
{
    partial class pingpong
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
            this.player1 = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p2score = new System.Windows.Forms.Label();
            this.p1score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Blue;
            this.player1.Location = new System.Drawing.Point(180, 296);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(150, 25);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.top.Location = new System.Drawing.Point(207, 123);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(30, 30);
            this.top.TabIndex = 1;
            this.top.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Red;
            this.player2.Location = new System.Drawing.Point(193, 12);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(150, 25);
            this.player2.TabIndex = 2;
            this.player2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p2score
            // 
            this.p2score.AutoSize = true;
            this.p2score.Location = new System.Drawing.Point(13, 13);
            this.p2score.Name = "p2score";
            this.p2score.Size = new System.Drawing.Size(13, 13);
            this.p2score.TabIndex = 3;
            this.p2score.Text = "0";
            // 
            // p1score
            // 
            this.p1score.AutoSize = true;
            this.p1score.Location = new System.Drawing.Point(13, 308);
            this.p1score.Name = "p1score";
            this.p1score.Size = new System.Drawing.Size(13, 13);
            this.p1score.TabIndex = 4;
            this.p1score.Text = "0";
            // 
            // pingpong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 333);
            this.Controls.Add(this.p1score);
            this.Controls.Add(this.p2score);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.top);
            this.Controls.Add(this.player1);
            this.Name = "pingpong";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.pingpong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label p2score;
        private System.Windows.Forms.Label p1score;
    }
}

