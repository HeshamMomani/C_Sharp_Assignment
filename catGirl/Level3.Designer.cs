namespace catGirl
{
    partial class Level3
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
            this.timer = new System.Windows.Forms.Label();
            this.miss = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fruit = new System.Windows.Forms.PictureBox();
            this.player3 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
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
            this.timer.TabIndex = 14;
            this.timer.Text = "Timer : ";
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
            this.miss.TabIndex = 15;
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
            this.sc.TabIndex = 16;
            this.sc.Text = "Score : 0";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 59;
            this.timer3.Tick += new System.EventHandler(this.GameTick3);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::catGirl.Properties.Resources.badfruit;
            this.pictureBox6.Location = new System.Drawing.Point(742, 196);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(118, 97);
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "badfruit";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::catGirl.Properties.Resources.badfruit;
            this.pictureBox5.Location = new System.Drawing.Point(426, 88);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(118, 97);
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "badfruit";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::catGirl.Properties.Resources.Add_time;
            this.pictureBox4.Location = new System.Drawing.Point(12, 196);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 89);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "addTime";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::catGirl.Properties.Resources.Add_time;
            this.pictureBox3.Location = new System.Drawing.Point(612, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 89);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "addTime";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::catGirl.Properties.Resources.Add_time;
            this.pictureBox2.Location = new System.Drawing.Point(306, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 89);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "addTime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::catGirl.Properties.Resources.fruit;
            this.pictureBox1.Location = new System.Drawing.Point(167, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 104);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "fruit";
            // 
            // fruit
            // 
            this.fruit.Image = global::catGirl.Properties.Resources.fruit;
            this.fruit.Location = new System.Drawing.Point(728, 68);
            this.fruit.Name = "fruit";
            this.fruit.Size = new System.Drawing.Size(89, 104);
            this.fruit.TabIndex = 28;
            this.fruit.TabStop = false;
            this.fruit.Tag = "fruit";
            // 
            // player3
            // 
            this.player3.BackColor = System.Drawing.Color.Pink;
            this.player3.Image = global::catGirl.Properties.Resources.baseet2;
            this.player3.Location = new System.Drawing.Point(355, 497);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(150, 168);
            this.player3.TabIndex = 27;
            this.player3.TabStop = false;
            this.player3.Tag = "player3";
            // 
            // back
            // 
            this.back.Image = global::catGirl.Properties.Resources.back2;
            this.back.Location = new System.Drawing.Point(789, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 38);
            this.back.TabIndex = 35;
            this.back.TabStop = false;
            this.back.Tag = "back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Image = global::catGirl.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(845, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 39);
            this.close.TabIndex = 36;
            this.close.TabStop = false;
            this.close.Tag = "close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fruit);
            this.Controls.Add(this.player3);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.miss);
            this.Controls.Add(this.timer);
            this.Name = "Level3";
            this.Text = "Level3";
            this.Load += new System.EventHandler(this.Level3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label miss;
        private System.Windows.Forms.Label sc;
        private System.Windows.Forms.PictureBox player3;
        private System.Windows.Forms.PictureBox fruit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox close;
    }
}