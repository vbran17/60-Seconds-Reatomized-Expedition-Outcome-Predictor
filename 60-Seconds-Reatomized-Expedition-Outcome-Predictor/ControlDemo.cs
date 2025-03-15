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
            MessageBox.Show("You clicked to create a folder in %appdata%.", "60_Seconds_Reatomized_Expedition_Outcome_Predictor");
            if (Directory.Exists(folderpath)) {
                MessageBox.Show("That Path Already Exists.", "60_Seconds_Reatomized_Expedition_Outcome_Predictor");
            } else {
                DirectoryInfo SixtySecFolder = Directory.CreateDirectory(folderpath);
                MessageBox.Show("The Directory Was Created Successfully.", "60_Seconds_Reatomized_Expedition_Outcome_Predictor");
            }

        }   

        private void buttonCreateATxtFile_Click(object sender, EventArgs e)
        {
            var folderpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "60-Seconds-Reatomized-Expedition-Outcome-Predictor");
            String path = Path.Combine(folderpath, "60-seconds-test.txt");

            //Ensures folder exists
            MessageBox.Show("You clicked to create a file in the %appdata% folder.", "60_Seconds_Reatomized_Expedition_Outcome_Predictor");
            if (!Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(folderpath);
                MessageBox.Show("A folder didn't exist and was created in %appdata% to store the file first.", "60_Seconds_Reatomized_Expedition_Outcome_Predictor");
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
                    MessageBox.Show("The file was created successfully.", "60_Seconds_Reatomized_Expedition_Outcome_Predictor");
                }
                else
                {
                    MessageBox.Show("There was already a file written with that path. This file has been overwritten.", "60_Seconds_Reatomized_Expedition_Outcome_Predictor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error Message");
            }
        }

        private void buttonReadATxtFile_Click(object sender, EventArgs e)
        {
            // TODO: Read a .txt file
            // TODO: Show the contents of the txt file in a message box
            var folderpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "60-Seconds-Reatomized-Expedition-Outcome-Predictor");
            String path = Path.Combine(folderpath, "60-seconds-test.txt");

            //Ensures folder exists
            if (!Directory.Exists(folderpath))
            {
                MessageBox.Show("There was no folder to read from. Try creating one using the first button.", "60_Seconds_Reatomized_Expedition_Outcome_Predictor");
                return;
            }

            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("There was no file to read from. Try creating one using the second button.", "60_Seconds_Reatomized_Expedition_Outcome_Predictor");
                }
                else
                {
                    MessageBox.Show(path, "Reading File:");
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string content = sr.ReadToEnd();  
                        MessageBox.Show(content, "File Contents:");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error Message");
            }
        }
    }
}
