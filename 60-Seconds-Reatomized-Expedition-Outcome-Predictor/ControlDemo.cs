using System;

namespace _60_Seconds_Reatomized_Expedition_Outcome_Predictor
{
    public partial class ControlDemo : Form
    {
        public ControlDemo()
        {
            InitializeComponent();
        }

        private void buttonCreateAppDataFolder_Click(object sender, EventArgs e)
        {
            // TODO: Create a folder in %appdata%
            var folderpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "60-Seconds-Reatomized-Expedition-Outcome-Predictor");

            //checks if folder exists and creates it if it doesn't
            if (Directory.Exists(folderpath)) {
                MessageBox.Show("You Clicked To Create A Folder In %appdata%.");
                MessageBox.Show("That Path Already Exists.");
            } else {
                MessageBox.Show("You clicked to create a folder in %appdata%.");
                DirectoryInfo SixtySecFolder = Directory.CreateDirectory(folderpath);
                MessageBox.Show("The Directory Was Created Successfully.");
            }

        }   

        private void buttonCreateATxtFile_Click(object sender, EventArgs e)
        {
            // TODO: Create a .txt file
        }

        private void buttonReadATxtFile_Click(object sender, EventArgs e)
        {
            // TODO: Read a .txt file
            // TODO: Show the contents of the txt file in a message box
        }
    }
}
