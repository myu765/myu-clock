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
            timer1.Interval = 500; // 0.5秒に1回Tickメソッド実行
            timer1.Enabled = true; // タイマースタート
            // クライアント領域を、320 x 200 に固定する
            Size size = new Size(320, 200);
            ClientSize = size;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now; // 現在時刻を取得
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
            label1.Text = d.ToString("tt", ci) // AM PMを表示
                        + string.Format(" {0:00}:{1:00}:{2:00}", d.Hour, d.Minute, d.Second); // 0埋め2桁で表示
            label1.Visible = true; // 時計を表示
        }
    }
}
