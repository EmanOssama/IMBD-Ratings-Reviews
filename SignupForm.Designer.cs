namespace IMBD1
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_gender = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_address = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTextbox_user_phone = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDatepicker_user_birthdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_confirm_password = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_password = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_email = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_user = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_last_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_first_name = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.btn_gender);
            this.panel2.Controls.Add(this.bunifuCustomLabel11);
            this.panel2.Controls.Add(this.btn_address);
            this.panel2.Controls.Add(this.bunifuCustomLabel10);
            this.panel2.Controls.Add(this.bunifuTextbox_user_phone);
            this.panel2.Controls.Add(this.bunifuCustomLabel9);
            this.panel2.Controls.Add(this.bunifuDatepicker_user_birthdate);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.btn_upload);
            this.panel2.Controls.Add(this.btn_signup);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.btn_confirm_password);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.btn_password);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.btn_email);
            this.panel2.Controls.Add(this.btn_user);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.btn_last_name);
            this.panel2.Controls.Add(this.btn_first_name);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(280, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 781);
            this.panel2.TabIndex = 1;
            // 
            // btn_gender
            // 
            this.btn_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_gender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gender.BackgroundImage")));
            this.btn_gender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gender.ForeColor = System.Drawing.Color.DimGray;
            this.btn_gender.Icon = ((System.Drawing.Image)(resources.GetObject("btn_gender.Icon")));
            this.btn_gender.Location = new System.Drawing.Point(556, 24);
            this.btn_gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_gender.Name = "btn_gender";
            this.btn_gender.Size = new System.Drawing.Size(169, 52);
            this.btn_gender.TabIndex = 24;
            this.btn_gender.text = "Ex: M-F";
            this.btn_gender.Enter += new System.EventHandler(this.btn_gender_Enter);
            this.btn_gender.Leave += new System.EventHandler(this.btn_gender_Leave);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(551, -9);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(94, 29);
            this.bunifuCustomLabel11.TabIndex = 23;
            this.bunifuCustomLabel11.Text = "Gender";
            // 
            // btn_address
            // 
            this.btn_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_address.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_address.BackgroundImage")));
            this.btn_address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_address.ForeColor = System.Drawing.Color.DimGray;
            this.btn_address.Icon = ((System.Drawing.Image)(resources.GetObject("btn_address.Icon")));
            this.btn_address.Location = new System.Drawing.Point(152, 228);
            this.btn_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_address.Name = "btn_address";
            this.btn_address.Size = new System.Drawing.Size(308, 52);
            this.btn_address.TabIndex = 22;
            this.btn_address.text = "Ex: Street 1 City A";
            this.btn_address.Enter += new System.EventHandler(this.btn_address_Enter);
            this.btn_address.Leave += new System.EventHandler(this.btn_address_Leave);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(151, 195);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(102, 29);
            this.bunifuCustomLabel10.TabIndex = 21;
            this.bunifuCustomLabel10.Text = "Address";
            // 
            // bunifuTextbox_user_phone
            // 
            this.bunifuTextbox_user_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuTextbox_user_phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTextbox_user_phone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox_user_phone.BackgroundImage")));
            this.bunifuTextbox_user_phone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox_user_phone.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuTextbox_user_phone.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox_user_phone.Icon")));
            this.bunifuTextbox_user_phone.Location = new System.Drawing.Point(152, 328);
            this.bunifuTextbox_user_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextbox_user_phone.Name = "bunifuTextbox_user_phone";
            this.bunifuTextbox_user_phone.Size = new System.Drawing.Size(308, 52);
            this.bunifuTextbox_user_phone.TabIndex = 20;
            this.bunifuTextbox_user_phone.text = "Ex: 0123456789";
            this.bunifuTextbox_user_phone.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            this.bunifuTextbox_user_phone.Enter += new System.EventHandler(this.bunifuTextbox1_Enter);
            this.bunifuTextbox_user_phone.Leave += new System.EventHandler(this.bunifuTextbox_user_phone_Leave);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(151, 295);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(93, 29);
            this.bunifuCustomLabel9.TabIndex = 19;
            this.bunifuCustomLabel9.Text = "Phone*";
            // 
            // bunifuDatepicker_user_birthdate
            // 
            this.bunifuDatepicker_user_birthdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuDatepicker_user_birthdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDatepicker_user_birthdate.BorderRadius = 0;
            this.bunifuDatepicker_user_birthdate.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuDatepicker_user_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker_user_birthdate.FormatCustom = null;
            this.bunifuDatepicker_user_birthdate.Location = new System.Drawing.Point(152, 429);
            this.bunifuDatepicker_user_birthdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker_user_birthdate.Name = "bunifuDatepicker_user_birthdate";
            this.bunifuDatepicker_user_birthdate.Size = new System.Drawing.Size(304, 44);
            this.bunifuDatepicker_user_birthdate.TabIndex = 18;
            this.bunifuDatepicker_user_birthdate.Value = new System.DateTime(2020, 4, 16, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(151, 396);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(112, 29);
            this.bunifuCustomLabel8.TabIndex = 17;
            this.bunifuCustomLabel8.Text = "BirthDate";
            // 
            // btn_upload
            // 
            this.btn_upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_upload.BackColor = System.Drawing.Color.Gold;
            this.btn_upload.FlatAppearance.BorderSize = 0;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.ForeColor = System.Drawing.Color.Black;
            this.btn_upload.Location = new System.Drawing.Point(556, 416);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(143, 45);
            this.btn_upload.TabIndex = 16;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.button2_Click);
            this.btn_upload.MouseLeave += new System.EventHandler(this.btn_upload_MouseLeave);
            this.btn_upload.MouseHover += new System.EventHandler(this.btn_upload_MouseHover);
            // 
            // btn_signup
            // 
            this.btn_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_signup.BackColor = System.Drawing.Color.Gold;
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.Black;
            this.btn_signup.Location = new System.Drawing.Point(539, 706);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(172, 45);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.button1_Click);
            this.btn_signup.MouseLeave += new System.EventHandler(this.btn_signup_MouseLeave);
            this.btn_signup.MouseHover += new System.EventHandler(this.btn_signup_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = global::IMBD1.Properties.Resources.iconfinder_men_5925629;
            this.pictureBox1.Location = new System.Drawing.Point(556, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(547, 205);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(164, 29);
            this.bunifuCustomLabel7.TabIndex = 14;
            this.bunifuCustomLabel7.Text = "Profile Picture";
            // 
            // btn_confirm_password
            // 
            this.btn_confirm_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_confirm_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_confirm_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_confirm_password.BackgroundImage")));
            this.btn_confirm_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_confirm_password.ForeColor = System.Drawing.Color.DimGray;
            this.btn_confirm_password.Icon = ((System.Drawing.Image)(resources.GetObject("btn_confirm_password.Icon")));
            this.btn_confirm_password.Location = new System.Drawing.Point(152, 737);
            this.btn_confirm_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_confirm_password.Name = "btn_confirm_password";
            this.btn_confirm_password.Size = new System.Drawing.Size(308, 52);
            this.btn_confirm_password.TabIndex = 13;
            this.btn_confirm_password.text = "*********";
            this.btn_confirm_password.Enter += new System.EventHandler(this.btn_confirm_password_Enter);
            this.btn_confirm_password.Leave += new System.EventHandler(this.btn_confirm_password_Leave);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(147, 704);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(220, 29);
            this.bunifuCustomLabel6.TabIndex = 12;
            this.bunifuCustomLabel6.Text = "Confirm Password*";
            // 
            // btn_password
            // 
            this.btn_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_password.BackgroundImage")));
            this.btn_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_password.ForeColor = System.Drawing.Color.DimGray;
            this.btn_password.Icon = ((System.Drawing.Image)(resources.GetObject("btn_password.Icon")));
            this.btn_password.Location = new System.Drawing.Point(156, 631);
            this.btn_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_password.Name = "btn_password";
            this.btn_password.Size = new System.Drawing.Size(304, 52);
            this.btn_password.TabIndex = 11;
            this.btn_password.text = "*********";
            this.btn_password.Enter += new System.EventHandler(this.btn_password_Enter);
            this.btn_password.Leave += new System.EventHandler(this.btn_password_Leave);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(151, 598);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(130, 29);
            this.bunifuCustomLabel5.TabIndex = 10;
            this.bunifuCustomLabel5.Text = "Password*";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(147, 493);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(92, 29);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "E-mail*";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // btn_email
            // 
            this.btn_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_email.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_email.BackgroundImage")));
            this.btn_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_email.ForeColor = System.Drawing.Color.DimGray;
            this.btn_email.Icon = ((System.Drawing.Image)(resources.GetObject("btn_email.Icon")));
            this.btn_email.Location = new System.Drawing.Point(152, 526);
            this.btn_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(308, 52);
            this.btn_email.TabIndex = 8;
            this.btn_email.text = "EX: Xyz_123@gmail.com";
            this.btn_email.Enter += new System.EventHandler(this.btn_email_Enter);
            this.btn_email.Leave += new System.EventHandler(this.btn_email_Leave);
            // 
            // btn_user
            // 
            this.btn_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_user.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_user.BackgroundImage")));
            this.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_user.ForeColor = System.Drawing.Color.DimGray;
            this.btn_user.Icon = ((System.Drawing.Image)(resources.GetObject("btn_user.Icon")));
            this.btn_user.Location = new System.Drawing.Point(152, 126);
            this.btn_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(308, 52);
            this.btn_user.TabIndex = 7;
            this.btn_user.text = "Ex: abc_xyz";
            this.btn_user.Enter += new System.EventHandler(this.btn_username_Enter);
            this.btn_user.Leave += new System.EventHandler(this.btn_username_Leave);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(151, 93);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(145, 29);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "User Name*";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // btn_last_name
            // 
            this.btn_last_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_last_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_last_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_last_name.BackgroundImage")));
            this.btn_last_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_last_name.ForeColor = System.Drawing.Color.DimGray;
            this.btn_last_name.Icon = ((System.Drawing.Image)(resources.GetObject("btn_last_name.Icon")));
            this.btn_last_name.Location = new System.Drawing.Point(353, 24);
            this.btn_last_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_last_name.Name = "btn_last_name";
            this.btn_last_name.Size = new System.Drawing.Size(169, 52);
            this.btn_last_name.TabIndex = 5;
            this.btn_last_name.text = "Ex: xyz";
            this.btn_last_name.Enter += new System.EventHandler(this.btn_last_name_Enter);
            this.btn_last_name.Leave += new System.EventHandler(this.btn_last_name_Leave);
            // 
            // btn_first_name
            // 
            this.btn_first_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_first_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_first_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_first_name.BackgroundImage")));
            this.btn_first_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_first_name.ForeColor = System.Drawing.Color.DimGray;
            this.btn_first_name.Icon = ((System.Drawing.Image)(resources.GetObject("btn_first_name.Icon")));
            this.btn_first_name.Location = new System.Drawing.Point(152, 24);
            this.btn_first_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_first_name.Name = "btn_first_name";
            this.btn_first_name.Size = new System.Drawing.Size(169, 52);
            this.btn_first_name.TabIndex = 4;
            this.btn_first_name.text = "Ex: abc";
            this.btn_first_name.OnTextChange += new System.EventHandler(this.btn_first_name_OnTextChange);
            this.btn_first_name.Enter += new System.EventHandler(this.bunifuTextbox2_Enter);
            this.btn_first_name.Leave += new System.EventHandler(this.btn_first_name_Leave);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(348, -9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(128, 29);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Last Name";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(147, -9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(131, 29);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "First Name";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::IMBD1.Properties.Resources.unnamed51;
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 781);
            this.panelLeft.TabIndex = 0;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 781);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignupForm_FormClosing);
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox btn_user;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuTextbox btn_last_name;
        private Bunifu.Framework.UI.BunifuTextbox btn_first_name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuTextbox btn_email;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuTextbox btn_confirm_password;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuTextbox btn_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox_user_phone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker_user_birthdate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuTextbox btn_address;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuTextbox btn_gender;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
    }
}