namespace Monte
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
            this.picArea = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label_RatioReal = new System.Windows.Forms.Label();
            this.label_IN = new System.Windows.Forms.Label();
            this.label_OUT = new System.Windows.Forms.Label();
            this.label_RatioMonte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).BeginInit();
            this.SuspendLayout();
            // 
            // picArea
            // 
            this.picArea.BackColor = System.Drawing.SystemColors.Window;
            this.picArea.Location = new System.Drawing.Point(12, 12);
            this.picArea.Name = "picArea";
            this.picArea.Size = new System.Drawing.Size(425, 426);
            this.picArea.TabIndex = 0;
            this.picArea.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(443, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(77, 57);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_RatioReal
            // 
            this.label_RatioReal.AutoSize = true;
            this.label_RatioReal.Location = new System.Drawing.Point(453, 98);
            this.label_RatioReal.Name = "label_RatioReal";
            this.label_RatioReal.Size = new System.Drawing.Size(38, 12);
            this.label_RatioReal.TabIndex = 2;
            this.label_RatioReal.Text = "label1";
            // 
            // label_IN
            // 
            this.label_IN.AutoSize = true;
            this.label_IN.Location = new System.Drawing.Point(453, 128);
            this.label_IN.Name = "label_IN";
            this.label_IN.Size = new System.Drawing.Size(38, 12);
            this.label_IN.TabIndex = 3;
            this.label_IN.Text = "label2";
            // 
            // label_OUT
            // 
            this.label_OUT.AutoSize = true;
            this.label_OUT.Location = new System.Drawing.Point(453, 162);
            this.label_OUT.Name = "label_OUT";
            this.label_OUT.Size = new System.Drawing.Size(38, 12);
            this.label_OUT.TabIndex = 4;
            this.label_OUT.Text = "label3";
            // 
            // label_RatioMonte
            // 
            this.label_RatioMonte.AutoSize = true;
            this.label_RatioMonte.Location = new System.Drawing.Point(453, 196);
            this.label_RatioMonte.Name = "label_RatioMonte";
            this.label_RatioMonte.Size = new System.Drawing.Size(38, 12);
            this.label_RatioMonte.TabIndex = 5;
            this.label_RatioMonte.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.label_RatioMonte);
            this.Controls.Add(this.label_OUT);
            this.Controls.Add(this.label_IN);
            this.Controls.Add(this.label_RatioReal);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.picArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picArea;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_RatioReal;
        private System.Windows.Forms.Label label_IN;
        private System.Windows.Forms.Label label_OUT;
        private System.Windows.Forms.Label label_RatioMonte;
    }
}

