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
/// Summary description for Cls_NewsLetterMaster
/// </summary>
public class Cls_NewsLetterMaster
{

    private int newsLetterId;
    private string newsLetterSubjectName;
    private string newsLetterDocumentedFile;
    private DateTime  newsLetterDate;
    private bool newsLetterstatus;
    private int volunteerId;

    // constructor
    public Cls_NewsLetterMaster()
    {
    }

    public int NewsLetterId { get { return newsLetterId; } set { newsLetterId = value; } }
    public string NewsLetterSubjectName { get { return newsLetterSubjectName; } set { newsLetterSubjectName = value; } }
    public string NewsLetterDocumentedFile { get { return newsLetterDocumentedFile; } set { newsLetterDocumentedFile = value; } }
    public DateTime  NewsLetterDate { get { return newsLetterDate; } set { newsLetterDate = value; } }
    public bool  NewsLetterstatus { get { return newsLetterstatus; } set { newsLetterstatus = value; } }
    public int VolunteerId { get { return volunteerId; } set { volunteerId = value; } }
    public DataSet GetvolunteerId()
    {
        try
        {
            string strText = "Sp_VolunteerMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public int InsertNewsLetterMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@NewsLetterSubjectName", NewsLetterSubjectName);
            p[1] = new SqlParameter("@NewsLetterDocumentedFile", NewsLetterDocumentedFile);
            p[2] = new SqlParameter("@NewsLetterstatus", NewsLetterstatus);
            p[3] = new SqlParameter("@VolunteerId", VolunteerId);
            int i = SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_NewsLetterMaster_Insert", p);
            return i;
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
}