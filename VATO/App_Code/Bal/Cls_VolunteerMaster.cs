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
/// Summary description for Cls_VolunteerMaster
/// </summary>
public class Cls_VolunteerMaster
{

    private int volunteerId;
    private string volunteerName;
    private DateTime  volunteerDoB;
    private DateTime  volunteerDoR;
    private string volunteerImageFileName;
    
    private string volunteerDescription;
    private string volunteerMobile;
    private string volunteerAddress;
    private string username;
    private string password;

    // constructor
    public Cls_VolunteerMaster()
    {
    }

    public int VolunteerId { get { return volunteerId; } set { volunteerId = value; } }
    public string VolunteerName { get { return volunteerName; } set { volunteerName = value; } }
    public DateTime  VolunteerDoB { get { return volunteerDoB; } set { volunteerDoB = value; } }
    public DateTime  VolunteerDoR { get { return volunteerDoR; } set { volunteerDoR = value; } }
    public string VolunteerImageFileName { get { return volunteerImageFileName; } set { volunteerImageFileName = value; } }
 
    public string VolunteerDescription { get { return volunteerDescription; } set { volunteerDescription = value; } }
    public string VolunteerMobile { get { return volunteerMobile; } set { volunteerMobile = value; } }
    public string VolunteerAddress { get { return volunteerAddress; } set { volunteerAddress = value; } }
    public string UserName { get { return username; } set { username = value; } }
    public string Password { get { return password; } set { password = value; } }

    public int Insertvolunteermaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[8];

            p[0] = new SqlParameter("@VolunteerName ", VolunteerName);
            p[1] = new SqlParameter("@VolunteerDoB ", VolunteerDoB);
            p[2] = new SqlParameter("@VolunteerImageFileName    ", VolunteerImageFileName);

            p[3] = new SqlParameter("@VolunteerDescription ", VolunteerDescription);
            p[4] = new SqlParameter("@VolunteerMobile ", VolunteerMobile);
            p[5] = new SqlParameter("@VolunteerAddress ", VolunteerAddress);
            p[6] = new SqlParameter("@UserName", UserName);
            p[7] = new SqlParameter("@Pwd", Password);


            int i = SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_VolunteerMaster_Insert", p);
            return i;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}