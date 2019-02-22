using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Helper;

namespace TestCreateQRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtData.Text.Trim()))
            {
                MessageBox.Show("Insert Data");
                return;
            }

            QRCodeEncoder qrCodecEncoder = new QRCodeEncoder();
            qrCodecEncoder.QRCodeBackgroundColor = System.Drawing.Color.White;
            qrCodecEncoder.QRCodeForegroundColor = System.Drawing.Color.Black;
            qrCodecEncoder.CharacterSet = "UTF-8";
            qrCodecEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodecEncoder.QRCodeScale = 6;
            qrCodecEncoder.QRCodeVersion = 0;
            qrCodecEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;

            Image imageQRCode;
            String data = txtData.Text;
            imageQRCode = qrCodecEncoder.Encode(data);
            imgOut.Image = imageQRCode;

        }
    }
}
