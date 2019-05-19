using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Yazılım_Yapımı_Dönem_Projesi
{
    public class Member : User
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Language { get; set; }
    }
}