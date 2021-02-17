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
/// Summary description for Class_Members
/// </summary>
/// 

public class Class_Members
{

	public Class_Members()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private int memberId;
    private string firstName;
    private string middleName;
    private string lastname;
    private string mailId;
    private string contactNo;
    private byte[] photoContent;
    private string photoFileName;
    private string address;
    private string dOR;
    private string username;
    private string pwd;

    public int MemberId { get { return memberId; } set { memberId = value; } }
    public string FirstName { get { return firstName; } set { firstName = value; } }
    public string MiddleName { get { return middleName; } set { middleName = value; } }
    public string Lastname { get { return lastname; } set { lastname = value; } }
    public string MailId { get { return mailId; } set { mailId = value; } }
    public string ContactNo { get { return contactNo; } set { contactNo = value; } }
    public byte[] PhotoContent { get { return photoContent; } set { photoContent = value; } }
    public string PhotoFileName { get { return photoFileName; } set { photoFileName = value; } }
    public string Address { get { return address; } set { address = value; } }
    public string DOR { get { return dOR; } set { dOR = value; } }
    public string UserName { get { return username; } set { username = value; } }
    public string Pwd { get { return pwd; } set { pwd = value; } }

    public int InsertMemberDetails()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[10];
            p[0] = new SqlParameter("@FirstName", FirstName);
            p[1] = new SqlParameter("@MiddleName", MiddleName);
            p[2] = new SqlParameter("@Lastname", Lastname);
            p[3] = new SqlParameter("@MailId", MailId);
            p[4] = new SqlParameter("@ContactNo", ContactNo);
            p[5] = new SqlParameter("@PhotoContent", PhotoContent);
            p[6] = new SqlParameter("@PhotoFileName", PhotoFileName);
            p[7] = new SqlParameter("@Address", Address);
            p[8] = new SqlParameter("@UserName", UserName);
            p[9] = new SqlParameter("@Pwd", Pwd);

            return SqlHelper.ExecuteNonQuery(Connection.con , CommandType.StoredProcedure, "sp_MembersMaster_Insert", p);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}
