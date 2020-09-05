using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace การใช้คิว
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double T, B;
        string c,a1,a2;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int i;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Queue<string> myQueue = new Queue<string>();
           
            string Text1 = textBox1.Text;
            string[] str1 = Text1.Split(" ".ToCharArray());
            foreach (string x in str1)
            {
                myQueue.Enqueue(x);
               
            }

            for (; ;)
            {
                c = myQueue.Dequeue();
                if (c=="+")
                {
                    foreach (string x1 in myQueue) { a1 = x1; i = 1; if (i == 1) break; }
                    i = 0;
                    if (a1 != "+" && a1 != "-" && a1 != "*" && a1 != "/")
                    {
                        foreach (string x1 in myQueue) { i++; a2 = x1; if (i == 2) break; }
                        i = 0;

                        if (a2 != "+" && a2 != "-" && a2 != "*" && a2 != "/")
                        {
                            a1 = myQueue.Dequeue();
                            a2 = myQueue.Dequeue();
                            double.TryParse(a1,out T);
                            double.TryParse(a2,out B);
                            T = T + B;
                            myQueue.Enqueue(T.ToString());
                        }
                        else myQueue.Enqueue(c);
                    }
                    else myQueue.Enqueue(c);

                }
                else if (c=="-")
                {
                    foreach (string x1 in myQueue) { a1 = x1;i = 1;if (i == 1) break; }
                    i = 0;
                    if (a1 != "+" && a1 != "-" && a1 != "*" && a1 != "/")
                    {
                        foreach (string x1 in myQueue) { i++; a2 = x1; if (i == 2) break; }
                        i = 0;

                        if (a2 != "+" && a2 != "-" && a2 != "*" && a2 != "/")
                        {
                            a1 = myQueue.Dequeue();
                            a2 = myQueue.Dequeue();
                            double.TryParse(a1, out T);
                            double.TryParse(a2, out B);
                            T = T - B;
                            myQueue.Enqueue(T.ToString());
                        }
                        else myQueue.Enqueue(c);
                    }
                    else myQueue.Enqueue(c);
                }
                else if (c=="*")
                {
                    foreach (string x1 in myQueue) { a1 = x1; i = 1; if (i == 1) break; }
                    i = 0;
                    if (a1 != "+" && a1 != "-" && a1 != "*" && a1 != "/")
                    {
                        foreach (string x1 in myQueue) { i++; a2 = x1; if (i == 2) break; }
                        i = 0;

                        if (a2 != "+" && a2 != "-" && a2 != "*" && a2 != "/")
                        {
                            a1 = myQueue.Dequeue();
                            a2 = myQueue.Dequeue();
                            double.TryParse(a1, out T);
                            double.TryParse(a2, out B);
                            T = T * B;
                            myQueue.Enqueue(T.ToString());
                        }
                        else myQueue.Enqueue(c);
                    }
                    else myQueue.Enqueue(c);
                }
                else if (c=="/")
                {
                    foreach (string x1 in myQueue) { a1 = x1; i = 1; if (i == 1) break; }
                    i = 0;
                    if (a1 != "+" && a1 != "-" && a1 != "*" && a1 != "/")
                    {
                        foreach (string x1 in myQueue) { i++; a2 = x1; if (i == 2) break; }
                        i = 0;

                        if (a2 != "+" && a2 != "-" && a2 != "*" && a2 != "/")
                        {
                            a1 = myQueue.Dequeue();
                            a2 = myQueue.Dequeue();
                            double.TryParse(a1, out T);
                            double.TryParse(a2, out B);
                            T = T / B;
                            myQueue.Enqueue(T.ToString());
                        }
                        else myQueue.Enqueue(c);
                    }
                    else myQueue.Enqueue(c);
                }

                else myQueue.Enqueue(c);

                if (myQueue.Count == 1) break;
            }

            textBox2.Text = myQueue.Dequeue();

        }
    }
}
