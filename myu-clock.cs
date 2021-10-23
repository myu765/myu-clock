using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // フォームがメモリ上に読み込まれた時の処理
            timer1.Interval = 250; // 0.25秒に1回Tickメソッド実行
            timer1.Enabled = true; // タイマースタート
            
            // クライアント領域を変更する
            //Size size = new Size(320, 180);
            Size size = new Size(384, 108);
            ClientSize = size;

            // 時刻の位置を調整する
            int posLabel1_X = (ClientSize.Width - label1.Width) / 2;
            int posLabel1_Y = ((ClientSize.Height - label1.Height) / 2) + (label2.Height / 2) + 4;
            label1.Location = new Point(posLabel1_X, posLabel1_Y);

            // 日付の位置を調整する
            int posLabel2_X = (ClientSize.Width - label2.Width) / 2;
            int posLabel2_Y = ((ClientSize.Height - label1.Height) / 2) - (label2.Height / 2) - 4;
            label2.Location = new Point(posLabel2_X, posLabel2_Y);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now; // 現在時刻を取得
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
            label1.Text = d.ToString("tt", ci) // AM PMを表示
                        + string.Format(" {0:00}:{1:00}:{2:00}", d.Hour, d.Minute, d.Second); // 0埋め2桁で表示
            label1.Visible = true; // 時計を表示
            label2.Text = d.ToString("yyyy/MM/dd(ddd)"); // 2021/01/02(月) の形式で表示する
            label2.Visible = true; // 年月日を表示
        }
    }
}
