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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBoxUser.Text !="" && textBoxPsw.Text != "")
            {
                Login();


             

            }
            else
            {

                MessageBox.Show("入力のデータ違います、もう一度入力");
            }
        }

        //Login
        public void Login()
        {
            if (radioButtonUser.Checked == true)
            {
                Dao dao = new Dao();
                 string sql = $"SELECT * FROM b_user WHERE id='{textBoxUser.Text}' AND psw='{textBoxPsw.Text}' ";
               
                MessageBox.Show(sql);
                IDataReader dc =dao.read(sql);
            //    MessageBox.Show(dc[0].ToString()+ dc["name"].ToString());

                if (dc.Read())
                {
                    //ログインの時　ユーザーのｉｄと名前を蓄える
                    Data.UID = dc["id"].ToString();
                    Data.UName = dc["name"].ToString();

                    MessageBox.Show("login 成功");

                    user user = new user();
                    this.Hide(); //隠す旧ウインドウ
                    user.ShowDialog();//新しいウインドウをポップアップ
                    this.Show(); //旧ウインドウを表す


                }
                else
                {
                    MessageBox.Show("login 失敗");

                    
                }

                dao.DaoClose();

            }

            if (radioButtonAdmin.Checked==true)
            {
                Dao dao = new Dao();
                 string sql = $"SELECT * FROM b_admin WHERE name='{textBoxUser.Text}' AND psw='{textBoxPsw.Text}' ";
               
                IDataReader dc = dao.read(sql);

                if (dc.Read())
                {
                    MessageBox.Show("manage login 成功");

                    admin1 user = new admin1();
                    this.Hide(); //隠す旧ウインドウ
                    user.ShowDialog();//新しいウインドウをポップアップ
                    this.Show(); //旧ウインドウを表す

                }
                else
                {
                    MessageBox.Show("manage login 失敗");

                }
                dao.DaoClose();
            }

           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
