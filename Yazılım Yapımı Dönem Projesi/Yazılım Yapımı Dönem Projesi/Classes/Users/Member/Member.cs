using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;

namespace Yazılım_Yapımı_Dönem_Projesi
{
    public class Member : User, CRUD
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Language { get; set; }

        public bool Add()
        {
            Database.ProcedureName = "dbo.AddMember";

            SqlParameter[] spParameter = new SqlParameter[5];
            spParameter[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            spParameter[0].Value = Username;

            spParameter[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            spParameter[1].Value = Password;

            spParameter[2] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            spParameter[2].Value = Name;

            spParameter[3] = new SqlParameter("@surname", SqlDbType.NVarChar, 50);
            spParameter[3].Value = Surname;

            spParameter[4] = new SqlParameter("@language", SqlDbType.Int);
            spParameter[4].Value = Language;

            try
            {
                Database.Queries(spParameter);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }
        public bool Update()
        {
            throw new NotImplementedException();
        }
        
        public bool Login()
        {
            Database.ProcedureName = "dbo.CheckUser";

            SqlParameter[] spParameter = new SqlParameter[3];
            spParameter[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            spParameter[0].Value = Username;

            spParameter[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            spParameter[1].Value = Password;

            spParameter[2] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            spParameter[2].Value = "Member";

            try
            {
                Database.Queries(spParameter);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}