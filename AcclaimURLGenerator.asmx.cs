using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using com.teletech.AUG.Core;

namespace AccUrlGeneratorWS
{
    /// <summary>
    /// Summary description for AcclaimURLGenerator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AcclaimURLGenerator : System.Web.Services.WebService
    {

        [WebMethod]
        public string GenerateUrl(string userName, string participantId, string blowPass)
        {
            AcclaimUrlGenerator aug = new AcclaimUrlGenerator();
            return aug.GenerateAcclaimURL(userName, participantId, blowPass);
        }

    }
}
