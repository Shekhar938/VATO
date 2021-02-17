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
/// Summary description for clsMails
/// </summary>
public class clsMails
{
	public clsMails()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int MailId { get; set; }
    public int RecMemMailId { get; set; }
    public int SendMemMailId { get; set; }
    public int AttachmentId { get; set; }
    public string strAttachedFile { get; set; }
    public string strAttatedFileDesc { get; set; }
    public bool  MailStatus { get; set; }
    public DateTime  MailDate { get; set; }
    public string MailMessage { get; set; }



    public int SendMail()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@SendMemMailId", SendMemMailId);
            p[1] = new SqlParameter("@RecMemMailId", RecMemMailId);
            p[2] = new SqlParameter("@AttachedFile", strAttachedFile);
            p[3] = new SqlParameter("@AttatedFileDesc", strAttatedFileDesc);
            p[4] = new SqlParameter("@MailMessage", MailMessage);

            return SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "sp_SendMail",p);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}
