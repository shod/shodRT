using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShodRT
{
    public partial class HexNum : Form
    {
        public HexNum()
        {
            InitializeComponent();
        }

        private void btnHB_Click(object sender, EventArgs e)
        {
            string dataH;
            dataH = txtH.Text.Replace(" ","");
            //dataH = Data_Hex_Dec(ref dataH);
            long longDataH = GetHexToDouble(dataH);
            txtN.Text = longDataH.ToString();
        }

        private void btnNH_Click(object sender, EventArgs e)
        {
            string dataH;
            /*double f = 4465;// Convert.ToDouble(txtH.Text);//4465.73;
            byte[] b = BitConverter.GetBytes(f);
            StringBuilder sb = new StringBuilder();
            foreach (byte by in b)
            {
                sb.Append(by.ToString("X"));
            }*/            

            int fi = Convert.ToInt16(txtN.Text);
            txtH.Text = fi.ToString("X");
            //txtN.Text = BitConverter.ToString(bytes).ToString();
            //dataH = txtH.Text.Trim(' ');
            //dataH = HexString2Ascii(dataH);
            //txtN.Text = dataH;
        }

        private void btnAH_Click(object sender, EventArgs e)
        {
            string dataH;
            dataH = txtAscii.Text;
            dataH = HexString2Ascii(dataH);
            txtAsciiHex.Text = dataH;
        }

        #region HexFunction

        public string Data_Hex_Asc(ref string Data)
        {

            string Data1 = "";

            string sData = "";

            while (Data.Length > 0)

            //first take two hex value using substring.

            //then convert Hex value into ascii.

            //then convert ascii value into character.
            {
                Data1 = System.Convert.ToChar(System.Convert.ToUInt32(Data.Substring(0, 2), 16)).ToString();

                sData = sData + Data1;

                Data = Data.Substring(2, Data.Length - 2);

            }
            return sData;
        }

        public string Data_Hex_Dec(ref string Data)
        {

            string Data1 = "";

            string sData = "";

            while (Data.Length > 0)

            //first take two hex value using substring.

            //then convert Hex value into ascii.

            //then convert ascii value into character.
            {
                Data1 = System.Convert.ToUInt32(Data.Substring(0, 2), 16).ToString();

                sData = sData + Data1;

                Data = Data.Substring(2, Data.Length - 2);

            }
            return sData;
        }

        /*
         * converting a Hexadecimal String(hex string) to ASCII.
         */
        private string HexString2Ascii(string asciiString)
        {
            string hex = "";
            foreach (char c in asciiString)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            return hex;
        }


        public static long GetHexToDouble(string strHex)
        {
            string strHexRev = String.Empty;
            int cnt;

            cnt = strHex.Length / 2;


            for (int i = 0; i < cnt; i++)
                strHexRev = strHexRev + strHex.Substring(i * 2, 2);
            Int64 longHex = Int64.Parse(strHexRev, System.Globalization.NumberStyles.HexNumber);
            return longHex;
            //return BitConverter.ToInt64(longHex,);
            //.Int64BitsToDouble(longHex);
        }

        /* Hex to Float */
        private float HexString2Float(string strHex)
        {
            //41c9fd08
            //byte[] bytes = BitConverter.GetBytes(strHex);
            int alen = strHex.Length / 2;
            byte[] bytes = new byte[alen];
            for (int i = 0, j = 0; i < strHex.Length; i += 2, j++)
                bytes[alen-1-j] = Convert.ToByte(strHex.Substring(i, 2), 16);

            float myFload = BitConverter.ToSingle(bytes, 0);
            return myFload;
        }
        #endregion //HexFunction

        private void btnHF_Click(object sender, EventArgs e)
        {
            string dataH;
            dataH = txtH.Text.Replace(" ","");

            float longDataH = HexString2Float(dataH);
            txtFloat.Text = longDataH.ToString();
            

        }
    

    }
}