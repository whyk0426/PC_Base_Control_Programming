namespace week5_assignment
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label_RealRatio = new System.Windows.Forms.Label();
            this.label_IN = new System.Windows.Forms.Label();
            this.label_OUT = new System.Windows.Forms.Label();
            this.label_MonteRatio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(527, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(74, 66);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_RealRatio
            // 
            this.label_RealRatio.AutoSize = true;
            this.label_RealRatio.Location = new System.Drawing.Point(532, 100);
            this.label_RealRatio.Name = "label_RealRatio";
            this.label_RealRatio.Size = new System.Drawing.Size(38, 12);
            this.label_RealRatio.TabIndex = 2;
            this.label_RealRatio.Text = "label1";
            // 
            // label_IN
            // 
            this.label_IN.AutoSize = true;
            this.label_IN.Location = new System.Drawing.Point(532, 125);
            this.label_IN.Name = "label_IN";
            this.label_IN.Size = new System.Drawing.Size(38, 12);
            this.label_IN.TabIndex = 3;
            this.label_IN.Text = "label2";
            // 
            // label_OUT
            // 
            this.label_OUT.AutoSize = true;
            this.label_OUT.Location = new System.Drawing.Point(532, 150);
            this.label_OUT.Name = "label_OUT";
            this.label_OUT.Size = new System.Drawing.Size(38, 12);
            this.label_OUT.TabIndex = 4;
            this.label_OUT.Text = "label3";
            // 
            // label_MonteRatio
            // 
            this.label_MonteRatio.AutoSize = true;
            this.label_MonteRatio.Location = new System.Drawing.Point(532, 175);
            this.label_MonteRatio.Name = "label_MonteRatio";
            this.label_MonteRatio.Size = new System.Drawing.Size(38, 12);
            this.label_MonteRatio.TabIndex = 5;
            this.label_MonteRatio.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 530);
            this.Controls.Add(this.label_MonteRatio);
            this.Controls.Add(this.label_OUT);
            this.Controls.Add(this.label_IN);
            this.Controls.Add(this.label_RealRatio);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_RealRatio;
        private System.Windows.Forms.Label label_IN;
        private System.Windows.Forms.Label label_OUT;
        private System.Windows.Forms.Label label_MonteRatio;
    }
}

