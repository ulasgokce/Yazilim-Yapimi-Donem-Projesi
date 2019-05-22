using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yazılım_Yapımı_Dönem_Projesi
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            //SqlCommand command = new SqlCommand("ResetDatabase", con);
            //command.CommandType = CommandType.StoredProcedure;
            //con.Open();
            //Response.Write(command.ExecuteNonQuery());
            //con.Close();
            User principal = new Member();
            if (principal is Member)
                Response.Write("sa");
        }
        [System.Web.Services.WebMethod]
        public static bool GetCurrentTime()
        {
            return true;
        }
    }
}