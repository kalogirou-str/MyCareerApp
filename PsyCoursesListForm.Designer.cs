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
            this.securityLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dataAnalyticsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cryptographyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // securityLinkLabel
            // 
            this.securityLinkLabel.AutoSize = true;
            this.securityLinkLabel.Location = new System.Drawing.Point(265, 197);
            this.securityLinkLabel.Name = "securityLinkLabel";
            this.securityLinkLabel.Size = new System.Drawing.Size(262, 20);
            this.securityLinkLabel.TabIndex = 1;
            this.securityLinkLabel.TabStop = true;
            this.securityLinkLabel.Text = "Συστήματα Υποστήριξης Αποφάσεων";
            this.securityLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.systhmataApofasewnLinkLabel_LinkClicked);
            // 
            // dataAnalyticsLinkLabel
            // 
            this.dataAnalyticsLinkLabel.AutoSize = true;
            this.dataAnalyticsLinkLabel.Location = new System.Drawing.Point(264, 304);
            this.dataAnalyticsLinkLabel.Name = "dataAnalyticsLinkLabel";
            this.dataAnalyticsLinkLabel.Size = new System.Drawing.Size(274, 20);
            this.dataAnalyticsLinkLabel.TabIndex = 2;
            this.dataAnalyticsLinkLabel.TabStop = true;
            this.dataAnalyticsLinkLabel.Text = "Ηλεκτρονικό Επιχειρείν και Καινοτομία";
            this.dataAnalyticsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hlektronikonEpixeirinLinkLabel_LinkClicked);
            // 
            // cryptographyLinkLabel
            // 
            this.cryptographyLinkLabel.AutoSize = true;
            this.cryptographyLinkLabel.Location = new System.Drawing.Point(282, 93);
            this.cryptographyLinkLabel.Name = "cryptographyLinkLabel";
            this.cryptographyLinkLabel.Size = new System.Drawing.Size(109, 20);
            this.cryptographyLinkLabel.TabIndex = 0;
            this.cryptographyLinkLabel.TabStop = true;
            this.cryptographyLinkLabel.Text = "Κρυπτογραφία";
            this.cryptographyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cryptographyLinkLabel_LinkClicked);
            // 
            // PsyCoursesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.dataAnalyticsLinkLabel);
            this.Controls.Add(this.securityLinkLabel);
            this.Controls.Add(this.cryptographyLinkLabel);
            this.Name = "PsyCoursesListForm";
            this.Text = "PsyCoursesListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel securityLinkLabel;
        private LinkLabel dataAnalyticsLinkLabel;
        private LinkLabel cryptographyLinkLabel;
    }
}