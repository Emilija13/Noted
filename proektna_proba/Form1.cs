using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using proektna_proba.Properties;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Diagnostics;

namespace proektna_proba
{
    public partial class Form1 : Form
    {
        public List<Note> notes { get; set; } = new List<Note>();

        public Form1()
        {
            InitializeComponent();
            SetForm();
        }

        public void SetForm()
        {
            FillDataGridView(notes);
            rtbNoteContent.ReadOnly = true;
            SetDataSource();

            btnAddNote.FlatStyle = FlatStyle.Flat;
            btnAddNote.FlatAppearance.BorderSize = 0;

            btnDeleteNote.FlatStyle = FlatStyle.Flat;
            btnDeleteNote.FlatAppearance.BorderSize = 0;

            btnOpenNoteForm.FlatStyle = FlatStyle.Flat;
            btnOpenNoteForm.FlatAppearance.BorderSize = 0;

            btnMoveTo.FlatStyle = FlatStyle.Flat;
            btnMoveTo.FlatAppearance.BorderSize = 0;

            btnAddToFavorites.FlatStyle = FlatStyle.Flat;
            btnAddToFavorites.FlatAppearance.BorderSize = 0;

            btnRemoveFromFavorites.FlatStyle = FlatStyle.Flat;
            btnRemoveFromFavorites.FlatAppearance.BorderSize = 0;

            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.FlatAppearance.BorderSize = 0;

            rtbNoteContent.Parent = groupBox1;
            groupBox1.Width = this.Width - 650;
            groupBox1.Height = this.Height - 50;
            rtbNoteContent.Width = groupBox1.Width - 200;
            rtbNoteContent.Height = groupBox1.Height - 23;
            groupBox6.Height = groupBox1.Height - 23;
            hyperlinksPanel.Height = groupBox6.Height - 50;
            dataGridView1.Height = this.Height - 115;
        }

        private void SetDataSource()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Note.categories;
            cmbCategories.DataSource = bindingSource;
            cmbCategoriesMove.DataSource = Note.categories;
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            NoteForm nf = new NoteForm();
            if(nf.ShowDialog() == DialogResult.OK)
            {
                notes.Add(nf.Note);
                notes.Sort((x, y) => x.Compare(x, y));

                SerializeNotes();

                FillDataGridView(notes);
                Note.categories.ResetBindings();

                cmbCategories.DataSource = null;
                cmbCategories.Items.Clear();
                cmbCategories.DataSource = Note.categories;
            }
        }


        public void SerializeNotes()
        {
            Stream stream = File.Open("NoteData.dat", FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, notes);
            stream.Close();
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete the selected note/s?",
                "Delete selected note/s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<int> IDs = GetIDOfSelectedRows();
                if (IDs != null)
                {
                    foreach (int id in IDs)
                    {
                        notes.RemoveAll(note => note.ID == id);
                    }
                    SerializeNotes();
                    FillDataGridView(notes);
                }

                if (notes.Count == 0)
                {
                    rtbNoteContent.Clear();
                    hyperlinksPanel.Controls.Clear();
                }
            }
        }

        private void btnOpenNoteForm_Click(object sender, EventArgs e)
        {
            List<int> IDs = GetIDOfSelectedRows();
            if(IDs.Count == 4)
            {
                Note note = notes.Find(item  => item.ID == IDs[0]);
                NoteForm nf = new NoteForm(note);
                if (nf.ShowDialog() == DialogResult.OK)
                {
                    notes.Remove(note);
                    notes.Add(nf.Note);
                    notes.Sort((x, y) => x.Compare(x, y));

                    SerializeNotes();

                    cmbCategories.DataSource = null;
                    cmbCategories.Items.Clear();
                    cmbCategories.DataSource = Note.categories;

                    cmbCategoriesMove.DataSource = null;
                    cmbCategoriesMove.Items.Clear();
                    cmbCategoriesMove.DataSource = Note.categories;
                }
            }
        }


        private List<int> GetIDOfSelectedRows()
        {
            if(dataGridView1.SelectedCells.Count > 0)
            {
                List<int> selectedIndexes = new List<int>();
                List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

                for (int i = 0; i < dataGridView1.SelectedCells.Count -1; i++)
                {
                    selectedIndexes.Add(dataGridView1.SelectedCells[i].RowIndex);
                }

                foreach(int index in selectedIndexes)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[index];
                    selectedRows.Add(selectedRow);
                }

                List<int> IDs = new List<int>();
                foreach (DataGridViewRow row in selectedRows)
                {
                    IDs.Add(Convert.ToInt32(row.Cells["Column5"].Value));
                }

                return IDs;
            }
            return null;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                List<int> IDs = GetIDOfSelectedRows();
                int ID = IDs[0];

                foreach(Note n in notes)
                {
                    if(ID.Equals(n.ID))
                    {
                        MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(n.RichTextBoxRtf));
                        rtbNoteContent.LoadFile(stream, RichTextBoxStreamType.RichText);

                        int row_index = 0;

                        hyperlinksPanel.Controls.Clear();
                        hyperlinksPanel.RowCount = 0;

                        foreach (var hyperlink in n.Hyperlinks)
                        {
                            LinkLabel ll = new LinkLabel() { Tag = hyperlink.Value, Text = hyperlink.Key, Width = 100 };
                            ll.LinkClicked += link_label_clicked;
                            hyperlinksPanel.Controls.Add(ll, 0, row_index);
                            row_index++;
                            hyperlinksPanel.RowCount++;
                        }

                        break;
                    }
                }
                
            }
        }

        private void link_label_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = (string)ll.Tag;
            try
            {
                process.Start();
            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }


        }

        private List<Note> getListOfNotesByCategory(String category)
        {
            List<Note> sortedNotes = new List<Note>();
            foreach (Note note in notes)
            {
                if (note.Category == cmbCategories.SelectedValue.ToString())
                {
                    sortedNotes.Add(note);
                }
            }
            return sortedNotes;
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.Items.Count > 0 && cmbCategories.SelectedIndex!=-1)
            {
                if (cmbCategories.SelectedValue.ToString() == "All Notes")
                {
                    FillDataGridView(notes);
                }
                else
                {
                    List<Note> sortedNotes = getListOfNotesByCategory((String)cmbCategories.SelectedItem);
                    FillDataGridView(sortedNotes);
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AdvancedCategoryForm cf = new AdvancedCategoryForm();
            if (cf.ShowDialog() == DialogResult.OK)
            {
                if (cf.category != "")
                {
                    Note.categories.Add(cf.category);
                }

                foreach (Note note in notes)
                {
                    bool catExists = false;
                    foreach(String cat in Note.categories)
                    {
                        if(note.Category == cat || note.Category=="")
                        {
                            catExists = true;
                        }
                    }
                    if (!catExists)
                    {
                        note.Category = "";
                    }
                }

                SerializeNotes();
                FillDataGridView(notes);

                cmbCategories.DataSource = null;
                cmbCategories.Items.Clear();
                cmbCategories.DataSource = Note.categories;

                cmbCategoriesMove.DataSource = null;
                cmbCategoriesMove.Items.Clear();
                cmbCategoriesMove.DataSource = Note.categories;

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetForm();
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to move the selected note/s? to {cmbCategoriesMove.SelectedValue.ToString()}",
                "Move selected note/s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<int> selectedNotesIDs = GetIDOfSelectedRows();
                foreach (Note note in notes)
                {
                    foreach (int ID in selectedNotesIDs)
                    {
                        if (note.ID == ID)
                        {
                            if(cmbCategoriesMove.SelectedValue.ToString() == "All Notes")
                            {
                                note.Category = "";
                            }
                            else
                            {
                                note.Category = cmbCategoriesMove.SelectedValue.ToString();
                            }
                            
                        }
                    }
                }
                cmbCategories.SelectedIndex = 0;
                SerializeNotes();
                FillDataGridView(notes);
            }  
        }

        private void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            List<int> selectedIDs = GetIDOfSelectedRows();
            foreach(Note note in notes)
            {
               foreach(int ID in selectedIDs)
                {
                    if(note.ID == ID)
                    {
                        note.Favorite = true;
                    }
                }
            }
            notes.Sort((x, y) => x.Compare(x, y));
            SerializeNotes();
            List<Note> NotesByCategory = getListOfNotesByCategory((String)cmbCategories.SelectedItem);
            
            if ((String)cmbCategories.SelectedItem == "All Notes")
            {
                FillDataGridView(notes);
            }
            else
            {
                FillDataGridView(NotesByCategory);
            }
        }

        private void btnRemoveFromFavorites_Click(object sender, EventArgs e)
        {
            List<int> selectedIDs = GetIDOfSelectedRows();
            foreach (Note note in notes)
            {
                foreach (int ID in selectedIDs)
                {
                    if (note.ID == ID)
                    {
                        note.Favorite = false;
                    }
                }
            }
            notes.Sort((x, y) => x.Compare(x, y));
            SerializeNotes();
            List<Note> NotesByCategory = getListOfNotesByCategory((String)cmbCategories.SelectedItem);
            
            if ((String)cmbCategories.SelectedItem == "All Notes")
            {
                FillDataGridView(notes);
            }
            else
            {
                FillDataGridView(NotesByCategory);
            }
        }

        public void FillDataGridView(List<Note> notesList)
        {
            if (File.Exists("NoteData.dat"))
            {
                Stream str = File.Open("NoteData.dat", FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                notes = (List<Note>)binaryFormatter.Deserialize(str);
                str.Close();
            }

            dataGridView1.Rows.Clear();

            foreach (Note note in notesList)
            {
                String title;
                if(note.Title == "")
                {
                    title = "(Untitled)";
                }
                else
                {
                    title= note.Title;
                }
                if(note.Favorite)
                {
                    dataGridView1.Rows.Add(new object[] {imageList1.Images[0], title, note.Category, note.DateTime, note.ID});
                }
                else
                {
                    dataGridView1.Rows.Add(new object[] { imageList1.Images[1], title, note.Category, note.DateTime, note.ID});
                }
            }
        }
    }
}
