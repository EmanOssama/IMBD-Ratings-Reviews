namespace IMBD1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_view_data = new System.Windows.Forms.Button();
            this.btn_manage_actors = new System.Windows.Forms.Button();
            this.btn_manage_movies = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelAdmin.Controls.Add(this.button3);
            this.panelAdmin.Controls.Add(this.linkLabel1);
            this.panelAdmin.Controls.Add(this.button2);
            this.panelAdmin.Controls.Add(this.button1);
            this.panelAdmin.Controls.Add(this.btn_view_data);
            this.panelAdmin.Controls.Add(this.btn_manage_actors);
            this.panelAdmin.Controls.Add(this.btn_manage_movies);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(280, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(622, 678);
            this.panelAdmin.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(210, 585);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 81);
            this.button3.TabIndex = 11;
            this.button3.Text = "Show Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Gold;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Location = new System.Drawing.Point(471, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(210, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 81);
            this.button2.TabIndex = 9;
            this.button2.Text = "Manage Prizes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(210, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "Manage Categories";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_view_data
            // 
            this.btn_view_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_view_data.BackColor = System.Drawing.Color.Gold;
            this.btn_view_data.FlatAppearance.BorderSize = 0;
            this.btn_view_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_data.ForeColor = System.Drawing.Color.Black;
            this.btn_view_data.Location = new System.Drawing.Point(210, 250);
            this.btn_view_data.Name = "btn_view_data";
            this.btn_view_data.Size = new System.Drawing.Size(170, 81);
            this.btn_view_data.TabIndex = 7;
            this.btn_view_data.Text = "View Data";
            this.btn_view_data.UseVisualStyleBackColor = false;
            this.btn_view_data.Click += new System.EventHandler(this.btn_view_data_Click);
            // 
            // btn_manage_actors
            // 
            this.btn_manage_actors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_manage_actors.BackColor = System.Drawing.Color.Gold;
            this.btn_manage_actors.FlatAppearance.BorderSize = 0;
            this.btn_manage_actors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage_actors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_actors.ForeColor = System.Drawing.Color.Black;
            this.btn_manage_actors.Location = new System.Drawing.Point(210, 137);
            this.btn_manage_actors.Name = "btn_manage_actors";
            this.btn_manage_actors.Size = new System.Drawing.Size(170, 81);
            this.btn_manage_actors.TabIndex = 6;
            this.btn_manage_actors.Text = "Manage Users";
            this.btn_manage_actors.UseVisualStyleBackColor = false;
            this.btn_manage_actors.Click += new System.EventHandler(this.btn_manage_actors_Click);
            // 
            // btn_manage_movies
            // 
            this.btn_manage_movies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_manage_movies.BackColor = System.Drawing.Color.Gold;
            this.btn_manage_movies.FlatAppearance.BorderSize = 0;
            this.btn_manage_movies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage_movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_movies.ForeColor = System.Drawing.Color.Black;
            this.btn_manage_movies.Location = new System.Drawing.Point(210, 20);
            this.btn_manage_movies.Name = "btn_manage_movies";
            this.btn_manage_movies.Size = new System.Drawing.Size(170, 81);
            this.btn_manage_movies.TabIndex = 5;
            this.btn_manage_movies.Text = "Manage Movies";
            this.btn_manage_movies.UseVisualStyleBackColor = false;
            this.btn_manage_movies.Click += new System.EventHandler(this.btn_manage_movies_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::IMBD1.Properties.Resources.unnamed5;
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 678);
            this.panelLeft.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 678);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btn_view_data;
        private System.Windows.Forms.Button btn_manage_actors;
        private System.Windows.Forms.Button btn_manage_movies;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button3;

    }
}