using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using casinoSmallGame.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace casinoSmallGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LottoForm lotto = new LottoForm();
            lotto.ShowDialog();
            Application.Exit();
        }



        public static DataTable GetOleDbDataTable(string Database, string OleDbString)
        {
            DataTable myDataTable = new DataTable();
            OleDbConnection icn = OleDbOpenConn(Database);
            OleDbDataAdapter da = new OleDbDataAdapter(OleDbString, icn);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            myDataTable = ds.Tables[0];
            if (icn.State == ConnectionState.Open) icn.Close();
            return myDataTable;
        }

        public static OleDbConnection OleDbOpenConn(string Database)
        {
            //connstr = "Provider=Microsoft.Jet.OLEDB.4.0 ;Data Source=" + Server.MapPath(".") + "\\App_Data\\DataBase1.mdb";
            string cnstr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\App_Data\\" + Database);
            OleDbConnection icn = new OleDbConnection();
            icn.ConnectionString = cnstr;
            if (icn.State == ConnectionState.Open) icn.Close();
            icn.Open();
            return icn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            string txtAcc = _txtAccount.Text.Trim();
            string txtPwd = _txtPassword.Text.Trim();

            //TODO 登入防呆


            string s = "Data Source =192.168.56.1\\SQLExpress; Initial Catalog = LOTTERY; Integrated Security = False; uid = sa; password = Timchangsql109; ";

            SqlConnection cn = new SqlConnection(s);

            cn.Open();//總開關

            SqlTransaction t= cn.BeginTransaction(); //BeginTransaction為SqlTransaction方法
            SqlCommand cmd = new SqlCommand("select * from TB_ACCOUNT where [ACCOUNT] = @acc and [PASSWORD] = @pwd ", cn);
            //告知是哪個指令及哪個連線
            cmd.Parameters.Add("@acc", txtAcc);
            cmd.Parameters.Add("@pwd", txtPwd);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                LottoForm l_LottoForm = new LottoForm();
                l_LottoForm.Show();
            }
            else
            {
                string ss = "123";
            }


            cn.Close();

            cn.Dispose();
        }
    }
}

