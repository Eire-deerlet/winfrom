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
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
            table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//図書番号を取ります
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//図書番号を取ります
            int number = int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString());

            if (number <0)
            {
                MessageBox.Show("在庫が足りない、管理者を連絡してください");
            }
            else
            {
                string sql = $"insert into b_lend (user_id,book_id,date_time,book_name) values ('{Data.UID}','{id}',GETDATE(),'{name}');" +
                    $"update b_book set stock = stock-1 where id='{id}'";

               // MessageBox.Show(sql);
                Dao dao = new Dao();
               if(dao.Execute(sql) > 1)
                {
                    MessageBox.Show($"ユーザー{Data.UName}本{id}を借ります、成功");
                    table();
                }
                    
            }
        }

        public void table()
        {
            dataGridView1.Rows.Clear();//旧データを削除
            Dao dao = new Dao();
            string sql = $"SELECT * FROM b_book";
            IDataReader reader = dao.read(sql);
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(),
                    reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());

            }
            reader.Close();
            dao.DaoClose();
        }
    }
}
