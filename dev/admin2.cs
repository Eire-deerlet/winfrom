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
    public partial class admin2 : Form
    {
        public admin2()
        {
            InitializeComponent();
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableID();
        }

        //図書番号詮索
        public void tableID()
        {
            dataGridView1.Rows.Clear();//旧データを削除
            Dao dao = new Dao();
            string sql = $"SELECT * FROM b_book where id={textBox1.Text}";
            IDataReader reader = dao.read(sql);
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(),
                    reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());

            }
            reader.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin21 admin = new admin21();
            admin.ShowDialog();

            table();//データを刷新する

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//図書番号を取ります
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//図書名を取ります
            string author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//作者を取ります
            string press = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();//出版社を取ります
            string number = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();//在庫を取ります
            admin22 admin = new admin22(id,name,author,press,number);
            admin.ShowDialog();

            table();//データを刷新する

        }

        private void button4_Click(object sender, EventArgs e)
        {
            table();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//図書番号を取ります
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//図書名を取ります

            label2.Text = id;
            label3.Text = name;
            DialogResult dr = MessageBox.Show("確認削除しますか", "情報のヒント", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                string sql = $"DELETE FROM b_book WHERE id='{id}'";
                Dao dao = new Dao();
               int n = dao.Execute(sql);
                if (n>0)
                {
                    MessageBox.Show("削除成功");
                    table();
                }
                else
                {
                    MessageBox.Show("削除失敗します");
                }

                dao.DaoClose();
            }
            }
            catch
            {
                MessageBox.Show("まだ、削除する図書のレコードをテーブルで選択してください。", "情報のヒント", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableName();
        }

        //図書名詮索
        public void tableName()
        {
            dataGridView1.Rows.Clear();//旧データを削除
            Dao dao = new Dao();
            string sql = $"SELECT * FROM b_book where name like '%{textBox2.Text}%'";
            IDataReader reader = dao.read(sql);
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(),
                    reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());

            }
            reader.Close();
            dao.DaoClose();
        }

        private void admin2_Load(object sender, EventArgs e)
        {
            table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//図書番号を取ります
            label3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//図書名を取ります
        }
        //データを表すに表中
        public void table()
        {
            dataGridView1.Rows.Clear();//旧データを削除
            Dao dao = new Dao();
            string sql = $"SELECT * FROM b_book";
           IDataReader reader= dao.read(sql);
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(),
                    reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());

            }
            reader.Close();
            dao.DaoClose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//図書番号を取ります
            label3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//図書名を取ります

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count; //選びの行数を得る
            string sql = $"delete from b_book where id in(";

            for (int i =0; i< count; i++)
            {
                sql += $"'{dataGridView1.SelectedRows[i].Cells[0].Value.ToString()}',";
            }
            sql = sql.Remove(sql.Length - 1);
            sql += ")";
            MessageBox.Show(sql);

            Dao dao = new Dao();
            int n = dao.Execute(sql);
            MessageBox.Show(n.ToString());

            if (n > n - 1)
            {
                MessageBox.Show($"成功に{n}行のデータを削除する");
                table();
            }
            
        }
    }
}
