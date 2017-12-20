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
        // calculator 폼의 모든 요소들(변수들)의 값을 임시로 저장해둘 수 있는 클래스 입니다.
        // SaveStatus()를 통해 tempData객체에 현재정보를 업데이트하고
        // LoadStatas()를 통해 tempData에 저장된 정보들을 가져와서 현재의 Form 에 적용시킵니다.
        Calc tempData = new Calc();

        double finalResult, result;
        string op, nextOp;
        bool op_pressed, sum_pressed, sub_pressed, enter_clicked;

        // 생성자
        public CalculatorV1()
        {
            InitializeComponent();
            finalResult = result = 0.0;
            op = nextOp = "";
            op_pressed = sum_pressed = sub_pressed = enter_clicked = false;
        }

        /// 숫자버튼(0~9) 를 클릭했을때 발생하는 이벤트 *****
        private void button0_Click(object sender, EventArgs e) 
        {
            if (calcStr.Text == "0" || op_pressed) // 연산자 이후에 숫자를 입력받는 경우.
            {
                calcStr.Clear();
                op_pressed = false;
            }
            if (enter_clicked && !op_pressed) // enter쳐서 계산이 완료된 시점에서 숫자를 누른다면, 초기화 한 후, 새로운 계산 시작
                initializeForm();

            // 일반적인 경우.
            // 두 개의 TextBox에 입력된 값을 넣습니다.
            Button btn = (Button)sender;
            calcStr.Text = calcStr.Text + btn.Text;
            str.Text = str.Text + btn.Text;
            op_pressed = false;
            enter_clicked = false;
        }

        /// backspace 버튼을 클릭했을때 발생하는 이벤트 *****
        private void backspaceBtn_Click(object sender, EventArgs e) 
        {
            if (enter_clicked || op_pressed) // 직전에 엔터/연산자를 입력했었다면, 지울것이 없으므로 무시.
                return;

            if (double.Parse(calcStr.Text) < 10.0) // 현재 지우려는 값이 10 미만이면, 그냥 0으로 세팅.
            {
                calcStr.Text = "0";
                str.Text = str.Text.Remove(str.Text.Length - 1);
                str.Text += "0";
                return;
            }
            // 일반적인 경우.
            // 입력받았던 숫자에서 1의 자리수를 지워줍니다. (/10)
            else
            {
                str.Text = str.Text.Remove(str.Text.Length - 1);
                calcStr.Text = calcStr.Text.Remove(calcStr.Text.Length - 1);
            }
        }

        /// CE 버튼을 클릭했을때 발생하는 이벤트 *****
        private void clrBtn_Click(object sender, EventArgs e)
        {
            // 모든값을 초기화 시켜줍니다.
            calcStr.Text = "0";
            str.Text = "";
            result = 0.0;
            finalResult = 0.0;
            op = nextOp = "";
            op_pressed = sum_pressed = sub_pressed = false;
        }

        /// 엔터 버튼을 클릭했을때 발생하는 이벤트 *****
        private void enterBtn_Click(object sender, EventArgs e)
        {
            // 엔터를 입력하면 마지막 연산(nextOp에 저장된 연산자)을 수행하고 결과값을 표시합니다.
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

            SaveStatus(); // 이어서 새로운 연산을 시작할 경우에 대비하여 현재 상태 저장.
            
            enter_clicked = true;
        }

        /// 연산자 버튼을 클릭했을때 발생하는 이벤트 *****
        private void operand_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (enter_clicked) // 엔터를 누른 후 첫 입력이 연산자라면, 엔터의 결과로 생성된 결과값을 사용하여 새로운 연산 시작.
            {
                initializeForm();
                calcStr.Text = str.Text = tempData.calcStr;
            }
            enter_clicked = false;

            if (op_pressed) // 이미 연산자가 눌린 상태에서 연달아 연산자를 누른 경우라면,  연산자만 변경해야 합니다.
            {
                str.Text = str.Text.Remove(str.Text.Length - 1);
                str.Text = str.Text + btn.Text;

                // +,- 에서 *,/ 로, 또는 그 반대로 변하는 경우, 문제가 생기므로 따로 처리합니다.
                // (+,- -> +,- 또는 *,/ -> *,/ 의 경우는 안전하므로 pass)
                if (!IsEqualOp(btn.Text, nextOp)) 
                {
                    LoadStatus(tempData); // 직전에 저장된 데이터를 불러와서 */ 연산으로 새로수행.
                    operand_Click(sender, e);
                }
                nextOp = btn.Text;
                return;
            }
            
            SaveStatus(); // 연산자가 후에 바뀔 경우에 대비하여 상태저장.

            // 프로그램 실행 후 첫 연산자 클릭이라면, 연산 없이 변수값 update 후 return
            if (nextOp.Equals("")) { 
                if (str.Text.Equals("")) // 숫자입력없이 연산자 누른경우, 0 + 와 같은 식으로 0을 대상으로 연산을 진행합니다.
                    TextBoxAppend(ref str, "0");

                result = (finalResult == 0.0) ? (double.Parse(calcStr.Text)) : 0.0; // = (enter) 기호 클릭 후 이어서 연산 진행하는 경우와 구분하기 위함
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
            str.Text = str.Text + btn.Text;

            // 예외 처리 끝. 실제 연산 수행
            switch (nextOp)
            {
                case "+":
                case "-":
                    //if(직전 연산자가 */ 이면) 마저 수행하고 result더해줍니다. 
                    //else 직전에도 +-였으면, 단순히 현재 입력값을 더하거나 빼줍니다.

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
                    break;
            }
        }
        
        /// TextBox의 Text에 값을 간편하게 넣기 위한 함수. 중요하지 않음
        private void TextBoxAppend(ref System.Windows.Forms.TextBox box, string orgin)
        {
            box.Text = box.Text + orgin;
        }

        /// 넘겨받은 연산자에 따라 그에 맞는 연산을 알아서 해주는 function
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

        /// 연산자 비교를 간단히 하기 위해만든 function
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
        
        /// tempData객체에 현재 상태를 store합니다.
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

        /// tempData객체의 정보를 load합니다.
        private void LoadStatus(Calc c)
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

        /// form을 초기화 하는 function
        private void initializeForm()
        {
            finalResult = result = 0.0;
            op = nextOp = "";
            op_pressed = sum_pressed = sub_pressed = enter_clicked = false;
            str.Text =  "";
            calcStr.Text = "";
        }

        private void str_TextChanged(object sender, EventArgs e) { return; }

        ///  keyboard input을 처리하기 위한 함수입니다. key press event가 발생하면 해당하는 키의 click event handler와 연결시켜줍니다.
        private void button0_KeyDown(object sender, KeyEventArgs e)
        {
            string input = e.KeyData.ToString();
            Button btn = new Button();
            object obj;
            switch (input)
            {
                case "D1":
                case "NumPad1":
                case "D2":
                case "NumPad2":
                case "D3":
                case "NumPad3":
                case "D4":
                case "NumPad4":
                case "D5":
                case "NumPad5":
                case "D6":
                case "NumPad6":
                case "D7":
                case "NumPad7":
                case "D8":
                case "NumPad8":
                case "D9":
                case "NumPad9":
                case "D0":
                case "NumPad0":
                    btn.Text = input.Last().ToString();
                    obj = (object)btn;
                    button0_Click(obj, null);
                    break;
                case "Multiply":
                    btn.Text = "*";
                    obj = (object)btn;
                    operand_Click(obj, null);
                    break;
                case "Divide":
                    btn.Text = "/";
                    obj = (object)btn;
                    operand_Click(obj, null);
                    break;
                case "Add":
                    btn.Text = "+";
                    obj = (object)btn;
                    operand_Click(obj, null);
                    break;
                case "Subtract":
                    btn.Text = "-";
                    obj = (object)btn;
                    operand_Click(obj, null);
                    break;
                case "Enter":
                    enterBtn_Click(null, null);
                    break;
                case "Back":
                    backspaceBtn_Click(null, null);
                    break;
                case "Delete":
                    clrBtn_Click(null, null);
                    break;
                default:
                    break;
            }
            
        }
    }
}