﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tClient
{
    public partial class Form1 : Form
    {
        private TClient clientChat; //채팅용
        private TClient clientCopy; //원위치복사용
        private TClient clientComm; //비트통신용
        private TClient clientColor;

        private string rbuffcol = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hostname = TSocket.HostName();
            IPAddress[] addrs = TSocket.HostAddresses();

            string st = hostname + "\r\n";
            for (int i = 0; i < addrs.Length; i++)
            {
                st = st + addrs[i].ToString() + "\r\n";
            }

            lblComInfo.Text = st;

            btnServerMe.PerformClick();
        }

        private void btnServerMe_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = TSocket.HostAddressesv4().ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (clientChat != null) clientChat.ClientClose();
            if (clientCopy != null) clientCopy.ClientClose();
            if (clientComm != null) clientComm.ClientClose();
            if (clientColor != null) clientColor.ClientClose();
        }

        private void timConnStatus_Tick(object sender, EventArgs e)
        {
            if (clientChat == null) { lblConnChat.Text = "Chat : " + "NULL"; }
            else
            {
                csConnStatus conn = clientChat.ClientStatus();
                lblConnChat.Text = "Chat : " + conn.ToString();
            }

            if (clientCopy == null) { lblConnCopy.Text = "Copy : " + "NULL"; }
            else
            {
                csConnStatus conn = clientCopy.ClientStatus();
                lblConnCopy.Text = "Copy : " + conn.ToString();
            }

            if (clientComm == null) { lblConnComm.Text = "Comm : " + "NULL"; }
            else
            {
                csConnStatus conn = clientComm.ClientStatus();
                lblConnComm.Text = "Comm : " + conn.ToString();
            }
            
            if (clientColor == null) { lblConnColor.Text = "Color : " + "NULL"; }
            else
            {
                csConnStatus conn = clientColor.ClientStatus();
                lblConnColor.Text = "Color : " + conn.ToString();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string serverIP = txtServerIP.Text;
            string clientIP = TSocket.HostAddressesv4().ToString();

            if (clientChat == null) clientChat = new TClient();
            clientChat.ClientBeginConnect(serverIP, 5000, clientIP);   // 1024~65535 추천

            if (clientCopy == null) clientCopy = new TClient();
            clientCopy.ClientBeginConnect(serverIP, 5001, clientIP);   // 1024~65535 추천

            if (clientComm == null) clientComm = new TClient();
            clientComm.ClientBeginConnect(serverIP, 5002, clientIP);   // 1024~65535 추천

            if (clientColor == null) clientColor = new TClient(AskingColorDataArrived);
            clientColor.ClientBeginConnect(serverIP, 5003, clientIP);
        }
        private void AskingColorDataArrived()
        {
            while (true)
            {
                rbuffcol += clientColor.GetRcvMsg();
                int idx1 = rbuffcol.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuffcol.IndexOf(TSocket.sETX(), idx1);

                if (idx2 - idx1 == 3)
                {
                    string stnet = rbuffcol.Substring(idx1 + 1, 2);
                    if (stnet == "RK")
                    {
                        string rgb = TSocket.sACK() + "RK" + Convert.ToString(hScrollBar1.Value) + "," + Convert.ToString(hScrollBar2.Value) + "," + Convert.ToString(hScrollBar3.Value) + TSocket.sETX();
                        clientColor.ClientSend(rgb);
                    }
                    // 처리한 곳까지 잘라내기
                    rbuffcol = rbuffcol.Substring(idx2 + 1);
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (clientChat == null) return;

            string st = txtSend.Text.Trim();
            if (st.Length <= 0) return;

            clientChat.ClientSend(st + "\r\n");
            txtDialog.Text += "[Me] " + st + "\r\n";
            txtSend.Text = "";
        }

        private void timGetRcvMsg_Tick(object sender, EventArgs e)
        {
            if (clientChat == null) return;
            string st = clientChat.GetRcvMsg();
            if (st.Length > 0) txtDialog.Text += st;
        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (clientCopy == null) return;

            if (e.Button != MouseButtons.Left) return;
            lblO.Left = e.X;
            lblO.Top = e.Y;

            string st = TSocket.sSTX() + Convert.ToString(e.X) +
                        "," + Convert.ToString(e.Y) + TSocket.sETX();
            clientCopy.ClientSend(st);
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (clientCopy == null) return;

            if (e.Button != MouseButtons.Left) return;
            lblO.Left = e.X;
            lblO.Top = e.Y;

            string st = TSocket.sSTX() + Convert.ToString(e.X) +
                        "," + Convert.ToString(e.Y) + TSocket.sETX();
            clientCopy.ClientSend(st);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') btnSend.PerformClick();
        }
        private void timAskBits_Tick(object sender, EventArgs e)
        {
            btnReadBits.PerformClick();
        }

        private void btnReadBits_Click_1(object sender, EventArgs e)
        {
            if (clientComm == null) return;
            if (clientComm.ClientStatus() != csConnStatus.Connected) return;

            bool success = TComm.AskDigitalInput(clientComm, out bool[] bits);
            if (success)
            {
                picLamp00.BackColor = bits[0] ? Color.GreenYellow : Color.Gray;
                picLamp01.BackColor = bits[1] ? Color.GreenYellow : Color.Gray;
                picLamp02.BackColor = bits[2] ? Color.GreenYellow : Color.Gray;
                picLamp03.BackColor = bits[3] ? Color.GreenYellow : Color.Gray;
                picLamp04.BackColor = bits[4] ? Color.GreenYellow : Color.Gray;
                picLamp05.BackColor = bits[5] ? Color.GreenYellow : Color.Gray;
                picLamp06.BackColor = bits[6] ? Color.GreenYellow : Color.Gray;
                picLamp07.BackColor = bits[7] ? Color.GreenYellow : Color.Gray;
            }
            lblCommOK.Text =
                        Convert.ToString(Convert.ToInt32(lblCommOK.Text) + 1);
        }

        private void timAskBits_Tick_1(object sender, EventArgs e)
        {
            btnReadBits.PerformClick();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            RedLabel.Text = Convert.ToString(hScrollBar1.Value);
            pictureBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            GreenLabel.Text = Convert.ToString(hScrollBar2.Value);
            pictureBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            BlueLabel.Text = Convert.ToString(hScrollBar3.Value);
            pictureBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }
    }
}
