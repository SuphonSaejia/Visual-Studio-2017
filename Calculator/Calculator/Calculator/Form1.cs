using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            char[] InfixArr = txtInfix.Text.ToCharArray();
            txtTmpInfix.Text = parseInfix(InfixArr);
            txtPostfix.Text = convertToPostfix(txtTmpInfix.Text);
            txtOutput.Text = calculatePostfix(txtPostfix.Text);
        }

        private string parseInfix(char[] input)  //function สำหรับการใส่ช่องว่างในแยกแต่ละ Token
        {
            string ret="";
            char tmp;
            for (int i = 0; i < input.Length ; i++)
            { int j,k;
                tmp = input[i];
                if (tmp == '.')
                {
                    ret += tmp;
                }
                else if (int.TryParse(tmp.ToString(), out j))  //ตรวจสอบว่า Token เป็นตัวเลขหรือไม่ ถ้าเป็นตัวเลขจะนำไปต่อกันตามจำนวนหลัก
                {
                    ret += tmp.ToString();
                    if(i<input.Length-1)   //ตรวจสอบว่าเป็น Token ตัวสุดท้ายหรือไม่
                     if(!int.TryParse(input[i+1].ToString(),out k) && input[i+1]!='.')  // ถ้าตัวถัดไปไม่ใช่ Token ตัวสุดท้ายและไม่ได้เป็นตัวเลข คือเป็น ( + - * / ) ให้เพิ่ม space เข้าไป 
                    {
                        ret += " ";
                    }
                }
                else
                {
                    ret += tmp.ToString()+ " "; // กรณี Token ไม่ใช่ตัวเลข ให้นำมาใส่ space ต่อท้าย
                }
            
            }
            return ret;
        }


        private string convertToPostfix(string infix)
        {
            string ret = "";
            infix = infix.Trim();
            string[] infixArr = infix.Split(' ');
            Stack<string> s = new Stack<string>();
            foreach (string token in infixArr)
            {
                switch (token)
                {   
                    case "(":
                        s.Push(token);
                        break;
                    case "+":
                        if (s.Count > 0)
                        while("+-*/".Contains(s.Peek()))
                        {
                            ret += s.Pop() + " ";
                        }
                        s.Push(token);
                        break;
                    case "-":
                        if(s.Count>0)
                        while ("+-*/".Contains(s.Peek()))
                        {
                            ret += s.Pop() + " ";
                        }
                        s.Push(token);
                        break;
                    case "*":
                        if (s.Count > 0)
                        while("*/".Contains(s.Peek()))
                        {
                            ret += s.Pop() + " ";
                        }
                        s.Push(token);
                        break;
                    case "/":
                        if (s.Count > 0)
                       while("*/".Contains(s.Peek()))
                        {
                            ret += s.Pop() + " ";
                        }
                       s.Push(token);
                        break;
                    case ")":
                        do
                        {
                            ret += s.Pop() + " ";
                        } while (s.Peek() != "(");

                        if (s.Count > 0)
                        if (s.Peek() == "(") s.Pop();
                             break;
                    default:
                        ret +=token + " ";
                        break;
                }
               
            }
            while(s.Count > 0) ret += s.Pop() +" ";
        
        return ret;
        }

        private string calculatePostfix(string postfix)
        {
            string ret="";
            double a, b;
            Stack<double> s = new Stack<double>();
            postfix = postfix.Trim();
            string[] postfixArr = postfix.Split(' ');
            foreach (string token in postfixArr)
            {
                if ("+-*/".Contains(token))
                {
                    b = s.Pop();
                    a = s.Pop();
                    switch (token)
                    {
                        case "+": s.Push(a + b); break;
                        case "-": s.Push(a - b); break;
                        case "*": s.Push(a * b); break;
                        case "/": s.Push(a / b); break;
                    }

                }
                else
                {
                    s.Push(double.Parse(token));
                }
            }
            ret = s.Pop().ToString();
            return ret;
        }

       
    }
}
