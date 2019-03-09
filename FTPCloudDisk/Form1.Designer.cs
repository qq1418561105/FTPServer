namespace FTPCloudDisk
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelPw = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.LoginB = new System.Windows.Forms.Button();
            this.RegiB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelUser.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelUser.Location = new System.Drawing.Point(66, 43);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(49, 14);
            this.LabelUser.TabIndex = 0;
            this.LabelUser.Text = "用户名";
            this.LabelUser.Click += new System.EventHandler(this.LabelUser_Click);
            // 
            // LabelPw
            // 
            this.LabelPw.AutoSize = true;
            this.LabelPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelPw.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPw.Location = new System.Drawing.Point(66, 85);
            this.LabelPw.Name = "LabelPw";
            this.LabelPw.Size = new System.Drawing.Size(35, 14);
            this.LabelPw.TabIndex = 1;
            this.LabelPw.Text = "密码";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.SystemColors.Window;
            this.UserName.Location = new System.Drawing.Point(134, 42);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(160, 21);
            this.UserName.TabIndex = 2;
            // 
            // PassWord
            // 
            this.PassWord.BackColor = System.Drawing.SystemColors.Window;
            this.PassWord.Location = new System.Drawing.Point(134, 78);
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '·';
            this.PassWord.Size = new System.Drawing.Size(160, 21);
            this.PassWord.TabIndex = 3;
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginB.Location = new System.Drawing.Point(58, 137);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(100, 23);
            this.LoginB.TabIndex = 4;
            this.LoginB.Text = "登录";
            this.LoginB.UseVisualStyleBackColor = false;
            // 
            // RegiB
            // 
            this.RegiB.BackColor = System.Drawing.SystemColors.Highlight;
            this.RegiB.Location = new System.Drawing.Point(194, 137);
            this.RegiB.Name = "RegiB";
            this.RegiB.Size = new System.Drawing.Size(100, 23);
            this.RegiB.TabIndex = 5;
            this.RegiB.Text = "注册";
            this.RegiB.UseVisualStyleBackColor = false;
            this.RegiB.Click += new System.EventHandler(this.RegiB_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(344, 190);
            this.Controls.Add(this.RegiB);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.LabelPw);
            this.Controls.Add(this.LabelUser);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Login";
            this.Text = "FTP云盘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label LabelPw;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.Button RegiB;
    }
}

