namespace MyCareerApp
{
    partial class Menu
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
            this.theoryButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.suggestButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // theoryButton
            // 
            this.theoryButton.Location = new System.Drawing.Point(278, 79);
            this.theoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(132, 22);
            this.theoryButton.TabIndex = 0;
            this.theoryButton.Text = "Θεωρία";
            this.theoryButton.UseVisualStyleBackColor = true;
            this.theoryButton.Click += new System.EventHandler(this.theoryButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(278, 129);
            this.testButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(132, 22);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // suggestButton
            // 
            this.suggestButton.Location = new System.Drawing.Point(278, 177);
            this.suggestButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suggestButton.Name = "suggestButton";
            this.suggestButton.Size = new System.Drawing.Size(132, 22);
            this.suggestButton.TabIndex = 2;
            this.suggestButton.Text = "Προτάσεις";
            this.suggestButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(278, 224);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 22);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Κλείσιμο εφαρμογής";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(613, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Έξοδος";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.suggestButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.theoryButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button theoryButton;
        private Button testButton;
        private Button suggestButton;
        private Button exitButton;
        private Button logoutButton;
    }
}