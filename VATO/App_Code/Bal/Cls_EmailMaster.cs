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
/// Summary description for Cls_EmailMaster
/// </summary>
public class Cls_EmailMaster
{

    private int emailId;
    private int emailSenderId;
    private string emaildate;
    private string emailSubjectText;
    private string eMailBodyMsg;
    private byte[] emailAttachFileContent;
    private string emailAttachFileName;
    private int emailReciptedId;


    // constructor
    public Cls_EmailMaster()
    {
    }
    public int  InsertEmailMaster()
    {
        try
        {
            SqlParameter []p=new SqlParameter[6];
            p[0]=new SqlParameter("@EmailSenderId",EmailSenderId);
            p[1]=new SqlParameter("@EmailSubjectText",EmailSubjectText);
            p[2]=new SqlParameter("@EMailBodyMsg",EMailBodyMsg);
            p[3]=new SqlParameter("@EmailAttachFileContent",EmailAttachFileContent);
            p[4]=new SqlParameter("@EmailAttachFileName",EmailAttachFileName);
            p[5] = new SqlParameter("@EmailReciptedId", EmailReciptedId);

            return SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_EmailMaster_Insert", p);
             
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }


    public int EmailId { get { return emailId; } set { emailId = value; } }
    public int EmailSenderId { get { return emailSenderId; } set { emailSenderId = value; } }
    public string Emaildate { get { return emaildate; } set { emaildate = value; } }
    public string EmailSubjectText { get { return emailSubjectText; } set { emailSubjectText = value; } }
    public string EMailBodyMsg { get { return eMailBodyMsg; } set { eMailBodyMsg = value; } }
    public byte[] EmailAttachFileContent { get { return emailAttachFileContent; } set { emailAttachFileContent = value; } }
    public string EmailAttachFileName { get { return emailAttachFileName; } set { emailAttachFileName = value; } }
    public int EmailReciptedId { get { return emailReciptedId; } set { emailReciptedId = value; } }

    public static DataSet ShowMemberEmails()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "SP_MemberEmailiddesplay");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowVolunteerEmails()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "SP_VolunteerEmailiddesplay");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public static DataSet ShowAdminEmails()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "SP_AdminEmailiddesplay");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }


    public static DataSet ShowMemberEmailsVolunteerWise(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@studentid", id);
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "SP_FacultyidemailsselectStudentId",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowVolunteerEmailsMembersWise(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@Facultyid", id);
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "SP_studentidemailsselectFacultyid", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }


    public static DataSet  ShowInboxdetails(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@Receptedid", id);
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "Sp_Inboxdetailshows", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowOutboxdetails(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@senderid", id);
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "Sp_outboxdetails", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public static DataSet ShowEmailDetailsidwiseInbox(int Emailid1 )
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter  p=new SqlParameter("@Emailid", Emailid1);
            
          
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "Sp_ShowDetailsEmailidwise", p);
       
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowEmailDetailsidwiseOutbox(int Emailid1)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@Emailid", Emailid1);


            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "Sp_ShowEmaildetailsOutbox", p);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static int UpdateEmailDeleteStatusInbox(int p)
    {
        try
        {
            return SqlHelper.ExecuteNonQuery(Connection.con, CommandType.Text, "update tbl_EmailDetails set EmailDeleteStatus=1 where Emailid=" + p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public static int  UpdateEmailDeleteStatusOutbox(int p)
    {
        try
        {
           return   SqlHelper.ExecuteNonQuery(Connection.con, CommandType.Text, "update tbl_emailmaster set EmailDeleteStatus=1 where Emailid="+p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
}