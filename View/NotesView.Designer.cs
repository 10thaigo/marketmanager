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
            this.icon = new FontAwesome.Sharp.IconPictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.button_addnote = new FontAwesome.Sharp.IconButton();
            this.panel_notes = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
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
            // panel_notes
            // 
            this.panel_notes.AutoScroll = true;
            this.panel_notes.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_notes.Location = new System.Drawing.Point(16, 68);
            this.panel_notes.Name = "panel_notes";
            this.panel_notes.Size = new System.Drawing.Size(772, 392);
            this.panel_notes.TabIndex = 6;
            // 
            // NotesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.panel_notes);
            this.Controls.Add(this.button_addnote);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotesView";
            this.Text = "NotesView";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox icon;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_info;
        private FontAwesome.Sharp.IconButton button_addnote;
        private System.Windows.Forms.FlowLayoutPanel panel_notes;
    }
}