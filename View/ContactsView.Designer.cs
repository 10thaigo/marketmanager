namespace MarketManager.View
{
    partial class ContactsView
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
            this.panel_contacts = new System.Windows.Forms.FlowLayoutPanel();
            this.button_addcontact = new FontAwesome.Sharp.IconButton();
            this.label_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.SystemColors.Control;
            this.icon.ForeColor = System.Drawing.Color.DimGray;
            this.icon.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
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
            this.label_title.Size = new System.Drawing.Size(137, 24);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Your contacts";
            // 
            // panel_contacts
            // 
            this.panel_contacts.AutoScroll = true;
            this.panel_contacts.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_contacts.Location = new System.Drawing.Point(16, 68);
            this.panel_contacts.Name = "panel_contacts";
            this.panel_contacts.Size = new System.Drawing.Size(772, 392);
            this.panel_contacts.TabIndex = 7;
            // 
            // button_addcontact
            // 
            this.button_addcontact.FlatAppearance.BorderSize = 0;
            this.button_addcontact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addcontact.ForeColor = System.Drawing.Color.DimGray;
            this.button_addcontact.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.button_addcontact.IconColor = System.Drawing.Color.DimGray;
            this.button_addcontact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_addcontact.IconSize = 42;
            this.button_addcontact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addcontact.Location = new System.Drawing.Point(636, 463);
            this.button_addcontact.Margin = new System.Windows.Forms.Padding(0);
            this.button_addcontact.Name = "button_addcontact";
            this.button_addcontact.Size = new System.Drawing.Size(155, 46);
            this.button_addcontact.TabIndex = 6;
            this.button_addcontact.Text = "New contact";
            this.button_addcontact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addcontact.UseVisualStyleBackColor = true;
            // 
            // label_info
            // 
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.DimGray;
            this.label_info.Location = new System.Drawing.Point(12, 65);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(750, 341);
            this.label_info.TabIndex = 8;
            this.label_info.Text = "undefined";
            this.label_info.Visible = false;
            // 
            // ContactsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.button_addcontact);
            this.Controls.Add(this.panel_contacts);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactsView";
            this.Text = "NotesView";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox icon;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.FlowLayoutPanel panel_contacts;
        private FontAwesome.Sharp.IconButton button_addcontact;
        private System.Windows.Forms.Label label_info;
    }
}