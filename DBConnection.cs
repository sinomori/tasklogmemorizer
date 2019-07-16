using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //データベース接続関係

namespace tasklogmemorizer
{
    class DBConnection
    {
        //データベース接続のための情報を入れましょう
        private const string DATABASE_SERVER = "m-yoshinari-PC\\SQLEXPRESS";
        private const string DATABASE_NAME = "tasklogmemorizer";
        private const string DATABASE_USER = "tasklogmemorizer_user";
        private const string DATABASE_PASSWORD = "kam440nami";

        private SqlConnection sqlCon;
        private SqlTransaction sqlTran;

        private void Open()
        {
            // 接続文字列を生成する
            string connectString =
            "Data Source = " + DATABASE_SERVER
            + ";Initial Catalog = " + DATABASE_NAME
            + ";User ID = " + DATABASE_USER
            + ";Password = " + DATABASE_PASSWORD;

            // SqlConnection の新しいインスタンスを生成する (接続文字列を指定)
            this.sqlCon = new System.Data.SqlClient.SqlConnection(connectString);

            // データベース接続を開く
            this.sqlCon.Open();


            //トランザクションの開始
            this.sqlTran = this.sqlCon.BeginTransaction();
        }

        public Boolean ExecuteSQL(string SQL)
        {
            this.Open();
            SqlCommand command = new SqlCommand()
             = SQL


            return true;
        }

        private void Close()
        {
            if (this.sqlTran.Connection != null)
            {
                // データベース接続を閉じる 
                this.sqlTran.Commit();
                this.sqlCon.Close();
                this.sqlCon.Dispose();
            }
        }
    }
}
