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
            this.computerDesignLinkLabel.Location = new System.Drawing.Point(244, 108);
            this.computerDesignLinkLabel.Name = "computerDesignLinkLabel";
            this.computerDesignLinkLabel.Size = new System.Drawing.Size(202, 15);
            this.computerDesignLinkLabel.TabIndex = 0;
            this.computerDesignLinkLabel.TabStop = true;
            this.computerDesignLinkLabel.Text = "Κινητές και Ασύρματες Επικοινωνίες";
            this.computerDesignLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.computerDesignLinkLabel_LinkClicked);
            // 
            // ArchitectureLinkLabel
            // 
            this.ArchitectureLinkLabel.AutoSize = true;
            this.ArchitectureLinkLabel.Location = new System.Drawing.Point(244, 53);
            this.ArchitectureLinkLabel.Name = "ArchitectureLinkLabel";
            this.ArchitectureLinkLabel.Size = new System.Drawing.Size(224, 15);
            this.ArchitectureLinkLabel.TabIndex = 1;
            this.ArchitectureLinkLabel.TabStop = true;
            this.ArchitectureLinkLabel.Text = "Προηγμένη Αρχιτεκτονική Υπολογιστών";
            this.ArchitectureLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ArchitectureLinkLabel_LinkClicked);
            // 
            // securityLinkLabel
            // 
            this.securityLinkLabel.AutoSize = true;
            this.securityLinkLabel.Location = new System.Drawing.Point(244, 177);
            this.securityLinkLabel.Name = "securityLinkLabel";
            this.securityLinkLabel.Size = new System.Drawing.Size(158, 15);
            this.securityLinkLabel.TabIndex = 2;
            this.securityLinkLabel.TabStop = true;
            this.securityLinkLabel.Text = "Δίκτυα Υψηλών Ταχυτήτων";
            this.securityLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.securityLinkLabel_LinkClicked);
            // 
            // DysCoursesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.securityLinkLabel);
            this.Controls.Add(this.ArchitectureLinkLabel);
            this.Controls.Add(this.computerDesignLinkLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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