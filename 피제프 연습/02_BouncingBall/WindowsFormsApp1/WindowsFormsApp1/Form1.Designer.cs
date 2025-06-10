namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.Slow = new System.Windows.Forms.RadioButton();
            this.Fast = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Slow
            // 
            this.Slow.AutoSize = true;
            this.Slow.Checked = true;
            this.Slow.Location = new System.Drawing.Point(421, 12);
            this.Slow.Name = "Slow";
            this.Slow.Size = new System.Drawing.Size(51, 16);
            this.Slow.TabIndex = 0;
            this.Slow.TabStop = true;
            this.Slow.Text = "Slow";
            this.Slow.UseVisualStyleBackColor = true;
            this.Slow.CheckedChanged += new System.EventHandler(this.Slow_CheckedChanged);
            // 
            // Fast
            // 
            this.Fast.AutoSize = true;
            this.Fast.Location = new System.Drawing.Point(421, 34);
            this.Fast.Name = "Fast";
            this.Fast.Size = new System.Drawing.Size(47, 16);
            this.Fast.TabIndex = 1;
            this.Fast.Text = "Fast";
            this.Fast.UseVisualStyleBackColor = true;
            this.Fast.CheckedChanged += new System.EventHandler(this.Fast_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Blue;
            this.Ball.Location = new System.Drawing.Point(303, 189);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Fast);
            this.Controls.Add(this.Slow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Slow;
        private System.Windows.Forms.RadioButton Fast;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Ball;
    }
}

