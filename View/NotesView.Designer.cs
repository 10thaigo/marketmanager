namespace MarketManager.View
{
    partial class NotesView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.icon = new FontAwesome.Sharp.IconPictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.button_addnote = new FontAwesome.Sharp.IconButton();
            this.grid_notes = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_notes)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.SystemColors.Control;
            this.icon.ForeColor = System.Drawing.Color.DimGray;
            this.icon.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.icon.IconColor = System.Drawing.Color.DimGray;
            this.icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon.IconSize = 50;
            this.icon.Location = new System.Drawing.Point(12, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 50);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.DimGray;
            this.label_title.Location = new System.Drawing.Point(68, 24);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(111, 24);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Your notes";
            // 
            // label_info
            // 
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.DimGray;
            this.label_info.Location = new System.Drawing.Point(12, 65);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(750, 341);
            this.label_info.TabIndex = 2;
            this.label_info.Text = "undefined";
            this.label_info.Visible = false;
            // 
            // button_addnote
            // 
            this.button_addnote.FlatAppearance.BorderSize = 0;
            this.button_addnote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addnote.ForeColor = System.Drawing.Color.DimGray;
            this.button_addnote.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.button_addnote.IconColor = System.Drawing.Color.DimGray;
            this.button_addnote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_addnote.IconSize = 42;
            this.button_addnote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addnote.Location = new System.Drawing.Point(625, 463);
            this.button_addnote.Margin = new System.Windows.Forms.Padding(0);
            this.button_addnote.Name = "button_addnote";
            this.button_addnote.Size = new System.Drawing.Size(166, 46);
            this.button_addnote.TabIndex = 5;
            this.button_addnote.Text = "Add new note";
            this.button_addnote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addnote.UseVisualStyleBackColor = true;
            // 
            // grid_notes
            // 
            this.grid_notes.AllowUserToAddRows = false;
            this.grid_notes.AllowUserToDeleteRows = false;
            this.grid_notes.AllowUserToResizeColumns = false;
            this.grid_notes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_notes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_notes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_notes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grid_notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_notes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.grid_notes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_notes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_notes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.creationDate});
            this.grid_notes.EnableHeadersVisualStyles = false;
            this.grid_notes.Location = new System.Drawing.Point(16, 68);
            this.grid_notes.MultiSelect = false;
            this.grid_notes.Name = "grid_notes";
            this.grid_notes.ReadOnly = true;
            this.grid_notes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_notes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_notes.RowHeadersVisible = false;
            this.grid_notes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_notes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_notes.ShowCellErrors = false;
            this.grid_notes.ShowCellToolTips = false;
            this.grid_notes.ShowEditingIcon = false;
            this.grid_notes.ShowRowErrors = false;
            this.grid_notes.Size = new System.Drawing.Size(772, 392);
            this.grid_notes.TabIndex = 6;
            this.grid_notes.Visible = false;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // creationDate
            // 
            this.creationDate.HeaderText = "Creation date";
            this.creationDate.Name = "creationDate";
            this.creationDate.ReadOnly = true;
            // 
            // NotesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.grid_notes);
            this.Controls.Add(this.button_addnote);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotesView";
            this.Text = "NotesView";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox icon;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_info;
        private FontAwesome.Sharp.IconButton button_addnote;
        private System.Windows.Forms.DataGridView grid_notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDate;
    }
}