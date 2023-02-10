
namespace Serial_Analyzer_Custom
{
    partial class FrmMain
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
            this.grbSerial = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoBtnSerial = new System.Windows.Forms.RadioButton();
            this.grbEthernet = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP_4 = new System.Windows.Forms.TextBox();
            this.txtIP_3 = new System.Windows.Forms.TextBox();
            this.txtIP_2 = new System.Windows.Forms.TextBox();
            this.txtIP_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoBtnEthernet = new System.Windows.Forms.RadioButton();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnDisconn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxTX = new System.Windows.Forms.PictureBox();
            this.pictureBoxRX = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendAscii = new System.Windows.Forms.Button();
            this.btnSendHex = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtxtRecvHex = new System.Windows.Forms.RichTextBox();
            this.rtxtRecvAscii = new System.Windows.Forms.RichTextBox();
            this.txtChecksum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chkAutoAck = new System.Windows.Forms.CheckBox();
            this.txtAutoAck = new System.Windows.Forms.TextBox();
            this.grbAutoAck = new System.Windows.Forms.GroupBox();
            this.btnSendCopy = new System.Windows.Forms.Button();
            this.btnChecksumCal = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.rtxtChecksumStr = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.rtxtSendHex = new System.Windows.Forms.RichTextBox();
            this.btnProtocolClear = new System.Windows.Forms.Button();
            this.grbSerial.SuspendLayout();
            this.grbEthernet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRX)).BeginInit();
            this.grbAutoAck.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSerial
            // 
            this.grbSerial.Controls.Add(this.comboBox5);
            this.grbSerial.Controls.Add(this.comboBox3);
            this.grbSerial.Controls.Add(this.comboBox4);
            this.grbSerial.Controls.Add(this.comboBox2);
            this.grbSerial.Controls.Add(this.comboBox1);
            this.grbSerial.Controls.Add(this.label12);
            this.grbSerial.Controls.Add(this.label11);
            this.grbSerial.Controls.Add(this.label10);
            this.grbSerial.Controls.Add(this.label9);
            this.grbSerial.Controls.Add(this.label8);
            this.grbSerial.Location = new System.Drawing.Point(12, 12);
            this.grbSerial.Name = "grbSerial";
            this.grbSerial.Size = new System.Drawing.Size(316, 143);
            this.grbSerial.TabIndex = 0;
            this.grbSerial.TabStop = false;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(222, 74);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(82, 20);
            this.comboBox5.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(222, 48);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(82, 20);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(222, 23);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(82, 20);
            this.comboBox4.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(55, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 20);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "페러티비트 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "데이터크기 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "정지비트 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "속도 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "포트 :";
            // 
            // rdoBtnSerial
            // 
            this.rdoBtnSerial.AutoSize = true;
            this.rdoBtnSerial.Checked = true;
            this.rdoBtnSerial.Location = new System.Drawing.Point(26, 12);
            this.rdoBtnSerial.Name = "rdoBtnSerial";
            this.rdoBtnSerial.Size = new System.Drawing.Size(55, 16);
            this.rdoBtnSerial.TabIndex = 1;
            this.rdoBtnSerial.TabStop = true;
            this.rdoBtnSerial.Text = "Serial";
            this.rdoBtnSerial.UseVisualStyleBackColor = true;
            this.rdoBtnSerial.CheckedChanged += new System.EventHandler(this.rdoBtnSerial_CheckedChanged);
            // 
            // grbEthernet
            // 
            this.grbEthernet.Controls.Add(this.label7);
            this.grbEthernet.Controls.Add(this.label6);
            this.grbEthernet.Controls.Add(this.label5);
            this.grbEthernet.Controls.Add(this.txtPort);
            this.grbEthernet.Controls.Add(this.label4);
            this.grbEthernet.Controls.Add(this.txtIP_4);
            this.grbEthernet.Controls.Add(this.txtIP_3);
            this.grbEthernet.Controls.Add(this.txtIP_2);
            this.grbEthernet.Controls.Add(this.txtIP_1);
            this.grbEthernet.Controls.Add(this.label3);
            this.grbEthernet.Enabled = false;
            this.grbEthernet.Location = new System.Drawing.Point(12, 161);
            this.grbEthernet.Name = "grbEthernet";
            this.grbEthernet.Size = new System.Drawing.Size(316, 53);
            this.grbEthernet.TabIndex = 6;
            this.grbEthernet.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = ".";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(245, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(45, 21);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "65535";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port :";
            // 
            // txtIP_4
            // 
            this.txtIP_4.Location = new System.Drawing.Point(166, 21);
            this.txtIP_4.Name = "txtIP_4";
            this.txtIP_4.Size = new System.Drawing.Size(30, 21);
            this.txtIP_4.TabIndex = 7;
            this.txtIP_4.Text = "255";
            // 
            // txtIP_3
            // 
            this.txtIP_3.Location = new System.Drawing.Point(124, 21);
            this.txtIP_3.Name = "txtIP_3";
            this.txtIP_3.Size = new System.Drawing.Size(30, 21);
            this.txtIP_3.TabIndex = 5;
            this.txtIP_3.Text = "255";
            // 
            // txtIP_2
            // 
            this.txtIP_2.Location = new System.Drawing.Point(84, 21);
            this.txtIP_2.Name = "txtIP_2";
            this.txtIP_2.Size = new System.Drawing.Size(30, 21);
            this.txtIP_2.TabIndex = 3;
            this.txtIP_2.Text = "255";
            // 
            // txtIP_1
            // 
            this.txtIP_1.Location = new System.Drawing.Point(41, 21);
            this.txtIP_1.Name = "txtIP_1";
            this.txtIP_1.Size = new System.Drawing.Size(30, 21);
            this.txtIP_1.TabIndex = 1;
            this.txtIP_1.Text = "255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP :";
            // 
            // rdoBtnEthernet
            // 
            this.rdoBtnEthernet.AutoSize = true;
            this.rdoBtnEthernet.Location = new System.Drawing.Point(25, 162);
            this.rdoBtnEthernet.Name = "rdoBtnEthernet";
            this.rdoBtnEthernet.Size = new System.Drawing.Size(69, 16);
            this.rdoBtnEthernet.TabIndex = 7;
            this.rdoBtnEthernet.Text = "Ethernet";
            this.rdoBtnEthernet.UseVisualStyleBackColor = true;
            this.rdoBtnEthernet.CheckedChanged += new System.EventHandler(this.rdoBtnEthernet_CheckedChanged);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(338, 18);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 23);
            this.btnConn.TabIndex = 2;
            this.btnConn.Text = "통신 연결";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnDisconn
            // 
            this.btnDisconn.Location = new System.Drawing.Point(338, 47);
            this.btnDisconn.Name = "btnDisconn";
            this.btnDisconn.Size = new System.Drawing.Size(75, 23);
            this.btnDisconn.TabIndex = 3;
            this.btnDisconn.Text = "통신 끊기";
            this.btnDisconn.UseVisualStyleBackColor = true;
            this.btnDisconn.Click += new System.EventHandler(this.btnDisconn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(48, 128);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxTX
            // 
            this.pictureBoxTX.Location = new System.Drawing.Point(444, 18);
            this.pictureBoxTX.Name = "pictureBoxTX";
            this.pictureBoxTX.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxTX.TabIndex = 4;
            this.pictureBoxTX.TabStop = false;
            // 
            // pictureBoxRX
            // 
            this.pictureBoxRX.Location = new System.Drawing.Point(444, 46);
            this.pictureBoxRX.Name = "pictureBoxRX";
            this.pictureBoxRX.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxRX.TabIndex = 5;
            this.pictureBoxRX.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "송신";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "수신";
            // 
            // btnSendAscii
            // 
            this.btnSendAscii.Enabled = false;
            this.btnSendAscii.Location = new System.Drawing.Point(12, 371);
            this.btnSendAscii.Name = "btnSendAscii";
            this.btnSendAscii.Size = new System.Drawing.Size(75, 23);
            this.btnSendAscii.TabIndex = 20;
            this.btnSendAscii.Text = "ASCII 전송";
            this.btnSendAscii.UseVisualStyleBackColor = true;
            this.btnSendAscii.Visible = false;
            // 
            // btnSendHex
            // 
            this.btnSendHex.Location = new System.Drawing.Point(12, 342);
            this.btnSendHex.Name = "btnSendHex";
            this.btnSendHex.Size = new System.Drawing.Size(75, 23);
            this.btnSendHex.TabIndex = 19;
            this.btnSendHex.Text = "HEX 전송";
            this.btnSendHex.UseVisualStyleBackColor = true;
            this.btnSendHex.Click += new System.EventHandler(this.btnSendHex_Click);
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSend.Location = new System.Drawing.Point(96, 342);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(407, 52);
            this.txtSend.TabIndex = 18;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "체크섬 (1 Byte) :";
            // 
            // rtxtRecvHex
            // 
            this.rtxtRecvHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtRecvHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtRecvHex.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rtxtRecvHex.Location = new System.Drawing.Point(96, 550);
            this.rtxtRecvHex.Name = "rtxtRecvHex";
            this.rtxtRecvHex.Size = new System.Drawing.Size(407, 105);
            this.rtxtRecvHex.TabIndex = 24;
            this.rtxtRecvHex.Text = "";
            // 
            // rtxtRecvAscii
            // 
            this.rtxtRecvAscii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtRecvAscii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtRecvAscii.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rtxtRecvAscii.Location = new System.Drawing.Point(96, 694);
            this.rtxtRecvAscii.Name = "rtxtRecvAscii";
            this.rtxtRecvAscii.Size = new System.Drawing.Size(407, 105);
            this.rtxtRecvAscii.TabIndex = 26;
            this.rtxtRecvAscii.Text = "";
            // 
            // txtChecksum
            // 
            this.txtChecksum.Location = new System.Drawing.Point(116, 287);
            this.txtChecksum.Name = "txtChecksum";
            this.txtChecksum.Size = new System.Drawing.Size(48, 21);
            this.txtChecksum.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 16;
            this.label14.Text = "보낼 데이터 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 530);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 12);
            this.label15.TabIndex = 23;
            this.label15.Text = "받는 데이터 : HEX";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 673);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "받는 데이터 : ASCII";
            // 
            // chkAutoAck
            // 
            this.chkAutoAck.AutoSize = true;
            this.chkAutoAck.Checked = true;
            this.chkAutoAck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoAck.Location = new System.Drawing.Point(12, 0);
            this.chkAutoAck.Name = "chkAutoAck";
            this.chkAutoAck.Size = new System.Drawing.Size(72, 16);
            this.chkAutoAck.TabIndex = 0;
            this.chkAutoAck.Text = "자동응답";
            this.chkAutoAck.UseVisualStyleBackColor = true;
            // 
            // txtAutoAck
            // 
            this.txtAutoAck.Location = new System.Drawing.Point(11, 21);
            this.txtAutoAck.Name = "txtAutoAck";
            this.txtAutoAck.Size = new System.Drawing.Size(48, 21);
            this.txtAutoAck.TabIndex = 1;
            // 
            // grbAutoAck
            // 
            this.grbAutoAck.Controls.Add(this.chkAutoAck);
            this.grbAutoAck.Controls.Add(this.txtAutoAck);
            this.grbAutoAck.Location = new System.Drawing.Point(338, 161);
            this.grbAutoAck.Name = "grbAutoAck";
            this.grbAutoAck.Size = new System.Drawing.Size(165, 53);
            this.grbAutoAck.TabIndex = 8;
            this.grbAutoAck.TabStop = false;
            // 
            // btnSendCopy
            // 
            this.btnSendCopy.Location = new System.Drawing.Point(251, 286);
            this.btnSendCopy.Name = "btnSendCopy";
            this.btnSendCopy.Size = new System.Drawing.Size(121, 23);
            this.btnSendCopy.TabIndex = 15;
            this.btnSendCopy.Text = "보낼 데이터, 복사";
            this.btnSendCopy.UseVisualStyleBackColor = true;
            this.btnSendCopy.Click += new System.EventHandler(this.btnSendCopy_Click);
            // 
            // btnChecksumCal
            // 
            this.btnChecksumCal.Location = new System.Drawing.Point(171, 286);
            this.btnChecksumCal.Name = "btnChecksumCal";
            this.btnChecksumCal.Size = new System.Drawing.Size(75, 23);
            this.btnChecksumCal.TabIndex = 14;
            this.btnChecksumCal.Text = "계산";
            this.btnChecksumCal.UseVisualStyleBackColor = true;
            this.btnChecksumCal.Click += new System.EventHandler(this.btnChecksumCal_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 12);
            this.label17.TabIndex = 9;
            this.label17.Text = "프로토콜 :";
            // 
            // rtxtChecksumStr
            // 
            this.rtxtChecksumStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtChecksumStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtChecksumStr.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rtxtChecksumStr.Location = new System.Drawing.Point(96, 242);
            this.rtxtChecksumStr.Name = "rtxtChecksumStr";
            this.rtxtChecksumStr.Size = new System.Drawing.Size(407, 38);
            this.rtxtChecksumStr.TabIndex = 10;
            this.rtxtChecksumStr.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(414, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "지우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 402);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 12);
            this.label18.TabIndex = 21;
            this.label18.Text = "보낸 데이터 : HEX";
            // 
            // rtxtSendHex
            // 
            this.rtxtSendHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtSendHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtSendHex.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rtxtSendHex.Location = new System.Drawing.Point(96, 422);
            this.rtxtSendHex.Name = "rtxtSendHex";
            this.rtxtSendHex.Size = new System.Drawing.Size(407, 105);
            this.rtxtSendHex.TabIndex = 22;
            this.rtxtSendHex.Text = "";
            // 
            // btnProtocolClear
            // 
            this.btnProtocolClear.Location = new System.Drawing.Point(414, 216);
            this.btnProtocolClear.Name = "btnProtocolClear";
            this.btnProtocolClear.Size = new System.Drawing.Size(89, 23);
            this.btnProtocolClear.TabIndex = 11;
            this.btnProtocolClear.Text = "지우기";
            this.btnProtocolClear.UseVisualStyleBackColor = true;
            this.btnProtocolClear.Click += new System.EventHandler(this.btnProtocolClear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 811);
            this.Controls.Add(this.btnProtocolClear);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.rtxtSendHex);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtxtChecksumStr);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnChecksumCal);
            this.Controls.Add(this.btnSendCopy);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtChecksum);
            this.Controls.Add(this.rtxtRecvAscii);
            this.Controls.Add(this.rtxtRecvHex);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.btnSendAscii);
            this.Controls.Add(this.btnSendHex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxRX);
            this.Controls.Add(this.pictureBoxTX);
            this.Controls.Add(this.btnDisconn);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.rdoBtnEthernet);
            this.Controls.Add(this.rdoBtnSerial);
            this.Controls.Add(this.grbEthernet);
            this.Controls.Add(this.grbSerial);
            this.Controls.Add(this.grbAutoAck);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grbSerial.ResumeLayout(false);
            this.grbSerial.PerformLayout();
            this.grbEthernet.ResumeLayout(false);
            this.grbEthernet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRX)).EndInit();
            this.grbAutoAck.ResumeLayout(false);
            this.grbAutoAck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSerial;
        private System.Windows.Forms.RadioButton rdoBtnSerial;
        private System.Windows.Forms.GroupBox grbEthernet;
        private System.Windows.Forms.RadioButton rdoBtnEthernet;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnDisconn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxTX;
        private System.Windows.Forms.PictureBox pictureBoxRX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP_4;
        private System.Windows.Forms.TextBox txtIP_3;
        private System.Windows.Forms.TextBox txtIP_2;
        private System.Windows.Forms.TextBox txtIP_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendAscii;
        private System.Windows.Forms.Button btnSendHex;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtxtRecvHex;
        private System.Windows.Forms.RichTextBox rtxtRecvAscii;
        private System.Windows.Forms.TextBox txtChecksum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkAutoAck;
        private System.Windows.Forms.TextBox txtAutoAck;
        private System.Windows.Forms.GroupBox grbAutoAck;
        private System.Windows.Forms.Button btnSendCopy;
        private System.Windows.Forms.Button btnChecksumCal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox rtxtChecksumStr;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox rtxtSendHex;
        private System.Windows.Forms.Button btnProtocolClear;
    }
}

