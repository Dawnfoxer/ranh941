using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//游戏玩法说明
namespace twefourpoint
{
    public partial class howPlay : Form
    {
        public howPlay()
        {
            InitializeComponent();
        }

        private void howPlay_Load(object sender, EventArgs e)
        {
            label1.Text = @"(1) 基础元素:2~10,A=1,J=11,Q=12,K=13;
(2) 在四个元素之间添加四则运算(+、-、*、/)以及小括号构成表达式,使得结果为24即成功;
(3) 每次游戏时间为60s,超时就停止当前游戏;
(4) 只能是正整数运算!负数和小数均无效！";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
