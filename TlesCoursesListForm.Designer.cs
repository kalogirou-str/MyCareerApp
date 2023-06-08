namespace MyCareerApp
{
    partial class TlesCoursesListForm
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
            this.bioinformaticsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.naturalLanguageProcessLinkLabel = new System.Windows.Forms.LinkLabel();
            this.androidLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // bioinformaticsLinkLabel
            // 
            this.bioinformaticsLinkLabel.AutoSize = true;
            this.bioinformaticsLinkLabel.Location = new System.Drawing.Point(225, 56);
            this.bioinformaticsLinkLabel.Name = "bioinformaticsLinkLabel";
            this.bioinformaticsLinkLabel.Size = new System.Drawing.Size(123, 20);
            this.bioinformaticsLinkLabel.TabIndex = 0;
            this.bioinformaticsLinkLabel.TabStop = true;
            this.bioinformaticsLinkLabel.Text = "Βιοπληροφορική";
            // 
            // naturalLanguageProcessLinkLabel
            // 
            this.naturalLanguageProcessLinkLabel.AutoSize = true;
            this.naturalLanguageProcessLinkLabel.Location = new System.Drawing.Point(225, 118);
            this.naturalLanguageProcessLinkLabel.Name = "naturalLanguageProcessLinkLabel";
            this.naturalLanguageProcessLinkLabel.Size = new System.Drawing.Size(219, 20);
            this.naturalLanguageProcessLinkLabel.TabIndex = 1;
            this.naturalLanguageProcessLinkLabel.TabStop = true;
            this.naturalLanguageProcessLinkLabel.Text = "Επεξεργασία Φυσικής Γλώσσας";
            // 
            // androidLinkLabel
            // 
            this.androidLinkLabel.AutoSize = true;
            this.androidLinkLabel.Location = new System.Drawing.Point(166, 194);
            this.androidLinkLabel.Name = "androidLinkLabel";
            this.androidLinkLabel.Size = new System.Drawing.Size(530, 20);
            this.androidLinkLabel.TabIndex = 2;
            this.androidLinkLabel.TabStop = true;
            this.androidLinkLabel.Text = "Σύγχρονα Θέματα Τεχνολογίας Λογισμικού - Λογισμικό για κινητές συσκευές";
            // 
            // TlesCoursesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.androidLinkLabel);
            this.Controls.Add(this.naturalLanguageProcessLinkLabel);
            this.Controls.Add(this.bioinformaticsLinkLabel);
            this.Name = "TlesCoursesListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel bioinformaticsLinkLabel;
        private LinkLabel naturalLanguageProcessLinkLabel;
        private LinkLabel androidLinkLabel;
    }
}