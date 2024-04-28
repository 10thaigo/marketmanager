namespace MarketManager.Control.Notes
{
    partial class NoteUserControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.icon = new FontAwesome.Sharp.IconPictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.button_edit = new FontAwesome.Sharp.IconButton();
            this.button_delete = new FontAwesome.Sharp.IconButton();
            this.button_see = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.SystemColors.Control;
            this.icon.ForeColor = System.Drawing.Color.DimGray;
            this.icon.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.icon.IconColor = System.Drawing.Color.DimGray;
            this.icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon.IconSize = 37;
            this.icon.Location = new System.Drawing.Point(3, 3);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(37, 37);
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.DimGray;
            this.label_title.Location = new System.Drawing.Point(46, 13);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(75, 16);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "undefined";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.DimGray;
            this.label_date.Location = new System.Drawing.Point(349, 13);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(75, 16);
            this.label_date.TabIndex = 4;
            this.label_date.Text = "undefined";
            // 
            // button_edit
            // 
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.DimGray;
            this.button_edit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.button_edit.IconColor = System.Drawing.Color.DimGray;
            this.button_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_edit.IconSize = 37;
            this.button_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_edit.Location = new System.Drawing.Point(637, 3);
            this.button_edit.Margin = new System.Windows.Forms.Padding(0);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(46, 37);
            this.button_edit.TabIndex = 5;
            this.button_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.DimGray;
            this.button_delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.button_delete.IconColor = System.Drawing.Color.DimGray;
            this.button_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_delete.IconSize = 37;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_delete.Location = new System.Drawing.Point(683, 3);
            this.button_delete.Margin = new System.Windows.Forms.Padding(0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(45, 37);
            this.button_delete.TabIndex = 6;
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_see
            // 
            this.button_see.FlatAppearance.BorderSize = 0;
            this.button_see.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_see.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_see.ForeColor = System.Drawing.Color.DimGray;
            this.button_see.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.button_see.IconColor = System.Drawing.Color.DimGray;
            this.button_see.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_see.IconSize = 37;
            this.button_see.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_see.Location = new System.Drawing.Point(591, 3);
            this.button_see.Margin = new System.Windows.Forms.Padding(0);
            this.button_see.Name = "button_see";
            this.button_see.Size = new System.Drawing.Size(46, 37);
            this.button_see.TabIndex = 7;
            this.button_see.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_see.UseVisualStyleBackColor = true;
            // 
            // NoteUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_see);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.icon);
            this.Name = "NoteUserControl";
            this.Size = new System.Drawing.Size(737, 43);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox icon;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_date;
        private FontAwesome.Sharp.IconButton button_edit;
        private FontAwesome.Sharp.IconButton button_delete;
        private FontAwesome.Sharp.IconButton button_see;
    }
}
