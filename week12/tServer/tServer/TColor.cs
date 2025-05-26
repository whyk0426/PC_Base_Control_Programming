using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

static class TComm
{
    //===========================================================
    //  통신에 성공하면 true 리턴
    //===========================================================
    public static bool AskDigitalInput(TServer ServerComm, out int red, out int green, out int blue)
    {
        // 수신버퍼 청소
        string dum = ServerComm.GetRcvMsg();

        // 명령 송신
        string st = TSocket.sSTX() + "RK" + TSocket.sETX();
        ServerComm.ServerSend(st);

        // 송신시간 기록
        DateTime stime = DateTime.Now;

        // 수신 대기
        int idx1, idx2, r = 0, g = 0, b = 0;
        bool success = false;
        string rbuff = "";
        while (true)
        {
            // timeout 검사
            double dtime = Util.TimeInSeconds(stime);
            if (dtime > 0.5) break;

            // 수신 버퍼 검사
            rbuff += ServerComm.GetRcvMsg();

            idx1 = rbuff.IndexOf(TSocket.sACK());
            if (idx1 >= 0)
            {
                idx2 = rbuff.IndexOf(TSocket.sETX(), idx1);

                if (idx2 - idx1 >= 8)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "RK")
                    {
                        string dd = rbuff.Substring(idx1 + 3, idx2 - idx1 - 3);
                        string[] rgb = dd.Split(',');
                        r = Convert.ToInt32(rgb[0]);
                        g = Convert.ToInt32(rgb[1]);
                        b = Convert.ToInt32(rgb[2]);
                        success = true;
                        break;
                    }
                }
            }
        }
        if (success)
        {
            red = r;
            green = g;
            blue = b;
        }
        else
        {
            red = 0;
            green = 0;
            blue = 0;
        }
        return success;
    }
}
