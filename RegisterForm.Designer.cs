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
            this.registerButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.haveAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(312, 256);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(94, 29);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Εγγραφή";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(287, 196);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 20);
            this.password.TabIndex = 10;
            this.password.Text = "Κωδικός";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(270, 124);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(111, 20);
            this.username.TabIndex = 9;
            this.username.Text = "Όνομα χρήστη";
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(387, 189);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PasswordChar = '*';
            this.registerPasswordTextBox.Size = new System.Drawing.Size(125, 27);
            this.registerPasswordTextBox.TabIndex = 8;
            // 
            // registerUsernameTextBox
            // 
            this.registerUsernameTextBox.Location = new System.Drawing.Point(387, 121);
            this.registerUsernameTextBox.Name = "registerUsernameTextBox";
            this.registerUsernameTextBox.Size = new System.Drawing.Size(125, 27);
            this.registerUsernameTextBox.TabIndex = 7;
            // 
            // haveAccountLinkLabel
            // 
            this.haveAccountLinkLabel.AutoSize = true;
            this.haveAccountLinkLabel.Location = new System.Drawing.Point(412, 265);
            this.haveAccountLinkLabel.Name = "haveAccountLinkLabel";
            this.haveAccountLinkLabel.Size = new System.Drawing.Size(171, 20);
            this.haveAccountLinkLabel.TabIndex = 12;
            this.haveAccountLinkLabel.TabStop = true;
            this.haveAccountLinkLabel.Text = "Έχετε ήδη λογιαριασμό;";
            this.haveAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.haveAccountLinkLabel_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.haveAccountLinkLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.registerPasswordTextBox);
            this.Controls.Add(this.registerUsernameTextBox);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button registerButton;
        private Label password;
        private Label username;
        private TextBox registerPasswordTextBox;
        private TextBox registerUsernameTextBox;
        private LinkLabel haveAccountLinkLabel;
    }
}