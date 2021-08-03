namespace IMBD1
{
    partial class Admin_Person
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Person));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iconButton_back = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_actor_movie_id = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_Prizes = new System.Windows.Forms.Panel();
            this.textBox_actor_movie_character_name = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBox_actor_director_prize = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelRateid = new System.Windows.Forms.Panel();
            this.textBox_directo_or_actor_rateid = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox_actor_gender = new System.Windows.Forms.TextBox();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.radioButton_actor = new System.Windows.Forms.RadioButton();
            this.radioButton_director = new System.Windows.Forms.RadioButton();
            this.textBox_actor_address = new System.Windows.Forms.TextBox();
            this.textBox_actor_phone = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox_actor_userid = new System.Windows.Forms.TextBox();
            this.textBox_actor_password = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox_actor_email = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox_actor_BD = new System.Windows.Forms.TextBox();
            this.textBox_actor_LN = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox_actor_FN = new System.Windows.Forms.TextBox();
            this.label_movie_title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_actor_photoupload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combobox_id = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Prizes.SuspendLayout();
            this.panelRateid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Gold;
            this.panelLeft.BackgroundImage = global::IMBD1.Properties.Resources.unnamed51;
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.iconButton_back);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 678);
            this.panelLeft.TabIndex = 2;
            // 
            // iconButton_back
            // 
            this.iconButton_back.BackColor = System.Drawing.Color.Black;
            this.iconButton_back.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_back.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconButton_back.IconColor = System.Drawing.Color.Gold;
            this.iconButton_back.IconSize = 26;
            this.iconButton_back.Location = new System.Drawing.Point(0, 0);
            this.iconButton_back.Name = "iconButton_back";
            this.iconButton_back.Rotation = 0D;
            this.iconButton_back.Size = new System.Drawing.Size(57, 40);
            this.iconButton_back.TabIndex = 50;
            this.iconButton_back.UseVisualStyleBackColor = false;
            this.iconButton_back.Click += new System.EventHandler(this.iconButton_back_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.comboBox_actor_movie_id);
            this.panel1.Controls.Add(this.bunifuCustomLabel13);
            this.panel1.Controls.Add(this.panel_Prizes);
            this.panel1.Controls.Add(this.panelRateid);
            this.panel1.Controls.Add(this.textBox_actor_gender);
            this.panel1.Controls.Add(this.radioButton_user);
            this.panel1.Controls.Add(this.radioButton_actor);
            this.panel1.Controls.Add(this.radioButton_director);
            this.panel1.Controls.Add(this.textBox_actor_address);
            this.panel1.Controls.Add(this.textBox_actor_phone);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.textBox_actor_userid);
            this.panel1.Controls.Add(this.textBox_actor_password);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.textBox_actor_email);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.textBox_actor_BD);
            this.panel1.Controls.Add(this.textBox_actor_LN);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.textBox_actor_FN);
            this.panel1.Controls.Add(this.label_movie_title);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.btn_actor_photoupload);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.combobox_id);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(280, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 678);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox_actor_movie_id
            // 
            this.comboBox_actor_movie_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_actor_movie_id.FormattingEnabled = true;
            this.comboBox_actor_movie_id.Location = new System.Drawing.Point(222, 509);
            this.comboBox_actor_movie_id.Name = "comboBox_actor_movie_id";
            this.comboBox_actor_movie_id.Size = new System.Drawing.Size(121, 24);
            this.comboBox_actor_movie_id.TabIndex = 52;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(67, 501);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(138, 32);
            this.bunifuCustomLabel13.TabIndex = 51;
            this.bunifuCustomLabel13.Text = "Movie-ID*";
            // 
            // panel_Prizes
            // 
            this.panel_Prizes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Prizes.Controls.Add(this.textBox_actor_movie_character_name);
            this.panel_Prizes.Controls.Add(this.bunifuCustomLabel14);
            this.panel_Prizes.Controls.Add(this.comboBox_actor_director_prize);
            this.panel_Prizes.Controls.Add(this.bunifuCustomLabel12);
            this.panel_Prizes.Location = new System.Drawing.Point(364, 347);
            this.panel_Prizes.Name = "panel_Prizes";
            this.panel_Prizes.Size = new System.Drawing.Size(246, 186);
            this.panel_Prizes.TabIndex = 50;
            // 
            // textBox_actor_movie_character_name
            // 
            this.textBox_actor_movie_character_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor_movie_character_name.Location = new System.Drawing.Point(39, 144);
            this.textBox_actor_movie_character_name.Name = "textBox_actor_movie_character_name";
            this.textBox_actor_movie_character_name.Size = new System.Drawing.Size(121, 22);
            this.textBox_actor_movie_character_name.TabIndex = 51;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(3, 98);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(234, 32);
            this.bunifuCustomLabel14.TabIndex = 54;
            this.bunifuCustomLabel14.Text = "Character-Name*";
            // 
            // comboBox_actor_director_prize
            // 
            this.comboBox_actor_director_prize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_actor_director_prize.FormattingEnabled = true;
            this.comboBox_actor_director_prize.Location = new System.Drawing.Point(39, 57);
            this.comboBox_actor_director_prize.Name = "comboBox_actor_director_prize";
            this.comboBox_actor_director_prize.Size = new System.Drawing.Size(121, 24);
            this.comboBox_actor_director_prize.TabIndex = 53;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(45, 10);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(105, 32);
            this.bunifuCustomLabel12.TabIndex = 51;
            this.bunifuCustomLabel12.Text = "Prizes*";
            // 
            // panelRateid
            // 
            this.panelRateid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRateid.Controls.Add(this.textBox_directo_or_actor_rateid);
            this.panelRateid.Controls.Add(this.bunifuCustomLabel11);
            this.panelRateid.Location = new System.Drawing.Point(386, 250);
            this.panelRateid.Name = "panelRateid";
            this.panelRateid.Size = new System.Drawing.Size(200, 88);
            this.panelRateid.TabIndex = 49;
            this.panelRateid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRateid_Paint);
            // 
            // textBox_directo_or_actor_rateid
            // 
            this.textBox_directo_or_actor_rateid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_directo_or_actor_rateid.Location = new System.Drawing.Point(10, 56);
            this.textBox_directo_or_actor_rateid.Name = "textBox_directo_or_actor_rateid";
            this.textBox_directo_or_actor_rateid.Size = new System.Drawing.Size(121, 22);
            this.textBox_directo_or_actor_rateid.TabIndex = 50;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(13, 4);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(111, 32);
            this.bunifuCustomLabel11.TabIndex = 43;
            this.bunifuCustomLabel11.Text = "Rate-ID";
            // 
            // textBox_actor_gender
            // 
            this.textBox_actor_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor_gender.Location = new System.Drawing.Point(222, 347);
            this.textBox_actor_gender.Name = "textBox_actor_gender";
            this.textBox_actor_gender.Size = new System.Drawing.Size(121, 22);
            this.textBox_actor_gender.TabIndex = 48;
            // 
            // radioButton_user
            // 
            this.radioButton_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_user.ForeColor = System.Drawing.Color.Gold;
            this.radioButton_user.Location = new System.Drawing.Point(68, 550);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(74, 29);
            this.radioButton_user.TabIndex = 47;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "User";
            this.radioButton_user.UseVisualStyleBackColor = false;
            // 
            // radioButton_actor
            // 
            this.radioButton_actor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_actor.AutoSize = true;
            this.radioButton_actor.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_actor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_actor.ForeColor = System.Drawing.Color.Gold;
            this.radioButton_actor.Location = new System.Drawing.Point(247, 550);
            this.radioButton_actor.Name = "radioButton_actor";
            this.radioButton_actor.Size = new System.Drawing.Size(79, 29);
            this.radioButton_actor.TabIndex = 46;
            this.radioButton_actor.TabStop = true;
            this.radioButton_actor.Text = "Actor";
            this.radioButton_actor.UseVisualStyleBackColor = false;
            this.radioButton_actor.CheckedChanged += new System.EventHandler(this.radioButton_actor_CheckedChanged);
            // 
            // radioButton_director
            // 
            this.radioButton_director.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_director.AutoSize = true;
            this.radioButton_director.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_director.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_director.ForeColor = System.Drawing.Color.Gold;
            this.radioButton_director.Location = new System.Drawing.Point(402, 550);
            this.radioButton_director.Name = "radioButton_director";
            this.radioButton_director.Size = new System.Drawing.Size(100, 29);
            this.radioButton_director.TabIndex = 45;
            this.radioButton_director.TabStop = true;
            this.radioButton_director.Text = "Director";
            this.radioButton_director.UseVisualStyleBackColor = false;
            this.radioButton_director.CheckedChanged += new System.EventHandler(this.radioButton_director_CheckedChanged);
            // 
            // textBox_actor_address
            // 
            this.textBox_actor_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor_address.Location = new System.Drawing.Point(222, 306);
            this.textBox_actor_address.Name = "textBox_actor_address";
            this.textBox_actor_address.Size = new System.Drawing.Size(121, 22);
            this.textBox_actor_address.TabIndex = 44;
            // 
            // textBox_actor_phone
            // 
            this.textBox_actor_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor_phone.Location = new System.Drawing.Point(222, 212);
            this.textBox_actor_phone.Name = "textBox_actor_phone";
            this.textBox_actor_phone.Size = new System.Drawing.Size(121, 22);
            this.textBox_actor_phone.TabIndex = 43;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(61, 262);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(107, 32);
            this.bunifuCustomLabel10.TabIndex = 42;
            this.bunifuCustomLabel10.Text = "E-mail*";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(61, 212);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(109, 32);
            this.bunifuCustomLabel9.TabIndex = 41;
            this.bunifuCustomLabel9.Text = "Phone*";
            // 
            // textBox_actor_userid
            // 
            this.textBox_actor_userid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor_userid.Enabled = false;
            this.textBox_actor_userid.Location = new System.Drawing.Point(222, 404);
            this.textBox_actor_userid.Name = "textBox_actor_userid";
            this.textBox_actor_userid.Size = new System.Drawing.Size(121, 22);
            this.textBox_actor_userid.TabIndex = 40;
            // 
            // textBox_actor_password
            // 
            this.textBox_actor_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor_password.Location = new System.Drawing.Point(222, 455);
            this.textBox_actor_password.Name = "textBox_actor_password";
            this.textBox_actor_password.Size = new System.Drawing.Size(121, 22);
            this.textBox_actor_password.TabIndex = 39;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(54, 455);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(139, 32);
            this.bunifuCustomLabel8.TabIndex = 38;
            this.bunifuCustomLabel8.Text = "Password";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(56, 17);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(145, 32);
            this.bunifuCustomLabel7.TabIndex = 37;
            this.bunifuCustomLabel7.Text = "Username";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(61, 347);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(110, 32);
            this.bunifuCustomLabel5.TabIndex = 34;
            this.bunifuCustomLabel5.Text = "Gender";
            // 
            // textBox_actor_email
            // 
            this.textBox_actor_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor_email.Location = new System.Drawing.Point(222, 262);
            this.textBox_actor_email.Name = "textBox_actor_email";
            this.textBox_actor_email.Size = new System.Drawing.Size(121, 22);
            this.textBox_actor_email.TabIndex = 33;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(59, 306);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(119, 32);
            this.bunifuCustomLabel4.TabIndex = 32;
            this.bunifuCustomLabel4.Text = "Address";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(61, 157);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(141, 32);
            this.bunifuCustomLabel3.TabIndex = 31;
            this.bunifuCustomLabel3.Text = "Birth Date";
            // 
            // textBox_actor_BD
            // 
            this.textBox_actor_BD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor_BD.Location = new System.Drawing.Point(222, 157);
            this.textBox_actor_BD.Name = "textBox_actor_BD";
            this.textBox_actor_BD.Size = new System.Drawing.Size(121, 22);
            this.textBox_actor_BD.TabIndex = 30;
            // 
            // textBox_actor_LN
            // 
            this.textBox_actor_LN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor_LN.Location = new System.Drawing.Point(222, 106);
            this.textBox_actor_LN.Name = "textBox_actor_LN";
            this.textBox_actor_LN.Size = new System.Drawing.Size(121, 22);
            this.textBox_actor_LN.TabIndex = 29;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(56, 106);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(151, 32);
            this.bunifuCustomLabel2.TabIndex = 28;
            this.bunifuCustomLabel2.Text = "Last Name";
            // 
            // textBox_actor_FN
            // 
            this.textBox_actor_FN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor_FN.Location = new System.Drawing.Point(222, 62);
            this.textBox_actor_FN.Name = "textBox_actor_FN";
            this.textBox_actor_FN.Size = new System.Drawing.Size(121, 22);
            this.textBox_actor_FN.TabIndex = 27;
            // 
            // label_movie_title
            // 
            this.label_movie_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_movie_title.AutoSize = true;
            this.label_movie_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_movie_title.ForeColor = System.Drawing.Color.Gold;
            this.label_movie_title.Location = new System.Drawing.Point(54, 57);
            this.label_movie_title.Name = "label_movie_title";
            this.label_movie_title.Size = new System.Drawing.Size(152, 32);
            this.label_movie_title.TabIndex = 4;
            this.label_movie_title.Text = "First Name";
            this.label_movie_title.Click += new System.EventHandler(this.label_movie_title_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.Gold;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(402, 602);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 45);
            this.btn_Delete.TabIndex = 26;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.Gold;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(235, 602);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(150, 45);
            this.btn_Update.TabIndex = 25;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.Gold;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(57, 602);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 45);
            this.btn_Add.TabIndex = 24;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_actor_photoupload
            // 
            this.btn_actor_photoupload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_actor_photoupload.BackColor = System.Drawing.Color.Gold;
            this.btn_actor_photoupload.FlatAppearance.BorderSize = 0;
            this.btn_actor_photoupload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actor_photoupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actor_photoupload.ForeColor = System.Drawing.Color.Black;
            this.btn_actor_photoupload.Location = new System.Drawing.Point(402, 186);
            this.btn_actor_photoupload.Name = "btn_actor_photoupload";
            this.btn_actor_photoupload.Size = new System.Drawing.Size(138, 45);
            this.btn_actor_photoupload.TabIndex = 23;
            this.btn_actor_photoupload.Text = "Upload";
            this.btn_actor_photoupload.UseVisualStyleBackColor = false;
            this.btn_actor_photoupload.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = global::IMBD1.Properties.Resources.iconfinder_men_5925629;
            this.pictureBox1.Location = new System.Drawing.Point(402, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(417, 11);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(90, 32);
            this.bunifuCustomLabel6.TabIndex = 21;
            this.bunifuCustomLabel6.Text = "Photo";
            // 
            // combobox_id
            // 
            this.combobox_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combobox_id.FormattingEnabled = true;
            this.combobox_id.Location = new System.Drawing.Point(222, 17);
            this.combobox_id.Name = "combobox_id";
            this.combobox_id.Size = new System.Drawing.Size(121, 24);
            this.combobox_id.TabIndex = 6;
            this.combobox_id.SelectedIndexChanged += new System.EventHandler(this.combobox_id_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(62, 404);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(116, 32);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "User_ID";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Admin_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Actor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Actor_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Actor_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Prizes.ResumeLayout(false);
            this.panel_Prizes.PerformLayout();
            this.panelRateid.ResumeLayout(false);
            this.panelRateid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combobox_id;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_actor_photoupload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private Bunifu.Framework.UI.BunifuCustomLabel label_movie_title;
        private System.Windows.Forms.TextBox textBox_actor_FN;
        private System.Windows.Forms.TextBox textBox_actor_password;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TextBox textBox_actor_email;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox textBox_actor_BD;
        private System.Windows.Forms.TextBox textBox_actor_LN;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox textBox_actor_phone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.TextBox textBox_actor_address;
        private System.Windows.Forms.RadioButton radioButton_user;
        private System.Windows.Forms.RadioButton radioButton_actor;
        private System.Windows.Forms.RadioButton radioButton_director;
        private System.Windows.Forms.TextBox textBox_actor_gender;
        private System.Windows.Forms.TextBox textBox_actor_userid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelRateid;
        private System.Windows.Forms.TextBox textBox_directo_or_actor_rateid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private FontAwesome.Sharp.IconButton iconButton_back;
        private System.Windows.Forms.Panel panel_Prizes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.ComboBox comboBox_actor_movie_id;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private System.Windows.Forms.ComboBox comboBox_actor_director_prize;
        private System.Windows.Forms.TextBox textBox_actor_movie_character_name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
    }
}