#define SIMUL
//#define REAL

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Serial_Analyzer_Custom
{
    public partial class FrmMain : Form
    {
        TcpClient tcpClient;
        byte[] mRx;
        byte[] mTx;

        private bool Connected { get => tcpClient == null ? false : tcpClient.Connected && bConnected; }

        bool bConnected    = false;
        bool isSendAutoChk = false;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            /*
            Bitmap bmp = new Bitmap("Resource\\Signal.bmp");

            int bmpX = 0;
            int bmpY = 0;

            Rectangle rect = new Rectangle(bmpX, bmpY, 16, 16);
            Bitmap cropBmp = cropAtRect(bmp, rect);

            imageList1.Images.AddStrip(cropBmp);

            pictureBoxRX.Image = imageList1.Images[0];
            //pictureBoxTX.Image = imageList1.Images[0];
            */



            // 세팅
#if SIMUL
            // 가상장비

            txtIP_1.Text = "192";
            txtIP_2.Text = "168";
            txtIP_3.Text = "192";
            txtIP_4.Text = "250";
            
#elif REAL
            // 실제장비
            
            txtIP_1.Text = "192";
            txtIP_2.Text = "168";
            txtIP_3.Text = "0";
            txtIP_4.Text = "200";
#endif          
            
            txtPort.Text = "2000";

            txtAutoAck.Text = "06";

            btnDisconn.Enabled = false;

            //rdoBtnEthernet_CheckedChanged(this, null);
            rdoBtnEthernet.Checked = true;
        }

        private void rdoBtnSerial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnSerial.Checked)
            {
                rdoBtnEthernet.Checked = false;

                grbEthernet.Enabled = false;
                grbSerial.Enabled = true;
            }
        }

        private void rdoBtnEthernet_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdoBtnEthernet.Checked)
            {
                rdoBtnSerial.Checked = false;

                grbEthernet.Enabled = true;
                grbSerial.Enabled = false;
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            // 시리얼 통신일 경우
            if (rdoBtnSerial.Checked)
            {

            }
            // 이더넷 통신일 경우
            else
            {
                connect();
            }
        }

        private void btnDisconn_Click(object sender, EventArgs e)
        {
            try
            {
                // 시리얼 통신일 경우
                if (rdoBtnSerial.Checked)
                {

                }
                // 이더넷 통신일 경우
                else
                {
                    if (tcpClient != null)
                    {
                        tcpClient.GetStream().Close();
                        tcpClient.Close();

                        btnConn.Invoke((MethodInvoker)delegate
                        {
                            btnConn.Enabled = true;
                        });

                        btnDisconn.Invoke((MethodInvoker)delegate
                        {
                            btnDisconn.Enabled = false;
                        });

                        grbEthernet.Invoke((MethodInvoker)delegate
                        {
                            grbEthernet.Enabled = true;
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 내용 작성 필요
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChecksumCal_Click(object sender, EventArgs e)
        {
            byte[] byteChecksumStr = ConvertHexStringToByte(rtxtChecksumStr.Text.Replace(" ", ""));
            byte byteChecksum      = CalCheckSum(byteChecksumStr, byteChecksumStr.Length);

            txtChecksum.Text       = byteChecksum.ToString("X");
        }

        /// <summary>
        /// [보낼 데이터, 복사] 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendCopy_Click(object sender, EventArgs e)
        {
            txtSend.Text = rtxtChecksumStr.Text + " " + txtChecksum.Text;
        }

        private void connect()
        {
            try
            {
                string strIP   = txtIP_1.Text + "." + txtIP_2.Text + "." + txtIP_3.Text + "." + txtIP_4.Text;
                string strPort = txtPort.Text;

                tcpClient = new TcpClient();
                tcpClient.BeginConnect(strIP, int.Parse(strPort), onCompleteConnect, tcpClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //throw new NotImplementedException();
        }

        private void onCompleteConnect(IAsyncResult iar)
        {
            TcpClient tcpc;

            try
            {
                //iar.AsyncWaitHandle.WaitOne(1000, false);

                tcpc = (TcpClient)iar.AsyncState;
                tcpc.EndConnect(iar);
                mRx = new byte[512];
                tcpc.GetStream().BeginRead(mRx, 0, mRx.Length, onCompleteReadFromServerStream, tcpc);
                
                bConnected = true; //연결 성공

                btnConn.Invoke((MethodInvoker) delegate
                {
                    btnConn.Enabled = false;
                });

                btnDisconn.Invoke((MethodInvoker) delegate
                {
                    btnDisconn.Enabled = true;
                });

                grbEthernet.Invoke((MethodInvoker)delegate
                {
                    grbEthernet.Enabled = false;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                bConnected = false; //연결 실패

                btnConn.Invoke((MethodInvoker)delegate
                {
                    btnConn.Enabled = true;
                });

                btnDisconn.Invoke((MethodInvoker)delegate
                {
                    btnDisconn.Enabled = false;
                });

                grbEthernet.Invoke((MethodInvoker)delegate
                {
                    grbEthernet.Enabled = true;
                });
            }

            //throw new NotImplementedException();
        }
        
        // [비동기] 서버에서 수신 후 응답
        private void onCompleteReadFromServerStream(IAsyncResult iar)
        {
            TcpClient tcpc;
            int nCountBytesReceivedFromServer;
            string strReceived;
            string byteReceived;

            try
            {
                if (!Connected)
                {
                    return;
                }
                else
                {
                    // [자동응답] 체크되어 있으면, 자동응답 패킷 전송
                    if (chkAutoAck.Checked && !isSendAutoChk)
                    {
                        isSendAutoChk = true;

                        WriteMessage(txtAutoAck.Text);

                        AppendRtxSendHex(txtAutoAck.Text);
                    }

                    tcpc = (TcpClient)iar.AsyncState;
                    nCountBytesReceivedFromServer = tcpc.GetStream().EndRead(iar);

                    if (nCountBytesReceivedFromServer == 0)
                    {
                        MessageBox.Show("Connection broken.");
                        return;
                    }

                    strReceived = Encoding.ASCII.GetString(mRx, 0, nCountBytesReceivedFromServer);
                    byteReceived = Encoding.Default.GetString(mRx, 0, nCountBytesReceivedFromServer);
                    //string s1 = Encoding.ASCII.GetString(mRx, 0, nCountBytesReceivedFromServer - 1);
                    //if (mRx[nCountBytesReceivedFromServer - 1] != '\n') return;

                    byte[] tRx = new byte[nCountBytesReceivedFromServer];

                    Array.Copy(mRx, 0, tRx, 0, nCountBytesReceivedFromServer);

                    //writeRichTextbox(rtxtRecvHex, ByteToHex(StringToByte(strReceived)));
                    writeRichTextbox(rtxtRecvHex, ConvertHexFormat(ByteToHex(tRx)));
                    writeRichTextbox(rtxtRecvAscii, ByteToString(tRx));


                    mRx = new byte[1024];
                    tcpc.GetStream().BeginRead(mRx, 0, mRx.Length, onCompleteReadFromServerStream, tcpc);
                    

                    /*
                    if (!chkAutoAck.Checked)
                    {
                        //WriteMessage(txtAutoAck.Text);

                        mRx = new byte[1024];
                        tcpc.GetStream().BeginRead(mRx, 0, mRx.Length, onCompleteReadFromServerStream, tcpc);
                    }
                    else
                    {
                        WriteMessage(txtAutoAck.Text);
                    }
                    */

                    bConnected = true; //연결 성공
                }

            }
            catch (Exception exc)
            {
                bConnected = false; //연결 실패
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //throw new NotImplementedException();
        }

        // [HEX 전송] 버튼 클릭
        private void btnSendHex_Click(object sender, EventArgs e)
        {
            isSendAutoChk = false;

            WriteMessage(txtSend.Text.Replace(" ", ""));

            AppendRtxSendHex(txtSend.Text.Replace(" ", ""));

            /*
            if (rtxtSendHex.Text.Length > 0)
            {
                rtxtSendHex.AppendText("\n");
            }

            rtxtSendHex.AppendText(ConvertHexFormat(txtSend.Text));
            */
        }

        

        private void btnProtocolClear_Click(object sender, EventArgs e)
        {
            rtxtChecksumStr.Clear();

            btnClear_Click(this, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtSendHex.Clear();
            rtxtRecvHex.Clear();
            rtxtRecvAscii.Clear();
        }

        private void WriteMessage(string message)
        {
            if (string.IsNullOrEmpty(txtSend.Text)) return;

            try
            {
                if (!Connected) return;

                //tx = Encoding.ASCII.GetBytes(txtSend.Text);
                mTx = ConvertHexStringToByte(message);

                if (tcpClient != null)
                {
                    if (tcpClient.Client.Connected)
                    {
                        tcpClient.GetStream().BeginWrite(mTx, 0, mTx.Length, onCompleteWriteToServer, tcpClient);
                    }
                }
            }
            catch (Exception exc)
            {
                bConnected = false;
                MessageBox.Show(exc.Message);
            }
        }

        // [비동기] 서버로 전송 후 응답
        private void onCompleteWriteToServer(IAsyncResult iar)
        {
            TcpClient tcpc;

            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                tcpc.GetStream().EndWrite(iar);
                //bCompleted = true;

            }
            catch (Exception exc)
            {
                //bCompleted = false;
                MessageBox.Show(exc.Message);
            }

            //throw new NotImplementedException();
        }

        private void AppendRtxSendHex(string msg)
        {
            /*
            if (rtxtSendHex.Text.Length > 0)
            {
                //rtxtSendHex.AppendText("\n");
                rtxtSendHex.Invoke((MethodInvoker)delegate { rtxtSendHex.AppendText("\n"); });
            }

            //rtxtSendHex.AppendText(ConvertHexFormat(msg));
            rtxtSendHex.Invoke((MethodInvoker)delegate { rtxtSendHex.AppendText(ConvertHexFormat(msg)); });
            */

            rtxtSendHex.Invoke((MethodInvoker)delegate
            {
                if (rtxtSendHex.Text.Length > 0)
                {
                    rtxtSendHex.AppendText("\n");
                }

                rtxtSendHex.AppendText(ConvertHexFormat(msg));
            });
        }

        /// <summary>
        /// RichTextBox 에 작성하는 함수
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <param name="str"></param>
        private void writeRichTextbox(RichTextBox richTextBox, string str)  // richTextbox1 에 쓰기 함수
        {
            richTextBox.Invoke((MethodInvoker)delegate { richTextBox.AppendText(str + "\r\n"); }); // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            richTextBox.Invoke((MethodInvoker)delegate { richTextBox.ScrollToCaret(); });  // 스크롤을 젤 밑으로.
        }

        /// <summary>
        /// Bitmap 크롭 함수
        /// </summary>
        /// <param name="orgImg"></param>
        /// <param name="sRect"></param>
        /// <returns></returns>
        public Bitmap cropAtRect(Bitmap orgImg, Rectangle sRect)
        {
            Rectangle destRect = new Rectangle(Point.Empty, sRect.Size);

            var cropImage = new Bitmap(destRect.Width, destRect.Height);
            using (var graphics = Graphics.FromImage(cropImage))
            {
                graphics.DrawImage(orgImg, destRect, sRect, GraphicsUnit.Pixel);
            }
            return cropImage;
        }

        // 바이트 배열을 String 으로 변환 
        private string ByteToString(byte[] strByte)
        {
            string str = Encoding.Default.GetString(strByte);
            return str;
        }

        // 바이트 배열을 HexString 으로 변환
        private string ByteToHex(byte[] ba)
        {
            StringBuilder sb = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                sb.AppendFormat("{0:X2}", b);
            }
            return sb.ToString();
        }

        // String을 바이트 배열로 변환 
        private byte[] StringToByte(string str)
        {
            byte[] StrByte = Encoding.UTF8.GetBytes(str);
            return StrByte;
        }

        /// <summary>
        /// 입력된 문자열, 바이트 배열로 변환하는 함수
        /// </summary>
        /// <param name="convertString"></param>
        /// <returns></returns>
        public static byte[] ConvertHexStringToByte(string convertString)
        {
            convertString     = convertString.Replace("\n", "").Replace(" ", "");
            byte[] convertArr = new byte[convertString.Length / 2];

            for (int i = 0; i < convertArr.Length; i++)
            {
                convertArr[i] = Convert.ToByte(convertString.Substring(i * 2, 2), 16);
            }
            
            return convertArr;
        }

        /// <summary>
        /// XOR 체크섬 계산하는 함수
        /// </summary>
        /// <param name="_PacketData"></param>
        /// <param name="PacketLength"></param>
        /// <returns></returns>
        public byte CalCheckSum(byte[] _PacketData, int PacketLength)
        {
            Byte _CheckSumByte = 0x00;
            for (int i = 0; i < PacketLength; i++)
                _CheckSumByte ^= _PacketData[i];
            return _CheckSumByte;
        }

        /// <summary>
        /// 체크섬 계산 함수
        /// </summary>
        /// <param name="sTmpMsg"></param>
        /// <returns></returns>
        public string CRC(string sTmpMsg)
        {
            byte[] convertArr = new byte[(sTmpMsg.Length) / 2];
            for (int i = 0; i < convertArr.Length; i++)
            {
                convertArr[i] = Convert.ToByte(sTmpMsg.Substring(i * 2, 2), 16);
            }
            //Variable with result of your calculation.
            int checksum = 0;
            //Step1: Add byte values.            
            foreach (byte value in convertArr)
            {
                checksum += value;
            }
            checksum = 256 - checksum;
            checksum &= 0xFF; // FFFFFF replace
            return checksum.ToString("X2");
        }

        public string ConvertHexFormat(string msg)
        {
            string res = string.Empty;

            for (int i = 0; i < msg.Length; i++)
            {
                res += msg.Substring(i, 1);

                if (i % 2 == 0 && i != 0)   // 짝수
                {

                }
                else if (i % 2 == 1)        // 홀수
                {
                    res += " ";
                }
                else                        // 0
                {

                }
                        
            }

            return res;
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(txtSend.Text.Replace(" ", ""));
            }
        }
    }
}
