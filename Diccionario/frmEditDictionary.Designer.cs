
namespace Diccionario
{
    partial class frmEditDictionary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditDictionary));
            this.label1 = new System.Windows.Forms.Label();
            this.lbDictionaryName = new System.Windows.Forms.Label();
            this.gvEditWords = new System.Windows.Forms.DataGridView();
            this.btnSaveWords = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmEditCells = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvEditWords)).BeginInit();
            this.cmEditCells.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dictionary:";
            // 
            // lbDictionaryName
            // 
            this.lbDictionaryName.AutoSize = true;
            this.lbDictionaryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDictionaryName.Location = new System.Drawing.Point(112, 9);
            this.lbDictionaryName.Name = "lbDictionaryName";
            this.lbDictionaryName.Size = new System.Drawing.Size(72, 25);
            this.lbDictionaryName.TabIndex = 1;
            this.lbDictionaryName.Text = "Name";
            // 
            // gvEditWords
            // 
            this.gvEditWords.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvEditWords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvEditWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvEditWords.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvEditWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvEditWords.ColumnHeadersHeight = 30;
            this.gvEditWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvEditWords.ContextMenuStrip = this.cmEditCells;
            this.gvEditWords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvEditWords.GridColor = System.Drawing.Color.Black;
            this.gvEditWords.Location = new System.Drawing.Point(16, 47);
            this.gvEditWords.Name = "gvEditWords";
            this.gvEditWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvEditWords.Size = new System.Drawing.Size(619, 391);
            this.gvEditWords.TabIndex = 2;
            this.gvEditWords.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvEditWords_KeyPress);
            // 
            // btnSaveWords
            // 
            this.btnSaveWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWords.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveWords.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveWords.Image")));
            this.btnSaveWords.Location = new System.Drawing.Point(641, 47);
            this.btnSaveWords.Name = "btnSaveWords";
            this.btnSaveWords.Size = new System.Drawing.Size(39, 38);
            this.btnSaveWords.TabIndex = 13;
            this.btnSaveWords.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(643, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmEditCells
            // 
            this.cmEditCells.BackColor = System.Drawing.Color.White;
            this.cmEditCells.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmEditCells.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeleteRow});
            this.cmEditCells.Name = "cmEditCells";
            this.cmEditCells.Size = new System.Drawing.Size(140, 26);
            // 
            // miDeleteRow
            // 
            this.miDeleteRow.Name = "miDeleteRow";
            this.miDeleteRow.Size = new System.Drawing.Size(139, 22);
            this.miDeleteRow.Text = "Delete row";
            // 
            // frmEditDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveWords);
            this.Controls.Add(this.gvEditWords);
            this.Controls.Add(this.lbDictionaryName);
            this.Controls.Add(this.label1);
            this.Name = "frmEditDictionary";
            this.Load += new System.EventHandler(this.frmEditDictionary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEditWords)).EndInit();
            this.cmEditCells.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDictionaryName;
        private System.Windows.Forms.DataGridView gvEditWords;
        private System.Windows.Forms.Button btnSaveWords;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip cmEditCells;
        private System.Windows.Forms.ToolStripMenuItem miDeleteRow;
    }
}