using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombassSoundboard {
    public partial class AboutWindow : Form {
        public AboutWindow() {
            InitializeComponent();
            Infobox.Text = String.Format(Infobox.Text, Assembly.GetExecutingAssembly().GetName().Version.ToString(),Program.player.getSounds().Count,Program.player.getTotalPlays());
            GitHubLinkLabel.Links.Add(0, GitHubLinkLabel.Text.Length, "https://github.com/griffenx/BombassSoundboard");
            BlogLinkLabel.Links.Add(0, BlogLinkLabel.Text.Length, "http://iamvishnu.tumblr.com");
        }

        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        
        private void BlogLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void CloseButton1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
