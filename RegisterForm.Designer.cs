namespace MyCareerApp
{
    partial class RegisterForm
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
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.haveAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(267, 142);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(66, 20);
            this.password.TabIndex = 10;
            this.password.Text = "Κωδικός:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(227, 91);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(106, 20);
            this.username.TabIndex = 9;
            this.username.Text = "Όνομα χρήστη:";
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(339, 142);
            this.registerPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PasswordChar = '*';
            this.registerPasswordTextBox.Size = new System.Drawing.Size(110, 23);
            this.registerPasswordTextBox.TabIndex = 8;
            // 
            // registerUsernameTextBox
            // 
            this.registerUsernameTextBox.Location = new System.Drawing.Point(339, 91);
            this.registerUsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerUsernameTextBox.Name = "registerUsernameTextBox";
            this.registerUsernameTextBox.Size = new System.Drawing.Size(110, 23);
            this.registerUsernameTextBox.TabIndex = 7;
            // 
            // haveAccountLinkLabel
            // 
            this.haveAccountLinkLabel.AutoSize = true;
            this.haveAccountLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.haveAccountLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.haveAccountLinkLabel.Location = new System.Drawing.Point(267, 248);
            this.haveAccountLinkLabel.Name = "haveAccountLinkLabel";
            this.haveAccountLinkLabel.Size = new System.Drawing.Size(173, 21);
            this.haveAccountLinkLabel.TabIndex = 12;
            this.haveAccountLinkLabel.TabStop = true;
            this.haveAccountLinkLabel.Text = "Έχετε ήδη λογαριασμό;";
            this.haveAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.haveAccountLinkLabel_LinkClicked);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.BackColor = System.Drawing.Color.Tan;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(284, 196);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(137, 36);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Εγγραφή";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.theoryButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.haveAccountLinkLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.registerPasswordTextBox);
            this.Controls.Add(this.registerUsernameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Εγγραφή";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label password;
        private Label username;
        private TextBox registerPasswordTextBox;
        private TextBox registerUsernameTextBox;
        private LinkLabel haveAccountLinkLabel;
        private Button registerButton;
    }
}