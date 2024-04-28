namespace MarketManager.Dialogs.Notes
{
    partial class AddNoteDialog
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_notetitle = new System.Windows.Forms.Label();
            this.label_notedescription = new System.Windows.Forms.Label();
            this.textbox_title = new System.Windows.Forms.TextBox();
            this.textbox_description = new System.Windows.Forms.RichTextBox();
            this.button_addnote = new FontAwesome.Sharp.IconButton();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_top.Controls.Add(this.label_title);
            this.panel_top.Controls.Add(this.button_exit);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(400, 32);
            this.panel_top.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(3, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(93, 15);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Add new note";
            // 
            // button_exit
            // 
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(368, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(32, 32);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // label_notetitle
            // 
            this.label_notetitle.AutoSize = true;
            this.label_notetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notetitle.ForeColor = System.Drawing.Color.DimGray;
            this.label_notetitle.Location = new System.Drawing.Point(3, 46);
            this.label_notetitle.Name = "label_notetitle";
            this.label_notetitle.Size = new System.Drawing.Size(43, 20);
            this.label_notetitle.TabIndex = 2;
            this.label_notetitle.Text = "Title";
            // 
            // label_notedescription
            // 
            this.label_notedescription.AutoSize = true;
            this.label_notedescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notedescription.ForeColor = System.Drawing.Color.DimGray;
            this.label_notedescription.Location = new System.Drawing.Point(3, 91);
            this.label_notedescription.Name = "label_notedescription";
            this.label_notedescription.Size = new System.Drawing.Size(100, 20);
            this.label_notedescription.TabIndex = 3;
            this.label_notedescription.Text = "Description";
            // 
            // textbox_title
            // 
            this.textbox_title.BackColor = System.Drawing.Color.Gainsboro;
            this.textbox_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_title.ForeColor = System.Drawing.Color.DimGray;
            this.textbox_title.Location = new System.Drawing.Point(7, 69);
            this.textbox_title.Name = "textbox_title";
            this.textbox_title.Size = new System.Drawing.Size(381, 15);
            this.textbox_title.TabIndex = 4;
            // 
            // textbox_description
            // 
            this.textbox_description.BackColor = System.Drawing.Color.Gainsboro;
            this.textbox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_description.ForeColor = System.Drawing.Color.DimGray;
            this.textbox_description.Location = new System.Drawing.Point(7, 114);
            this.textbox_description.Name = "textbox_description";
            this.textbox_description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textbox_description.Size = new System.Drawing.Size(381, 267);
            this.textbox_description.TabIndex = 5;
            this.textbox_description.Text = "";
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
            this.button_addnote.Location = new System.Drawing.Point(222, 395);
            this.button_addnote.Margin = new System.Windows.Forms.Padding(0);
            this.button_addnote.Name = "button_addnote";
            this.button_addnote.Size = new System.Drawing.Size(166, 46);
            this.button_addnote.TabIndex = 6;
            this.button_addnote.Text = "Add new note";
            this.button_addnote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addnote.UseVisualStyleBackColor = true;
            // 
            // AddNoteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.button_addnote);
            this.Controls.Add(this.textbox_description);
            this.Controls.Add(this.textbox_title);
            this.Controls.Add(this.label_notedescription);
            this.Controls.Add(this.label_notetitle);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNoteDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new note";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_notetitle;
        private System.Windows.Forms.Label label_notedescription;
        private System.Windows.Forms.TextBox textbox_title;
        private System.Windows.Forms.RichTextBox textbox_description;
        private FontAwesome.Sharp.IconButton button_addnote;
    }
}