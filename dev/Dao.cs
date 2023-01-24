
using System.Data.SqlClient;

namespace BookMs
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = "Data Source = YANGTZE; Initial Catalog = BookDB; Integrated Security = True"; //データ連絡


            sc =  new SqlConnection(str);　//データ　連絡対象
            sc.Open();      //open　データ
            return sc;      //返しデータを連絡対象
        }

        public SqlCommand command(string sql)
        {
            SqlCommand cmd=  new SqlCommand(sql, connect());

            return cmd;
        }

        public int Execute(string sql)　
        {
            return command(sql).ExecuteNonQuery();　//updateをsql
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();//　readをsql
      }

        public void DaoClose()
        {
            sc.Close();　//連絡解開
        }
    }
}
