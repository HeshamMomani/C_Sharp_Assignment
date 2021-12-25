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
            this.f2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.fruit = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.sc = new System.Windows.Forms.Label();
            this.miss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.f2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTimer1
            // 
            this.MainTimer1.Enabled = true;
            this.MainTimer1.Interval = 59;
            this.MainTimer1.Tick += new System.EventHandler(this.GameTick);
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
            this.player.Size = new System.Drawing.Size(155, 161);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.LightCoral;
            this.logo.Image = global::catGirl.Properties.Resources.logo2;
            this.logo.Location = new System.Drawing.Point(315, 238);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(338, 214);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // fruit
            // 
            this.fruit.Image = global::catGirl.Properties.Resources.fruit;
            this.fruit.Location = new System.Drawing.Point(78, 84);
            this.fruit.Name = "fruit";
            this.fruit.Size = new System.Drawing.Size(89, 104);
            this.fruit.TabIndex = 7;
            this.fruit.TabStop = false;
            this.fruit.Tag = "fruit";
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
            // sc
            // 
            this.sc.AutoSize = true;
            this.sc.Font = new System.Drawing.Font("Freestyle Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc.Location = new System.Drawing.Point(12, 0);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(116, 42);
            this.sc.TabIndex = 9;
            this.sc.Text = "Score : 0";
            // 
            // miss
            // 
            this.miss.AutoSize = true;
            this.miss.Font = new System.Drawing.Font("Freestyle Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miss.Location = new System.Drawing.Point(747, 0);
            this.miss.Name = "miss";
            this.miss.Size = new System.Drawing.Size(127, 42);
            this.miss.TabIndex = 10;
            this.miss.Text = "Missed : 0";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.miss);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.fruit);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.logo);
            this.MaximizeBox = false;
            this.Name = "Level1";
            this.Text = "Level1";
            this.Load += new System.EventHandler(this.Level1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.f2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox f2;
        private System.Windows.Forms.Timer MainTimer1;
        private System.Windows.Forms.PictureBox fruit;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label sc;
        private System.Windows.Forms.Label miss;
    }
}

