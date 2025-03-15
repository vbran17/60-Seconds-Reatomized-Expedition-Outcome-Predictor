namespace _60_Seconds_Reatomized_Expedition_Outcome_Predictor
{
    partial class ControlDemo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCreateAppDataFolder = new Button();
            buttonCreateATxtFile = new Button();
            buttonReadATxtFile = new Button();
            SuspendLayout();
            // 
            // buttonCreateAppDataFolder
            // 
            buttonCreateAppDataFolder.Location = new Point(12, 12);
            buttonCreateAppDataFolder.Name = "buttonCreateAppDataFolder";
            buttonCreateAppDataFolder.Size = new Size(273, 23);
            buttonCreateAppDataFolder.TabIndex = 0;
            buttonCreateAppDataFolder.Text = "Click me to create a folder in %appdata%";
            buttonCreateAppDataFolder.UseVisualStyleBackColor = true;
            buttonCreateAppDataFolder.Click += buttonCreateAppDataFolder_Click;
            // 
            // buttonCreateATxtFile
            // 
            buttonCreateATxtFile.Location = new Point(12, 41);
            buttonCreateATxtFile.Name = "buttonCreateATxtFile";
            buttonCreateATxtFile.Size = new Size(273, 23);
            buttonCreateATxtFile.TabIndex = 1;
            buttonCreateATxtFile.Text = "Click me to create a text file";
            buttonCreateATxtFile.UseVisualStyleBackColor = true;
            buttonCreateATxtFile.Click += buttonCreateATxtFile_Click;
            // 
            // buttonReadATxtFile
            // 
            buttonReadATxtFile.Location = new Point(12, 70);
            buttonReadATxtFile.Name = "buttonReadATxtFile";
            buttonReadATxtFile.Size = new Size(273, 23);
            buttonReadATxtFile.TabIndex = 2;
            buttonReadATxtFile.Text = "Click me to read a text file";
            buttonReadATxtFile.UseVisualStyleBackColor = true;
            buttonReadATxtFile.Click += buttonReadATxtFile_Click;
            // 
            // ControlDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonReadATxtFile);
            Controls.Add(buttonCreateATxtFile);
            Controls.Add(buttonCreateAppDataFolder);
            Name = "ControlDemo";
            Text = "60_Seconds_Reatomized_Expedition_Outcome_Predictor";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreateAppDataFolder;
        private Button buttonCreateATxtFile;
        private Button buttonReadATxtFile;
    }
}
