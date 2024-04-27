namespace MarketManager
{
    partial class MainView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_view = new System.Windows.Forms.Panel();
            this.button_contacts = new FontAwesome.Sharp.IconButton();
            this.button_notes = new FontAwesome.Sharp.IconButton();
            this.button_settings = new FontAwesome.Sharp.IconButton();
            this.button_information = new FontAwesome.Sharp.IconButton();
            this.button_stock = new FontAwesome.Sharp.IconButton();
            this.button_sell = new FontAwesome.Sharp.IconButton();
            this.label_clock = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_top.Controls.Add(this.label_clock);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1000, 32);
            this.panel_top.TabIndex = 0;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.button_sell);
            this.panel_buttons.Controls.Add(this.button_stock);
            this.panel_buttons.Controls.Add(this.button_contacts);
            this.panel_buttons.Controls.Add(this.button_notes);
            this.panel_buttons.Controls.Add(this.button_settings);
            this.panel_buttons.Controls.Add(this.button_information);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_buttons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_buttons.Location = new System.Drawing.Point(0, 32);
            this.panel_buttons.Margin = new System.Windows.Forms.Padding(0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(200, 518);
            this.panel_buttons.TabIndex = 1;
            // 
            // panel_view
            // 
            this.panel_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_view.Location = new System.Drawing.Point(200, 32);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(800, 518);
            this.panel_view.TabIndex = 2;
            // 
            // button_contacts
            // 
            this.button_contacts.FlatAppearance.BorderSize = 0;
            this.button_contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_contacts.ForeColor = System.Drawing.Color.DimGray;
            this.button_contacts.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.button_contacts.IconColor = System.Drawing.Color.DimGray;
            this.button_contacts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_contacts.IconSize = 42;
            this.button_contacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_contacts.Location = new System.Drawing.Point(0, 92);
            this.button_contacts.Margin = new System.Windows.Forms.Padding(0);
            this.button_contacts.Name = "button_contacts";
            this.button_contacts.Size = new System.Drawing.Size(200, 46);
            this.button_contacts.TabIndex = 1;
            this.button_contacts.Text = "Contacts";
            this.button_contacts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_contacts.UseVisualStyleBackColor = true;
            // 
            // button_notes
            // 
            this.button_notes.FlatAppearance.BorderSize = 0;
            this.button_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_notes.ForeColor = System.Drawing.Color.DimGray;
            this.button_notes.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.button_notes.IconColor = System.Drawing.Color.DimGray;
            this.button_notes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_notes.IconSize = 42;
            this.button_notes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_notes.Location = new System.Drawing.Point(0, 138);
            this.button_notes.Margin = new System.Windows.Forms.Padding(0);
            this.button_notes.Name = "button_notes";
            this.button_notes.Size = new System.Drawing.Size(200, 46);
            this.button_notes.TabIndex = 2;
            this.button_notes.Text = "Notes";
            this.button_notes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_notes.UseVisualStyleBackColor = true;
            // 
            // button_settings
            // 
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_settings.ForeColor = System.Drawing.Color.DimGray;
            this.button_settings.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.button_settings.IconColor = System.Drawing.Color.DimGray;
            this.button_settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_settings.IconSize = 42;
            this.button_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_settings.Location = new System.Drawing.Point(0, 184);
            this.button_settings.Margin = new System.Windows.Forms.Padding(0);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(200, 46);
            this.button_settings.TabIndex = 3;
            this.button_settings.Text = "Settings";
            this.button_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // button_information
            // 
            this.button_information.FlatAppearance.BorderSize = 0;
            this.button_information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_information.ForeColor = System.Drawing.Color.DimGray;
            this.button_information.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.button_information.IconColor = System.Drawing.Color.DimGray;
            this.button_information.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_information.IconSize = 42;
            this.button_information.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_information.Location = new System.Drawing.Point(0, 230);
            this.button_information.Margin = new System.Windows.Forms.Padding(0);
            this.button_information.Name = "button_information";
            this.button_information.Size = new System.Drawing.Size(200, 46);
            this.button_information.TabIndex = 4;
            this.button_information.Text = "Information";
            this.button_information.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_information.UseVisualStyleBackColor = true;
            // 
            // button_stock
            // 
            this.button_stock.FlatAppearance.BorderSize = 0;
            this.button_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stock.ForeColor = System.Drawing.Color.DimGray;
            this.button_stock.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.button_stock.IconColor = System.Drawing.Color.DimGray;
            this.button_stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_stock.IconSize = 42;
            this.button_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_stock.Location = new System.Drawing.Point(0, 46);
            this.button_stock.Margin = new System.Windows.Forms.Padding(0);
            this.button_stock.Name = "button_stock";
            this.button_stock.Size = new System.Drawing.Size(200, 46);
            this.button_stock.TabIndex = 5;
            this.button_stock.Text = "Stock";
            this.button_stock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_stock.UseVisualStyleBackColor = true;
            // 
            // button_sell
            // 
            this.button_sell.FlatAppearance.BorderSize = 0;
            this.button_sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sell.ForeColor = System.Drawing.Color.DimGray;
            this.button_sell.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.button_sell.IconColor = System.Drawing.Color.DimGray;
            this.button_sell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_sell.IconSize = 42;
            this.button_sell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sell.Location = new System.Drawing.Point(0, 0);
            this.button_sell.Margin = new System.Windows.Forms.Padding(0);
            this.button_sell.Name = "button_sell";
            this.button_sell.Size = new System.Drawing.Size(200, 46);
            this.button_sell.TabIndex = 6;
            this.button_sell.Text = "Sell";
            this.button_sell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sell.UseVisualStyleBackColor = true;
            // 
            // label_clock
            // 
            this.label_clock.AutoSize = true;
            this.label_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clock.ForeColor = System.Drawing.Color.White;
            this.label_clock.Location = new System.Drawing.Point(3, 9);
            this.label_clock.Name = "label_clock";
            this.label_clock.Size = new System.Drawing.Size(296, 15);
            this.label_clock.TabIndex = 0;
            this.label_clock.Text = "The current date and time is Fri Apr 26 17:54:00 2024";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel_view);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Manager";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.FlowLayoutPanel panel_buttons;
        private FontAwesome.Sharp.IconButton button_contacts;
        private FontAwesome.Sharp.IconButton button_notes;
        private FontAwesome.Sharp.IconButton button_settings;
        private FontAwesome.Sharp.IconButton button_information;
        private System.Windows.Forms.Panel panel_view;
        private FontAwesome.Sharp.IconButton button_sell;
        private FontAwesome.Sharp.IconButton button_stock;
        private System.Windows.Forms.Label label_clock;
    }
}

