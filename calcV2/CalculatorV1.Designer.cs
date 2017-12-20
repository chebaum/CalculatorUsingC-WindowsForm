namespace calcV2
{
    partial class CalculatorV1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcStr = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.sumBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.backspaceBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.str = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcStr
            // 
            this.calcStr.BackColor = System.Drawing.SystemColors.Window;
            this.calcStr.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.calcStr.Location = new System.Drawing.Point(12, 58);
            this.calcStr.Name = "calcStr";
            this.calcStr.ReadOnly = true;
            this.calcStr.Size = new System.Drawing.Size(325, 43);
            this.calcStr.TabIndex = 19;
            this.calcStr.Text = "0";
            this.calcStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.enterBtn.Location = new System.Drawing.Point(249, 366);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(88, 56);
            this.enterBtn.TabIndex = 17;
            this.enterBtn.Text = "=";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.divBtn.Location = new System.Drawing.Point(249, 304);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(88, 56);
            this.divBtn.TabIndex = 16;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.operand_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mulBtn.Location = new System.Drawing.Point(249, 242);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(88, 56);
            this.mulBtn.TabIndex = 15;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.operand_Click);
            // 
            // sumBtn
            // 
            this.sumBtn.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sumBtn.Location = new System.Drawing.Point(249, 118);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(88, 56);
            this.sumBtn.TabIndex = 14;
            this.sumBtn.Text = "+";
            this.sumBtn.UseVisualStyleBackColor = true;
            this.sumBtn.Click += new System.EventHandler(this.operand_Click);
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subBtn.Location = new System.Drawing.Point(249, 180);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(88, 56);
            this.subBtn.TabIndex = 13;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.operand_Click);
            // 
            // backspaceBtn
            // 
            this.backspaceBtn.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backspaceBtn.Location = new System.Drawing.Point(91, 366);
            this.backspaceBtn.Name = "backspaceBtn";
            this.backspaceBtn.Size = new System.Drawing.Size(152, 56);
            this.backspaceBtn.TabIndex = 12;
            this.backspaceBtn.Text = "backspace";
            this.backspaceBtn.UseVisualStyleBackColor = true;
            this.backspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(170, 180);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 56);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button0_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button8.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(91, 180);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 56);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button0_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clrBtn.Location = new System.Drawing.Point(12, 118);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(231, 56);
            this.clrBtn.TabIndex = 9;
            this.clrBtn.Text = "CE";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button7.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(12, 180);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 56);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button0_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(91, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 56);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button0_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(12, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button0_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(170, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 56);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button0_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(91, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(170, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(12, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 56);
            this.button1.TabIndex = 18;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button0_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button0.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button0.Location = new System.Drawing.Point(12, 366);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(73, 56);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // str
            // 
            this.str.BackColor = System.Drawing.SystemColors.Menu;
            this.str.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.str.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.str.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.str.Location = new System.Drawing.Point(12, 12);
            this.str.Name = "str";
            this.str.ReadOnly = true;
            this.str.Size = new System.Drawing.Size(325, 24);
            this.str.TabIndex = 19;
            this.str.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.str.TextChanged += new System.EventHandler(this.str_TextChanged);
            // 
            // CalculatorV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 443);
            this.Controls.Add(this.str);
            this.Controls.Add(this.calcStr);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.sumBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.backspaceBtn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Name = "Endas Calculator";
            this.Text = "Endas Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcStr;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button sumBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button backspaceBtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.TextBox str;
    }
}

