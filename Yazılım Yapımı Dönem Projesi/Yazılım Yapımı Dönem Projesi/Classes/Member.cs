using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yazılım_Yapımı_Dönem_Projesi
{
    public class Member : User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Language { get; set; }
    }
}