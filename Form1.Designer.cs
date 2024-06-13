namespace odevNDP1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            dosyaAcToolStripMenuItem = new ToolStripMenuItem();
            dosyaKaydetToolStripMenuItem = new ToolStripMenuItem();
            cikisToolStripMenuItem = new ToolStripMenuItem();
            biçimToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapistirToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            renkToolStripMenuItem = new ToolStripMenuItem();
            yaziRengiToolStripMenuItem = new ToolStripMenuItem();
            zeminRengiToolStripMenuItem = new ToolStripMenuItem();
            yaziCesidiToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            kesToolStripButton1 = new ToolStripButton();
            kopyalaToolStripButton2 = new ToolStripButton();
            yapistirToolStripButton3 = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, biçimToolStripMenuItem, ayarlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniToolStripMenuItem, dosyaAcToolStripMenuItem, dosyaKaydetToolStripMenuItem, cikisToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(64, 24);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(224, 26);
            yeniToolStripMenuItem.Text = "Yeni";
            yeniToolStripMenuItem.Click += yeniToolStripMenuItem_Click;
            // 
            // dosyaAcToolStripMenuItem
            // 
            dosyaAcToolStripMenuItem.Name = "dosyaAcToolStripMenuItem";
            dosyaAcToolStripMenuItem.Size = new Size(224, 26);
            dosyaAcToolStripMenuItem.Text = "Dosya Aç";
            dosyaAcToolStripMenuItem.Click += dosyaAcToolStripMenuItem_Click;
            // 
            // dosyaKaydetToolStripMenuItem
            // 
            dosyaKaydetToolStripMenuItem.Name = "dosyaKaydetToolStripMenuItem";
            dosyaKaydetToolStripMenuItem.Size = new Size(224, 26);
            dosyaKaydetToolStripMenuItem.Text = "Dosya Kaydet";
            dosyaKaydetToolStripMenuItem.Click += dosyaKaydetToolStripMenuItem_Click;
            // 
            // cikisToolStripMenuItem
            // 
            cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            cikisToolStripMenuItem.Size = new Size(224, 26);
            cikisToolStripMenuItem.Text = "Çıkış";
            cikisToolStripMenuItem.Click += cikisToolStripMenuItem_Click;
            // 
            // biçimToolStripMenuItem
            // 
            biçimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kesToolStripMenuItem, kopyalaToolStripMenuItem, yapistirToolStripMenuItem });
            biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            biçimToolStripMenuItem.Size = new Size(60, 24);
            biçimToolStripMenuItem.Text = "Biçim";
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(146, 26);
            kesToolStripMenuItem.Text = "Kes";
            kesToolStripMenuItem.Click += kesToolStripMenuItem_Click;
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(146, 26);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            kopyalaToolStripMenuItem.Click += kopyalaToolStripMenuItem_Click;
            // 
            // yapistirToolStripMenuItem
            // 
            yapistirToolStripMenuItem.Name = "yapistirToolStripMenuItem";
            yapistirToolStripMenuItem.Size = new Size(146, 26);
            yapistirToolStripMenuItem.Text = "Yapıştır";
            yapistirToolStripMenuItem.Click += yapistirToolStripMenuItem_Click;
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { renkToolStripMenuItem, yaziCesidiToolStripMenuItem });
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(70, 24);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // renkToolStripMenuItem
            // 
            renkToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yaziRengiToolStripMenuItem, zeminRengiToolStripMenuItem });
            renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            renkToolStripMenuItem.Size = new Size(158, 26);
            renkToolStripMenuItem.Text = "Renk";
            // 
            // yaziRengiToolStripMenuItem
            // 
            yaziRengiToolStripMenuItem.Name = "yaziRengiToolStripMenuItem";
            yaziRengiToolStripMenuItem.Size = new Size(176, 26);
            yaziRengiToolStripMenuItem.Text = "Yazı Rengi";
            yaziRengiToolStripMenuItem.Click += yaziRengiToolStripMenuItem_Click;
            // 
            // zeminRengiToolStripMenuItem
            // 
            zeminRengiToolStripMenuItem.Name = "zeminRengiToolStripMenuItem";
            zeminRengiToolStripMenuItem.Size = new Size(176, 26);
            zeminRengiToolStripMenuItem.Text = "Zemin Rengi";
            zeminRengiToolStripMenuItem.Click += zeminRengiToolStripMenuItem_Click;
            // 
            // yaziCesidiToolStripMenuItem
            // 
            yaziCesidiToolStripMenuItem.Name = "yaziCesidiToolStripMenuItem";
            yaziCesidiToolStripMenuItem.Size = new Size(158, 26);
            yaziCesidiToolStripMenuItem.Text = "Yazı Çeşiti";
            yaziCesidiToolStripMenuItem.Click += yaziCesidiToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { kesToolStripButton1, kopyalaToolStripButton2, yapistirToolStripButton3 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // kesToolStripButton1
            // 
            kesToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            kesToolStripButton1.Image = (Image)resources.GetObject("kesToolStripButton1.Image");
            kesToolStripButton1.ImageTransparentColor = Color.Magenta;
            kesToolStripButton1.Name = "kesToolStripButton1";
            kesToolStripButton1.Size = new Size(29, 24);
            kesToolStripButton1.Text = "KES";
            kesToolStripButton1.Click += kesToolStripButton1_Click;
            // 
            // kopyalaToolStripButton2
            // 
            kopyalaToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            kopyalaToolStripButton2.Image = (Image)resources.GetObject("kopyalaToolStripButton2.Image");
            kopyalaToolStripButton2.ImageTransparentColor = Color.Magenta;
            kopyalaToolStripButton2.Name = "kopyalaToolStripButton2";
            kopyalaToolStripButton2.Size = new Size(29, 24);
            kopyalaToolStripButton2.Text = "KOPYALA";
            kopyalaToolStripButton2.Click += kopyalaToolStripButton2_Click;
            // 
            // yapistirToolStripButton3
            // 
            yapistirToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            yapistirToolStripButton3.Image = (Image)resources.GetObject("yapistirToolStripButton3.Image");
            yapistirToolStripButton3.ImageTransparentColor = Color.Magenta;
            yapistirToolStripButton3.Name = "yapistirToolStripButton3";
            yapistirToolStripButton3.Size = new Size(29, 24);
            yapistirToolStripButton3.Text = "YAPISTIR";
            yapistirToolStripButton3.Click += yapistirToolStripButton3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 394);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem dosyaAcToolStripMenuItem;
        private ToolStripMenuItem dosyaKaydetToolStripMenuItem;
        private ToolStripMenuItem cikisToolStripMenuItem;
        private ToolStripMenuItem biçimToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapistirToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem renkToolStripMenuItem;
        private ToolStripMenuItem yaziRengiToolStripMenuItem;
        private ToolStripMenuItem zeminRengiToolStripMenuItem;
        private ToolStripMenuItem yaziCesidiToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton kesToolStripButton1;
        private ToolStripButton kopyalaToolStripButton2;
        private ToolStripButton yapistirToolStripButton3;
        private RichTextBox richTextBox1;
    }
}
