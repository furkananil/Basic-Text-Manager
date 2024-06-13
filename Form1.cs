/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2023-2024 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........:ÖDEV-1
**				ÖÐRENCÝ ADI............:FURKAN ANIL ÖZDEMÝR
**				ÖÐRENCÝ NUMARASI.......:b231210063
**              DERSÝN ALINDIÐI GRUP...:B GRUBU
****************************************************************************/

using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace odevNDP1
{
    public partial class Form1 : Form
    {
        private string suankiDosya = "";
        private bool icerikDegisti = false;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Basit Not Defteri";
      
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yaziRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colordialog = new ColorDialog())
            {
                if (colordialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colordialog.Color;
                    colordialog.Reset();

                }
            }
        }

        private void zeminRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog bgcolordialog = new ColorDialog())
            {
                if (bgcolordialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionBackColor = bgcolordialog.Color;
                    bgcolordialog.Reset();

                }
            }
        }

        private void yaziCesidiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontdialog = new FontDialog())
            {
                if (fontdialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fontdialog.Font;
                    fontdialog.Reset();
                }
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckSave();
            richTextBox1.Clear();
            suankiDosya = "";
            icerikDegisti = false;
        }

        private void dosyaAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckSave();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                    suankiDosya = openFileDialog.FileName;
                    icerikDegisti = false;
                }
            }
        }

        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "rtf dosyasi|*.rtf";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                Kayit.WriteLine(richTextBox1.Text);
                Kayit.Close();
            }
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckSave();
            Application.Exit();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void kesToolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapistirToolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckSave()
        {
                var result = MessageBox.Show("Deðiþiklikleri kaydetmek ister misiniz?", "Kaydet", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
        }

        private void SaveFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (string.IsNullOrEmpty(suankiDosya))
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                        suankiDosya = saveFileDialog.FileName;
                        icerikDegisti = false;
                    }
                }
                else
                {
                    File.WriteAllText(suankiDosya, richTextBox1.Text);
                    icerikDegisti = false;
                }
            }
        }
    }
}
