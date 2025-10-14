using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private string[] imageFiles;
        private int currentImageIndex = 0;
        private bool isDarkTheme = false;
        private string[] images = new string[]
        {
            "C:\\Users\\illya\\RiderProjects\\WinFormsApp1\\WinFormsApp1\\images\\1.jpg",
            "C:\\Users\\illya\\RiderProjects\\WinFormsApp1\\WinFormsApp1\\images\\2.png",
            "C:\\Users\\illya\\RiderProjects\\WinFormsApp1\\WinFormsApp1\\images\\3.png"
        };
        public Form1()
        {
            InitializeComponent();
        }

        // Change image on double click
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (imageFiles.Length == 0) return;

            if (checkBox4.Checked)
                currentImageIndex = random.Next(imageFiles.Length);
            else
                currentImageIndex = (currentImageIndex + 1) % imageFiles.Length;

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = Image.FromFile(imageFiles[currentImageIndex]);
        }

        // "Always on top"
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = checkBox2.Checked;
        }

        // Fullscreen mode
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            WindowState = checkBox3.Checked ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        // Theme change
        private void ThemeChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                isDarkTheme = rb == radioButton2;
                ApplyTheme();
            }
        }

        private void ApplyTheme()
        {
            if (isDarkTheme)
            {
                BackColor = Color.FromArgb(40, 40, 40);
                ForeColor = Color.White;
            }
            else
            {
                BackColor = SystemColors.Control;
                ForeColor = SystemColors.ControlText;
            }
        }

        // Simple dialog window
        private void ShowCustomDialog()
        {
            Form dialog = new Form
            {
                Text = "Dialog",
                Size = new Size(300, 150),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label label = new Label
            {
                Text = "This is a simple dialog window!",
                AutoSize = true,
                Location = new Point(50, 30)
            };

            Button okButton = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new Point(110, 70)
            };

            dialog.Controls.Add(label);
            dialog.Controls.Add(okButton);
            dialog.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowCustomDialog();
        }

        private void buttonShowPicture_Click(object sender, EventArgs e)
        {
            int index = random.Next(images.Length);
            pictureBox1.Image = Image.FromFile(images[index]);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Add tab
        private void button2_Click(object sender, EventArgs e)
        {
            string tabName = $"Tab {tabControl1.TabCount + 1}";
            TabPage newTab = new TabPage(tabName);
            Label label = new Label
            {
                Text = $"Content: {tabName}",
                Location = new Point(10, 10),
                AutoSize = true
            };
            newTab.Controls.Add(label);
            tabControl1.TabPages.Add(newTab);
        }

        // Remove last tab
        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.TabPages.Count - 1);
            }
        }

        // Change background when selecting color
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color[] colors = { Color.LightBlue, Color.LightGreen, Color.LightPink, Color.LightYellow, Color.LightCoral };
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < colors.Length)
            {
                BackColor = colors[listBox1.SelectedIndex];
            }
        }

        private void avaMärkmedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notes opened!", "My Notes");
        }

        private void salvestaMärkmedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notes saved!", "Save");
        }
    }
}
