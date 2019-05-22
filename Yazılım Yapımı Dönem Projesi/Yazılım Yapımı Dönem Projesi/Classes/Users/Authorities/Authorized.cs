using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Yazılım_Yapımı_Dönem_Projesi
{
    public class Authorized : User, CRUD
    {
        public int Authority { get; set; }
        public bool Login()
        {
            return true;
        }

        public bool Add()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}