namespace DiscordPlaying_BOT
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dcpic = new System.Windows.Forms.PictureBox();
            this.instapic = new System.Windows.Forms.PictureBox();
            this.facepic = new System.Windows.Forms.PictureBox();
            this.twitpic = new System.Windows.Forms.PictureBox();
            this.redditpic = new System.Windows.Forms.PictureBox();
            this.gitpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dcpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instapic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redditpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitpic)).BeginInit();
            this.SuspendLayout();
            // 
            // dcpic
            // 
            this.dcpic.BackColor = System.Drawing.Color.Transparent;
            this.dcpic.Image = global::DiscordPlaying_BOT.Properties.Resources.discord48_48;
            this.dcpic.Location = new System.Drawing.Point(157, 21);
            this.dcpic.Name = "dcpic";
            this.dcpic.Size = new System.Drawing.Size(51, 50);
            this.dcpic.TabIndex = 0;
            this.dcpic.TabStop = false;
            this.dcpic.Click += new System.EventHandler(this.dcpic_Click);
            // 
            // instapic
            // 
            this.instapic.BackColor = System.Drawing.Color.Transparent;
            this.instapic.Image = global::DiscordPlaying_BOT.Properties.Resources.instagram48_48;
            this.instapic.Location = new System.Drawing.Point(59, 21);
            this.instapic.Name = "instapic";
            this.instapic.Size = new System.Drawing.Size(47, 50);
            this.instapic.TabIndex = 1;
            this.instapic.TabStop = false;
            this.instapic.Click += new System.EventHandler(this.instapic_Click);
            // 
            // facepic
            // 
            this.facepic.BackColor = System.Drawing.Color.Transparent;
            this.facepic.Image = global::DiscordPlaying_BOT.Properties.Resources.facebook48_48;
            this.facepic.Location = new System.Drawing.Point(12, 21);
            this.facepic.Name = "facepic";
            this.facepic.Size = new System.Drawing.Size(48, 50);
            this.facepic.TabIndex = 2;
            this.facepic.TabStop = false;
            this.facepic.Click += new System.EventHandler(this.facepic_Click);
            // 
            // twitpic
            // 
            this.twitpic.BackColor = System.Drawing.Color.Transparent;
            this.twitpic.Image = global::DiscordPlaying_BOT.Properties.Resources.twitter48_48;
            this.twitpic.Location = new System.Drawing.Point(106, 21);
            this.twitpic.Name = "twitpic";
            this.twitpic.Size = new System.Drawing.Size(51, 50);
            this.twitpic.TabIndex = 3;
            this.twitpic.TabStop = false;
            this.twitpic.Click += new System.EventHandler(this.twitpic_Click);
            // 
            // redditpic
            // 
            this.redditpic.BackColor = System.Drawing.Color.Transparent;
            this.redditpic.Image = global::DiscordPlaying_BOT.Properties.Resources.reddit48_48;
            this.redditpic.Location = new System.Drawing.Point(259, 21);
            this.redditpic.Name = "redditpic";
            this.redditpic.Size = new System.Drawing.Size(52, 50);
            this.redditpic.TabIndex = 4;
            this.redditpic.TabStop = false;
            this.redditpic.Click += new System.EventHandler(this.redditpic_Click);
            // 
            // gitpic
            // 
            this.gitpic.BackColor = System.Drawing.Color.Transparent;
            this.gitpic.Image = global::DiscordPlaying_BOT.Properties.Resources.github48_48;
            this.gitpic.Location = new System.Drawing.Point(208, 21);
            this.gitpic.Name = "gitpic";
            this.gitpic.Size = new System.Drawing.Size(51, 50);
            this.gitpic.TabIndex = 5;
            this.gitpic.TabStop = false;
            this.gitpic.Click += new System.EventHandler(this.gitpic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiscordPlaying_BOT.Properties.Resources.DiscordBot_Logolu_New;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(323, 121);
            this.Controls.Add(this.gitpic);
            this.Controls.Add(this.redditpic);
            this.Controls.Add(this.twitpic);
            this.Controls.Add(this.facepic);
            this.Controls.Add(this.instapic);
            this.Controls.Add(this.dcpic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISCORD PLAYING BOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dcpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instapic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redditpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dcpic;
        private System.Windows.Forms.PictureBox instapic;
        private System.Windows.Forms.PictureBox facepic;
        private System.Windows.Forms.PictureBox twitpic;
        private System.Windows.Forms.PictureBox redditpic;
        private System.Windows.Forms.PictureBox gitpic;
    }
}

