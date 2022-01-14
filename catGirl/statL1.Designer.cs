namespace catGirl
{
    partial class statL1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::catGirl.Properties.Resources.bbck;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 507);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 114);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Level 1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Crimson;
            this.back.Image = global::catGirl.Properties.Resources.back2;
            this.back.Location = new System.Drawing.Point(565, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(41, 36);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 32;
            this.back.TabStop = false;
            this.back.Tag = "back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Crimson;
            this.close.Image = global::catGirl.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(612, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(42, 36);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.close.TabIndex = 33;
            this.close.TabStop = false;
            this.close.Tag = "close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // statL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 508);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "statL1";
            this.Text = "statL1";
            this.Load += new System.EventHandler(this.statL1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox close;
    }
}