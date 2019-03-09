namespace FTPCloudDisk
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelPassword2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.BackColor = System.Drawing.Color.White;
            this.LabelUser.Font = new System.Drawing.Font("SimSun", 10F);
            this.LabelUser.Location = new System.Drawing.Point(69, 34);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(49, 14);
            this.LabelUser.TabIndex = 0;
            this.LabelUser.Text = "用户名";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.White;
            this.LabelPassword.Font = new System.Drawing.Font("SimSun", 10F);
            this.LabelPassword.Location = new System.Drawing.Point(83, 72);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(35, 14);
            this.LabelPassword.TabIndex = 1;
            this.LabelPassword.Text = "密码";
            // 
            // LabelPassword2
            // 
            this.LabelPassword2.AutoSize = true;
            this.LabelPassword2.BackColor = System.Drawing.Color.White;
            this.LabelPassword2.Font = new System.Drawing.Font("SimSun", 10F);
            this.LabelPassword2.Location = new System.Drawing.Point(55, 109);
            this.LabelPassword2.Name = "LabelPassword2";
            this.LabelPassword2.Size = new System.Drawing.Size(63, 14);
            this.LabelPassword2.TabIndex = 2;
            this.LabelPassword2.Text = "确认密码";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(147, 29);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(123, 21);
            this.UserName.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(147, 70);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(123, 21);
            this.Password.TabIndex = 4;
            // 
            // Password2
            // 
            this.Password2.Location = new System.Drawing.Point(147, 107);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(123, 21);
            this.Password2.TabIndex = 5;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(72, 155);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(74, 19);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "提交";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(196, 155);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(74, 19);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 192);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.LabelPassword2);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUser);
            this.Name = "Register";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelPassword2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Password2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
    }
}