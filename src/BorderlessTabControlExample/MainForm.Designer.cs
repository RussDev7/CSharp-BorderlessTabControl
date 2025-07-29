using System.Windows.Forms;
using System.Drawing;

namespace BorderlessTabControlExample
{
    partial class MainForm
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
            Main_BorderlessTabControl = new BorderlessTabControl();
            tabPage1 = new TabPage();
            BottomRight_Button = new Button();
            BottomLeft_Button = new Button();
            TopRight_Button = new Button();
            TopLeft_Button = new Button();
            tabPage2 = new TabPage();
            Normal_RadioButton = new RadioButton();
            Buttons_RadioButton = new RadioButton();
            FlatButtons_RadioButton = new RadioButton();
            AddTabs_Button = new Button();
            Ex_Button = new Button();
            Main_BorderlessTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // Main_BorderlessTabControl
            // 
            Main_BorderlessTabControl.Controls.Add(tabPage1);
            Main_BorderlessTabControl.Controls.Add(tabPage2);
            Main_BorderlessTabControl.Dock = DockStyle.Bottom;
            Main_BorderlessTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            Main_BorderlessTabControl.ItemSize = new Size(72, 24);
            Main_BorderlessTabControl.Location = new Point(0, 31);
            Main_BorderlessTabControl.Name = "Main_BorderlessTabControl";
            Main_BorderlessTabControl.NearestNeighborStretch = true;
            Main_BorderlessTabControl.SelectedIndex = 0;
            Main_BorderlessTabControl.Size = new Size(404, 230);
            Main_BorderlessTabControl.SizeMode = TabSizeMode.Fixed;
            Main_BorderlessTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(BottomRight_Button);
            tabPage1.Controls.Add(BottomLeft_Button);
            tabPage1.Controls.Add(TopRight_Button);
            tabPage1.Controls.Add(TopLeft_Button);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(396, 198);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // BottomRight_Button
            // 
            BottomRight_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BottomRight_Button.ForeColor = Color.Black;
            BottomRight_Button.Location = new Point(303, 172);
            BottomRight_Button.Name = "BottomRight_Button";
            BottomRight_Button.Size = new Size(90, 23);
            BottomRight_Button.TabIndex = 3;
            BottomRight_Button.Text = "Bottom Right";
            BottomRight_Button.UseVisualStyleBackColor = true;
            // 
            // BottomLeft_Button
            // 
            BottomLeft_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BottomLeft_Button.ForeColor = Color.Black;
            BottomLeft_Button.Location = new Point(3, 172);
            BottomLeft_Button.Name = "BottomLeft_Button";
            BottomLeft_Button.Size = new Size(90, 23);
            BottomLeft_Button.TabIndex = 2;
            BottomLeft_Button.Text = "Bottom Left";
            BottomLeft_Button.UseVisualStyleBackColor = true;
            // 
            // TopRight_Button
            // 
            TopRight_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TopRight_Button.ForeColor = Color.Black;
            TopRight_Button.Location = new Point(303, 3);
            TopRight_Button.Name = "TopRight_Button";
            TopRight_Button.Size = new Size(90, 23);
            TopRight_Button.TabIndex = 1;
            TopRight_Button.Text = "Top Right";
            TopRight_Button.UseVisualStyleBackColor = true;
            // 
            // TopLeft_Button
            // 
            TopLeft_Button.ForeColor = Color.Black;
            TopLeft_Button.Location = new Point(3, 3);
            TopLeft_Button.Name = "TopLeft_Button";
            TopLeft_Button.Size = new Size(90, 23);
            TopLeft_Button.TabIndex = 0;
            TopLeft_Button.Text = "Top Left";
            TopLeft_Button.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Red;
            tabPage2.ForeColor = SystemColors.ControlText;
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(396, 198);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // Normal_RadioButton
            // 
            Normal_RadioButton.AutoSize = true;
            Normal_RadioButton.Checked = true;
            Normal_RadioButton.ForeColor = Color.Black;
            Normal_RadioButton.Location = new Point(12, 6);
            Normal_RadioButton.Name = "Normal_RadioButton";
            Normal_RadioButton.Size = new Size(65, 19);
            Normal_RadioButton.TabIndex = 1;
            Normal_RadioButton.TabStop = true;
            Normal_RadioButton.Text = "Normal";
            Normal_RadioButton.UseVisualStyleBackColor = true;
            Normal_RadioButton.CheckedChanged += GetSelectedCorners;
            // 
            // Buttons_RadioButton
            // 
            Buttons_RadioButton.AutoSize = true;
            Buttons_RadioButton.ForeColor = Color.Black;
            Buttons_RadioButton.Location = new Point(83, 6);
            Buttons_RadioButton.Name = "Buttons_RadioButton";
            Buttons_RadioButton.Size = new Size(66, 19);
            Buttons_RadioButton.TabIndex = 2;
            Buttons_RadioButton.Text = "Buttons";
            Buttons_RadioButton.UseVisualStyleBackColor = true;
            Buttons_RadioButton.CheckedChanged += GetSelectedCorners;
            // 
            // FlatButtons_RadioButton
            // 
            FlatButtons_RadioButton.AutoSize = true;
            FlatButtons_RadioButton.ForeColor = Color.Black;
            FlatButtons_RadioButton.Location = new Point(155, 6);
            FlatButtons_RadioButton.Name = "FlatButtons_RadioButton";
            FlatButtons_RadioButton.Size = new Size(90, 19);
            FlatButtons_RadioButton.TabIndex = 3;
            FlatButtons_RadioButton.Text = "Flat_Buttons";
            FlatButtons_RadioButton.UseVisualStyleBackColor = true;
            FlatButtons_RadioButton.CheckedChanged += GetSelectedCorners;
            // 
            // AddTabs_Button
            // 
            AddTabs_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddTabs_Button.Location = new Point(296, 4);
            AddTabs_Button.Name = "AddTabs_Button";
            AddTabs_Button.Size = new Size(75, 23);
            AddTabs_Button.TabIndex = 4;
            AddTabs_Button.Text = "Add Tabs";
            AddTabs_Button.UseVisualStyleBackColor = true;
            AddTabs_Button.Click += AddTabs_Button_Click;
            // 
            // Ex_Button
            // 
            Ex_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Ex_Button.Location = new Point(377, 4);
            Ex_Button.Name = "Ex_Button";
            Ex_Button.Size = new Size(23, 23);
            Ex_Button.TabIndex = 5;
            Ex_Button.Text = "!";
            Ex_Button.UseVisualStyleBackColor = true;
            Ex_Button.Click += Ex_Button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            ClientSize = new Size(404, 261);
            Controls.Add(Main_BorderlessTabControl);
            Controls.Add(Ex_Button);
            Controls.Add(AddTabs_Button);
            Controls.Add(FlatButtons_RadioButton);
            Controls.Add(Buttons_RadioButton);
            Controls.Add(Normal_RadioButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "Borderless TabPage Example";
            Main_BorderlessTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BorderlessTabControl Main_BorderlessTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BottomRight_Button;
        private Button BottomLeft_Button;
        private Button TopRight_Button;
        private Button TopLeft_Button;
        private RadioButton Normal_RadioButton;
        private RadioButton Buttons_RadioButton;
        private RadioButton FlatButtons_RadioButton;
        private Button AddTabs_Button;
        private Button Ex_Button;
    }
}
