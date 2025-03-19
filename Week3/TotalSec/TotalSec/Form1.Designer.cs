namespace TotalSec
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
            this.textBox_TotalSec = new System.Windows.Forms.TextBox();
            this.textBox_Hour = new System.Windows.Forms.TextBox();
            this.textBox_Min = new System.Windows.Forms.TextBox();
            this.textBox_Sec = new System.Windows.Forms.TextBox();
            this.button_HMN = new System.Windows.Forms.Button();
            this.button_TotalSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_TotalSec
            // 
            this.textBox_TotalSec.Location = new System.Drawing.Point(34, 81);
            this.textBox_TotalSec.Name = "textBox_TotalSec";
            this.textBox_TotalSec.Size = new System.Drawing.Size(82, 21);
            this.textBox_TotalSec.TabIndex = 0;
            this.textBox_TotalSec.Text = "10000";
            // 
            // textBox_Hour
            // 
            this.textBox_Hour.Location = new System.Drawing.Point(258, 35);
            this.textBox_Hour.Name = "textBox_Hour";
            this.textBox_Hour.Size = new System.Drawing.Size(82, 21);
            this.textBox_Hour.TabIndex = 1;
            // 
            // textBox_Min
            // 
            this.textBox_Min.Location = new System.Drawing.Point(258, 81);
            this.textBox_Min.Name = "textBox_Min";
            this.textBox_Min.Size = new System.Drawing.Size(82, 21);
            this.textBox_Min.TabIndex = 2;
            // 
            // textBox_Sec
            // 
            this.textBox_Sec.Location = new System.Drawing.Point(258, 126);
            this.textBox_Sec.Name = "textBox_Sec";
            this.textBox_Sec.Size = new System.Drawing.Size(82, 21);
            this.textBox_Sec.TabIndex = 3;
            // 
            // button_HMN
            // 
            this.button_HMN.Location = new System.Drawing.Point(153, 55);
            this.button_HMN.Name = "button_HMN";
            this.button_HMN.Size = new System.Drawing.Size(54, 35);
            this.button_HMN.TabIndex = 4;
            this.button_HMN.Text = ">>";
            this.button_HMN.UseVisualStyleBackColor = true;
            this.button_HMN.Click += new System.EventHandler(this.button_HMN_Click);
            // 
            // button_TotalSec
            // 
            this.button_TotalSec.Location = new System.Drawing.Point(153, 96);
            this.button_TotalSec.Name = "button_TotalSec";
            this.button_TotalSec.Size = new System.Drawing.Size(54, 35);
            this.button_TotalSec.TabIndex = 5;
            this.button_TotalSec.Text = "<<";
            this.button_TotalSec.UseVisualStyleBackColor = true;
            this.button_TotalSec.Click += new System.EventHandler(this.button_TotalSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "TotalSec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 212);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_TotalSec);
            this.Controls.Add(this.button_HMN);
            this.Controls.Add(this.textBox_Sec);
            this.Controls.Add(this.textBox_Min);
            this.Controls.Add(this.textBox_Hour);
            this.Controls.Add(this.textBox_TotalSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TotalSec;
        private System.Windows.Forms.TextBox textBox_Hour;
        private System.Windows.Forms.TextBox textBox_Min;
        private System.Windows.Forms.TextBox textBox_Sec;
        private System.Windows.Forms.Button button_HMN;
        private System.Windows.Forms.Button button_TotalSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

