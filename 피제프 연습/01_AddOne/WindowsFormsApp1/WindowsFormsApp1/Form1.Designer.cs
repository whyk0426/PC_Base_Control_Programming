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
            this.Reset = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Increment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(303, 51);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(85, 69);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(303, 155);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(85, 69);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Increment
            // 
            this.Increment.Location = new System.Drawing.Point(303, 262);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(85, 69);
            this.Increment.TabIndex = 2;
            this.Increment.Text = "Increment";
            this.Increment.UseVisualStyleBackColor = true;
            this.Increment.Click += new System.EventHandler(this.Increment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(52, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 383);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Reset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Increment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

