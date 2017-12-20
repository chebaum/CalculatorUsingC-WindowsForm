using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace calcV2
{

    public partial class CalculatorV1 : Form
    {
        Calc tempData = new Calc();

        double finalResult, result;
        string op, nextOp;
        bool op_pressed, sum_pressed, sub_pressed, enter_clicked;

        public CalculatorV1()
        {
            InitializeComponent();
            finalResult = result = 0.0;
            op = nextOp = "";
            op_pressed = sum_pressed = sub_pressed = enter_clicked = false;
        }
        

        private void button0_Click(object sender, EventArgs e)
        {
            if (calcStr.Text == "0" || op_pressed)
            {
                calcStr.Clear();
                op_pressed = false;
            }
            if (enter_clicked && !op_pressed) // enter쳐서 계산이 완료된 상태에서 새로운 숫자를 누르면 
                initializeForm(); // -> 처음부터 새로시작

            Button btn = (Button)sender;
            calcStr.Text = calcStr.Text + btn.Text;
            str.Text = str.Text + btn.Text;
            op_pressed = false;
            enter_clicked = false;
            //result = double.Parse(calcStr.Text);
        }
        
        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            if (enter_clicked || op_pressed)
                return;
            if (double.Parse(calcStr.Text) < 10.0)
            {
                calcStr.Text = "0";
                str.Text = str.Text.Remove(str.Text.Length - 1);
                str.Text += "0";

                return;
            }
            else
            {
                str.Text = str.Text.Remove(str.Text.Length - 1);
                calcStr.Text = calcStr.Text.Remove(calcStr.Text.Length - 1);
                //result = double.Parse(calcStr.Text);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            calcStr.Text = "0";
            str.Text = "";
            result = 0.0;
            finalResult = 0.0;
            op = nextOp = "";
            op_pressed = sum_pressed = sub_pressed = false;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            switch (nextOp)
            {
                case "+":
                case "-":
                    Calculate(ref finalResult, nextOp, double.Parse(calcStr.Text));
                    break;
                case "*":
                case "/": 
                    Calculate(ref result, nextOp, double.Parse(calcStr.Text));
                    if (sum_pressed) Calculate(ref finalResult, "+", result);
                    else if (sub_pressed) Calculate(ref finalResult, "-", result);
                    else finalResult = result;
                    break;
                default:
                    break;
            }
            str.Text = calcStr.Text = finalResult.ToString();

            SaveStatus();
            
            //op_pressed = sum_pressed = sub_pressed = false;
            enter_clicked = true;
            //result = 0.0;
            //op = nextOp = "";
        }

        private void operand_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (enter_clicked) // 엔터를 누른 후 첫 입력이 연산자라면, 
            {
                initializeForm();
                calcStr.Text = str.Text = tempData.calcStr;
            }
            enter_clicked = false;

            if (op_pressed) // 이미 연산자가 눌린 상태에서 또 연산자를 누르면 연산자만 변경
            {
                str.Text = str.Text.Remove(str.Text.Length - 1);
                str.Text = str.Text + btn.Text;
                
                if (!IsEqualOp(btn.Text, nextOp)) // +- 에서 */ 이것만 문제. 아니라면 if문 패스
                {
                    SetStatus(tempData); // 직전에 저장된 데이터를 불러와서 */ 연산으로 새로수행.
                    operand_Click(sender, e);
                }
                nextOp = btn.Text;
                return;
            }
            SaveStatus();
            if (nextOp.Equals("")) { // 첫 연산자 클릭이라면, 연산 없이 값 저장 후 리턴.
                result = (finalResult == 0.0) ? (double.Parse(calcStr.Text)) : 0.0; // = (enter) 기호 클릭 후 이어서 연산 진행하는 경우와 구분
                if (btn.Text.Equals("+") || btn.Text.Equals("-")) {
                    if(!enter_clicked) 
                        Calculate(ref finalResult, "+", result);
                    result = 0;
                }
                op_pressed = true;
                nextOp = btn.Text;
                str.Text = str.Text + btn.Text;
                return;
            }
            
            op_pressed = true;
            op = nextOp;
            nextOp = btn.Text;

            if (str.Text.Equals("")) // 숫자 입력없이 바로 연산자만 누르면 0 + 이런식으로 앞에 0 추가해준다. 0 + ..
                TextBoxAppend(ref str, "0");
            str.Text = str.Text + btn.Text;

            
            switch (nextOp)
            {
                case "+":
                case "-":
                    //if(직전 연산자가 */ 이면 마저 수행하고 result더해줘야해) 현재 입력받은 키가 +-이면 finalResult업데이트후 result초기화
                    //else 직전에도 +-였으면 

                    if (op.Equals("+") || op.Equals("-"))
                        Calculate(ref finalResult, op, double.Parse(calcStr.Text));
                    else
                    {
                        Calculate(ref result, op, double.Parse(calcStr.Text));
                        if (sum_pressed) Calculate(ref finalResult, "+", result);
                        else if (sub_pressed) Calculate(ref finalResult, "-", result);
                        else finalResult = result;
                    }
                    sum_pressed = sub_pressed = false;
                    calcStr.Text = finalResult.ToString();
                    result = 0.0;
                    break;

                case "*":
                case "/":
                    //직전이 +-이면 result에 그냥 값 넣고
                    //직전에 */였으면 result<-현재textbox값*result 해주고 다음 inst대기
                    if (op.Equals("+") || op.Equals("-"))
                    {
                        result = double.Parse(calcStr.Text);
                        if (op.Equals("+")) sum_pressed = true;
                        else sub_pressed = true;
                    }
                    else
                        Calculate(ref result, op, double.Parse(calcStr.Text));

                    calcStr.Text = result.ToString();
                    break;

                default:
                    MessageBox.Show("보이면 에러");
                    //finalResult = result;
                    //result = 0.0;
                    break;
            }
        }
        private void TextBoxAppend(ref System.Windows.Forms.TextBox box, string orgin)
        {
            box.Text = box.Text + orgin;
        }

        private void Calculate(ref double reference, string op, double value)
        {
            switch (op)
            {
                case "+":
                    reference += value;
                    break;
                case "-":
                    reference -= value;
                    break;
                case "*":
                    reference *= value;
                    break;
                case "/":
                    reference /= value;
                    break;
                default:
                    MessageBox.Show("보이면 에러");
                    break;
            }
        }
        private bool IsEqualOp(string a, string b)
        {
            if (a.Equals("+") || a.Equals("-"))
            {
                if (b.Equals("+") || b.Equals("-"))
                    return true;
                else
                    return false;
            }
            else
            {
                if (b.Equals("*") || b.Equals("/"))
                    return true;
                else
                    return false;
            }
        }
        private void SaveStatus()
        {
            tempData.finalResult = finalResult;
            tempData.result = result;
            tempData.op = op;
            tempData.nextOp = nextOp;
            tempData.op_pressed = op_pressed;
            tempData.sum_pressed = sum_pressed;
            tempData.sub_pressed = sub_pressed;
            tempData.enter_clicked = enter_clicked;
            tempData.calcStr = calcStr.Text;
            tempData.str = str.Text;
        }
        private void SetStatus(Calc c)
        {
            finalResult = c.finalResult;
            result = c.result;
            op = c.op;
            nextOp = c.nextOp;
            op_pressed = c.op_pressed;
            sum_pressed = c.sum_pressed;
            sub_pressed = c.sub_pressed;
            enter_clicked = c.enter_clicked;
            calcStr.Text = c.calcStr;
            str.Text = c.str;
        }
        private void initializeForm()
        {
            finalResult = result = 0.0;
            op = nextOp = "";
            op_pressed = sum_pressed = sub_pressed = enter_clicked = false;
            str.Text =  "";
            calcStr.Text = "";
        }
        private void str_TextChanged(object sender, EventArgs e) { return; }
    }
}