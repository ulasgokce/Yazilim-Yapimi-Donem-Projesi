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

        public Member Login()
        {
            Database.ProcedureName = "dbo.CheckUser";

            SqlParameter[] spParameter = new SqlParameter[3];
            spParameter[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            spParameter[0].Value = Username;

            spParameter[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            spParameter[1].Value = Password;

            spParameter[2] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            spParameter[2].Value = "Member";

            Member member = null;
            try
            {
                DataSet ds = Database.Queries(spParameter);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    member = new Member()
                    {
                        Id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]),
                        Language = Convert.ToInt32(ds.Tables[0].Rows[0]["language"]),
                        Name = ds.Tables[0].Rows[0]["name"].ToString(),
                        Password = ds.Tables[0].Rows[0]["password"].ToString(),
                        Surname = ds.Tables[0].Rows[0]["surname"].ToString(),
                        Username = ds.Tables[0].Rows[0]["username"].ToString()
                    };
                }
                return member;
            }
            catch
            {
                return member;
            }
        }
    }
}