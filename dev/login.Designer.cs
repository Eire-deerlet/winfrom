
namespace BookMs
{
    partial class login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labeUser = new System.Windows.Forms.Label();
            this.labelPsw = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPsw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(243, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "books管理系統";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeUser
            // 
            this.labeUser.AllowDrop = true;
            this.labeUser.AutoSize = true;
            this.labeUser.Location = new System.Drawing.Point(187, 174);
            this.labeUser.Name = "labeUser";
            this.labeUser.Size = new System.Drawing.Size(73, 15);
            this.labeUser.TabIndex = 1;
            this.labeUser.Text = "ユーザー　：";
            this.labeUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPsw
            // 
            this.labelPsw.AllowDrop = true;
            this.labelPsw.AutoSize = true;
            this.labelPsw.Location = new System.Drawing.Point(180, 220);
            this.labelPsw.Name = "labelPsw";
            this.labelPsw.Size = new System.Drawing.Size(82, 15);
            this.labelPsw.TabIndex = 2;
            this.labelPsw.Text = "パスワード　：";
            this.labelPsw.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.AllowDrop = true;
            this.textBoxUser.Location = new System.Drawing.Point(271, 170);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(257, 22);
            this.textBoxUser.TabIndex = 3;
            // 
            // textBoxPsw
            // 
            this.textBoxPsw.AllowDrop = true;
            this.textBoxPsw.Location = new System.Drawing.Point(271, 211);
            this.textBoxPsw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPsw.Name = "textBoxPsw";
            this.textBoxPsw.Size = new System.Drawing.Size(257, 22);
            this.textBoxPsw.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(199, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.Location = new System.Drawing.Point(409, 306);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "消除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AllowDrop = true;
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Checked = true;
            this.radioButtonUser.Location = new System.Drawing.Point(199, 258);
            this.radioButtonUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(76, 19);
            this.radioButtonUser.TabIndex = 7;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "ユーザー";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            this.radioButtonUser.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AllowDrop = true;
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(405, 258);
            this.radioButtonAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(73, 19);
            this.radioButtonAdmin.TabIndex = 8;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "管理者";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPsw);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPsw);
            this.Controls.Add(this.labeUser);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.Text = "ログイン";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeUser;
        private System.Windows.Forms.Label labelPsw;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPsw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
    }
}

