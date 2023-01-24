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
    public partial class user2 : Form
    {
        public user2()
        {
            InitializeComponent();
            table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void table()
        {
            dataGridView1.Rows.Clear();//旧データを削除
            Dao dao = new Dao();
            string sql = $"SELECT * FROM b_lend";
            IDataReader reader = dao.read(sql);
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(),
                    reader[2].ToString(), reader[4].ToString(), reader[3].ToString());

            }
            reader.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lendId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//借り本のｉｄ
            string bookId = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//図書番号
            string sql = $"delete from b_lend where lend_id={lendId} ;update b_book set stock=stock+1 where id ={bookId}";
            MessageBox.Show(sql);
            Dao dao = new Dao();
           
            if (dao.Execute(sql)>1)
            {
                MessageBox.Show("本を返す　成功します");
                table();
            }
            else
            {
                MessageBox.Show("選択するを違います");
            }


        }
    }
}
