using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 數字解碼
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a, j = 0;
            int x = 0;
            Stopwatch sw = new Stopwatch();
            a = Convert.ToInt32(textBox2.Text);
            sw.Start();
            Random r = new Random();
            int[] b = new int[a];
            
            int guessnum = 1;
            for (int i = 10; i > 10 - a; i--)
            {
                guessnum *= i;
            }
            int[] Sumnumber = new int[guessnum];
            int index = 0;
            switch (a)
            {
                case 1:
                    for (int i = 1; i < 10; i++)
                    { Sumnumber[index] = i; index++; }
                    break;
                case 2:
                    for (int i = 1; i < 10; i++)
                    {
                        for (int i2 = 1; i2 < 10; i2++)
                        {
                            if (i2 == i) { continue; }
                            Sumnumber[index] = i * 10 + i2; index++;
                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i < 10; i++)
                    {
                        for (int i2 = 1; i2 < 10; i2++)
                        {
                            if (i2 == i) { continue; }
                            for (int i3 = 1; i3 < 10; i3++)
                            {
                                if (i3 == i2 || i3 == i) { continue; }
                                Sumnumber[index] = i * 100 + i2 * 10 + i3; index++;
                            }
                        }
                    }
                    break;
                case 4:
                    for (int i = 1; i < 10; i++)
                    {
                        for (int i2 = 1; i2 < 10; i2++)
                        {
                            if (i2 == i) { continue; }
                            for (int i3 = 1; i3 < 10; i3++)
                            {
                                if (i3 == i2 || i3 == i) { continue; }
                                for (int i4 = 1; i4 < 10; i4++)
                                {
                                    if (i4 == i3 || i4 == i2 || i4 == i) { continue; }
                                    Sumnumber[index] = i * 1000 + i2 * 100 + i3 * 10 + i4; index++;
                                }
                            }
                        }
                    }
                    break;
                case 5:
                    for (int i = 1; i < 10; i++)
                    {
                        for (int i2 = 1; i2 < 10; i2++)
                        {
                            if (i2 == i) { continue; }
                            for (int i3 = 1; i3 < 10; i3++)
                            {
                                if (i3 == i2 || i3 == i) { continue; }
                                for (int i4 = 1; i4 < 10; i4++)
                                {
                                    if (i4 == i3 || i4 == i2 || i4 == i3) { continue; }
                                    for (int i5 = 1; i5 < 10; i5++)
                                    {
                                        if (i5 == i4 || i5 == i3 || i5 == i2 || i5 == i) { continue; }
                                        Sumnumber[index] = i * 10000 + i2 * 1000 + i3 * 100 + i4 * 10 + i5; index++;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 6:
                    for (int i = 1; i < 10; i++)
                    {
                        for (int i2 = 1; i2 < 10; i2++)
                        {
                            if (i2 == i) { continue; }
                            for (int i3 = 1; i3 < 10; i3++)
                            {
                                if (i3 == i2 || i3 == i) { continue; }
                                for (int i4 = 1; i4 < 10; i4++)
                                {
                                    if (i4 == i3 || i4 == i2 || i4 == i3) { continue; }
                                    for (int i5 = 1; i5 < 10; i5++)
                                    {
                                        if (i5 == i4 || i5 == i3 || i5 == i2 || i5 == i) { continue; }
                                        for (int i6 = 1; i6 < 10; i6++)
                                        {
                                            if (i6 == i5 || i6 == i4 || i6 == i3 || i6 == i2 || i6 == i) { continue; }
                                            Sumnumber[index] = i * 100000 + i2 * 10000 + i3 * 1000 + i4 * 100 + i5 * 10 + i6; index++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 7:
                    for (int i = 1; i < 10; i++)
                    {
                        for (int i2 = 1; i2 < 10; i2++)
                        {
                            if (i2 == i) { continue; }
                            for (int i3 = 1; i3 < 10; i3++)
                            {
                                if (i3 == i2 || i3 == i) { continue; }
                                for (int i4 = 1; i4 < 10; i4++)
                                {
                                    if (i4 == i3 || i4 == i2 || i4 == i3) { continue; }
                                    for (int i5 = 1; i5 < 10; i5++)
                                    {
                                        if (i5 == i4 || i5 == i3 || i5 == i2 || i5 == i) { continue; }
                                        for (int i6 = 1; i6 < 10; i6++)
                                        {
                                            if (i6 == i5 || i6 == i4 || i6 == i3 || i6 == i2 || i6 == i) { continue; }
                                            for (int i7 = 1; i7 < 10; i7++)
                                            {
                                                if (i7 == i6 || i7 == i5 || i7 == i4 || i7 == i3 || i7 == i2 || i7 == i) { continue; }
                                                Sumnumber[index] = i * 1000000 + i2 * 100000 + i3 * 10000 + i4 * 1000 + i5 * 100 + i6 * 10 + i7; index++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 8:
                    for (int i = 1; i < 10; i++)
                    {
                        for (int i2 = 1; i2 < 10; i2++)
                        {
                            if (i2 == i) { continue; }
                            for (int i3 = 1; i3 < 10; i3++)
                            {
                                if (i3 == i2 || i3 == i) { continue; }
                                for (int i4 = 1; i4 < 10; i4++)
                                {
                                    if (i4 == i3 || i4 == i2 || i4 == i3) { continue; }
                                    for (int i5 = 1; i5 < 10; i5++)
                                    {
                                        if (i5 == i4 || i5 == i3 || i5 == i2 || i5 == i) { continue; }
                                        for (int i6 = 1; i6 < 10; i6++)
                                        {
                                            if (i6 == i5 || i6 == i4 || i6 == i3 || i6 == i2 || i6 == i) { continue; }
                                            for (int i7 = 1; i7 < 10; i7++)
                                            {
                                                if (i7 == i6 || i7 == i5 || i7 == i4 || i7 == i3 || i7 == i2 || i7 == i) { continue; }
                                                for (int i8 = 1; i8 < 10; i8++)
                                                {
                                                    if (i8 == i7 || i8 == i6 || i8 == i5 || i8 == i4 || i8 == i3 || i8 == i2 || i8 == i) { continue; }
                                                    Sumnumber[index] = i * 10000000 + i2 * 1000000 + i3 * 100000 + i4 * 10000 + i5 * 1000 + i6 * 100 + i7 * 10 + i8; index++;
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 9:
                    for (int i = 1; i < 10; i++)
                    {
                        for (int i2 = 1; i2 < 10; i2++)
                        {
                            if (i2 == i) { continue; }
                            for (int i3 = 1; i3 < 10; i3++)
                            {
                                if (i3 == i2 || i3 == i) { continue; }
                                for (int i4 = 1; i4 < 10; i4++)
                                {
                                    if (i4 == i3 || i4 == i2 || i4 == i3) { continue; }
                                    for (int i5 = 1; i5 < 10; i5++)
                                    {
                                        if (i5 == i4 || i5 == i3 || i5 == i2 || i5 == i) { continue; }
                                        for (int i6 = 1; i6 < 10; i6++)
                                        {
                                            if (i6 == i5 || i6 == i4 || i6 == i3 || i6 == i2 || i6 == i) { continue; }
                                            for (int i7 = 1; i7 < 10; i7++)
                                            {
                                                if (i7 == i6 || i7 == i5 || i7 == i4 || i7 == i3 || i7 == i2 || i7 == i) { continue; }
                                                for (int i8 = 1; i8 < 10; i8++)
                                                {
                                                    if (i8 == i7 || i8 == i6 || i8 == i5 || i8 == i4 || i8 == i3 || i8 == i2 || i8 == i) { continue; }
                                                    for (int i9 = 1; i9 < 10; i9++)
                                                    {
                                                        if (i9 == i8 || i9 == i7 || i9 == i6 || i9 == i5 || i9 == i4 || i9 == i3 || i9 == i2 || i9 == i) { continue; }
                                                        Sumnumber[index] = i * 100000000 + i2 * 10000000 + i3 * 1000000 + i4 * 100000 + i5 * 10000 + i6 * 1000 + i7 * 100 + i8 * 10 + i9; index++;
                                                    }

                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
            }

                    b[j] = r.Next(1, 10);
                    j++;
                    do
                    {
                        if (a == 1) { break; }//case1
                        b[j] = r.Next(1, 10);

                        for (; x < j; x++)
                        {
                            if (b[x] == b[j])
                            {
                                b[j] = r.Next(1, 10);
                                x = -1;
                            }

                        }
                        x = 0;
                        j++;

                    } while (j < a);

                    Console.Write("題目：");
                    int sum = 0;
                    foreach (int c in b)
                    {
                        sum *= 10;
                        sum += c;
                    }

                    textBox1.Text+="亂數產生的題目為："+sum; //題目

            j = 0;
            x = 0;
            int[] Ans = new int[a];
            int A = 0, B = 0, sumA = 0;

            //假設a=2

            //------------提取ans[0],ans[1]兩個數字
            Ans[j] = r.Next(1, 10);
            j++;
            do
            {
                if (a == 1) { break; }//case1
                Ans[j] = r.Next(1, 10);
                for (; x < j; x++)
                {
                    if (Ans[x] == Ans[j])
                    {
                        Ans[j] = r.Next(1, 10);
                        x = -1;
                    }
                }
                x = 0;
                j++;

            } while (j < a);
            int guess = 0;
            foreach (int c in Ans)
            {
                guess *= 10;
                guess += c;
            }

            //答案 ?A?B
            //Console.WriteLine("{0}\t{1}A{2}B", guess, RA(guess.ToString(), sum.ToString()), RB(guess.ToString(), sum.ToString()));
            textBox1.Text += "\r\n亂數猜測："+guess+"\t結果："+RA(guess.ToString(), sum.ToString())+"A"+RB(guess.ToString(), sum.ToString())+"B";


            A = RA(guess.ToString(), sum.ToString());
            B = RB(guess.ToString(), sum.ToString());
            int AnsData = 0;


            for (int i = 0; i < guessnum; i++)
            {
                if (Sumnumber[i] == 0) { break; }
                if (RA(Sumnumber[i].ToString(), guess.ToString()) != A || RB(Sumnumber[i].ToString(), guess.ToString()) != B)
                {
                    Sumnumber[i] = -1;

                }

            }

            for (int i = 0; i < guessnum; i++)
            {
                if (Sumnumber[i] == -1) { continue; }
                else { AnsData = Sumnumber[i]; break; }
            }
            textBox1.Text += "\r\n亂數猜測："+AnsData+ "\t結果：" + RA(AnsData.ToString(), sum.ToString())+"A"+RB(AnsData.ToString(), sum.ToString())+"B";

            int round = 2;
            while (A != a)
            {
                A = RA(AnsData.ToString(), sum.ToString());
                B = RB(AnsData.ToString(), sum.ToString());
                if (A == a) { break; }//----



                for (int i = 0; i < guessnum; i++)
                {
                    if (Sumnumber[i] == -1) { continue; }
                    if (Sumnumber[i] == AnsData) { Sumnumber[i] = -1; continue; };
                    if (Sumnumber[i] == 0) { break; }

                    if (RA(Sumnumber[i].ToString(), AnsData.ToString()) != A || RB(Sumnumber[i].ToString(), AnsData.ToString()) != B)
                    {
                        Sumnumber[i] = -1;
                    }



                }

                for (int i = 0; i < guessnum; i++)
                {
                    if (Sumnumber[i] == -1) { continue; }
                    else { AnsData = Sumnumber[i]; break; }
                }



                textBox1.Text += "\r\n亂數猜測："+AnsData+ "\t結果：" + RA(AnsData.ToString(), sum.ToString())+"A"+RB(AnsData.ToString(), sum.ToString())+"B";
                round++;



                if (RA(AnsData.ToString(), sum.ToString()) == a) { break; }
            }
            sw.Stop();
            textBox1.Text += "\r\n猜測次數："+round+"次";
            double time = sw.ElapsedMilliseconds;
            textBox1.Text += "  總花費時間"+time/1000+"秒";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //處理A數

        private static int RA(string x, string j)
        {
            int A = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x.Substring(i, 1) == j.Substring(i, 1))
                {
                    A++;
                }
            }
            return A;
        }

        //處理B數
        private static int RB(string x, string j)
        {
            int B = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int z = 0; z < j.Length; z++)
                {
                    if (i == z) { continue; }
                    if (x.Substring(i, 1) == j.Substring(z, 1))
                    { B++; }

                }
            }

            return B;
        }


    }
}
