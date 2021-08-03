namespace IMBD1
{
    partial class Admin_Prize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Prize));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iconButton_back = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_prize_delete = new System.Windows.Forms.Button();
            this.btn_prize_update = new System.Windows.Forms.Button();
            this.btn_prize_add = new System.Windows.Forms.Button();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox_prize_nationality = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combobox_prize_title = new System.Windows.Forms.ComboBox();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::IMBD1.Properties.Resources.unnamed51;
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.iconButton_back);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 678);
            this.panelLeft.TabIndex = 3;
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
            this.iconButton_back.TabIndex = 51;
            this.iconButton_back.UseVisualStyleBackColor = false;
            this.iconButton_back.Click += new System.EventHandler(this.iconButton_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btn_prize_delete);
            this.panel1.Controls.Add(this.btn_prize_update);
            this.panel1.Controls.Add(this.btn_prize_add);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.textBox_prize_nationality);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.combobox_prize_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(280, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 678);
            this.panel1.TabIndex = 4;
            // 
            // btn_prize_delete
            // 
            this.btn_prize_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_prize_delete.BackColor = System.Drawing.Color.Gold;
            this.btn_prize_delete.FlatAppearance.BorderSize = 0;
            this.btn_prize_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prize_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prize_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_prize_delete.Location = new System.Drawing.Point(236, 523);
            this.btn_prize_delete.Name = "btn_prize_delete";
            this.btn_prize_delete.Size = new System.Drawing.Size(150, 45);
            this.btn_prize_delete.TabIndex = 19;
            this.btn_prize_delete.Text = "Delete";
            this.btn_prize_delete.UseVisualStyleBackColor = false;
            this.btn_prize_delete.Click += new System.EventHandler(this.btn_prize_delete_Click);
            // 
            // btn_prize_update
            // 
            this.btn_prize_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_prize_update.BackColor = System.Drawing.Color.Gold;
            this.btn_prize_update.FlatAppearance.BorderSize = 0;
            this.btn_prize_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prize_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prize_update.ForeColor = System.Drawing.Color.Black;
            this.btn_prize_update.Location = new System.Drawing.Point(236, 430);
            this.btn_prize_update.Name = "btn_prize_update";
            this.btn_prize_update.Size = new System.Drawing.Size(150, 45);
            this.btn_prize_update.TabIndex = 18;
            this.btn_prize_update.Text = "Update";
            this.btn_prize_update.UseVisualStyleBackColor = false;
            this.btn_prize_update.Click += new System.EventHandler(this.btn_prize_update_Click);
            // 
            // btn_prize_add
            // 
            this.btn_prize_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_prize_add.BackColor = System.Drawing.Color.Gold;
            this.btn_prize_add.FlatAppearance.BorderSize = 0;
            this.btn_prize_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prize_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prize_add.ForeColor = System.Drawing.Color.Black;
            this.btn_prize_add.Location = new System.Drawing.Point(236, 337);
            this.btn_prize_add.Name = "btn_prize_add";
            this.btn_prize_add.Size = new System.Drawing.Size(150, 45);
            this.btn_prize_add.TabIndex = 17;
            this.btn_prize_add.Text = "Add";
            this.btn_prize_add.UseVisualStyleBackColor = false;
            this.btn_prize_add.Click += new System.EventHandler(this.btn_prize_add_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(133, 256);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(150, 32);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Nationality";
            // 
            // textBox_prize_nationality
            // 
            this.textBox_prize_nationality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_prize_nationality.Location = new System.Drawing.Point(319, 262);
            this.textBox_prize_nationality.Name = "textBox_prize_nationality";
            this.textBox_prize_nationality.Size = new System.Drawing.Size(121, 22);
            this.textBox_prize_nationality.TabIndex = 9;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(176, 167);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(70, 32);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Title";
            // 
            // combobox_prize_title
            // 
            this.combobox_prize_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combobox_prize_title.FormattingEnabled = true;
            this.combobox_prize_title.Location = new System.Drawing.Point(319, 175);
            this.combobox_prize_title.Name = "combobox_prize_title";
            this.combobox_prize_title.Size = new System.Drawing.Size(121, 24);
            this.combobox_prize_title.TabIndex = 7;
            this.combobox_prize_title.SelectedIndexChanged += new System.EventHandler(this.combobox_prize_title_SelectedIndexChanged);
            // 
            // Admin_Prize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Prize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Prize";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Prize_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Prize_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private FontAwesome.Sharp.IconButton iconButton_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combobox_prize_title;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox textBox_prize_nationality;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button btn_prize_add;
        private System.Windows.Forms.Button btn_prize_update;
        private System.Windows.Forms.Button btn_prize_delete;
    }
}