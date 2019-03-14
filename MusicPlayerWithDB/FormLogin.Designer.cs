namespace MusicPlayerWithDB {
    partial class FormInit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInit));
            this.mainLabel = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.bt_signup = new System.Windows.Forms.Button();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.passErrorImage = new System.Windows.Forms.PictureBox();
            this.passNotMatch = new System.Windows.Forms.Label();
            this.passInvalidFormat = new System.Windows.Forms.Label();
            this.passFormat = new System.Windows.Forms.Label();
            this.usrExists = new System.Windows.Forms.Label();
            this.usersTableAdapter1 = new MusicPlayerWithDB.DataSetMainTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(313, 182);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(415, 76);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Music Player";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_login
            // 
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_login.Location = new System.Drawing.Point(449, 500);
            this.bt_login.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(150, 40);
            this.bt_login.TabIndex = 1;
            this.bt_login.Text = "Log In";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // Username
            // 
            this.Username.ForeColor = System.Drawing.Color.Gray;
            this.Username.Location = new System.Drawing.Point(419, 370);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(210, 26);
            this.Username.TabIndex = 3;
            this.Username.Text = "username";
            this.Username.Visible = false;
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Password
            // 
            this.Password.ForeColor = System.Drawing.Color.Gray;
            this.Password.Location = new System.Drawing.Point(419, 428);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(210, 26);
            this.Password.TabIndex = 4;
            this.Password.Text = "password";
            this.Password.Visible = false;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // bt_signup
            // 
            this.bt_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_signup.Location = new System.Drawing.Point(449, 558);
            this.bt_signup.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(150, 40);
            this.bt_signup.TabIndex = 7;
            this.bt_signup.Text = "Sign Up";
            this.bt_signup.UseVisualStyleBackColor = true;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.ConfirmPassword.Location = new System.Drawing.Point(419, 486);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(210, 26);
            this.ConfirmPassword.TabIndex = 8;
            this.ConfirmPassword.Text = "confirm password";
            this.ConfirmPassword.Visible = false;
            this.ConfirmPassword.Enter += new System.EventHandler(this.ConfirmPassword_Enter);
            this.ConfirmPassword.Leave += new System.EventHandler(this.ConfirmPassword_Leave);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_cancel.Location = new System.Drawing.Point(639, 558);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(110, 40);
            this.bt_cancel.TabIndex = 10;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Visible = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // passErrorImage
            // 
            this.passErrorImage.Image = global::MusicPlayerWithDB.Properties.Resources.imageres_98;
            this.passErrorImage.Location = new System.Drawing.Point(651, 483);
            this.passErrorImage.Name = "passErrorImage";
            this.passErrorImage.Size = new System.Drawing.Size(32, 32);
            this.passErrorImage.TabIndex = 11;
            this.passErrorImage.TabStop = false;
            this.passErrorImage.Visible = false;
            // 
            // passNotMatch
            // 
            this.passNotMatch.AutoSize = true;
            this.passNotMatch.Location = new System.Drawing.Point(440, 300);
            this.passNotMatch.Name = "passNotMatch";
            this.passNotMatch.Size = new System.Drawing.Size(177, 20);
            this.passNotMatch.TabIndex = 12;
            this.passNotMatch.Text = "Passwords don\'t match!";
            this.passNotMatch.Visible = false;
            // 
            // passInvalidFormat
            // 
            this.passInvalidFormat.AutoSize = true;
            this.passInvalidFormat.Location = new System.Drawing.Point(423, 300);
            this.passInvalidFormat.Name = "passInvalidFormat";
            this.passInvalidFormat.Size = new System.Drawing.Size(209, 20);
            this.passInvalidFormat.TabIndex = 13;
            this.passInvalidFormat.Text = "Password has invalid format!";
            this.passInvalidFormat.Visible = false;
            // 
            // passFormat
            // 
            this.passFormat.AutoSize = true;
            this.passFormat.Location = new System.Drawing.Point(647, 431);
            this.passFormat.Name = "passFormat";
            this.passFormat.Size = new System.Drawing.Size(361, 20);
            this.passFormat.TabIndex = 14;
            this.passFormat.Text = "at least: one digit, one lower case. one upper case\r\n";
            this.passFormat.Visible = false;
            // 
            // usrExists
            // 
            this.usrExists.AutoSize = true;
            this.usrExists.Location = new System.Drawing.Point(384, 300);
            this.usrExists.Name = "usrExists";
            this.usrExists.Size = new System.Drawing.Size(282, 20);
            this.usrExists.TabIndex = 15;
            this.usrExists.Text = "User with this username already exists!";
            this.usrExists.Visible = false;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // FormInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 678);
            this.Controls.Add(this.usrExists);
            this.Controls.Add(this.passFormat);
            this.Controls.Add(this.passInvalidFormat);
            this.Controls.Add(this.passNotMatch);
            this.Controls.Add(this.passErrorImage);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.bt_signup);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.mainLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormInit";
            this.Text = "Music Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.passErrorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button bt_signup;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.PictureBox passErrorImage;
        private System.Windows.Forms.Label passNotMatch;
        private System.Windows.Forms.Label passInvalidFormat;
        private System.Windows.Forms.Label passFormat;
        private System.Windows.Forms.Label usrExists;
        private DataSetMainTableAdapters.UsersTableAdapter usersTableAdapter1;
    }
}