/*using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace proektna_proba
{
    public partial class NoteForm : Form
    {
        public Note Note { get; set; }
        System.Windows.Forms.TextBox tbFindText = new System.Windows.Forms.TextBox();
        System.Windows.Forms.Button btnDeleteFindTb = new System.Windows.Forms.Button();


        public NoteForm()
        {
            InitializeComponent();
            setForm();
            rtbContent.AllowDrop = true;
            rtbContent.DragEnter += NoteForm_DragEnter;
            rtbContent.DragDrop += NoteForm_DragDrop;
        }

        public NoteForm(Note note)
        {
            InitializeComponent();
            setForm();

            Note = note;
            tbTitle.Text = note.Title;
            cbFavorite.Checked = note.Favorite;
            cmbCategories.SelectedIndex = cmbCategories.FindStringExact(note.Category);
            if (cmbCategories.SelectedIndex == -1)
            {
                cmbCategories.SelectedIndex = 0;
            }
            MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(Note.RichTextBoxRtf));
            rtbContent.LoadFile(stream, RichTextBoxStreamType.RichText);
            rtbContent.Select();

            tableLayoutPanel1.HorizontalScroll.Visible = false;

            foreach (var hyperlink in note.Hyperlinks)
            {
                add_link_and_button(hyperlink.Key, hyperlink.Value, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.RowCount++;
            }
        }

        public void setForm()
        {
            cmbCategories.DataSource = Note.categories;

            tableLayoutPanel1.Parent = panelHyperlinks;

            btnAdd.Location = new Point(this.Width - 170, this.Height - 75);
            btnCancel.Location = new Point(this.Width - 90, this.Height - 75);
            panelHyperlinks.Location = new Point(this.Width - 260, 55);
            tbTitle.Width = this.Width - panelHyperlinks.Width - 25;
            rtbContent.Width = this.Width - panelHyperlinks.Width - 25;
            panelHyperlinks.Height = this.Height - 150;
            tableLayoutPanel1.Height = this.Height - 200;

            rtbContent.Height = this.Height - 200;

            tbFindText.Parent = this;
            tbFindText.Size = new Size(100, 40);
            tbFindText.Font = new Font(tbFindText.Font.FontFamily, 12);

            btnDeleteFindTb.Text = "x";
            btnDeleteFindTb.Size = new Size(20, 20);
            btnDeleteFindTb.TextAlign = ContentAlignment.MiddleCenter;
            btnDeleteFindTb.FlatStyle = FlatStyle.Flat;
            btnDeleteFindTb.FlatAppearance.BorderSize = 0;
            btnDeleteFindTb.Location = new Point(tbFindText.ClientSize.Width - btnDeleteFindTb.Width, -3);
            btnDeleteFindTb.Cursor = Cursors.Default;

            tbFindText.Controls.Add(btnDeleteFindTb);
            tbFindText.Location = new Point(this.Width - 350, 120);

            tbFindText.TextChanged += TbFindText_TextChanged;
            btnDeleteFindTb.Click += DisabletbFindText;

            tbFindText.BringToFront();

            tbFindText.Visible = false;
            btnDeleteFindTb.Visible = false;

            panelCategories.Location = new Point(tbTitle.Width - 120, 30);
        }


        private void TbFindText_TextChanged(object sender, EventArgs e)
        {
            rtbContent.SelectionStart = 0;
            rtbContent.SelectionLength = rtbContent.TextLength;
            rtbContent.SelectionBackColor = Color.White;
            Find(rtbContent, tbFindText.Text);
        }

        private void Find(RichTextBox richTextBox1, String textBox1Text)
        {
            string[] words = textBox1Text.Split(',');
            foreach (string word in words)
            {
                int startindex = 0;
                while (startindex < richTextBox1.TextLength)
                {
                    int wordstartIndex = richTextBox1.Find(word, startindex, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        richTextBox1.SelectionStart = wordstartIndex;
                        richTextBox1.SelectionLength = word.Length;
                        richTextBox1.SelectionBackColor = Color.Yellow;
                    }
                    else
                        break;
                    startindex += wordstartIndex + word.Length;
                }
            }
        }

        public void DisabletbFindText(object sender, EventArgs e)
        {
            tbFindText.Visible = false;
            btnDeleteFindTb.Visible = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cat = cmbCategories.SelectedValue.ToString();


            Dictionary<string, string> hyperlinks = get_all_hyperlinks();

            if (cat == "All Notes")
            {
                Note = new Note(tbTitle.Text, rtbContent.ForeColor, rtbContent.Rtf, cbFavorite.Checked, "", hyperlinks);
            }
            else
            {
                Note = new Note(tbTitle.Text, rtbContent.ForeColor, rtbContent.Rtf, cbFavorite.Checked, 
                    cmbCategories.SelectedValue.ToString(), hyperlinks);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        //TOOLS
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                rtbContent.SelectionFont = fd.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtbContent.SelectionColor = cd.Color;
            }
        }

        private void highlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtbContent.SelectionBackColor = cd.Color;
            }
        }

        private void noHighlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.SelectionBackColor = Color.Transparent;
        }

        //*TOOLS

        //EDIT

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbTitle.Clear();
            rtbContent.Clear();
            removeAllHyperlinks();
            cbFavorite.Checked = false;
            cmbCategories.SelectedIndex = 0;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Cut();
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.SelectAll();
        }

        private void findCtrlFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbFindText.Visible = true;
            btnDeleteFindTb.Visible = true;
            tbFindText.Focus();
        }

        //*EDIT

        private void NoteForm_Resize(object sender, EventArgs e)
        {
            setForm();
        }


        private void btnAddCategory_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add a new category", btnAddCategory);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryForm cf = new CategoryForm();
            if (cf.ShowDialog() == DialogResult.OK)
            {
                if (cf.category != "")
                {
                    Note.categories.Add(cf.category);
                }
                cmbCategories.SelectedIndex = cmbCategories.Items.Count - 1;
            }
        }

        private void Link_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private Dictionary<string, string> get_all_hyperlinks()
        {
            Dictionary<string, string> hyperlinks = new Dictionary<string, string>();


            TableLayoutControlCollection controls = tableLayoutPanel1.Controls;

            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i] is LinkLabel)
                {
                    LinkLabel ll = (LinkLabel)controls[i];
                    hyperlinks.Add(ll.Text, ll.Tag.ToString());
                }
            }

            return hyperlinks;
        }


        private void remove_hyperlink_clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            int row = tableLayoutPanel1.GetRow(btn);

            if (row >= tableLayoutPanel1.RowCount)
            {
                return;
            }

            var control = tableLayoutPanel1.GetControlFromPosition(0, row);
            tableLayoutPanel1.Controls.Remove(control);
            control = tableLayoutPanel1.GetControlFromPosition(1, row);
            tableLayoutPanel1.Controls.Remove(control);


            for (int i = row + 1; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    var c = tableLayoutPanel1.GetControlFromPosition(j, i);
                    if (c != null)
                    {
                        tableLayoutPanel1.SetRow(c, i - 1);
                    }
                }
            }

            var removeStyle = tableLayoutPanel1.RowCount - 1;

            if (tableLayoutPanel1.RowStyles.Count > removeStyle)
                tableLayoutPanel1.RowStyles.RemoveAt(removeStyle);

            tableLayoutPanel1.RowCount--;
        }

        private void removeAllHyperlinks()
        {
            while (tableLayoutPanel1.Controls.Count > 0)
            {
                tableLayoutPanel1.Controls[0].Dispose();
            }
        }

        private void link_label_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = (string)ll.Tag;
            process.Start();
        }

        private void add_link_and_button(string text, string value, int row_index)
        {
            LinkLabel l = new LinkLabel() { Text = text, Tag = value, Width = 100 };
            l.LinkClicked += link_label_clicked;
            System.Windows.Forms.Button b = new System.Windows.Forms.Button() { Text = "Remove", Width = 50 };
            b.Font = new Font(b.Font.FontFamily, 6);
            b.Click += remove_hyperlink_clicked;



            tableLayoutPanel1.Controls.Add(l, 0, row_index);
            tableLayoutPanel1.Controls.Add(b, 1, row_index);
            tableLayoutPanel1.RowCount++;
        }

        private void btnAddHyperlink_Click(object sender, EventArgs e)
        {
            HyperlinkForm form = new HyperlinkForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                add_link_and_button(form.HyperlinkText, form.HyperlinkValue, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.RowCount++;
            }
        }

        private void NoteForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void NoteForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (file.EndsWith(".rtf"))
                    rtbContent.LoadFile(file);
                else if (file.EndsWith(".txt"))
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(file);
                    rtbContent.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }

        }

    }
}
