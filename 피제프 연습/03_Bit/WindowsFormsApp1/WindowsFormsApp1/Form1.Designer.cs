﻿namespace WindowsFormsApp1
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnToBit = new System.Windows.Forms.Button();
            this.btnFromBit = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnShiftUp = new System.Windows.Forms.Button();
            this.btnShiftDown = new System.Windows.Forms.Button();
            this.chk0 = new System.Windows.Forms.CheckBox();
            this.BITS = new System.Windows.Forms.GroupBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.BITS.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(31, 31);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 21);
            this.txtNumber.TabIndex = 0;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(31, 133);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 21);
            this.txtIndex.TabIndex = 1;
            // 
            // btnToBit
            // 
            this.btnToBit.Location = new System.Drawing.Point(198, 21);
            this.btnToBit.Name = "btnToBit";
            this.btnToBit.Size = new System.Drawing.Size(75, 39);
            this.btnToBit.TabIndex = 2;
            this.btnToBit.Text = ">>";
            this.btnToBit.UseVisualStyleBackColor = true;
            this.btnToBit.Click += new System.EventHandler(this.btnToBit_Click);
            // 
            // btnFromBit
            // 
            this.btnFromBit.Location = new System.Drawing.Point(198, 66);
            this.btnFromBit.Name = "btnFromBit";
            this.btnFromBit.Size = new System.Drawing.Size(75, 39);
            this.btnFromBit.TabIndex = 3;
            this.btnFromBit.Text = "<<";
            this.btnFromBit.UseVisualStyleBackColor = true;
            this.btnFromBit.Click += new System.EventHandler(this.btnFromBit_Click);
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(198, 129);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(75, 39);
            this.btnON.TabIndex = 4;
            this.btnON.Text = "ON";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Location = new System.Drawing.Point(198, 174);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(75, 39);
            this.btnOFF.TabIndex = 5;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(198, 219);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 39);
            this.btnToggle.TabIndex = 6;
            this.btnToggle.Text = "Toggle";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnShiftUp
            // 
            this.btnShiftUp.Location = new System.Drawing.Point(31, 306);
            this.btnShiftUp.Name = "btnShiftUp";
            this.btnShiftUp.Size = new System.Drawing.Size(100, 39);
            this.btnShiftUp.TabIndex = 7;
            this.btnShiftUp.Text = "ShiftUp";
            this.btnShiftUp.UseVisualStyleBackColor = true;
            this.btnShiftUp.Click += new System.EventHandler(this.btnShiftUp_Click);
            // 
            // btnShiftDown
            // 
            this.btnShiftDown.Location = new System.Drawing.Point(173, 306);
            this.btnShiftDown.Name = "btnShiftDown";
            this.btnShiftDown.Size = new System.Drawing.Size(100, 39);
            this.btnShiftDown.TabIndex = 8;
            this.btnShiftDown.Text = "ShiftDown";
            this.btnShiftDown.UseVisualStyleBackColor = true;
            this.btnShiftDown.Click += new System.EventHandler(this.btnShiftDown_Click);
            // 
            // chk0
            // 
            this.chk0.AutoSize = true;
            this.chk0.Location = new System.Drawing.Point(18, 312);
            this.chk0.Name = "chk0";
            this.chk0.Size = new System.Drawing.Size(30, 16);
            this.chk0.TabIndex = 9;
            this.chk0.Text = "0";
            this.chk0.UseVisualStyleBackColor = true;
            // 
            // BITS
            // 
            this.BITS.Controls.Add(this.chk7);
            this.BITS.Controls.Add(this.chk6);
            this.BITS.Controls.Add(this.chk0);
            this.BITS.Controls.Add(this.chk5);
            this.BITS.Controls.Add(this.chk1);
            this.BITS.Controls.Add(this.chk4);
            this.BITS.Controls.Add(this.chk2);
            this.BITS.Controls.Add(this.chk3);
            this.BITS.Location = new System.Drawing.Point(313, 21);
            this.BITS.Name = "BITS";
            this.BITS.Size = new System.Drawing.Size(68, 353);
            this.BITS.TabIndex = 10;
            this.BITS.TabStop = false;
            this.BITS.Text = "BITS";
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(18, 272);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(30, 16);
            this.chk1.TabIndex = 10;
            this.chk1.Text = "1";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(18, 234);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(30, 16);
            this.chk2.TabIndex = 11;
            this.chk2.Text = "2";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(18, 193);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(30, 16);
            this.chk3.TabIndex = 12;
            this.chk3.Text = "3";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(18, 157);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(30, 16);
            this.chk4.TabIndex = 13;
            this.chk4.Text = "4";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(18, 117);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(30, 16);
            this.chk5.TabIndex = 14;
            this.chk5.Text = "5";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(18, 72);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(30, 16);
            this.chk6.TabIndex = 15;
            this.chk6.Text = "6";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(18, 35);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(30, 16);
            this.chk7.TabIndex = 16;
            this.chk7.Text = "7";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 408);
            this.Controls.Add(this.BITS);
            this.Controls.Add(this.btnShiftDown);
            this.Controls.Add(this.btnShiftUp);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.btnFromBit);
            this.Controls.Add(this.btnToBit);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BITS.ResumeLayout(false);
            this.BITS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnToBit;
        private System.Windows.Forms.Button btnFromBit;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnShiftUp;
        private System.Windows.Forms.Button btnShiftDown;
        private System.Windows.Forms.CheckBox chk0;
        private System.Windows.Forms.GroupBox BITS;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
    }
}

