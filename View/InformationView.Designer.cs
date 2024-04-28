namespace MarketManager.View
{
    partial class InformationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationView));
            this.icon = new FontAwesome.Sharp.IconPictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.label_info2 = new System.Windows.Forms.Label();
            this.label_info3 = new System.Windows.Forms.Label();
            this.label_info4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.SystemColors.Control;
            this.icon.ForeColor = System.Drawing.Color.DimGray;
            this.icon.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
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
            this.label_title.Size = new System.Drawing.Size(113, 24);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Information";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.DimGray;
            this.label_info.Location = new System.Drawing.Point(12, 74);
            this.label_info.MaximumSize = new System.Drawing.Size(750, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(743, 60);
            this.label_info.TabIndex = 2;
            this.label_info.Text = resources.GetString("label_info.Text");
            // 
            // label_info2
            // 
            this.label_info2.AutoSize = true;
            this.label_info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info2.ForeColor = System.Drawing.Color.DimGray;
            this.label_info2.Location = new System.Drawing.Point(12, 143);
            this.label_info2.MaximumSize = new System.Drawing.Size(750, 0);
            this.label_info2.Name = "label_info2";
            this.label_info2.Size = new System.Drawing.Size(729, 60);
            this.label_info2.TabIndex = 3;
            this.label_info2.Text = resources.GetString("label_info2.Text");
            // 
            // label_info3
            // 
            this.label_info3.AutoSize = true;
            this.label_info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info3.ForeColor = System.Drawing.Color.DimGray;
            this.label_info3.Location = new System.Drawing.Point(12, 422);
            this.label_info3.MaximumSize = new System.Drawing.Size(750, 0);
            this.label_info3.Name = "label_info3";
            this.label_info3.Size = new System.Drawing.Size(750, 40);
            this.label_info3.TabIndex = 4;
            this.label_info3.Text = "I designed it with the aim of facilitating the work of these businesses, and also" +
    " to improve my programming skills.";
            // 
            // label_info4
            // 
            this.label_info4.AutoSize = true;
            this.label_info4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info4.ForeColor = System.Drawing.Color.DimGray;
            this.label_info4.Location = new System.Drawing.Point(12, 480);
            this.label_info4.MaximumSize = new System.Drawing.Size(750, 0);
            this.label_info4.Name = "label_info4";
            this.label_info4.Size = new System.Drawing.Size(193, 20);
            this.label_info4.TabIndex = 5;
            this.label_info4.Text = "Current release: b1.0.0";
            // 
            // InformationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.label_info4);
            this.Controls.Add(this.label_info3);
            this.Controls.Add(this.label_info2);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationView";
            this.Text = "InformationView";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox icon;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_info2;
        private System.Windows.Forms.Label label_info3;
        private System.Windows.Forms.Label label_info4;
    }
}