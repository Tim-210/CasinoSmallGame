using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casinoSmallGame.Forms
{
    public partial class LottoForm : Form
    {
        public LottoForm()
        {
            InitializeComponent();
        }
        Random random = new Random();
        public int[] guessnum = new int[6];
        public int[] luckynum = new int[6];
        int gnum1 = 0, gnum2 = 0, gnum3 = 0, gnum4 = 0, gnum5 = 0, gnum6 = 0, gspnum = 0;
        int spnum = 0, check = 0, count = 0;
        bool checkdone = false;
        int[] arrayAll = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 };
        int[] arrayDelete = new int[11];



        private void LottoForm_Load(object sender, EventArgs e)
        {

        }

        private void _btnClean_Click(object sender, EventArgs e)
        {
            clean();
            _txtnum1.Text = string.Empty;
            _txtnum2.Text = string.Empty;
            _txtnum3.Text = string.Empty;
            _txtnum4.Text = string.Empty;
            _txtnum5.Text = string.Empty;
            _txtnum6.Text = string.Empty;
            _txtspnum.Text = string.Empty;

        }
        private void _btnOpen_Click(object sender, EventArgs e)
        {
            clean();
            checkformat();//start from null
            if (checkdone)
            {
                guessnum[0] = gnum1;
                guessnum[1] = gnum2;
                guessnum[2] = gnum3;
                guessnum[3] = gnum4;
                guessnum[4] = gnum5;
                guessnum[5] = gnum6;
                if (_rdbNormal.Checked == true)
                {
                    lottoNormal();
                }
                else if (_rdbHighRate.Checked == true)
                {
                    lottoHighRate();
                }

                verify();
                show();
            }
        }
        private void lottoNormal()
        {
            int a = 0, b = 0;
            for (int i = 0; i < luckynum.GetLength(0); i++)
            {
                do
                {
                    a = random.Next(0, 50);
                    check = Array.IndexOf(luckynum, a);
                } while (check != -1);
                luckynum[i] = a;
            }
            do
            {
                b = random.Next(0, 50);
                check = Array.IndexOf(luckynum, b);
            } while (check != -1);
            spnum = b;
        }
        private void lottoHighRate()
        {
           
            int a = 0;

            for (int i = 0; i < 11; i++)      //保留玩家猜的7個數字，並隨機找出10個數字等待刪除
            {
                do
                {
                    a = random.Next(0, 50);
                    check = Array.IndexOf(guessnum, a);
                    if (check==-1)
                    {
                        check = Array.IndexOf(arrayDelete, a);
                        if (check==-1)
                        {
                            if (a == gspnum)
                            {
                                check = 1;
                            }
                        }
                    }
                } while (check != -1);
                arrayDelete[i] = a;
            }
            for (int i = 0; i < 11; i++)
            {
                check = 0;
                check = Array.IndexOf(arrayAll, arrayDelete[i]);
                Array.Clear(arrayAll, check, 1);
            }
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    a = random.Next(0, arrayAll.Length);
                    check = Array.IndexOf(luckynum, arrayAll[a]);
                } while (check != -1);
                luckynum[i] = arrayAll[a];
            }
            do
            {
                a = random.Next(0, arrayAll.Length);
                check = Array.IndexOf(luckynum, arrayAll[a]);
            } while (check != -1);
            spnum = a;
        }
        private void verify()
        {
            for (int i = 0; i < 6; i++)
            {
                check = Array.IndexOf(luckynum, guessnum[i]);
                if (check != -1)
                    count += 1;
            }
        }
        private void show()
        {
            foreach (var item in luckynum)
            {
                _lblOpenOrderShow.Text += " " + item;
            }
            Array.Sort(luckynum);
            foreach (var item in luckynum)
            {
                _lblOpenSortShow.Text += " " + item;
            }
            _lblSpnumShoe.Text += spnum;
            Array.Sort(guessnum);
            foreach (var item in guessnum)
            {
                _lblGnumShow.Text += " " + item;
            }
            _lblGspnumShow.Text += gspnum;
            if (count == 6)
            {
                _lblResult.Text += "恭喜你中頭獎了!";
            }
            else if (count == 5 && gspnum == spnum)
            {
                _lblResult.Text += "恭喜你中貳獎了!";
            }
            else if (count == 5)
            {
                _lblResult.Text += "恭喜你中參獎了!";
            }
            else if (count == 4 && gspnum == spnum)
            {
                _lblResult.Text += "恭喜你中肆獎了!";
            }
            else if (count == 4)
            {
                _lblResult.Text += "恭喜你中伍獎了!";
            }
            else if (count == 3 && gspnum == spnum)
            {
                _lblResult.Text += "恭喜你中陸獎了!";
            }
            else if (count == 2 && gspnum == spnum)
            {
                _lblResult.Text += "恭喜你中柒獎了!";
            }
            else if (count == 3)
            {
                _lblResult.Text += "恭喜你中普獎了!";
            }
            else
            {
                _lblResult.Text += "再接再厲!";
            }
        }
        private void checkformat()
        {
            if (string.IsNullOrWhiteSpace(_txtnum1.Text) ||
                string.IsNullOrWhiteSpace(_txtnum2.Text) ||
                string.IsNullOrWhiteSpace(_txtnum3.Text) ||
                string.IsNullOrWhiteSpace(_txtnum4.Text) ||
                string.IsNullOrWhiteSpace(_txtnum5.Text) ||
                string.IsNullOrWhiteSpace(_txtnum6.Text) ||
                string.IsNullOrWhiteSpace(_lblSpnum1.Text))  //find and modify
            {
                DialogResult result = MessageBox.Show("空格內不得為空白!!", "大樂透世界溫馨提醒您",
                    MessageBoxButtons.OK);
            }
            else
            {
                checkint();
            }
        }
        private void checkint()
        {
            if (!int.TryParse(_txtnum1.Text, out gnum1) ||
                !int.TryParse(_txtnum2.Text, out gnum2) ||
                !int.TryParse(_txtnum3.Text, out gnum3) ||
                !int.TryParse(_txtnum4.Text, out gnum4) ||
                !int.TryParse(_txtnum5.Text, out gnum5) ||
                !int.TryParse(_txtnum6.Text, out gnum6) ||
                !int.TryParse(_txtspnum.Text, out gspnum))//find and modify
            {
                DialogResult result = MessageBox.Show("有格式打錯囉!!", "大樂透世界溫馨提醒您",
                    MessageBoxButtons.OK);
            }
            else
            {
                checkrange();
            }
        }
        private void checkrange()
        {
            if (gnum1 < 1 || gnum1 > 49 ||
                gnum2 < 1 || gnum2 > 49 ||
                gnum3 < 1 || gnum3 > 49 ||
                gnum4 < 1 || gnum4 > 49 ||
                gnum5 < 1 || gnum5 > 49 ||
                gnum6 < 1 || gnum6 > 49 ||
                gspnum < 1 || gspnum > 49)
            {
                DialogResult result = MessageBox.Show("數字範圍要在1-49內喔!!", "大樂透世界溫馨提醒您",
                    MessageBoxButtons.OK);
            }
            else
            {
                checkrepeat();
            }
        }
        private void checkrepeat()
        {
            if (gnum1 == gnum2 || gnum1 == gnum3 || gnum1 == gnum4 ||
                              gnum1 == gnum5 || gnum1 == gnum6 || gnum1 == gspnum ||
                gnum2 == gnum3 || gnum2 == gnum4 || gnum2 == gnum5 || gnum2 == gnum6 || gnum2 == gspnum ||
                gnum3 == gnum4 || gnum3 == gnum5 || gnum3 == gnum6 || gnum3 == gspnum ||
                gnum4 == gnum5 || gnum4 == gnum6 || gnum4 == gspnum ||
                gnum5 == gnum6 || gnum5 == gspnum ||
                gnum6 == gspnum)//find and modify!!
            {
                DialogResult result = MessageBox.Show("有數字重複囉!!", "大樂透世界溫馨提醒您",
                   MessageBoxButtons.OK);
            }
            else
            {
                checkRdb();
            }
        }
        private void checkRdb()
        {
            if (_rdbNormal.Checked == false && _rdbHighRate.Checked == false)
            {
                DialogResult result = MessageBox.Show("遊戲玩法為選擇喔!!", "大樂透世界溫醒您!", MessageBoxButtons.OK);
            }
            else
            {
                checkdone = true;

            }
        }

        private void clean()
        {
            checkdone = false;
            Array.Clear(luckynum, 0, luckynum.Length);
            Array.Clear(guessnum, 0, guessnum.Length);
            Array.Clear(arrayDelete, 0, arrayDelete.Length);
            int[] arrayAll = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 };
            spnum = 0;
            gspnum = 0;
            check = 0;
            _lblOpenOrderShow.Text = string.Empty;
            _lblOpenSortShow.Text = string.Empty;
            _lblSpnumShoe.Text = string.Empty;
            _lblGnumShow.Text = string.Empty;
            _lblGspnumShow.Text = string.Empty;
            _lblResult.Text = string.Empty;
        }
        private void _klblExplain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.taiwanlottery.com.tw/lotto649/index.asp");
        }
    }
}


