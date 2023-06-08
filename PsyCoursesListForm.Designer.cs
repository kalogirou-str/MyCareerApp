namespace MyCareerApp
{
    partial class PsyCoursesListForm
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
            this.cryptographyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.securityLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dataAnalyticsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cryptographyLinkLabel
            // 
            this.cryptographyLinkLabel.AutoSize = true;
            this.cryptographyLinkLabel.Location = new System.Drawing.Point(247, 70);
            this.cryptographyLinkLabel.Name = "cryptographyLinkLabel";
            this.cryptographyLinkLabel.Size = new System.Drawing.Size(88, 15);
            this.cryptographyLinkLabel.TabIndex = 0;
            this.cryptographyLinkLabel.TabStop = true;
            this.cryptographyLinkLabel.Text = "Κρυπτογραφία";
            this.cryptographyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cryptographyLinkLabel_LinkClicked);
            // 
            // securityLinkLabel
            // 
            this.securityLinkLabel.AutoSize = true;
            this.securityLinkLabel.Location = new System.Drawing.Point(232, 148);
            this.securityLinkLabel.Name = "securityLinkLabel";
            this.securityLinkLabel.Size = new System.Drawing.Size(211, 15);
            this.securityLinkLabel.TabIndex = 1;
            this.securityLinkLabel.TabStop = true;
            this.securityLinkLabel.Text = "Συστήματα Υποστήριξης Αποφάσεων";
            this.securityLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.securityLinkLabel_LinkClicked);
            // 
            // dataAnalyticsLinkLabel
            // 
            this.dataAnalyticsLinkLabel.AutoSize = true;
            this.dataAnalyticsLinkLabel.Location = new System.Drawing.Point(231, 228);
            this.dataAnalyticsLinkLabel.Name = "dataAnalyticsLinkLabel";
            this.dataAnalyticsLinkLabel.Size = new System.Drawing.Size(212, 15);
            this.dataAnalyticsLinkLabel.TabIndex = 2;
            this.dataAnalyticsLinkLabel.TabStop = true;
            this.dataAnalyticsLinkLabel.Text = "Ηλεκτρονικό Επιχειρείν και Καινοτομία";
            this.dataAnalyticsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dataAnalyticsLinkLabel_LinkClicked);
            // 
            // PsyCoursesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.dataAnalyticsLinkLabel);
            this.Controls.Add(this.securityLinkLabel);
            this.Controls.Add(this.cryptographyLinkLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PsyCoursesListForm";
            this.Text = "PsyCoursesListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel cryptographyLinkLabel;
        private LinkLabel securityLinkLabel;
        private LinkLabel dataAnalyticsLinkLabel;
    }
}