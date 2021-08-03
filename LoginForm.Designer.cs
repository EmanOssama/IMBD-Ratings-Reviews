namespace IMBD1
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_signin = new System.Windows.Forms.Button();
            this.btn_password = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_username = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelLogin.Controls.Add(this.linkLabel1);
            this.panelLogin.Controls.Add(this.btn_signin);
            this.panelLogin.Controls.Add(this.btn_password);
            this.panelLogin.Controls.Add(this.bunifuCustomLabel2);
            this.panelLogin.Controls.Add(this.bunifuCustomLabel1);
            this.panelLogin.Controls.Add(this.btn_username);
            this.panelLogin.Location = new System.Drawing.Point(276, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(886, 781);
            this.panelLogin.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Location = new System.Drawing.Point(326, 620);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(172, 25);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create an account";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_signin
            // 
            this.btn_signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_signin.BackColor = System.Drawing.Color.Gold;
            this.btn_signin.FlatAppearance.BorderSize = 0;
            this.btn_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.Color.Black;
            this.btn_signin.Location = new System.Drawing.Point(331, 534);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(150, 45);
            this.btn_signin.TabIndex = 4;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.button1_Click);
            this.btn_signin.MouseLeave += new System.EventHandler(this.btn_signin_MouseLeave);
            this.btn_signin.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btn_password
            // 
            this.btn_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_password.BackgroundImage")));
            this.btn_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_password.ForeColor = System.Drawing.Color.DimGray;
            this.btn_password.Icon = ((System.Drawing.Image)(resources.GetObject("btn_password.Icon")));
            this.btn_password.Location = new System.Drawing.Point(262, 419);
            this.btn_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_password.Name = "btn_password";
            this.btn_password.Size = new System.Drawing.Size(333, 52);
            this.btn_password.TabIndex = 3;
            this.btn_password.text = "*********";
            this.btn_password.Enter += new System.EventHandler(this.btn_password_Enter);
            this.btn_password.Leave += new System.EventHandler(this.btn_password_Leave);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(256, 361);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(139, 32);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(256, 186);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(159, 32);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Username  ";
            // 
            // btn_username
            // 
            this.btn_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_username.BackgroundImage")));
            this.btn_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_username.ForeColor = System.Drawing.Color.DimGray;
            this.btn_username.Icon = ((System.Drawing.Image)(resources.GetObject("btn_username.Icon")));
            this.btn_username.Location = new System.Drawing.Point(262, 250);
            this.btn_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_username.Name = "btn_username";
            this.btn_username.Size = new System.Drawing.Size(333, 52);
            this.btn_username.TabIndex = 0;
            this.btn_username.text = "Ex: Xyz_123";
            this.btn_username.Enter += new System.EventHandler(this.bunifuTextbox1_Enter);
            this.btn_username.Leave += new System.EventHandler(this.btn_username_Leave);
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::IMBD1.Properties.Resources.unnamed5;
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 781);
            this.panelLeft.TabIndex = 0;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 781);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private Bunifu.Framework.UI.BunifuTextbox btn_username;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btn_signin;
        private Bunifu.Framework.UI.BunifuTextbox btn_password;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
    }
}