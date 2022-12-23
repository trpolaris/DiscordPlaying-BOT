using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_Project.Discord;

namespace DiscordPlaying_BOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("Application id'nizi yazın", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("Application id'nizi yazın", ref this.handlers, true, null);
            this.presence.details = "Detay metnini yazın";
            this.presence.state = "Durum metnini yazın";
            this.presence.largeImageKey = "Büyük fotoğraf seçin";
            this.presence.largeImageText = "Büyük fotoğraf metnini girin";
            this.presence.smallImageKey = "Küçük fotoğraf seçin";
            this.presence.smallImageText = "Küçük fotoğraf metnini girin";
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void facepic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Facebook linikinizi girin");
        }

        private void instapic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("İnstagram linikinizi girin");
        }

        private void twitpic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Twitter linikinizi girin");
        }

        private void dcpic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Discord linikinizi girin");
        }

        private void gitpic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Github linikinizi girin");
        }

        private void redditpic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Reddit linikinizi girin");
        }
    }
}
