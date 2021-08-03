namespace IMBD1
{
    partial class Admin_Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Categories));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iconButton_back = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_category_delete = new System.Windows.Forms.Button();
            this.btn_category_update = new System.Windows.Forms.Button();
            this.btn_category_add = new System.Windows.Forms.Button();
            this.textBox_category_name = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combobox_category_id = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
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
            this.iconButton_back.TabIndex = 51;
            this.iconButton_back.UseVisualStyleBackColor = false;
            this.iconButton_back.Click += new System.EventHandler(this.iconButton_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btn_category_delete);
            this.panel1.Controls.Add(this.btn_category_update);
            this.panel1.Controls.Add(this.btn_category_add);
            this.panel1.Controls.Add(this.textBox_category_name);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.combobox_category_id);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(280, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 678);
            this.panel1.TabIndex = 3;
            // 
            // btn_category_delete
            // 
            this.btn_category_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_category_delete.BackColor = System.Drawing.Color.Gold;
            this.btn_category_delete.FlatAppearance.BorderSize = 0;
            this.btn_category_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_category_delete.Location = new System.Drawing.Point(245, 514);
            this.btn_category_delete.Name = "btn_category_delete";
            this.btn_category_delete.Size = new System.Drawing.Size(150, 45);
            this.btn_category_delete.TabIndex = 18;
            this.btn_category_delete.Text = "Delete";
            this.btn_category_delete.UseVisualStyleBackColor = false;
            this.btn_category_delete.Click += new System.EventHandler(this.btn_category_delete_Click);
            // 
            // btn_category_update
            // 
            this.btn_category_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_category_update.BackColor = System.Drawing.Color.Gold;
            this.btn_category_update.FlatAppearance.BorderSize = 0;
            this.btn_category_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category_update.ForeColor = System.Drawing.Color.Black;
            this.btn_category_update.Location = new System.Drawing.Point(245, 420);
            this.btn_category_update.Name = "btn_category_update";
            this.btn_category_update.Size = new System.Drawing.Size(150, 45);
            this.btn_category_update.TabIndex = 17;
            this.btn_category_update.Text = "Update";
            this.btn_category_update.UseVisualStyleBackColor = false;
            this.btn_category_update.Click += new System.EventHandler(this.btn_category_update_Click);
            // 
            // btn_category_add
            // 
            this.btn_category_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_category_add.BackColor = System.Drawing.Color.Gold;
            this.btn_category_add.FlatAppearance.BorderSize = 0;
            this.btn_category_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category_add.ForeColor = System.Drawing.Color.Black;
            this.btn_category_add.Location = new System.Drawing.Point(245, 322);
            this.btn_category_add.Name = "btn_category_add";
            this.btn_category_add.Size = new System.Drawing.Size(150, 45);
            this.btn_category_add.TabIndex = 16;
            this.btn_category_add.Text = "Add";
            this.btn_category_add.UseVisualStyleBackColor = false;
            this.btn_category_add.Click += new System.EventHandler(this.btn_category_add_Click);
            // 
            // textBox_category_name
            // 
            this.textBox_category_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_category_name.Location = new System.Drawing.Point(245, 218);
            this.textBox_category_name.Name = "textBox_category_name";
            this.textBox_category_name.Size = new System.Drawing.Size(121, 22);
            this.textBox_category_name.TabIndex = 8;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(150, 218);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 32);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Type";
            // 
            // combobox_category_id
            // 
            this.combobox_category_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combobox_category_id.FormattingEnabled = true;
            this.combobox_category_id.Location = new System.Drawing.Point(245, 126);
            this.combobox_category_id.Name = "combobox_category_id";
            this.combobox_category_id.Size = new System.Drawing.Size(121, 24);
            this.combobox_category_id.TabIndex = 6;
            this.combobox_category_id.SelectedIndexChanged += new System.EventHandler(this.combobox_category_id_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(150, 126);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(42, 32);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "ID";
            // 
            // Admin_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Categories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Categories_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Categories_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private FontAwesome.Sharp.IconButton iconButton_back;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox combobox_category_id;
        private System.Windows.Forms.TextBox textBox_category_name;
        private System.Windows.Forms.Button btn_category_add;
        private System.Windows.Forms.Button btn_category_update;
        private System.Windows.Forms.Button btn_category_delete;
    }
}