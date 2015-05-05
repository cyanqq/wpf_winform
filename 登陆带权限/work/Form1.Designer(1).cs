namespace 登录
{
    partial class form_longin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_longin));
            this.label1 = new System.Windows.Forms.Label();
            this.LbUser = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbYanzheng = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbYangzhengip = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LbShow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(218, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "焦化一体化智能控制系统";
            // 
            // LbUser
            // 
            this.LbUser.AutoSize = true;
            this.LbUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUser.Location = new System.Drawing.Point(209, 153);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(40, 18);
            this.LbUser.TabIndex = 1;
            this.LbUser.Text = "账户";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.Location = new System.Drawing.Point(209, 201);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(40, 18);
            this.LbPassword.TabIndex = 2;
            this.LbPassword.Text = "密码";
            // 
            // LbYanzheng
            // 
            this.LbYanzheng.AutoSize = true;
            this.LbYanzheng.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbYanzheng.Location = new System.Drawing.Point(193, 249);
            this.LbYanzheng.Name = "LbYanzheng";
            this.LbYanzheng.Size = new System.Drawing.Size(56, 18);
            this.LbYanzheng.TabIndex = 3;
            this.LbYanzheng.Text = "验证码";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(302, 150);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(120, 21);
            this.tbUser.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(302, 199);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(120, 21);
            this.tbPassword.TabIndex = 5;
            // 
            // tbYangzhengip
            // 
            this.tbYangzhengip.Location = new System.Drawing.Point(302, 246);
            this.tbYangzhengip.Name = "tbYangzhengip";
            this.tbYangzhengip.Size = new System.Drawing.Size(120, 21);
            this.tbYangzhengip.TabIndex = 6;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("宋体", 8.3F);
            this.BtnLogin.Location = new System.Drawing.Point(450, 308);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("宋体", 8.3F);
            this.BtnReset.Location = new System.Drawing.Point(573, 308);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "重置";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(545, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "看不清换一张";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbShow
            // 
            this.LbShow.AutoSize = true;
            this.LbShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(185)))), ((int)(((byte)(127)))));
            this.LbShow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbShow.Image = ((System.Drawing.Image)(resources.GetObject("LbShow.Image")));
            this.LbShow.Location = new System.Drawing.Point(469, 250);
            this.LbShow.Name = "LbShow";
            this.LbShow.Size = new System.Drawing.Size(56, 16);
            this.LbShow.TabIndex = 12;
            this.LbShow.Text = "label2";
            this.LbShow.Click += new System.EventHandler(this.LbShow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // form_longin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(969, 569);
            this.Controls.Add(this.LbShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.tbYangzhengip);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.LbYanzheng);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_longin";
            this.Text = "焦化智能控制系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbUser;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbYanzheng;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbYangzhengip;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LbShow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

