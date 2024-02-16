using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proektna_proba
{
    public partial class HyperlinkForm : Form
    {
        public string HyperlinkText { get; set; }
        public string HyperlinkValue { get; set; }
        public HyperlinkForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            HyperlinkValue = textBox2.Text;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            HyperlinkValue = files[0];
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            label5.Visible = true;
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HyperlinkText = textBox1.Text;
        }
    }
}
