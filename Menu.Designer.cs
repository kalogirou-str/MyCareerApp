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
            this.SuspendLayout();
            // 
            // theoryButton
            // 
            this.theoryButton.Location = new System.Drawing.Point(318, 72);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(94, 29);
            this.theoryButton.TabIndex = 0;
            this.theoryButton.Text = "Θεωρία";
            this.theoryButton.UseVisualStyleBackColor = true;
            this.theoryButton.Click += new System.EventHandler(this.theoryButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(318, 132);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(94, 29);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // suggestButton
            // 
            this.suggestButton.Location = new System.Drawing.Point(318, 191);
            this.suggestButton.Name = "suggestButton";
            this.suggestButton.Size = new System.Drawing.Size(94, 29);
            this.suggestButton.TabIndex = 2;
            this.suggestButton.Text = "Προτάσεις";
            this.suggestButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(318, 246);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 29);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Έξοδος";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.suggestButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.theoryButton);
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
    }
}