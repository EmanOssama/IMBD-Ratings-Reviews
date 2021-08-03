namespace IMBD1
{
    partial class View_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Data));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iconButton_back = new FontAwesome.Sharp.IconButton();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_view_category = new System.Windows.Forms.RadioButton();
            this.radioButton_view_prize = new System.Windows.Forms.RadioButton();
            this.radioButton_view_user = new System.Windows.Forms.RadioButton();
            this.radioButton_view_movies = new System.Windows.Forms.RadioButton();
            this.panelLeft.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::IMBD1.Properties.Resources.unnamed5;
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.iconButton_back);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(229, 678);
            this.panelLeft.TabIndex = 2;
            // 
            // iconButton_back
            // 
            this.iconButton_back.BackColor = System.Drawing.Color.Black;
            this.iconButton_back.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_back.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconButton_back.IconColor = System.Drawing.Color.Gold;
            this.iconButton_back.IconSize = 26;
            this.iconButton_back.Location = new System.Drawing.Point(0, 3);
            this.iconButton_back.Name = "iconButton_back";
            this.iconButton_back.Rotation = 0D;
            this.iconButton_back.Size = new System.Drawing.Size(57, 40);
            this.iconButton_back.TabIndex = 51;
            this.iconButton_back.UseVisualStyleBackColor = false;
            this.iconButton_back.Click += new System.EventHandler(this.iconButton_back_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel_main.Controls.Add(this.btn_update);
            this.panel_main.Controls.Add(this.btn_delete);
            this.panel_main.Controls.Add(this.btn_Add);
            this.panel_main.Controls.Add(this.dataGridView1);
            this.panel_main.Controls.Add(this.groupBox1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(229, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(673, 678);
            this.panel_main.TabIndex = 3;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.Gold;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(251, 625);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 45);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.BackColor = System.Drawing.Color.Gold;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(486, 625);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 45);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.Gold;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(23, 625);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 45);
            this.btn_Add.TabIndex = 25;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-20, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(707, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioButton_view_category);
            this.groupBox1.Controls.Add(this.radioButton_view_prize);
            this.groupBox1.Controls.Add(this.radioButton_view_user);
            this.groupBox1.Controls.Add(this.radioButton_view_movies);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(152, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton_view_category
            // 
            this.radioButton_view_category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_view_category.AutoSize = true;
            this.radioButton_view_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_view_category.ForeColor = System.Drawing.Color.Gold;
            this.radioButton_view_category.Location = new System.Drawing.Point(119, 115);
            this.radioButton_view_category.Name = "radioButton_view_category";
            this.radioButton_view_category.Size = new System.Drawing.Size(213, 29);
            this.radioButton_view_category.TabIndex = 3;
            this.radioButton_view_category.TabStop = true;
            this.radioButton_view_category.Text = "View Categories Info";
            this.radioButton_view_category.UseVisualStyleBackColor = true;
            this.radioButton_view_category.CheckedChanged += new System.EventHandler(this.radioButton_view_category_CheckedChanged);
            // 
            // radioButton_view_prize
            // 
            this.radioButton_view_prize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_view_prize.AutoSize = true;
            this.radioButton_view_prize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_view_prize.ForeColor = System.Drawing.Color.Gold;
            this.radioButton_view_prize.Location = new System.Drawing.Point(119, 152);
            this.radioButton_view_prize.Name = "radioButton_view_prize";
            this.radioButton_view_prize.Size = new System.Drawing.Size(172, 29);
            this.radioButton_view_prize.TabIndex = 2;
            this.radioButton_view_prize.TabStop = true;
            this.radioButton_view_prize.Text = "View Prizes Info";
            this.radioButton_view_prize.UseVisualStyleBackColor = true;
            this.radioButton_view_prize.CheckedChanged += new System.EventHandler(this.radioButton_view_prize_CheckedChanged);
            // 
            // radioButton_view_user
            // 
            this.radioButton_view_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_view_user.AutoSize = true;
            this.radioButton_view_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_view_user.ForeColor = System.Drawing.Color.Gold;
            this.radioButton_view_user.Location = new System.Drawing.Point(119, 73);
            this.radioButton_view_user.Name = "radioButton_view_user";
            this.radioButton_view_user.Size = new System.Drawing.Size(169, 29);
            this.radioButton_view_user.TabIndex = 1;
            this.radioButton_view_user.TabStop = true;
            this.radioButton_view_user.Text = "View Users Info";
            this.radioButton_view_user.UseVisualStyleBackColor = true;
            this.radioButton_view_user.CheckedChanged += new System.EventHandler(this.radioButton_view_user_CheckedChanged);
            // 
            // radioButton_view_movies
            // 
            this.radioButton_view_movies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_view_movies.AutoSize = true;
            this.radioButton_view_movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_view_movies.ForeColor = System.Drawing.Color.Gold;
            this.radioButton_view_movies.Location = new System.Drawing.Point(119, 29);
            this.radioButton_view_movies.Name = "radioButton_view_movies";
            this.radioButton_view_movies.Size = new System.Drawing.Size(181, 29);
            this.radioButton_view_movies.TabIndex = 0;
            this.radioButton_view_movies.TabStop = true;
            this.radioButton_view_movies.Text = "View Movies Info";
            this.radioButton_view_movies.UseVisualStyleBackColor = true;
            this.radioButton_view_movies.CheckedChanged += new System.EventHandler(this.radioButton_view_movies_CheckedChanged);
            // 
            // View_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 678);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_Data_FormClosing);
            this.Load += new System.EventHandler(this.View_Data_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_view_user;
        private System.Windows.Forms.RadioButton radioButton_view_movies;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Add;
        private FontAwesome.Sharp.IconButton iconButton_back;
        private System.Windows.Forms.RadioButton radioButton_view_category;
        private System.Windows.Forms.RadioButton radioButton_view_prize;
    }
}