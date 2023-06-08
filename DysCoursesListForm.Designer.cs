namespace MyCareerApp
{
    partial class DysCoursesListForm
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
            this.computerDesignLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ArchitectureLinkLabel = new System.Windows.Forms.LinkLabel();
            this.securityLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // computerDesignLinkLabel
            // 
            this.computerDesignLinkLabel.AutoSize = true;
            this.computerDesignLinkLabel.Location = new System.Drawing.Point(320, 80);
            this.computerDesignLinkLabel.Name = "computerDesignLinkLabel";
            this.computerDesignLinkLabel.Size = new System.Drawing.Size(268, 20);
            this.computerDesignLinkLabel.TabIndex = 0;
            this.computerDesignLinkLabel.TabStop = true;
            this.computerDesignLinkLabel.Text = "Σχεδίαση Υπολογιστικών Συστημάτων";
            // 
            // ArchitectureLinkLabel
            // 
            this.ArchitectureLinkLabel.AutoSize = true;
            this.ArchitectureLinkLabel.Location = new System.Drawing.Point(310, 156);
            this.ArchitectureLinkLabel.Name = "ArchitectureLinkLabel";
            this.ArchitectureLinkLabel.Size = new System.Drawing.Size(284, 20);
            this.ArchitectureLinkLabel.TabIndex = 1;
            this.ArchitectureLinkLabel.TabStop = true;
            this.ArchitectureLinkLabel.Text = "Προηγμένη Αρχιτεκτονική Υπολογιστών";
            // 
            // securityLinkLabel
            // 
            this.securityLinkLabel.AutoSize = true;
            this.securityLinkLabel.Location = new System.Drawing.Point(310, 235);
            this.securityLinkLabel.Name = "securityLinkLabel";
            this.securityLinkLabel.Size = new System.Drawing.Size(135, 20);
            this.securityLinkLabel.TabIndex = 2;
            this.securityLinkLabel.TabStop = true;
            this.securityLinkLabel.Text = "Ασφάλεια Δικτύων";
            // 
            // DysCoursesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.securityLinkLabel);
            this.Controls.Add(this.ArchitectureLinkLabel);
            this.Controls.Add(this.computerDesignLinkLabel);
            this.Name = "DysCoursesListForm";
            this.Text = "DysCoursesListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel computerDesignLinkLabel;
        private LinkLabel ArchitectureLinkLabel;
        private LinkLabel securityLinkLabel;
    }
}