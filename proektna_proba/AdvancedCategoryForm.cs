using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proektna_proba//A
{
    public partial class AdvancedCategoryForm : Form
    {
        public String category;
        public AdvancedCategoryForm()
        {
            InitializeComponent();
            clbCategories.DataSource = Note.categories;
        }

        private bool NameExists(String category)
        {
            foreach (String c in Note.categories)
            {
                if (category == c)
                {
                    return true;
                }
            }
            return false;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (NameExists(tbName.Text))
            {
                errorProvider1.SetError(tbName, "A category with this name already exists");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<String> categoriesToBeDeleted = new List<string>();
            foreach (var item in clbCategories.CheckedItems)
            {
                categoriesToBeDeleted.Add(item.ToString());
            }

            foreach (String cat in categoriesToBeDeleted)
            {
                Note.categories.Remove(cat);
            }

            clbCategories.DataSource = null;
            clbCategories.Items.Clear();
            clbCategories.DataSource = Note.categories;

            category = tbName.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
