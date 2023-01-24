
namespace BookMs
{
    partial class user
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.助けるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理者を連絡するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.図書検索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自分の本を借りToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系統ToolStripMenuItem,
            this.図書検索ToolStripMenuItem,
            this.自分の本を借りToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系統ToolStripMenuItem
            // 
            this.系統ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.助けるToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.管理者を連絡するToolStripMenuItem});
            this.系統ToolStripMenuItem.Name = "系統ToolStripMenuItem";
            this.系統ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.系統ToolStripMenuItem.Text = "系統";
            // 
            // 助けるToolStripMenuItem
            // 
            this.助けるToolStripMenuItem.Name = "助けるToolStripMenuItem";
            this.助けるToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.助けるToolStripMenuItem.Text = "助ける";
            this.助けるToolStripMenuItem.Click += new System.EventHandler(this.助けるToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 管理者を連絡するToolStripMenuItem
            // 
            this.管理者を連絡するToolStripMenuItem.Name = "管理者を連絡するToolStripMenuItem";
            this.管理者を連絡するToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.管理者を連絡するToolStripMenuItem.Text = "管理者を連絡する";
            // 
            // 図書検索ToolStripMenuItem
            // 
            this.図書検索ToolStripMenuItem.Name = "図書検索ToolStripMenuItem";
            this.図書検索ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.図書検索ToolStripMenuItem.Text = "図書検索";
            this.図書検索ToolStripMenuItem.Click += new System.EventHandler(this.図書検索ToolStripMenuItem_Click);
            // 
            // 自分の本を借りToolStripMenuItem
            // 
            this.自分の本を借りToolStripMenuItem.Name = "自分の本を借りToolStripMenuItem";
            this.自分の本を借りToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.自分の本を借りToolStripMenuItem.Text = "自分の本を借り";
            this.自分の本を借りToolStripMenuItem.Click += new System.EventHandler(this.自分の本を借りToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "歓迎";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "user";
            this.Text = "ユーザー管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系統ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 助けるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理者を連絡するToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 図書検索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自分の本を借りToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}