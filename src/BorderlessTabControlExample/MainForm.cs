using System.Windows.Forms;
using System.Drawing;
using System;

namespace BorderlessTabControlExample
{
    public partial class MainForm : Form
    {
        // Form initialization.
        public MainForm()
        {
            InitializeComponent();
        }

        // Change the tab control appearance based on the selected input.
        private void GetSelectedCorners(object sender, EventArgs e)
        {
            if (Normal_RadioButton.Checked)
                Main_BorderlessTabControl.Appearance = TabAppearance.Normal;
            else if (Buttons_RadioButton.Checked)
                Main_BorderlessTabControl.Appearance = TabAppearance.Buttons;
            else if (FlatButtons_RadioButton.Checked)
                Main_BorderlessTabControl.Appearance = TabAppearance.FlatButtons;
        }

        // Alter the existing tabs and add new tabs to the tab control.
        private void AddTabs_Button_Click(object sender, EventArgs e)
        {
            // Rename controls.
            Main_BorderlessTabControl.TabPages[0].Text = "Red";
            Main_BorderlessTabControl.TabPages[1].Text = "Orange";
            Main_BorderlessTabControl.TabPages.Add(      "Yellow");
            Main_BorderlessTabControl.TabPages.Add(      "Green");

            // Grab the page you want to style.
            var page1 = Main_BorderlessTabControl.TabPages[0];
            var page2 = Main_BorderlessTabControl.TabPages[1];
            var page3 = Main_BorderlessTabControl.TabPages[2];
            var page4 = Main_BorderlessTabControl.TabPages[3];

            // Adjust tabPage 1.
            page1.Tag = new BorderlessTabControl.TabColorInfo(page1)
            {
                PageBack = Color.Red, // Page background.
                FaceBack = Color.Red, // Button background.
                TextFore = Color.Snow // Caption (text) color.
            };

            // Adjust tabPage 2.
            page2.Tag = new BorderlessTabControl.TabColorInfo(page2)
            {
                PageBack = Color.Orange, // Page background.
                FaceBack = Color.Orange, // Button background.
                TextFore = Color.Snow    // Caption (text) color.
            };

            // Adjust tabPage 3.
            page3.Tag = new BorderlessTabControl.TabColorInfo(page3)
            {
                PageBack = Color.Yellow, // Page background.
                FaceBack = Color.Yellow, // Button background.
                TextFore = Color.Snow    // Caption (text) color.
            };

            // Adjust tabPage 4.
            page4.Tag = new BorderlessTabControl.TabColorInfo(page4)
            {
                PageBack = Color.Green, // Page background.
                FaceBack = Color.Green, // Button background.
                TextFore = Color.Snow   // Caption (text) color.
            };
        }

        // Change form back color.
        private void Ex_Button_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Plum;
        }
    }
}
