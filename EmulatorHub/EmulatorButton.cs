using System;
using System.Windows.Forms;

namespace EmulatorHub
{
    class EmulatorButton : Button
    {   
        private string ExePath { get; set; }

        public EmulatorButton(string exePath)
        {
            this.Text = exePath.Remove(0, exePath.LastIndexOf("\\") + 1);
            this.Text = Text.Replace(".exe", "");
            this.Text = Text.Replace(".lnk", "");
            this.ExePath = exePath;
            this.Click += new EventHandler(ButtonClick);
            this.AutoSize = true;
        }

        public void ButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(ExePath);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}
