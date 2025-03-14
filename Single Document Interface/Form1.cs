using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
//using static System.Net.Mime.MediaTypeNames;

namespace Single_Document_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hiển thị trạng thái ban đầu
            toolStripStatusLabel1.Text = "Sẵn sàng";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File file2 = new File();

            //file2.MdiParent = this;

            //file2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(ActiveMdiChild != null)
            //{
            //    ActiveMdiChild.Close();
            //}
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtb.Clear();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private System.Windows.Forms.RichTextBox GetRichTextBox()
        {
            System.Windows.Forms.RichTextBox rtb = null;
            if (ActiveMdiChild != null)
            {
                rtb = (System.Windows.Forms.RichTextBox)ActiveMdiChild.Controls[0];
            }
            return rtb;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectAll();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            ////set tieu de
            //openFile.Title = "Hop thoai mo file ";
            ////check dieu kien loc file
            //openFile.Filter = "Text File|*.txt;| All File|*.*";
            ////check xem nguoi dung da chon hay chua
            //if (openFile.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBox.Show(openFile.SafeFileName);

            //}
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
            //    currentFile = openFileDialog.FileName;
            //    toolStripStatusLabel1.Text = "Mở tệp: " + Path.GetFileName(currentFile);
            //}
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Open my new File";
            of.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
                rtb.LoadFile(of.FileName, RichTextBoxStreamType.PlainText);
            this.Text = of.FileName;

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save my new File";
            sf.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
                rtb.SaveFile(sf.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sf.FileName;

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetup.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = rtb.Font;
            fd.ShowDialog();
            rtb.Font = fd.Font;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    rtb.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rtb.SelectionFont;
                System.Drawing.FontStyle newStyle = currentFont.Style ^ System.Drawing.FontStyle.Bold;
                rtb.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb.SelectionFont != null)
            {

                FontStyle style = rtb.SelectionFont.Style;
                style ^= FontStyle.Italic; //Trạng thái Italic
                rtb.SelectionFont = new Font(rtb.SelectionFont, style);
            }
        }

        private void underToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb.SelectionFont != null)
            {
                FontStyle style = rtb.SelectionFont.Style;
                style ^= FontStyle.Underline; //Trạng thái Underline
                rtb.SelectionFont = new Font(rtb.SelectionFont, style);
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb.SelectionFont != null)
            {
                rtb.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            }
        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtb.BackColor = colorDialog.Color;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rtb.Clear();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = rtb.Font;
            fd.ShowDialog();
            rtb.Font = fd.Font;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Open my new File";
            of.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
                rtb.LoadFile(of.FileName, RichTextBoxStreamType.PlainText);
            this.Text = of.FileName;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save my new File";
            sf.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
                rtb.SaveFile(sf.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sf.FileName;

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    rtb.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (rtb.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rtb.SelectionFont;
                System.Drawing.FontStyle newStyle = currentFont.Style ^ System.Drawing.FontStyle.Bold;
                rtb.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (rtb.SelectionFont != null)
            {
                FontStyle style = rtb.SelectionFont.Style;
                style ^= FontStyle.Underline; //Trạng thái Underline
                rtb.SelectionFont = new Font(rtb.SelectionFont, style);
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (rtb.SelectionFont != null)
            {

                FontStyle style = rtb.SelectionFont.Style;
                style ^= FontStyle.Italic; //Trạng thái Italic
                rtb.SelectionFont = new Font(rtb.SelectionFont, style);
            }
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionIndent = 5;
        }

        private void ptsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtb.SelectionIndent = 10;
        }

        private void ptsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rtb.SelectionIndent = 15;
        }

        private void ptsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            rtb.SelectionIndent = 20;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void addBulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionBullet = !rtb.SelectionBullet;
        }

        private void removeBulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tắt chế độ bullet cho đoạn văn bản đã chọn
            rtb.SelectionBullet = false;
        }
    }
}
