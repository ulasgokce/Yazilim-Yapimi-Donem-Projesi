using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yazılım_Yapımı_Dönem_Projesi
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}