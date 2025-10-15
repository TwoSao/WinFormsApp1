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
        private string[] images;
        private string[] lang;

        string imagesPath = Path.Combine(Application.StartupPath, "..", "..", "..", "images");
        
        public Form1()
        {
            InitializeComponent();
            imagesPath = Path.GetFullPath(imagesPath);
            lang = new string[3] { "RU", "EST", "ENG" };

            images = new string[]
            {
                Path.Combine(imagesPath, "1.jpg"),
                Path.Combine(imagesPath, "2.png"),
                Path.Combine(imagesPath, "3.png")
            };
        }

        // Change image on double click
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                int index = random.Next(images.Length);
                pictureBox1.Image = Image.FromFile(images[index]);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            
        }

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
private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    if (listBox1.SelectedIndex < 0) return; 

    string selectedLang = lang[listBox1.SelectedIndex];

    switch (selectedLang)
    {
        case "ENG":
            button1.Text = "Open Dialog";
            button2.Text = "Add Tab";
            button3.Text = "Remove Tab";
            buttonShowPicture.Text = "Show Picture";
            label1.Text = "Welcome";
            label2.Text = "Select an option:";
            checkBox1.Text = "Always on Top";
            checkBox2.Text = "Show Picture";
            checkBox3.Text = "Fullscreen";
            checkBox4.Text = "Random Image";
            break;

        case "RU":
            button1.Text = "Открыть диалог";
            button2.Text = "Добавить вкладку";
            button3.Text = "Удалить вкладку";
            buttonShowPicture.Text = "Показать картинку";
            label1.Text = "Добро пожаловать";
            label2.Text = "Выберите опцию:";
            checkBox1.Text = "Всегда сверху";
            checkBox2.Text = "Показать картинку";
            checkBox3.Text = "Полноэкранный режим";
            checkBox4.Text = "Случайная картинка";
            break;

        case "EST":
            button1.Text = "Ava dialoog";
            button2.Text = "Lisa vaheleht";
            button3.Text = "Eemalda vaheleht";
            buttonShowPicture.Text = "Näita pilti";
            label1.Text = "Tere tulemast";
            label2.Text = "Vali valik:";
            checkBox1.Text = "Alati ees";
            checkBox2.Text = "Näita pilti";
            checkBox3.Text = "Täisekraan";
            checkBox4.Text = "Juhuslik pilt";
            break;

        default:
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            buttonShowPicture.Text = "";
            label1.Text = "";
            label2.Text = "";
            checkBox1.Text = "";
            checkBox2.Text = "";
            checkBox3.Text = "";
            checkBox4.Text = "";
            break;
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
