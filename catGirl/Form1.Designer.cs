namespace catGirl
{
    partial class Level1
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
            this.MainTimer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.miss = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.fruit = new System.Windows.Forms.PictureBox();
            this.f2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTimer1
            // 
            this.MainTimer1.Enabled = true;
            this.MainTimer1.Interval = 59;
            this.MainTimer1.Tick += new System.EventHandler(this.GameTick);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timer.Dock = System.Windows.Forms.DockStyle.Top;
            this.timer.Font = new System.Drawing.Font("Freestyle Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(0, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(105, 44);
            this.timer.TabIndex = 12;
            this.timer.Text = "Timer : ";
            this.timer.Click += new System.EventHandler(this.timer_Click);
            // 
            // miss
            // 
            this.miss.AutoSize = true;
            this.miss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.miss.Dock = System.Windows.Forms.DockStyle.Top;
            this.miss.Font = new System.Drawing.Font("Freestyle Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miss.Location = new System.Drawing.Point(0, 44);
            this.miss.Name = "miss";
            this.miss.Size = new System.Drawing.Size(129, 44);
            this.miss.TabIndex = 13;
            this.miss.Text = "Missed : 0";
            // 
            // sc
            // 
            this.sc.AutoSize = true;
            this.sc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sc.Dock = System.Windows.Forms.DockStyle.Top;
            this.sc.Font = new System.Drawing.Font("Freestyle Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc.Location = new System.Drawing.Point(0, 88);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(118, 44);
            this.sc.TabIndex = 14;
            this.sc.Text = "Score : 0";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(552, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(149, 24);
            this.name.TabIndex = 15;
            this.name.Tag = "name";
            this.name.Text = "Name:             ";
            // 
            // back
            // 
            this.back.Image = global::catGirl.Properties.Resources.back2;
            this.back.Location = new System.Drawing.Point(789, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 38);
            this.back.TabIndex = 17;
            this.back.TabStop = false;
            this.back.Tag = "back";
            this.back.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // close
            // 
            this.close.Image = global::catGirl.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(845, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 39);
            this.close.TabIndex = 16;
            this.close.TabStop = false;
            this.close.Tag = "close";
            this.close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::catGirl.Properties.Resources.fruit;
            this.pictureBox5.Location = new System.Drawing.Point(765, 66);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 104);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "fruit";
            // 
            // fruit
            // 
            this.fruit.Image = global::catGirl.Properties.Resources.fruit;
            this.fruit.Location = new System.Drawing.Point(145, 66);
            this.fruit.Name = "fruit";
            this.fruit.Size = new System.Drawing.Size(89, 104);
            this.fruit.TabIndex = 7;
            this.fruit.TabStop = false;
            this.fruit.Tag = "fruit";
            // 
            // f2
            // 
            this.f2.Image = global::catGirl.Properties.Resources.fruit;
            this.f2.Location = new System.Drawing.Point(315, 66);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(89, 104);
            this.f2.TabIndex = 2;
            this.f2.TabStop = false;
            this.f2.Tag = "fruit";
            // 
            // player
            // 
            this.player.Image = global::catGirl.Properties.Resources.girl2;
            this.player.Location = new System.Drawing.Point(402, 492);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(155, 183);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.name);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.miss);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.fruit);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.player);
            this.MaximizeBox = false;
            this.Name = "Level1";
            this.Text = "Level1";
            this.Load += new System.EventHandler(this.Level1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox f2;
        private System.Windows.Forms.Timer MainTimer1;
        private System.Windows.Forms.PictureBox fruit;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label miss;
        private System.Windows.Forms.Label sc;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox back;
    }
}

