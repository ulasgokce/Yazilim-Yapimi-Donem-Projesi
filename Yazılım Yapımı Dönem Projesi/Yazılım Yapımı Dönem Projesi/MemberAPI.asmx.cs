using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Yazılım_Yapımı_Dönem_Projesi
{
    /// <summary>
    /// Summary description for API
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class API : System.Web.Services.WebService
    {
        [WebMethod]
        public bool MemberLogin(Member member)
        {
            return member.Login();
        }
        [WebMethod]
        public bool AuthorizedLogin(Authorized authorized)
        {
            return authorized.Login();
        }
        [WebMethod]
        public bool Deneme()
        {
            return true;
        }
    }
}
