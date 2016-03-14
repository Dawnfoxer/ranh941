using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//游戏记录窗口
namespace twefourpoint
{
    public partial class viewRecord : Form
    {
        public viewRecord()
        {
            InitializeComponent();
        }

        private void viewRecord_Load(object sender, EventArgs e)
        {
            readGame();
        }

        //读取游戏记录
        private void readGame()
        {
            //#为每条记录的分隔符
            //|为每条记录的字段的分隔符
            //关闭资源！！！否则文件被占用，无法删除和读取
            if (File.Exists(@"record.txt"))
            {
                string allKeyWord = File.ReadAllText(@"record.txt");
                string[] info = allKeyWord.Split('#').Where(s => !string.IsNullOrEmpty(s)).ToArray();

                int infoNum = info.Length;
                string[] infoDetail;
                int infoDetailNum;
                int index = 0;
                for (int i = 0; i < infoNum; i++)
                {
                    index = dataGridView1.Rows.Add();//添加新行
                    dataGridView1.Rows[index].HeaderCell.Value = i.ToString();
                    infoDetail = info[i].Split('|');
                    infoDetailNum = infoDetail.Length;
                    for (int j = 0; j < infoDetailNum; j++)
                    {
                        dataGridView1.Rows[index].Cells[j].Value = infoDetail[j];
                    }
                }
            }
            else
            {
                File.Create(@"record.txt").Close();
            }

        }

        //清空记录的游戏信息
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr;
            dr = MessageBox.Show("          确定清零？", "提示信息", messButton);
            if (dr == DialogResult.OK)
            {
                if (File.Exists(@"record.txt"))
                {
                    File.Delete(@"record.txt");

                } else
                {
                    File.Create(@"record.txt").Close();
                }

                dataGridView1.Rows.Clear();//清空表格显示的所有元素
                button1.Enabled = false;
            } else {

            }


        }

        //关闭弹出框
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
