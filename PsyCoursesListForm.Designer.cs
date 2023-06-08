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
            this.cryptographyLinkLabel.Location = new System.Drawing.Point(362, 89);
            this.cryptographyLinkLabel.Name = "cryptographyLinkLabel";
            this.cryptographyLinkLabel.Size = new System.Drawing.Size(109, 20);
            this.cryptographyLinkLabel.TabIndex = 0;
            this.cryptographyLinkLabel.TabStop = true;
            this.cryptographyLinkLabel.Text = "Κρυπτογραφία";
            // 
            // securityLinkLabel
            // 
            this.securityLinkLabel.AutoSize = true;
            this.securityLinkLabel.Location = new System.Drawing.Point(362, 215);
            this.securityLinkLabel.Name = "securityLinkLabel";
            this.securityLinkLabel.Size = new System.Drawing.Size(282, 20);
            this.securityLinkLabel.TabIndex = 1;
            this.securityLinkLabel.TabStop = true;
            this.securityLinkLabel.Text = "Ασφάλεια Πληροφοριακών Συστημάτων";
            // 
            // dataAnalyticsLinkLabel
            // 
            this.dataAnalyticsLinkLabel.AutoSize = true;
            this.dataAnalyticsLinkLabel.Location = new System.Drawing.Point(378, 277);
            this.dataAnalyticsLinkLabel.Name = "dataAnalyticsLinkLabel";
            this.dataAnalyticsLinkLabel.Size = new System.Drawing.Size(162, 20);
            this.dataAnalyticsLinkLabel.TabIndex = 2;
            this.dataAnalyticsLinkLabel.TabStop = true;
            this.dataAnalyticsLinkLabel.Text = "Αναλυτική Δεδομένων";
            // 
            // PsyCoursesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataAnalyticsLinkLabel);
            this.Controls.Add(this.securityLinkLabel);
            this.Controls.Add(this.cryptographyLinkLabel);
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