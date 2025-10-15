namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new System.Windows.Forms.PictureBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            checkBox4 = new System.Windows.Forms.CheckBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            button1 = new System.Windows.Forms.Button();
            buttonShowPicture = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            label2 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            avaMärkmedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            salvestaMärkmedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Location = new System.Drawing.Point(30, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(150, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(220, 50);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(101, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Always on top";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox2.Location = new System.Drawing.Point(220, 75);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(114, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Show PictureBox";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(220, 100);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(76, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Maximize";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new System.Drawing.Point(220, 125);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(102, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Random order";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(220, 170);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(89, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Light theme";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += ThemeChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(220, 195);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(86, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Dark theme";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += ThemeChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(30, 220);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 30);
            button1.TabIndex = 7;
            button1.Text = "Show dialog";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonShowPicture
            // 
            buttonShowPicture.Location = new System.Drawing.Point(140, 220);
            buttonShowPicture.Name = "buttonShowPicture";
            buttonShowPicture.Size = new System.Drawing.Size(100, 30);
            buttonShowPicture.TabIndex = 14;
            buttonShowPicture.Text = "Show picture";
            buttonShowPicture.UseVisualStyleBackColor = true;
            buttonShowPicture.Click += buttonShowPicture_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(30, 270);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(300, 150);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(292, 122);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "First";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(292, 122);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Second";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(20, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(184, 21);
            label2.TabIndex = 0;
            label2.Text = "Second tab - designed!";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(350, 270);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(80, 30);
            button2.TabIndex = 9;
            button2.Text = "Add tab";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(350, 310);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(80, 30);
            button3.TabIndex = 10;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "RU", "EST", "ENG"});
            listBox1.Location = new System.Drawing.Point(450, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(120, 94);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(600, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { avaMärkmedToolStripMenuItem, salvestaMärkmedToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // avaMärkmedToolStripMenuItem
            // 
            avaMärkmedToolStripMenuItem.Name = "avaMärkmedToolStripMenuItem";
            avaMärkmedToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            avaMärkmedToolStripMenuItem.Text = "Open notes";
            avaMärkmedToolStripMenuItem.Click += avaMärkmedToolStripMenuItem_Click;
            // 
            // salvestaMärkmedToolStripMenuItem
            // 
            salvestaMärkmedToolStripMenuItem.Name = "salvestaMärkmedToolStripMenuItem";
            salvestaMärkmedToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            salvestaMärkmedToolStripMenuItem.Text = "Save notes";
            salvestaMärkmedToolStripMenuItem.Click += salvestaMärkmedToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(450, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 15);
            label1.TabIndex = 13;
            label1.Text = "Color selection:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(600, 450);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Controls.Add(buttonShowPicture);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Text = "WinForms Application";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonShowPicture;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaMärkmedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvestaMärkmedToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}