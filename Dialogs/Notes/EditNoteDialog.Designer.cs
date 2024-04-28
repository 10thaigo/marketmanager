namespace MarketManager.Dialogs.Notes
{
    partial class EditNoteDialog
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
            this.button_editnote = new FontAwesome.Sharp.IconButton();
            this.label_error_title = new System.Windows.Forms.Label();
            this.label_error_description = new System.Windows.Forms.Label();
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
            this.label_title.Size = new System.Drawing.Size(71, 15);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "undefined";
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
            // button_editnote
            // 
            this.button_editnote.FlatAppearance.BorderSize = 0;
            this.button_editnote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editnote.ForeColor = System.Drawing.Color.DimGray;
            this.button_editnote.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.button_editnote.IconColor = System.Drawing.Color.DimGray;
            this.button_editnote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_editnote.IconSize = 42;
            this.button_editnote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_editnote.Location = new System.Drawing.Point(280, 395);
            this.button_editnote.Margin = new System.Windows.Forms.Padding(0);
            this.button_editnote.Name = "button_editnote";
            this.button_editnote.Size = new System.Drawing.Size(108, 46);
            this.button_editnote.TabIndex = 6;
            this.button_editnote.Text = "Done";
            this.button_editnote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_editnote.UseVisualStyleBackColor = true;
            // 
            // label_error_title
            // 
            this.label_error_title.AutoSize = true;
            this.label_error_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_title.ForeColor = System.Drawing.Color.Red;
            this.label_error_title.Location = new System.Drawing.Point(52, 51);
            this.label_error_title.Name = "label_error_title";
            this.label_error_title.Size = new System.Drawing.Size(86, 13);
            this.label_error_title.TabIndex = 7;
            this.label_error_title.Text = "Required field";
            this.label_error_title.Visible = false;
            // 
            // label_error_description
            // 
            this.label_error_description.AutoSize = true;
            this.label_error_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_description.ForeColor = System.Drawing.Color.Red;
            this.label_error_description.Location = new System.Drawing.Point(109, 96);
            this.label_error_description.Name = "label_error_description";
            this.label_error_description.Size = new System.Drawing.Size(86, 13);
            this.label_error_description.TabIndex = 8;
            this.label_error_description.Text = "Required field";
            this.label_error_description.Visible = false;
            // 
            // EditNoteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.label_error_description);
            this.Controls.Add(this.label_error_title);
            this.Controls.Add(this.button_editnote);
            this.Controls.Add(this.textbox_description);
            this.Controls.Add(this.textbox_title);
            this.Controls.Add(this.label_notedescription);
            this.Controls.Add(this.label_notetitle);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditNoteDialog";
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
        private FontAwesome.Sharp.IconButton button_editnote;
        private System.Windows.Forms.Label label_error_title;
        private System.Windows.Forms.Label label_error_description;
    }
}