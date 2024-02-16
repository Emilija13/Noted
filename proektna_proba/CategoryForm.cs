using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proektna_proba
{
    public partial class CategoryForm : Form
    {
        public String category;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private bool NameExists(String category)
        {
            foreach(String c in Note.categories)
            {
                if(category == c)
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
            category = tbName.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
