namespace 비트계산기
{
    partial class Form1
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
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_Index = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_On = new System.Windows.Forms.Button();
            this.button_Off = new System.Windows.Forms.Button();
            this.button_Toggle = new System.Windows.Forms.Button();
            this.button_ShiftUp = new System.Windows.Forms.Button();
            this.button_ShiftDown = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Bits = new System.Windows.Forms.GroupBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Bits.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(12, 12);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(72, 21);
            this.textBox_Number.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_Index
            // 
            this.textbox_Index.Location = new System.Drawing.Point(12, 115);
            this.textbox_Index.Name = "textbox_Index";
            this.textbox_Index.Size = new System.Drawing.Size(72, 21);
            this.textbox_Index.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_On
            // 
            this.button_On.Location = new System.Drawing.Point(123, 115);
            this.button_On.Name = "button_On";
            this.button_On.Size = new System.Drawing.Size(74, 34);
            this.button_On.TabIndex = 6;
            this.button_On.Text = "On";
            this.button_On.UseVisualStyleBackColor = true;
            this.button_On.Click += new System.EventHandler(this.button_On_Click);
            // 
            // button_Off
            // 
            this.button_Off.Location = new System.Drawing.Point(123, 155);
            this.button_Off.Name = "button_Off";
            this.button_Off.Size = new System.Drawing.Size(74, 34);
            this.button_Off.TabIndex = 7;
            this.button_Off.Text = "Off";
            this.button_Off.UseVisualStyleBackColor = true;
            this.button_Off.Click += new System.EventHandler(this.button_Off_Click);
            // 
            // button_Toggle
            // 
            this.button_Toggle.Location = new System.Drawing.Point(123, 195);
            this.button_Toggle.Name = "button_Toggle";
            this.button_Toggle.Size = new System.Drawing.Size(74, 34);
            this.button_Toggle.TabIndex = 8;
            this.button_Toggle.Text = "Toggle";
            this.button_Toggle.UseVisualStyleBackColor = true;
            this.button_Toggle.Click += new System.EventHandler(this.button_Toggle_Click);
            // 
            // button_ShiftUp
            // 
            this.button_ShiftUp.Location = new System.Drawing.Point(12, 259);
            this.button_ShiftUp.Name = "button_ShiftUp";
            this.button_ShiftUp.Size = new System.Drawing.Size(87, 34);
            this.button_ShiftUp.TabIndex = 9;
            this.button_ShiftUp.Text = "ShiftUp";
            this.button_ShiftUp.UseVisualStyleBackColor = true;
            this.button_ShiftUp.Click += new System.EventHandler(this.button_ShiftUp_Click);
            // 
            // button_ShiftDown
            // 
            this.button_ShiftDown.Location = new System.Drawing.Point(110, 259);
            this.button_ShiftDown.Name = "button_ShiftDown";
            this.button_ShiftDown.Size = new System.Drawing.Size(87, 34);
            this.button_ShiftDown.TabIndex = 10;
            this.button_ShiftDown.Text = "ShiftDown";
            this.button_ShiftDown.UseVisualStyleBackColor = true;
            this.button_ShiftDown.Click += new System.EventHandler(this.button_ShiftDown_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 221);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 16);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Bits
            // 
            this.Bits.Controls.Add(this.checkBox0);
            this.Bits.Controls.Add(this.checkBox7);
            this.Bits.Controls.Add(this.checkBox6);
            this.Bits.Controls.Add(this.checkBox5);
            this.Bits.Controls.Add(this.checkBox4);
            this.Bits.Controls.Add(this.checkBox3);
            this.Bits.Controls.Add(this.checkBox2);
            this.Bits.Controls.Add(this.checkBox1);
            this.Bits.Location = new System.Drawing.Point(225, 12);
            this.Bits.Name = "Bits";
            this.Bits.Size = new System.Drawing.Size(85, 281);
            this.Bits.TabIndex = 12;
            this.Bits.TabStop = false;
            this.Bits.Text = "Bits";
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Location = new System.Drawing.Point(19, 247);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(30, 16);
            this.checkBox0.TabIndex = 18;
            this.checkBox0.Text = "0";
            this.checkBox0.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(19, 20);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(30, 16);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.Text = "7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(19, 58);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(30, 16);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(19, 94);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(30, 16);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(19, 130);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(30, 16);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 161);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(30, 16);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 193);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 16);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 332);
            this.Controls.Add(this.Bits);
            this.Controls.Add(this.button_ShiftDown);
            this.Controls.Add(this.button_ShiftUp);
            this.Controls.Add(this.button_Toggle);
            this.Controls.Add(this.button_Off);
            this.Controls.Add(this.button_On);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textbox_Index);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Bits.ResumeLayout(false);
            this.Bits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_Index;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_On;
        private System.Windows.Forms.Button button_Off;
        private System.Windows.Forms.Button button_Toggle;
        private System.Windows.Forms.Button button_ShiftUp;
        private System.Windows.Forms.Button button_ShiftDown;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox Bits;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

