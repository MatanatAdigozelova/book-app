namespace login_registration
{
    partial class login
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
            this.loginBox = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(122, 248);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(143, 43);
            this.loginBox.TabIndex = 0;
            this.loginBox.Text = "log in";
            this.loginBox.UseVisualStyleBackColor = true;
            this.loginBox.Click += new System.EventHandler(this.loginBox_Click);
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(122, 151);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(143, 20);
            this.userBox.TabIndex = 1;
            this.userBox.TextChanged += new System.EventHandler(this.userBox_TextChanged);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(122, 205);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(143, 20);
            this.passBox.TabIndex = 2;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user.Location = new System.Drawing.Point(116, 132);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(78, 16);
            this.user.TabIndex = 3;
            this.user.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(119, 186);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(75, 16);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 475);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.loginBox);
            this.Name = "login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label password;
    }
}

