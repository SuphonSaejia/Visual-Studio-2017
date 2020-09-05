using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace แปลงสมการ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<string> myStack = new Stack<string>();
        string t = "";
        string s = "";
        int i = 0;
        int j,b=0;
        // สุพล แซ่เจี่ย 61030060
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            string Text2 = textBox2.Text;
            string[] str2 = Text2.Split(" ".ToCharArray());

            Double a, b;
                
            foreach (string x in str2)
            {
                if (x == "+")
                {
                    Double.TryParse(myStack.Pop(), out a);
                    Double.TryParse(myStack.Pop(), out b);
                    myStack.Push((a + b).ToString());

                }
                else if (x == "-")
                {
                    Double.TryParse(myStack.Pop(), out a);
                    Double.TryParse(myStack.Pop(), out b);
                    myStack.Push((a - b).ToString());

                }
                else if (x == "*")
                {
                    Double.TryParse(myStack.Pop(), out a);
                    Double.TryParse(myStack.Pop(), out b);
                    myStack.Push((a * b).ToString());

                }
                else if (x == "/")
                {
                    Double.TryParse(myStack.Pop(), out a);
                    Double.TryParse(myStack.Pop(), out b);
                    myStack.Push((a * b).ToString());

                }
                else
                {
                    myStack.Push(x);

                }

                


            }

            textBox3.Text = myStack.Pop();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Text1 = textBox1.Text;
            string[] str1 = Text1.Split(" ".ToCharArray());
            foreach (string x in str1)
            {
                if (x == "+")
                { if (t == "-" || t == "*" || t == "/")
                    {
                        for (j = 0; j != i; i--) textBox2.Text += myStack.Pop() + " ";
                    }
                    myStack.Push("+"); i++; t = "+";
                }


                else if (x == "-")
                {
                    if (t == "+" || t == "*" || t == "/")
                    {
                        for (j = 0; j != i; i--) textBox2.Text += myStack.Pop() + " ";
                    }
                    myStack.Push("-"); i++; t = "-";
                }


                else if (x == "*")
                {
                    if (t == "/")
                    {
                        for (j = 0; j != i; i--) textBox2.Text += myStack.Pop() + " ";
                    }
                    myStack.Push("*"); i++; t = "*";
                }


                else if (x == "/")
                { if (t == "*")
                    {
                        for (j = 0; j != i; i--) textBox2.Text += myStack.Pop() + " ";
                    }
                    myStack.Push("/"); i++; t = "/";
                }

                else if (x == "(")
                {
                    myStack.Push("("); i++; t = "(";
                }

                else if (x == ")")
                {
                    for (j = 0; j != i; i--)
                    {
                        s = myStack.Pop(); if (s == "(")

                        {
                            t = myStack.Pop(); myStack.Push(t); b=1; i--;
                        }

                        if (b == 1) break; textBox2.Text += s + " ";
                    }
                } 

                else textBox2.Text += x+" ";
                
                 b = 0;
            }
            if(i != 0) for (j = 0; j != i; i--) textBox2.Text += myStack.Pop();
        }
    }
}
