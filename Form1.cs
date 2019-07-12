using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace tasklogmemorizer
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            
            InitializeComponent();
            RegistHotKeys();
            //PresetCombos();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.InsertTaskRecord(1, cmbTask1.SelectedIndex, txtTaskMemo1.Text);

            
            //DateTime nowDateTime = DateTime.Now;
            //MemorizeTaskLog(nowDateTime);
            //notifyIcon1.BalloonTipTitle = "TaskLogMemorizer";
            //notifyIcon1.BalloonTipText = "タスク1を記録しました。";
            //notifyIcon1.ShowBalloonTip(3000);
        }

        public void MemorizeTaskLog(DateTime loggedTime)
        {
            //http://okwakatta.net/code/ado06.html
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();


            conn.ConnectionString = @"Data Source=m-yoshinari-PC\SQLEXPRESS;Initial Catalog=tasklogmemorizer;User Id=tasklogmemorizer_user;Password=kam440nami;";
            conn.Open();

            SqlTransaction transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            string sql = "insert TaskRecord values ('m-yoshinari','" + loggedTime.ToString("yyyy-MM-dd HH:mm:ss") + "',1,1,1,'test')";

            try
            {
                command.CommandText = sql;
                command.Connection = conn;
                command.Transaction = transaction;
                command.ExecuteNonQuery();

                //トランザクションをコミットします。
                transaction.Commit();
            }
            catch (System.Exception)
            {
                //トランザクションをロールバックします。
                transaction.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //各コンボボックスの設定
            setComboBox();

        }

        private void setComboBox()
        {
            //各コンボボックス設定
            //マスターから設定値を取得して設定
           





        }

        private void btnHideForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            //SqlConnection conn = new SqlConnection();
            //SqlCommand command = new SqlCommand();
            //DataTable dt = new DataTable();

            //string id = string.Empty;
            //string name = string.Empty;

            //conn.ConnectionString = @"Data Source=DESKTOP-0NSBKH3\SQLEXPRESS;Initial Catalog=tasklogmemorizer;User Id=tasklogmemorizer_user;Password=kam440nami;";
            //conn.Open();

            //command.CommandText = "SELECT * FROM TaskRecord";
            //command.Connection = conn;
            //SqlDataReader reader = command.ExecuteReader();

            //// 結果を表示します。
            //while (reader.Read())
            //{
            //    id = (string)reader.GetValue(0);
            //    name = (string)reader.GetValue(3);

            //    MessageBox.Show("ID:" + id + " 名称:" + name);

            //}

            //// 接続を解除します。
            //conn.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // アイコン非表示
            notifyIcon1.Visible = false;
            // アプリケーション終了
            //UnRegistHotKeys();
            Application.Exit();
        }

        private void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Set1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime nowDateTime = DateTime.Now;
            MemorizeTaskLog(nowDateTime);
        }
        private void RegistHotKeys()
        {
            const int MOD_ALT = 0x0001;
            const int MOD_CONTROL = 0x0002;
            const int MOD_SHIFT = 0x0004;
            const int MOD_WIN = 0x0008;
            const int HOTKEY_ID = 0x0001;
            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL | MOD_ALT, (int)Keys.D1);
            //RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL | MOD_ALT, (int)Keys.D2);
            //RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL | MOD_ALT, (int)Keys.D3);
            //RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL | MOD_ALT, (int)Keys.D4);
            //RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL | MOD_ALT, (int)Keys.D5);
            //RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL | MOD_ALT, (int)Keys.D6);
        }
        private void UnRegistHotKeys()
        {
            const int HOTKEY_ID = 0x0001;
            UnregisterHotKey(Handle, HOTKEY_ID);
        }
        protected override void WndProc(ref Message m)
        {
            const int MOD_ALT = 0x0001;
            const int MOD_CONTROL = 0x0002;
            const int MOD_SHIFT = 0x0004;
            const int MOD_WIN = 0x0008;
            const int WM_HOTKEY = 0x0312;
            const int HOTKEY_ID = 0x0001;
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                if (((int)m.WParam) == HOTKEY_ID)
                {
                    DateTime nowDateTime = DateTime.Now;
                    MemorizeTaskLog(nowDateTime);
                    notifyIcon1.BalloonTipTitle = "TaskLogMemorizer";
                    notifyIcon1.BalloonTipText = "タスク1を記録しました。";
                    notifyIcon1.ShowBalloonTip(3000);

                }
            }
        }

        [DllImport("user32.dll")]
        extern static int RegisterHotKey(IntPtr HWnd, int ID, int MOD_KEY, int KEY);

        [DllImport("user32.dll")]
        extern static int UnregisterHotKey(IntPtr HWnd, int ID);

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // アイコン非表示
            notifyIcon1.Visible = false;
            // アプリケーション終了
            //UnRegistHotKeys();
            Application.Exit();
        }
    }
}
