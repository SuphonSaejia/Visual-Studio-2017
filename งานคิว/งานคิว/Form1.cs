using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace งานคิว
{
    public partial class Form1 : Form
    {
        SoundPlayer into = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\into.wav");
        SoundPlayer num1 = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\1.wav");
        SoundPlayer num2 = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\2.wav");
        SoundPlayer num3 = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\3.wav");
        SoundPlayer num4 = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\4.wav");
        SoundPlayer num5 = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\5.wav");
        SoundPlayer num6 = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\6.wav");
        SoundPlayer num7 = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\7.wav");
        SoundPlayer num8 = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\8.wav");
        SoundPlayer num9 = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\9.wav");
        SoundPlayer num0 = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\0.wav");
        SoundPlayer A = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\A.wav");
        SoundPlayer B = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\B.wav");
        SoundPlayer to = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\to.wav");
        SoundPlayer co = new SoundPlayer(@"C:\Users\user\Desktop\งานคิว\งานคิว\bin\Debug\files (online-audio-converter.com)\coun.wav");
        public Form1()
        {
            InitializeComponent();
        }
        Queue<string> myQueue = new Queue<string>();//เก็บฝากถอน
        Queue<string> myQueue2 = new Queue<string>();//เก็บเปิดบัญชี
        int i = 0,j=0;
        String s = "";
        Char[] c;
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (myQueue2.Count > 0)
            {
                s = myQueue2.Dequeue();
                listBox2.Items.Add(("  " + s + " =>>  " + "C3"));
                c = s.ToCharArray();
                into.Play(); de1();
                foreach (Char x in c)
                {
                    if (x == 'A') { A.Play(); de(); }
                    if (x == 'B') { B.Play(); de(); }
                    if (x == '0') { num0.Play(); de(); }
                    if (x == '1') { num1.Play(); de(); }
                    if (x == '2') { num2.Play(); de(); }
                    if (x == '3') { num3.Play(); de(); }
                    if (x == '4') { num4.Play(); de(); }
                    if (x == '5') { num5.Play(); de(); }
                    if (x == '6') { num6.Play(); de(); }
                    if (x == '7') { num7.Play(); de(); }
                    if (x == '8') { num8.Play(); de(); }
                    if (x == '9') { num9.Play(); de(); }

                }
                to.Play(); de(); co.Play(); de1(); num3.Play(); de();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;

            if (i != 1000)
            {
                if (i > 99) s = "A-" + i.ToString();
                else if (i > 9) s = "A-0" + i.ToString();
                else s = "A-00" + i.ToString();
                myQueue.Enqueue(s);
            }
            else
            {
                i = 1;
                s = "A-00" + i.ToString();
                myQueue.Enqueue(s);
            }
            // listBox1.Items.Add((myQueue.Dequeue()+" - "+""));  แสดงผล
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (myQueue.Count > 0)
            {
                s = myQueue.Dequeue();
                listBox1.Items.Add(("  "+s+ " =>>  " + "C1"));
                c = s.ToCharArray();
                into.Play(); de1();
                foreach (Char x in c)
                {
                    if (x == 'A') { A.Play(); de(); }
                    if (x == 'B') { B.Play(); de(); }
                    if (x == '0') { num0.Play(); de(); }
                    if (x == '1') { num1.Play(); de(); }
                    if (x == '2') { num2.Play(); de(); }
                    if (x == '3') { num3.Play(); de(); }
                    if (x == '4') { num4.Play(); de(); }
                    if (x == '5') { num5.Play(); de(); }
                    if (x == '6') { num6.Play(); de(); }
                    if (x == '7') { num7.Play(); de(); }
                    if (x == '8') { num8.Play(); de(); }
                    if (x == '9') { num9.Play(); de(); }

                } 
                to.Play(); de(); co.Play(); de1(); num1.Play(); de();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (myQueue.Count > 0)
            {
                s = myQueue.Dequeue();
                listBox1.Items.Add(("  " + s + " =>>  " + "C2"));
                c = s.ToCharArray();
                into.Play(); de1();
                foreach (Char x in c)
                {
                    if (x == 'A') { A.Play(); de(); }
                    if (x == 'B') { B.Play(); de(); }
                    if (x == '0') { num0.Play(); de(); }
                    if (x == '1') { num1.Play(); de(); }
                    if (x == '2') { num2.Play(); de(); }
                    if (x == '3') { num3.Play(); de(); }
                    if (x == '4') { num4.Play(); de(); }
                    if (x == '5') { num5.Play(); de(); }
                    if (x == '6') { num6.Play(); de(); }
                    if (x == '7') { num7.Play(); de(); }
                    if (x == '8') { num8.Play(); de(); }
                    if (x == '9') { num9.Play(); de(); }

                }
                to.Play(); de(); co.Play(); de1(); num2.Play(); de();

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (myQueue2.Count > 0)
            {
                s = myQueue2.Dequeue();
                listBox2.Items.Add(("  " + s + " =>>  " + "C4"));
                c = s.ToCharArray();
                into.Play(); de1();
                foreach (Char x in c)
                {
                    if (x == 'A') { A.Play(); de(); }
                    if (x == 'B') { B.Play(); de(); }
                    if (x == '0') { num0.Play(); de(); }
                    if (x == '1') { num1.Play(); de(); }
                    if (x == '2') { num2.Play(); de(); }
                    if (x == '3') { num3.Play(); de(); }
                    if (x == '4') { num4.Play(); de(); }
                    if (x == '5') { num5.Play(); de(); }
                    if (x == '6') { num6.Play(); de(); }
                    if (x == '7') { num7.Play(); de(); }
                    if (x == '8') { num8.Play(); de(); }
                    if (x == '9') { num9.Play(); de(); }

                }
                to.Play(); de(); co.Play(); de1(); num4.Play(); de();
            }
        }
        private void de1() { for (int i = 0; i != 700000000; i++) ; }
        private void de() { for (int i = 0; i != 500000000; i++) ; }
        private void button2_Click(object sender, EventArgs e)
        {
            j++;

            if (j != 1000)
            {
                if (j > 99) s = "B-" + j.ToString();
                else if (i > 9) s = "B-0" + j.ToString();
                else s = "B-00" + j.ToString();
                myQueue2.Enqueue(s);
            }
            else
            {
                j = 1;
                s = "B-00" + j.ToString();
                myQueue2.Enqueue(s);
            }
        }
    }
}
