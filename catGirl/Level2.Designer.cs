
namespace catGirl
{
    partial class Level2
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
            this.Score = new System.Windows.Forms.Label();
            this.Missed = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PinkPanther = new System.Windows.Forms.PictureBox();
            this.Bomb = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Jewel = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkPanther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jewel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Score.Dock = System.Windows.Forms.DockStyle.Top;
            this.Score.Font = new System.Drawing.Font("Freestyle Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(0, 88);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(118, 44);
            this.Score.TabIndex = 26;
            this.Score.Tag = "Score";
            this.Score.Text = "Score : 0";
            // 
            // Missed
            // 
            this.Missed.AutoSize = true;
            this.Missed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Missed.Dock = System.Windows.Forms.DockStyle.Top;
            this.Missed.Font = new System.Drawing.Font("Freestyle Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Missed.Location = new System.Drawing.Point(0, 44);
            this.Missed.Name = "Missed";
            this.Missed.Size = new System.Drawing.Size(129, 44);
            this.Missed.TabIndex = 25;
            this.Missed.Tag = "Missed";
            this.Missed.Text = "Missed : 0";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Timer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Timer.Font = new System.Drawing.Font("Freestyle Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(0, 0);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(118, 44);
            this.Timer.TabIndex = 24;
            this.Timer.Tag = "Timer";
            this.Timer.Text = "Timer : 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 59;
            this.timer1.Tag = "timer1";
            this.timer1.Tick += new System.EventHandler(this.GameTick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::catGirl.Properties.Resources._5sec;
            this.pictureBox1.Location = new System.Drawing.Point(159, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "TimeBonus";
            // 
            // PinkPanther
            // 
            this.PinkPanther.Image = global::catGirl.Properties.Resources.PinkPanther1;
            this.PinkPanther.Location = new System.Drawing.Point(395, 507);
            this.PinkPanther.Name = "PinkPanther";
            this.PinkPanther.Size = new System.Drawing.Size(92, 146);
            this.PinkPanther.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PinkPanther.TabIndex = 27;
            this.PinkPanther.TabStop = false;
            this.PinkPanther.Tag = "PinkPanther";
            // 
            // Bomb
            // 
            this.Bomb.Image = global::catGirl.Properties.Resources.Bomb;
            this.Bomb.Location = new System.Drawing.Point(689, 62);
            this.Bomb.Name = "Bomb";
            this.Bomb.Size = new System.Drawing.Size(70, 70);
            this.Bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bomb.TabIndex = 23;
            this.Bomb.TabStop = false;
            this.Bomb.Tag = "Bomb";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::catGirl.Properties.Resources.Diamond;
            this.pictureBox3.Location = new System.Drawing.Point(526, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Jewel";
            // 
            // Jewel
            // 
            this.Jewel.Image = global::catGirl.Properties.Resources.Diamond;
            this.Jewel.Location = new System.Drawing.Point(335, 61);
            this.Jewel.Name = "Jewel";
            this.Jewel.Size = new System.Drawing.Size(61, 62);
            this.Jewel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Jewel.TabIndex = 21;
            this.Jewel.TabStop = false;
            this.Jewel.Tag = "Jewel";
            // 
            // back
            // 
            this.back.Image = global::catGirl.Properties.Resources.back2;
            this.back.Location = new System.Drawing.Point(810, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(41, 36);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 29;
            this.back.TabStop = false;
            this.back.Tag = "back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Image = global::catGirl.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(847, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(42, 36);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.close.TabIndex = 28;
            this.close.TabStop = false;
            this.close.Tag = "close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(640, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(149, 24);
            this.name.TabIndex = 30;
            this.name.Tag = "name";
            this.name.Text = "Name:             ";
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PinkPanther);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Missed);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Bomb);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Jewel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Name = "Level2";
            this.Text = "Level2";
            this.Load += new System.EventHandler(this.Level2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkPanther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jewel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PinkPanther;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Missed;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.PictureBox Bomb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Jewel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label name;
    }
}