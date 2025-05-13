using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatArduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                success = SPort.OpenPorts(serialPort, Convert.ToInt32(txtPortNum.Text));
            }
            catch
            { }

            if (success)
            {
                btnOpen.Enabled = false;
                btnSend.Enabled = true;
            }
            else { MessageBox.Show("시리얼포트를 열지 못했습니다", "오류"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SPort.GetPortsList();

            lblCOMs.Text = "";
            for (int i = 0; i < ports.Length; i++)
            {
                lblCOMs.Text = lblCOMs.Text + ports[i] + "\r\n";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtDialog.Text.Length > 1200) txtDialog.Text = "";

            string st = txtInput.Text.Trim();
            if (st.Length == 0) return;

            st = st + "\r\n";
            SPort.Send(serialPort, st);

            txtDialog.Text += "[PC] " + st;
            txtInput.Text = "";
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //편지함에 편지가 도착하면 자동으로 받아옴
            if (txtDialog.Text.Length > 1200) txtDialog.Text = ""; //글자수가 1200자 넘으면 지워라

            string inp = SPort.Read(serialPort); //sport안의 read 함수. string으로 읽어라. 편지를 보내는 순간 편지함에서는 편지는 지워져
            //txtDialog.Text += "[Arduino] " + inp;  // 다른 쓰레드여서 오류. 요 함수는 다른 쓰레드에 있어서. 그런데 txtDialog는 UI쓰레드
            txtDialog.Invoke((MethodInvoker)(() => txtDialog.Text += "[Arduino] " + inp));  // 다른 쓰레드에서는 Invoke를 사용해서 작업을 위임
        }
    }
}
