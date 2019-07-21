using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Wox.Plugin.Spotify
{
    public partial class SpotifyPluginSettings : Control
    {
        public SpotifyPluginSettings ()
        {
            Button button = new Button();   
            TextBox tbox = new TextBox();
            tbox.Text = "hollah hollah";
            tbox.Width = 250;
            tbox.Height = 150;
            tbox.Visibility = 0;
        }
    }
}