namespace proektna_proba
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.btnOpenNoteForm = new System.Windows.Forms.Button();
            this.rtbNoteContent = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.hyperlinksPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnMoveTo = new System.Windows.Forms.Button();
            this.cmbCategoriesMove = new System.Windows.Forms.ComboBox();
            this.btnAddToFavorites = new System.Windows.Forms.Button();
            this.btnRemoveFromFavorites = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnAddNote.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNote.Location = new System.Drawing.Point(143, 14);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(57, 64);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "New";
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteNote.Location = new System.Drawing.Point(61, 14);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(82, 64);
            this.btnDeleteNote.TabIndex = 3;
            this.btnDeleteNote.Text = "Delete";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // btnOpenNoteForm
            // 
            this.btnOpenNoteForm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNoteForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenNoteForm.Location = new System.Drawing.Point(6, 14);
            this.btnOpenNoteForm.Name = "btnOpenNoteForm";
            this.btnOpenNoteForm.Size = new System.Drawing.Size(54, 64);
            this.btnOpenNoteForm.TabIndex = 4;
            this.btnOpenNoteForm.Text = "Edit";
            this.btnOpenNoteForm.UseVisualStyleBackColor = true;
            this.btnOpenNoteForm.Click += new System.EventHandler(this.btnOpenNoteForm_Click);
            // 
            // rtbNoteContent
            // 
            this.rtbNoteContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbNoteContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNoteContent.Location = new System.Drawing.Point(229, 21);
            this.rtbNoteContent.Name = "rtbNoteContent";
            this.rtbNoteContent.Size = new System.Drawing.Size(381, 445);
            this.rtbNoteContent.TabIndex = 5;
            this.rtbNoteContent.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "YellowStar");
            this.imageList1.Images.SetKeyName(1, "transparentpicture.png");
            this.imageList1.Images.SetKeyName(2, "bin_icon_gray.png");
            this.imageList1.Images.SetKeyName(3, "Edit-icon-grey.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Date,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(823, 388);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Title";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Category";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 200;
            // 
            // Date
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.DefaultCellStyle = dataGridViewCellStyle5;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Date.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Show";
            // 
            // cmbCategories
            // 
            this.cmbCategories.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(6, 36);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(124, 30);
            this.cmbCategories.TabIndex = 9;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCategory.Location = new System.Drawing.Point(136, 36);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(29, 33);
            this.btnAddCategory.TabIndex = 10;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.rtbNoteContent);
            this.groupBox1.Location = new System.Drawing.Point(841, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(627, 490);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Note content";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.hyperlinksPanel);
            this.groupBox6.Location = new System.Drawing.Point(6, 21);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(217, 456);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Note Hyperlinks";
            // 
            // hyperlinksPanel
            // 
            this.hyperlinksPanel.AutoScroll = true;
            this.hyperlinksPanel.ColumnCount = 1;
            this.hyperlinksPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hyperlinksPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.hyperlinksPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinksPanel.Location = new System.Drawing.Point(6, 21);
            this.hyperlinksPanel.Margin = new System.Windows.Forms.Padding(4);
            this.hyperlinksPanel.Name = "hyperlinksPanel";
            this.hyperlinksPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hyperlinksPanel.RowCount = 1;
            this.hyperlinksPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hyperlinksPanel.Size = new System.Drawing.Size(204, 429);
            this.hyperlinksPanel.TabIndex = 11;
            // 
            // btnMoveTo
            // 
            this.btnMoveTo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoveTo.Location = new System.Drawing.Point(5, 15);
            this.btnMoveTo.Name = "btnMoveTo";
            this.btnMoveTo.Size = new System.Drawing.Size(92, 63);
            this.btnMoveTo.TabIndex = 13;
            this.btnMoveTo.Text = "Move to";
            this.btnMoveTo.UseVisualStyleBackColor = true;
            this.btnMoveTo.Click += new System.EventHandler(this.btnMoveTo_Click);
            // 
            // cmbCategoriesMove
            // 
            this.cmbCategoriesMove.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriesMove.FormattingEnabled = true;
            this.cmbCategoriesMove.Location = new System.Drawing.Point(103, 36);
            this.cmbCategoriesMove.Name = "cmbCategoriesMove";
            this.cmbCategoriesMove.Size = new System.Drawing.Size(131, 30);
            this.cmbCategoriesMove.TabIndex = 15;
            // 
            // btnAddToFavorites
            // 
            this.btnAddToFavorites.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToFavorites.Location = new System.Drawing.Point(4, 12);
            this.btnAddToFavorites.Name = "btnAddToFavorites";
            this.btnAddToFavorites.Size = new System.Drawing.Size(179, 30);
            this.btnAddToFavorites.TabIndex = 16;
            this.btnAddToFavorites.Text = "Add to Favorites";
            this.btnAddToFavorites.UseVisualStyleBackColor = true;
            this.btnAddToFavorites.Click += new System.EventHandler(this.btnAddToFavorites_Click);
            // 
            // btnRemoveFromFavorites
            // 
            this.btnRemoveFromFavorites.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveFromFavorites.Location = new System.Drawing.Point(6, 48);
            this.btnRemoveFromFavorites.Name = "btnRemoveFromFavorites";
            this.btnRemoveFromFavorites.Size = new System.Drawing.Size(177, 29);
            this.btnRemoveFromFavorites.TabIndex = 17;
            this.btnRemoveFromFavorites.Text = "Remove From Favorites";
            this.btnRemoveFromFavorites.UseVisualStyleBackColor = true;
            this.btnRemoveFromFavorites.Click += new System.EventHandler(this.btnRemoveFromFavorites_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBox2.Controls.Add(this.btnAddNote);
            this.groupBox2.Controls.Add(this.btnOpenNoteForm);
            this.groupBox2.Controls.Add(this.btnDeleteNote);
            this.groupBox2.Location = new System.Drawing.Point(186, -6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 83);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBox3.Controls.Add(this.cmbCategories);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnAddCategory);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(12, -6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 83);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBox4.Controls.Add(this.cmbCategoriesMove);
            this.groupBox4.Controls.Add(this.btnMoveTo);
            this.groupBox4.Location = new System.Drawing.Point(392, -6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 83);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBox5.Controls.Add(this.btnRemoveFromFavorites);
            this.groupBox5.Controls.Add(this.btnAddToFavorites);
            this.groupBox5.Location = new System.Drawing.Point(646, -6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 83);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1480, 632);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Noted";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.Button btnOpenNoteForm;
        private System.Windows.Forms.RichTextBox rtbNoteContent;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMoveTo;
        private System.Windows.Forms.ComboBox cmbCategoriesMove;
        private System.Windows.Forms.Button btnAddToFavorites;
        private System.Windows.Forms.Button btnRemoveFromFavorites;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel hyperlinksPanel;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

