namespace constructer
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
            this.button_catMaker = new System.Windows.Forms.Button();
            this.button_catN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_catMaker
            // 
            this.button_catMaker.Location = new System.Drawing.Point(287, 60);
            this.button_catMaker.Name = "button_catMaker";
            this.button_catMaker.Size = new System.Drawing.Size(122, 84);
            this.button_catMaker.TabIndex = 0;
            this.button_catMaker.Text = "cat만들기";
            this.button_catMaker.UseVisualStyleBackColor = true;
            this.button_catMaker.Click += new System.EventHandler(this.button_catMaker_Click);
            // 
            // button_catN
            // 
            this.button_catN.Location = new System.Drawing.Point(287, 191);
            this.button_catN.Name = "button_catN";
            this.button_catN.Size = new System.Drawing.Size(122, 84);
            this.button_catN.TabIndex = 1;
            this.button_catN.Text = "Num Cat";
            this.button_catN.UseVisualStyleBackColor = true;
            this.button_catN.Click += new System.EventHandler(this.button_catN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_catN);
            this.Controls.Add(this.button_catMaker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_catMaker;
        private System.Windows.Forms.Button button_catN;
        private System.Windows.Forms.Label label1;
    }
}

