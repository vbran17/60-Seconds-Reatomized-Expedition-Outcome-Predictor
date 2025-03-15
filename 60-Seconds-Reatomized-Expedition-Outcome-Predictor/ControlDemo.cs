using System;
using System.IO;

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
            MessageBox.Show("You clicked to create a folder in %appdata%.");
            if (Directory.Exists(folderpath)) {
                MessageBox.Show("That Path Already Exists.");
            } else {
                DirectoryInfo SixtySecFolder = Directory.CreateDirectory(folderpath);
                MessageBox.Show("The Directory Was Created Successfully.");
            }

        }   

        private void buttonCreateATxtFile_Click(object sender, EventArgs e)
        {
            var folderpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "60-Seconds-Reatomized-Expedition-Outcome-Predictor");
            String path = Path.Combine(folderpath, "60-seconds-test.txt");

            //Ensures folder exists
            if (!Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(folderpath);
                MessageBox.Show("A folder was created in %appdata% to store the file first.");
            }

            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(":D:D:D:D:D:D:D:D:D");
                        sw.WriteLine("https://www.youtube.com/watch?v=DXMyt8sZx9w");
                    }
                    MessageBox.Show("The file was created successfully.");
                }
                else
                {
                    MessageBox.Show("This file has been overwritten.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonReadATxtFile_Click(object sender, EventArgs e)
        {
            // TODO: Read a .txt file
            // TODO: Show the contents of the txt file in a message box
        }
    }
}
