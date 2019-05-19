using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Yazılım_Yapımı_Dönem_Projesi
{
    public abstract class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}