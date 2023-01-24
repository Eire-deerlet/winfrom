
namespace BookMs
{
    partial class admin1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.システムToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.図書管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.助けるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 52);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 28);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.システムToolStripMenuItem,
            this.図書管理ToolStripMenuItem,
            this.助けるToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 28);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // システムToolStripMenuItem
            // 
            this.システムToolStripMenuItem.Name = "システムToolStripMenuItem";
            this.システムToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.システムToolStripMenuItem.Text = "システム";
            // 
            // 図書管理ToolStripMenuItem
            // 
            this.図書管理ToolStripMenuItem.Name = "図書管理ToolStripMenuItem";
            this.図書管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.図書管理ToolStripMenuItem.Text = "図書管理";
            this.図書管理ToolStripMenuItem.Click += new System.EventHandler(this.図書管理ToolStripMenuItem_Click);
            // 
            // 助けるToolStripMenuItem
            // 
            this.助けるToolStripMenuItem.Name = "助けるToolStripMenuItem";
            this.助けるToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.助けるToolStripMenuItem.Text = "助ける";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(183, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "歓迎な図書歓迎システムを来る";
            // 
            // admin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin1";
            this.Text = "管理者ホームページ";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem システムToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 図書管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 助けるToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}