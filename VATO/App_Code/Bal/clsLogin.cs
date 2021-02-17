using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using BackToMyVillage;
/// <summary>
/// Summary description for clsLogin
/// </summary>
public class clsLogin
{
    public clsLogin()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static  string UserName { get; set; }
    public static  string Password { get; set; }
    public static string Role { get; set; }

    //public string GetUserLogin()
    //{
    //    try
    //    {
    //        SqlParameter[] p = new SqlParameter[3];

    //        p[0] = new SqlParameter("@UserName", UserName);
    //        p[0].SqlDbType = SqlDbType.VarChar;

    //        p[1] = new SqlParameter("@Password", Password);
    //        p[1].SqlDbType = SqlDbType.VarChar;

    //        p[2] = new SqlParameter("@Role", SqlDbType.VarChar, 20);
    //        p[2].Direction = ParameterDirection.Output;

    //        SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "sp_EmpLoginChecking", p);

    //        return this.Role = Convert.ToString(p[2].Value.ToString());
    //    }
    //    catch (Exception ex)
    //    {
    //        throw new ArgumentException(ex.Message);
    //    }
    //}

    SqlConnection cn;
    SqlCommand cmd;

    public int GetUserId()
    {
        try
        {
            cn = new SqlConnection(Connection.con);
            cn.Open();
            cmd = new SqlCommand("select max(UserId) from tbl_UserMaster", cn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public object GetUserIdByLoginDetails(string str1, string p)
    {
        try
        {
            cn = new SqlConnection(Connection.con);
            cn.Open();
            cmd = new SqlCommand("select UserId from tbl_UserLogin where User_LoginId='" + str1 + "' and User_Password='" + p + "'", cn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
    public string GetUserLogin(out int Id)
    {
        try
        {
            SqlParameter[] p = new SqlParameter[4];

            p[0] = new SqlParameter("@LoginName", UserName );
            p[1] = new SqlParameter("@Password", Password);
            p[2] = new SqlParameter("@Role", SqlDbType.VarChar, 50);
            p[2].Direction = ParameterDirection.Output;
            p[3] = new SqlParameter("@Vole_Mem_id", SqlDbType.Int);
            p[3].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "spLoginChecking", p);
            Role = Convert.ToString(p[2].Value);
            if (Role != "NoUser")
                Id = Convert.ToInt32(p[3].Value);
            else
                Id = 0;
            return Role;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    /////
    ////
    public static void ActiveVolunteerOnlineStatus(int Id)
    {
        try
        {
            string str = "Update tbl_VolunteerOnline set [status]=1 where VounteerId=" + Id;
            SqlHelper.ExecuteNonQuery(Connection.con, CommandType.Text, str);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public static void InActiveVolunteerOnlineStatus(int Id)
    {
        try
        {
            string str = "Update tbl_VolunteerOnline set [status]=0 where VolunteerId=" + Id;
            SqlHelper.ExecuteNonQuery(Connection.con, CommandType.Text, str);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public static void ActiveMemberOnlineStatus(int Id)
    {
        try
        {
            string str = "Update tbl_MenberOnline set [status]=1 where MemberId=" + Id;
            SqlHelper.ExecuteNonQuery(Connection.con, CommandType.Text, str);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public static void InActiveMemberOnlineStatus(int Id)
    {
        try
        {
            string str = "Update tbl_MemberOnline set [status]=0 where MemberId=" + Id;
            SqlHelper.ExecuteNonQuery(Connection.con, CommandType.Text, str);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet GetOnlineVolunteerData()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "sp_GetOnlineVolunteerData");
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet GetOnlineMemberData()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "sp_GetOnlineMemberData");
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}
