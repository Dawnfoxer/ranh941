using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//author： hr
//time:15/12/27
//version：1.3
namespace HR
{
    class LibHr
    {
        private static string[] ovsArr = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };//基本元素
        private static string[] opsArr = new string[] { "+", "-", "*", "/", "(", ")" };//运算符号和括号
        private static int[] kh1ps = new int[] { 0, 10, 0, 16, 6, 16, 6, 22, 12, 22 };//一对括号的位置
        private static int[] kh2ps = new int[] { 0, 10, 12, 22, 0, 16, 1, 9, 0, 16, 7, 15, 6, 22, 7, 15, 6, 22, 13, 21 };//两对括号的位置
        private static string[] fOps = new string[] { "+", "-", "*", "/" };

        // C#6.0 using expression-bodied member or CSE0003 warning
        public static string[] getovsArr() => ovsArr;

        public static string[] getopsArr() => opsArr;

        //运算符优先级
        static int privority(string str)
        {

            int pri = 0;
            switch (str)
            {
                case "+": pri = 1; break;
                case "-": pri = 1; break;
                case "*": pri = 2; break;
                case "/": pri = 2; break;
                case "(": pri = 3; break;
                case ")": pri = 3; break;
            }

            return pri;
        }

        //四则运算
        static int[] opsAl(string first, string second, string ops)
        {

            int[] res = new int[2] { 1, 0 };// res[0]为标志位 1正常 0不正常；res[1]为结果位
            int firOps = merror(first);
            int secOps = merror(second);

            switch (ops)
            {
                case "+": res[1] = firOps + secOps; break;
                case "-":
                    if (firOps >= secOps)
                    {
                        res[1] = firOps - secOps; break;
                    }
                    else
                    {
                        res[0] = 0; break;
                    }
                case "*": res[1] = firOps * secOps; break;
                case "/":
                    if (secOps == 0 || firOps >= secOps || firOps % secOps != 0)
                    {
                        res[0] = 0; break;
                    }
                    else
                    {
                        res[1] = firOps / secOps; break;
                    }

            }
            return res;
        }

        //检测返回值的合法性
        static Boolean isValid(int res)
        {
            if (res == 0)
            {
                return false;
            }

            return true;
        }

        //对应数据
        static int merror(string s)
        {
            int resNum = 0;
            switch (s)
            {
                case "J": resNum = 11; break;
                case "Q": resNum = 12; break;
                case "K": resNum = 13; break;
                case "A": resNum = 1; break;
                default: resNum = int.Parse(s); break;
            }
            return resNum;
        }

        //求表达式值
        static int opsExp(string[] arr)
        {
            arr = arr.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            Stack<string> ovs = new Stack<string>();//操作数
            Stack<string> ops = new Stack<string>();//操作符
            int res = 0;
            foreach (string str in arr)
            {
                if (str.Equals(";"))
                {
                    while (ops.Count != 0)
                    {
                        if (ovs.Count >= 2)
                        {
                            string firOps = ovs.Pop();
                            string secOps = ovs.Pop();
                            string onceOps = ops.Pop();
                            int[] resOps = opsAl(secOps, firOps, onceOps);
                            if (isValid(resOps[0]))
                            {
                                ovs.Push(resOps[1].ToString());

                            }
                            else
                            {
                                return res;

                            }

                        }
                    }

                    if (ops.Count == 0)
                    {

                        res = int.Parse(ovs.Pop());
                        break;
                    }

                }
                if (ovsArr.Contains(str))
                {
                    ovs.Push(str);
                }
                else if (opsArr.Contains(str))
                {
                    //第一个运算符
                    if (ops.Count == 0)
                    {
                        ops.Push(str);
                    }
                    else {

                        //遇到左括号
                        if (str.Equals("("))
                        {
                            ops.Push(str);
                        }

                        //15/12/24 3:30 by hr
                        // 还需要考虑括号隔两个操作符的情况！
                        //遇到右括号且当前栈顶元素为左括号 
                        //if (str.Equals(")") && ops.Peek().Equals('('))
                        if (str.Equals(")"))
                        {
                            //还需要考虑括号隔两个操作符的情况！
                            while (!ops.Peek().Equals("("))
                            {
                                if (ovs.Count >= 2)
                                {
                                    string firOps = ovs.Pop();
                                    string secOps = ovs.Pop();
                                    string onceOps = ops.Pop();
                                    int[] resOps = opsAl(secOps, firOps, onceOps);
                                    if (isValid(resOps[0]))
                                    {
                                        ovs.Push(resOps[1].ToString());
                                    }
                                    else
                                    {
                                        return res;
                                    }
                                }

                            }
                            if (ops.Peek().Equals("("))
                            {
                                ops.Pop();
                            }

                        }


                        if ((str.Equals("+") || str.Equals("-") || str.Equals("*") || str.Equals("/")))
                        {

                            //当前操作符优先级低于操作符栈顶元素优先级 
                            if (!ops.Peek().Equals("(") && privority(ops.Peek()) >= privority(str))
                            {
                                if (ovs.Count >= 2)
                                {
                                    string firOps = ovs.Pop();
                                    string secOps = ovs.Pop();
                                    string onceOps = ops.Pop();
                                    int[] resOps = opsAl(secOps, firOps, onceOps);
                                    if (isValid(resOps[0]))
                                    {
                                        ovs.Push(resOps[1].ToString());
                                        ops.Push(str);
                                    }
                                    else
                                    {
                                        return res;
                                    }

                                }
                            }

                            //当前运算符优先级大于运算符栈顶元素优先级
                            if (!ops.Peek().Equals("(") && privority(ops.Peek()) < privority(str))
                            {
                                ops.Push(str);
                            }

                            if (ops.Peek().Equals("("))
                            {
                                ops.Push(str);
                            }


                        }
                    }

                }
                else
                {
                    //Console.WriteLine("存在不合法数据或符号");
                    break;
                }

            }

            return res;
        }

        //字符串转数组 且去掉空字符
        static string[] strToArr(string str)
        {
            string[] strArr = new string[100];
            strArr = Regex.Split(str, @"\b(J|Q|K|A|0|1|2|3|4|5|6|7|8|9|10|;)\b|(\+|\-|\*|\/|\(|\))");
            strArr = strArr.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            return strArr;
        }

        //满足24的表达式
        //返回值为空字符时 表示不存在满足条件的表达式
        static string rightExp(string ops0, string ops1, string ops2, string ops3)
        {
            string[] exp = new string[200];//存储表达式 无括号
            string[] expKhArr = new string[200];//存储表达式 带括号
            exp[199] = ";";//表达式结束符
            string rExp = "";//存放正确的表达式

            exp[2] = ops0;
            exp[8] = ops1;
            exp[14] = ops2;
            exp[20] = ops3;

            //无括号
            for (int o = 0; o < 4; o++)
                for (int p = 0; p < 4; p++)
                    for (int q = 0; q < 4; q++)
                    {
                        exp[5] = fOps[o];
                        exp[11] = fOps[p];
                        exp[17] = fOps[q];

                        //默认 没有括号的情况
                        rExp = isRightExp(exp);
                        if (rExp.Count() != 0)
                        {
                            return rExp;
                        }

                        //一对括号
                        for (int i = 0; i < kh1ps.Length; i += 2)
                        {

                            expKhArr = expKh(exp, false, i, (i + 1));
                            rExp = isRightExp(expKhArr);
                            if (rExp.Count() != 0)
                            {
                                return rExp;
                            }

                            //清除此次运算的括号 运算符和操作数是固定位置 可被覆盖 因此不作考虑
                            exp[kh1ps[i]] = "";
                            exp[kh1ps[i + 1]] = "";

                        }

                        //两对括号
                        for (int i = 0; i < kh2ps.Length; i += 4)
                        {

                            expKhArr = expKh(exp, true, i, (i + 1), (i + 2), (i + 3));
                            rExp = isRightExp(expKhArr);
                            if (rExp.Count() != 0)
                            {
                                return rExp;
                            }
                            
                            //清除此次运算的括号
                            exp[kh2ps[i]] = "";
                            exp[kh2ps[i + 1]] = "";
                            exp[kh2ps[i + 2]] = "";
                            exp[kh2ps[i + 3]] = "";

                        }
                    }

            return rExp;
        }

        //产生四个基础元素
        public static string[] randElem()
        {
            string[] elem = new string[4];
            Random a = new Random();
            int elemNum = 0;
            while (elemNum < 4)
            {
                int opsEle = a.Next(0, 13);
                string opsTemp = ovsArr[opsEle];
                if (!elem.Contains(opsTemp))
                {
                    elem[elemNum++] = opsTemp;
                    //  Console.WriteLine("基础："+opsEle);
                }

            }
            return elem;
        }

        //考虑正确表达式带括号 
        //flag false为一括号 true为二括号
        static string[] expKh(string[] expKh, bool flag, int a, int b, int c = 0, int d = 0)
        {
            if (!flag)
            {

                expKh[kh1ps[a]] = "(";
                expKh[kh1ps[b]] = ")";
            }
            else
            {
                expKh[kh2ps[a]] = "(";
                expKh[kh2ps[b]] = ")";
                expKh[kh2ps[c]] = "(";
                expKh[kh2ps[d]] = ")";
            }
            return expKh;
        }

        //获取表达式的值是否为24
       static string isRightExp(string[] exp)
        {
            string rightExp = "";
            if (opsExp(exp) == 24)
            {
                rightExp = String.Join("", exp.Where(s => !string.IsNullOrEmpty(s)).ToArray());
                return rightExp.TrimEnd(';');
            }
            else {
                rightExp = "";//清空数据 下次不受影响
            }

            return rightExp;
        }

        //基础元素的组合
        static string[] opsP(string[] ops)
        {
            string[] opsP = new string[222];
            int opsPNum = 0;
            int opsNum = ops.Length;
            for (int i = 0; i < opsNum; i++)
                for (int j = 0; j < opsNum; j++)
                    for (int k = 0; k < opsNum; k++)
                        for (int l = 0; l < opsNum; l++)
                        {
                            if (i != j && i != k && i != l && j != k && j != l && k != l)
                            {
                                opsP[opsPNum++] = ops[i];
                                opsP[opsPNum++] = ops[j];
                                opsP[opsPNum++] = ops[k];
                                opsP[opsPNum++] = ops[l];

                            }
                        }

            return opsP;
        }

        //值为的24表达式组合是否存在
        public static string beginTestRightExp(string[] eleArr)
        {
            string[] opsPArr = opsP(eleArr);
            string rightexp = "";
            for (int i = 0; i < opsPArr.Length; i += 4)
            {
                rightexp = rightExp(opsPArr[i], opsPArr[i + 1], opsPArr[i + 2], opsPArr[i + 3]);
                if (rightexp.Length != 0)
                {
                    return rightexp;
                }

            }

            return rightexp;
        }

        //检测输入表达式是否为合法
        //exp 输入表达式 ; eleArr 生成的表达式
        private static bool isValidExp(string[] exp,string[] eleArr)
        {
            foreach (string ele in exp)
            {
                if (ele.Equals(";") || (getopsArr().Contains(ele) || getovsArr().Contains(ele)))
                {
                    if (eleArr.Contains(ele) || ele.Equals("(") || ele.Equals(")"))
                        continue;
                }
                else
                {
                    return false;
                }

            }
            return true;
        }

        //验证表达式正确性
        //expI 输入的表达式; eleArrCopy 生成的表达式
        public static bool isRight(string expI, string[] eleArrCopy)
        {

            //2015/12/26 字符串中含有空字符串时匹配出问题
            expI = expI.Replace(" ", "");//过滤掉输入字符串中所有的空格
            string[] expEle = new string[100];
            //;结束标识符
            expEle = strToArr(expI + ";");
            if (!isValidExp(expEle, eleArrCopy))
            {
                return false;
            }
            if (opsExp(expEle) == 24)
            {
                return true;
            }
            else {
                return false;
            }

        }
    }
}
