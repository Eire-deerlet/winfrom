using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMs
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();

            label1.Text = $"歓迎{Data.UName}ログイン";
        }

        private void 図書検索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           user1 user = new user1();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void 自分の本を借りToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user2 user = new user2();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void 助けるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("help");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
