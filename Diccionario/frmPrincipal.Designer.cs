
namespace Diccionario
{
    partial class Diccionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diccionario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.search = new System.Windows.Forms.TabPage();
            this.gvWords = new System.Windows.Forms.DataGridView();
            this.gfrd = new System.Windows.Forms.Label();
            this.cbSearchDictionary = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.word = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveWord = new System.Windows.Forms.Button();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDictionary = new System.Windows.Forms.ListBox();
            this.dictionary = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManageDictionary = new System.Windows.Forms.TextBox();
            this.btnEditDictionary = new System.Windows.Forms.Button();
            this.btnDeleteDictionary = new System.Windows.Forms.Button();
            this.btnCreateDictionary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAvailableDictionaries = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWords)).BeginInit();
            this.word.SuspendLayout();
            this.dictionary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.search);
            this.tabControl1.Controls.Add(this.word);
            this.tabControl1.Controls.Add(this.dictionary);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(802, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // search
            // 
            this.search.Controls.Add(this.label6);
            this.search.Controls.Add(this.gvWords);
            this.search.Controls.Add(this.gfrd);
            this.search.Controls.Add(this.cbSearchDictionary);
            this.search.Controls.Add(this.btnSearch);
            this.search.Controls.Add(this.txtSearch);
            this.search.Location = new System.Drawing.Point(4, 22);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(3);
            this.search.Size = new System.Drawing.Size(794, 424);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.ToolTipText = "Search for a word";
            this.search.UseVisualStyleBackColor = true;
            // 
            // gvWords
            // 
            this.gvWords.AllowUserToAddRows = false;
            this.gvWords.AllowUserToDeleteRows = false;
            this.gvWords.AllowUserToOrderColumns = true;
            this.gvWords.AllowUserToResizeRows = false;
            this.gvWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvWords.BackgroundColor = System.Drawing.Color.White;
            this.gvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWords.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gvWords.Location = new System.Drawing.Point(84, 87);
            this.gvWords.Name = "gvWords";
            this.gvWords.ReadOnly = true;
            this.gvWords.RowHeadersWidth = 20;
            this.gvWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvWords.Size = new System.Drawing.Size(624, 233);
            this.gvWords.TabIndex = 4;
            this.gvWords.Visible = false;
            // 
            // gfrd
            // 
            this.gfrd.AutoSize = true;
            this.gfrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gfrd.Location = new System.Drawing.Point(140, 51);
            this.gfrd.Name = "gfrd";
            this.gfrd.Size = new System.Drawing.Size(76, 20);
            this.gfrd.TabIndex = 3;
            this.gfrd.Text = "Search in";
            // 
            // cbSearchDictionary
            // 
            this.cbSearchDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchDictionary.FormattingEnabled = true;
            this.cbSearchDictionary.Location = new System.Drawing.Point(222, 48);
            this.cbSearchDictionary.Name = "cbSearchDictionary";
            this.cbSearchDictionary.Size = new System.Drawing.Size(121, 28);
            this.cbSearchDictionary.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(621, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(457, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // word
            // 
            this.word.Controls.Add(this.label4);
            this.word.Controls.Add(this.btnSaveWord);
            this.word.Controls.Add(this.txtMeaning);
            this.word.Controls.Add(this.label3);
            this.word.Controls.Add(this.txtWord);
            this.word.Controls.Add(this.label2);
            this.word.Controls.Add(this.lbDictionary);
            this.word.Location = new System.Drawing.Point(4, 22);
            this.word.Name = "word";
            this.word.Padding = new System.Windows.Forms.Padding(3);
            this.word.Size = new System.Drawing.Size(794, 424);
            this.word.TabIndex = 1;
            this.word.Text = "Add a word";
            this.word.ToolTipText = "Add a word to a dictionary";
            this.word.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Meaning";
            // 
            // btnSaveWord
            // 
            this.btnSaveWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWord.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveWord.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveWord.Image")));
            this.btnSaveWord.Location = new System.Drawing.Point(412, 192);
            this.btnSaveWord.Name = "btnSaveWord";
            this.btnSaveWord.Size = new System.Drawing.Size(39, 38);
            this.btnSaveWord.TabIndex = 11;
            this.btnSaveWord.UseVisualStyleBackColor = true;
            this.btnSaveWord.Click += new System.EventHandler(this.btnSaveWord_Click);
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeaning.Location = new System.Drawing.Point(412, 143);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(151, 26);
            this.txtMeaning.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Word";
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(412, 62);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(151, 26);
            this.txtWord.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Dictionary";
            // 
            // lbDictionary
            // 
            this.lbDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDictionary.FormattingEnabled = true;
            this.lbDictionary.ItemHeight = 20;
            this.lbDictionary.Location = new System.Drawing.Point(114, 62);
            this.lbDictionary.Name = "lbDictionary";
            this.lbDictionary.Size = new System.Drawing.Size(218, 284);
            this.lbDictionary.TabIndex = 6;
            // 
            // dictionary
            // 
            this.dictionary.Controls.Add(this.label5);
            this.dictionary.Controls.Add(this.txtManageDictionary);
            this.dictionary.Controls.Add(this.btnEditDictionary);
            this.dictionary.Controls.Add(this.btnDeleteDictionary);
            this.dictionary.Controls.Add(this.btnCreateDictionary);
            this.dictionary.Controls.Add(this.label1);
            this.dictionary.Controls.Add(this.lbAvailableDictionaries);
            this.dictionary.Location = new System.Drawing.Point(4, 22);
            this.dictionary.Name = "dictionary";
            this.dictionary.Size = new System.Drawing.Size(794, 424);
            this.dictionary.TabIndex = 2;
            this.dictionary.Text = "Add a dictionary";
            this.dictionary.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dictionary name";
            // 
            // txtManageDictionary
            // 
            this.txtManageDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManageDictionary.Location = new System.Drawing.Point(490, 62);
            this.txtManageDictionary.Name = "txtManageDictionary";
            this.txtManageDictionary.Size = new System.Drawing.Size(177, 31);
            this.txtManageDictionary.TabIndex = 20;
            // 
            // btnEditDictionary
            // 
            this.btnEditDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDictionary.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDictionary.Image")));
            this.btnEditDictionary.Location = new System.Drawing.Point(338, 116);
            this.btnEditDictionary.Name = "btnEditDictionary";
            this.btnEditDictionary.Size = new System.Drawing.Size(37, 40);
            this.btnEditDictionary.TabIndex = 19;
            this.btnEditDictionary.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDictionary
            // 
            this.btnDeleteDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDictionary.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDictionary.Image")));
            this.btnDeleteDictionary.Location = new System.Drawing.Point(338, 62);
            this.btnDeleteDictionary.Name = "btnDeleteDictionary";
            this.btnDeleteDictionary.Size = new System.Drawing.Size(37, 39);
            this.btnDeleteDictionary.TabIndex = 18;
            this.btnDeleteDictionary.UseVisualStyleBackColor = true;
            this.btnDeleteDictionary.Click += new System.EventHandler(this.btnDeleteDictionary_Click);
            // 
            // btnCreateDictionary
            // 
            this.btnCreateDictionary.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateDictionary.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDictionary.ForeColor = System.Drawing.Color.Transparent;
            this.btnCreateDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateDictionary.Image")));
            this.btnCreateDictionary.Location = new System.Drawing.Point(673, 55);
            this.btnCreateDictionary.Name = "btnCreateDictionary";
            this.btnCreateDictionary.Size = new System.Drawing.Size(39, 38);
            this.btnCreateDictionary.TabIndex = 17;
            this.btnCreateDictionary.UseVisualStyleBackColor = false;
            this.btnCreateDictionary.Click += new System.EventHandler(this.btnCreateDictionary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Available Dicionaries";
            // 
            // lbAvailableDictionaries
            // 
            this.lbAvailableDictionaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailableDictionaries.FormattingEnabled = true;
            this.lbAvailableDictionaries.ItemHeight = 20;
            this.lbAvailableDictionaries.Location = new System.Drawing.Point(114, 62);
            this.lbAvailableDictionaries.Name = "lbAvailableDictionaries";
            this.lbAvailableDictionaries.Size = new System.Drawing.Size(218, 284);
            this.lbAvailableDictionaries.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Word";
            // 
            // Diccionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Diccionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Diccionario_Load);
            this.tabControl1.ResumeLayout(false);
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWords)).EndInit();
            this.word.ResumeLayout(false);
            this.word.PerformLayout();
            this.dictionary.ResumeLayout(false);
            this.dictionary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage search;
        private System.Windows.Forms.TabPage word;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lbDictionary;
        private System.Windows.Forms.TabPage dictionary;
        private System.Windows.Forms.Label gfrd;
        private System.Windows.Forms.ComboBox cbSearchDictionary;
        private System.Windows.Forms.TextBox txtManageDictionary;
        private System.Windows.Forms.Button btnEditDictionary;
        private System.Windows.Forms.Button btnDeleteDictionary;
        private System.Windows.Forms.Button btnCreateDictionary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAvailableDictionaries;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveWord;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvWords;
        private System.Windows.Forms.Label label6;
    }
}

