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
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // theoryButton
            // 
            this.theoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theoryButton.BackColor = System.Drawing.Color.Tan;
            this.theoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.theoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theoryButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.theoryButton.Location = new System.Drawing.Point(226, 56);
            this.theoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(244, 66);
            this.theoryButton.TabIndex = 0;
            this.theoryButton.Text = "Θεωρία";
            this.theoryButton.UseVisualStyleBackColor = false;
            this.theoryButton.Click += new System.EventHandler(this.theoryButton_Click);
            // 
            // testButton
            // 
            this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testButton.BackColor = System.Drawing.Color.Tan;
            this.testButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testButton.Location = new System.Drawing.Point(226, 126);
            this.testButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(244, 66);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Τεστ";
            this.testButton.UseVisualStyleBackColor = false;
            // 
            // suggestButton
            // 
            this.suggestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suggestButton.BackColor = System.Drawing.Color.Tan;
            this.suggestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suggestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suggestButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suggestButton.Location = new System.Drawing.Point(226, 196);
            this.suggestButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suggestButton.Name = "suggestButton";
            this.suggestButton.Size = new System.Drawing.Size(244, 66);
            this.suggestButton.TabIndex = 2;
            this.suggestButton.Text = "Συστάσεις";
            this.suggestButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Tan;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(226, 266);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(244, 66);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Έξοδος";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.Location = new System.Drawing.Point(577, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(101, 47);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Αποσύνδεση";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeMessage.Location = new System.Drawing.Point(217, 9);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(253, 31);
            this.welcomeMessage.TabIndex = 5;
            this.welcomeMessage.Text = "Καλώς όρισες Χρήστη";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.welcomeMessage);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.suggestButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.theoryButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Μενού";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button theoryButton;
        private Button testButton;
        private Button suggestButton;
        private Button exitButton;
        private Button logoutButton;
        private Label welcomeMessage;
    }
}