using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_App2
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        // Global variables - String arrays for titles/name of tracks and path of tracks

        String[] paths, files;

        private void button1_Click(object sender, EventArgs e)
        {
            // Select songs
            OpenFileDialog ofd = new OpenFileDialog();

            // Code to select multiple music files
            ofd.Multiselect = true;


            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save names of track in files array
                paths = ofd.FileNames; // Save path of track in path array

                // Display titles in list box
                for(int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); // Display songs in ListBox
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code to play music
            WindowsMediaPlayer.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close the app
            this.Close();
        }
    }
}
