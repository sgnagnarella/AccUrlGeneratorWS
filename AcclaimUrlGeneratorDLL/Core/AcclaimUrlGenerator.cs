using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.SessionState;
using System.Collections.Specialized;
using System.Collections;



using com.teletech.AUG.Encryptor;




namespace com.teletech.AUG.Core
{
    public class AcclaimUrlGenerator
    {



        public string GenerateAcclaimURL(string userName, string participantId, string blowFishhPass)
        {
            try
            {
                int timeOffSet = int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("AUG_TimeOffset"));

                string genTok = System.Configuration.ConfigurationManager.AppSettings.Get("AUG_GenTok");

                string urlBegin = System.Configuration.ConfigurationManager.AppSettings.Get("AUG_UrlBegin");

                string blowPass = "!fr#*sD23(#p$&@8";

                if (blowFishhPass != string.Empty)
                {
                    blowPass = blowFishhPass;
                }

                string static1 = System.Configuration.ConfigurationManager.AppSettings.Get("AUG_Static1");

                string static2 = System.Configuration.ConfigurationManager.AppSettings.Get("AUG_Static2");

                string static3 = System.Configuration.ConfigurationManager.AppSettings.Get("AUG_Static3");

                string static4 = System.Configuration.ConfigurationManager.AppSettings.Get("AUG_Static4");




                // Get current time in MST time zone
                DateTime utfDateTime = DateTime.Now;
                //We will need to check DST!!
                DateTime estDateTime = utfDateTime.AddHours(timeOffSet);

                ////If dst on north we have to add an hour.
                //if (Constants.c_processDST && DateTime.Now.IsDaylightSavingTime())
                //{
                //    estDateTime = estDateTime.AddHours(1);
                //}


                //date to yyyymmddhhmmss
                string dateToString = estDateTime.ToString("yyyyMMddHHmmss");

                //to int
                long dateInt = Convert.ToInt64(dateToString);

                //* 7
                dateInt = dateInt * 7;

                string oneIntercalatedPartId = null;

                //Intercalate 1 in the participantId starting with 1
                foreach (char c in participantId)
                {
                    oneIntercalatedPartId += "1";
                    oneIntercalatedPartId += c;
                }

                // NonEncyoted sptok

                string nEncSptok = static1 + dateInt.ToString() + static2 + userName + static3 + oneIntercalatedPartId + static4;


                //Convert nEncSpok to hexa
                string hexNEncSptok = Utilities.StringToHex(nEncSptok);

                //foreach (char c in nEncSptok)
                //{
                //    int tmp = c;
                //    hexNEncSptok += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
                //}

                //Convert key to hexa
                string hexKey = Utilities.StringToHex(blowPass);

                //foreach (char c in blowPass)
                //{
                //    int tmp = c;
                //    hexKey += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
                //}

                //Padding requiered for the algo to work (explain later)
                int totalChar = nEncSptok.Length * 2;

                switch (totalChar % 16)
                {
                    case 0:
                        hexNEncSptok += "0808080808080808";
                        break;
                    case 2:
                        hexNEncSptok += "07070707070707";
                        break;
                    case 4:
                        hexNEncSptok += "060606060606";
                        break;
                    case 6:
                        hexNEncSptok += "0505050505";
                        break;
                    case 8:
                        hexNEncSptok += "04040404";
                        break;
                    case 10:
                        hexNEncSptok += "030303";
                        break;
                    case 12:
                        hexNEncSptok += "0202";
                        break;
                    case 14:
                        hexNEncSptok += "01";
                        break;
                }



                Blowfish bAlgo = new Blowfish(Utilities.HexToByte(hexKey));
                byte[] bNEncSptok = Utilities.HexToByte(hexNEncSptok);



                bAlgo.Encipher(bNEncSptok, bNEncSptok.Length);

                //string hexEncSptok = Blowfish.Encrypt(hexNEncSptok, hexKey, Mode.ECB, string.Empty);
                string hexEncSptok = Utilities.ByteToHex(bNEncSptok);
                //string hexEncSptok = "93B5EA5D6FFD33F523C2AD86BE110A75ABCB2A63484A808D794C326B1EBE9547A5897D67FC9B23FD25A10AA18BD5147EB7E98C3812675B528933B6C710B377D4";

                //Concatenate Url 
                string finalUrl = urlBegin;

                //Add gentok
                finalUrl += "gentok=" + genTok;

                //Add sptok
                finalUrl += "&sptok=" + hexEncSptok.ToLower();

                return finalUrl;
            }
            catch (Exception ex)
            {
                return ex.Source;
            }
           
        }


    }

}
