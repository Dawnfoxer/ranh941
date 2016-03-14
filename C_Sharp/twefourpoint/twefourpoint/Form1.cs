using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HR;
using System.IO;

//游戏主窗口
namespace twefourpoint
{
    public partial class Form1 : Form
    {
        string[] eleArr;//存操作数
        System.DateTime startTime, crrutTime;//记录每次游戏开始和结束时间
        System.TimeSpan time;//时间间隔
        string timeShow;//显示计时
        int runtime;//记录秒数
        string realTime;//实际答题时长

        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            makeEle();
            textBox2.Enabled = false;
            button3.Enabled = false;//禁止输入
            timer1.Enabled = false;//必须放在元素产生后 暂停计时器 否则计时器状态为true,点击开始按钮，计时出错

        }

        private void Verify(object sender, EventArgs e)
        {
            string expInp = textBox2.Text.ToString();

            if (expInp.Count() != 0)
            {
                //在计时期间方能答题
                if (timer1.Enabled || !zantingToolStripMenuItem.Enabled)
                {
      
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult dr;

                    if (LibHr.isRight(expInp,eleArr))
                    {
                        timer1.Enabled = false;
                        stopwatch.Stop();
                        //记录成绩
                        realTime = timeShow.Split(':')[2];
                        recordGame(true);
                        dr = MessageBox.Show("          正确! 用时" + realTime + "s! "+"返回(确定),新游戏(取消)?", "提示信息", messButton);

                        if (button3.Enabled)
                        {
                            if (dr == DialogResult.OK)
                            {
                                disPlay();
                                label7.Focus();//设置焦点
                                textBox2.Enabled = false;
                                button3.Enabled = false;//获取答案后则无法输入
                                zantingToolStripMenuItem.Enabled = false;

                            }
                            else {
                                Refesh(sender, e);
                            }
                        }
                    }
                    else
                    {
                        stopwatch.Stop();
                        //在规定的时间内
                        //计时器暂停
                        if (timer1.Enabled || !zantingToolStripMenuItem.Enabled)
                        {
                            //记录成绩
                            realTime = timeShow.Split(':')[2];
                            recordGame(false);
                            if (zantingToolStripMenuItem.Enabled)
                            {
                                dr = MessageBox.Show("          错误!继续答题(确定),新游戏(取消)?", "提示信息", messButton);
                            }
                            else
                            {
                                dr = MessageBox.Show("          错误!返回查看系统正确答案(确定),新游戏(取消)?", "提示信息", messButton);

                            }
                            if (button3.Enabled)
                            {
                                if (dr == DialogResult.OK)
                                {
                                    if (zantingToolStripMenuItem.Enabled)
                                    {
                                        timer1.Enabled = true;
                                        stopwatch.Start();
                                    }
                                    else
                                    {
                                        disPlay();
                                        label7.Focus();//设置焦点
                                        textBox2.Enabled = false;
                                        button3.Enabled = false;//获取答案后则无法输入
                                    }


                                }
                                else {
                                    Refesh(sender, e);
                                }
                            }
                        }

                    }
                }
            }

        }

        private void Refesh(object sender, EventArgs e)
        {
            stopwatch.Reset();
            makeEle();
            button1.Enabled = true;
            textBox2.Enabled = true;
            button3.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            label6.Text = "";
            label7.Visible = true;
            kaishiToolStripMenuItem.Enabled = false;
            zantingToolStripMenuItem.Enabled = true;


        }

        private void find(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                button1.Enabled = false;
                textBox2.Enabled = false;
                button3.Enabled = false;//获取答案后则无法输入
                timer1.Enabled = false;
                kaishiToolStripMenuItem.Enabled = false;
                zantingToolStripMenuItem.Enabled = false;
                stopwatch.Stop();
                disPlay();
            }

        }

        //四个元素的生成
        private void makeEle()
        {
            eleArr = LibHr.randElem();
            label1.Text = eleArr[0];
            label2.Text = eleArr[1];
            label3.Text = eleArr[2];
            label4.Text = eleArr[3];

            startTime = System.DateTime.Now;
            timer1.Enabled = true;
            stopwatch.Start(); ;

        }

        //找到正确表达式
        private void disPlay()
        {
            if (button1.Enabled)
            {
                button1.Enabled = false;
            }
            //string rightexp = LibHr.rightExp(eleArr[0], eleArr[1], eleArr[2], eleArr[3]);
            string rightexp = LibHr.beginTestRightExp(eleArr);
            if (rightexp.Length != 0)
            {
                textBox1.Text = rightexp;
            }
            else {
                textBox1.Text = "不存在"; 
            }
        }

        //记录答题时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            crrutTime = System.DateTime.Now;
            time = crrutTime - startTime;
            timeShow = time.ToString().Split('.')[0];
            stopwatch.Stop();//计算的是停止到开始的时间！！！！！！
            runtime = int.Parse(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Start();
            label7.Text = timeShow.ToString();//必须放在if判断前 message是同步状态 否则最后一个时间显示必须在点击对话框后才出现
            if (60000 - 50 <= runtime && runtime <= 60000 + 999 )
            {
                timer1.Enabled = false; 
                stopwatch.Stop();
                textBox2.Enabled = false;
                button3.Enabled = false;//获取答案后则无法输入
                //记录成绩
                realTime = timeShow.Split(':')[2];
                recordGame(true,true);
                MessageBox.Show("          " + "时间到！");
                
            }          

        }

        //开始当前游戏计时
        private void startGame(object sender, EventArgs e)
        {
            //if判断必须在前面 如果放在后面 在计时器为true时重置，计时错误
            if (!timer1.Enabled)
            {
                textBox2.Enabled = true;
                button3.Enabled = true;//激活输入
                textBox2.Text = "";
                startTime = System.DateTime.Now;
                stopwatch.Reset();
                stopwatch.Start();//在窗口化实例时已经在测量时间，将已经测量的运行时间置0

            }
            timer1.Enabled = true;
            label7.Visible = true;
            kaishiToolStripMenuItem.Enabled = false;
            zantingToolStripMenuItem.Enabled = true;


        }
        
        //停止当前游戏
        private void stopGame(object sender, EventArgs e)
        {
            //if判断必须放在计时器状态之前 
            if (timer1.Enabled)
            {
                zantingToolStripMenuItem.Enabled = false;//暂停时能检验输入的表达式
            }

            timer1.Enabled = false;
            stopwatch.Stop();
        }

        //查看记录
        private void viewRecord(object sender, EventArgs e)
        {
           viewRecord login = new viewRecord();
            login.Owner = this;
            //模式窗体 锁定主窗口
            if (login.ShowDialog() == DialogResult.OK)
            {

            }
            login.Dispose();
        }

        //版权说明
        private void version(object sender, EventArgs e)
        {
            MessageBox.Show("真好玩！哈哈~~~ by hr","版权");
        }

        //玩法说明
        private void paly(object sender, EventArgs e)
        {
            howPlay login = new howPlay();
            login.Owner = this;
            //模式窗体 锁定主窗口
            if (login.ShowDialog() == DialogResult.OK)
            {

            }
            login.Dispose();
        }

        //记录成绩
        //# 作为每次记录的标记
        //| 作为记录的每个字段的标记
        private void recordGame(bool res,bool timeOut = false)
        {
            string strKey;
            if (!timeOut)
            {
                strKey = startTime.ToString() + '|' + crrutTime.ToString() + '|' + realTime + '|' + (res ? "正确" : "错误") + "#";

            }else{
                strKey = startTime.ToString() + '|' + crrutTime.ToString() + '|' + realTime + '|' + "超时" + "#";
            }
            File.AppendAllText(@"record.txt", strKey);
        }
    }
}
