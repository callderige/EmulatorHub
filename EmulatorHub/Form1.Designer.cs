using System.IO;

namespace EmulatorHub
{
    partial class Form1
    {
        public Form1(string s)
        {
            InitializeComponent();
            AddButton();
        }
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
            this.AutoSize = true;
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion

        private void AddButton()
        {
            string emulatorDirectory = @"C:\Users\Cliff\Desktop\Enumlators";
            int offsetY = 0;
            foreach (string dir in Directory.GetDirectories(emulatorDirectory))
            {
                foreach (string file in Directory.GetFiles(dir, "*.exe"))
                {
                    EmulatorButton emulatorButton = new EmulatorButton(file);
                    emulatorButton.Location = new System.Drawing.Point(100, 100 + (30 * offsetY));
                    this.Controls.Add(emulatorButton);
                    offsetY++;
                }
            }
        }
    }
}

