using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace calcV2
{
    public class Calc
    {
        public double finalResult, result;
        public string op, nextOp;
        public bool op_pressed, sum_pressed, sub_pressed, enter_clicked;
        public string calcStr, str;

        public Calc()
        {
            finalResult = result = 0.0;
            op = nextOp = "";
            op_pressed = sum_pressed = sub_pressed = enter_clicked = false;
            calcStr = str = "";
        }
        public void SetCalc(Calc c)
        {
            this.finalResult = c.finalResult;
            this.result = c.result;
            this.op = c.op;
            this.nextOp = c.nextOp;
            this.op_pressed = c.op_pressed;
            this.sum_pressed = c.sum_pressed;
            this.sub_pressed = c.sub_pressed;
            this.enter_clicked = c.enter_clicked;
            this.calcStr = c.calcStr;
            this.str = c.str;
        }
    }
}
