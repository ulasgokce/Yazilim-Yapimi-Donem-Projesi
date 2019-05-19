using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Yazılım_Yapımı_Dönem_Projesi
{
    public class Authorized : User
    {
        public int Authority { get; set; }
    }
}