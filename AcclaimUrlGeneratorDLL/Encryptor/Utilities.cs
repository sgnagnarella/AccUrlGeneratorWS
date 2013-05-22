using System;
using System.Collections.Generic;
using System.Text;

namespace com.teletech.AUG.Core
{
    public class Utilities
    {
        public static byte[] HexToByte(string hexInput)
        {
            byte[] byteVar = null;
            if (hexInput.Length > 0)
            {
                int ndx = 0;
                int byteCnt;
                byteCnt = hexInput.Length / 2;
                byteVar = new byte[byteCnt];
                for (int i = 0; i < byteCnt; i++)
                {
                    byteVar[i] = Convert.ToByte(hexInput.Substring(ndx, 2), 16);
                    ndx += 2;
                }


            }
            return byteVar;
        }

        public static string ByteToHex(byte[] byteInput)
        {
            string toReturn = null;
            foreach (byte bb in byteInput)
            {
                string temp = bb.ToString("X");
                
                if (bb.ToString("X").Length < 2)
                {
                    temp = "0" + temp;
                }
                toReturn += temp;
            }
            return toReturn;

        }

        public static string StringToHex(string stringInput)
        {
            string hexNEncSptok = null;

            foreach (char c in stringInput)
            {
                int tmp = c;
                hexNEncSptok += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            return hexNEncSptok;
        }
    }
}
