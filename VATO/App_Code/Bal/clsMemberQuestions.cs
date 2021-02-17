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
/// Summary description for clsMemberQuestions
/// </summary>
public class clsMemberQuestions
{
	public clsMemberQuestions()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private int activityId;
    private int questionId;
    private string questionRegDate;
    private string questionDescription;

    public int VillageId { get; set; }
    public int QuestionId { get { return questionId; } set { questionId = value; } }
    public int ActivityId { get { return activityId; } set { activityId = value; } }
    public string QuestionRegDate { get { return questionRegDate; } set { questionRegDate = value; } }
    public string QuestionDescription { get { return questionDescription; } set { questionDescription = value; } }

    public int InsertActivityQuestionMaster()
    {
        try 
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@ActivityId", ActivityId);
            p[1] = new SqlParameter("@questionDescription", questionDescription);
            return SqlHelper.ExecuteNonQuery(Connection .con, CommandType.StoredProcedure, "sp_ActivityQuestionMaster_Insert", p);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet GetAllQuestionsToanswer()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Connection.con , CommandType.StoredProcedure, "sp_GetActivityQuestionMasterToAnswer");
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public string strAnswerProvided { get; set; }
    public string Description { get; set; }
    public string DocFileName { get; set; }

    public int InsertActivityQuestionAnswerMaster()
    {
        try 
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@ActivityId", ActivityId );
            p[1] = new SqlParameter("@QuestionId", questionId );
            p[2] = new SqlParameter("@AnswersProvided", strAnswerProvided);
            p[3] = new SqlParameter("@Description", Description);
            p[4] = new SqlParameter("@DocumentFileName", DocFileName);
            return SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "sp_ActivityQuestionAnswerMaster_Insert", p);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public int MemberId { get; set; }

    public string MemberActivityQuestionraiseMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@ActivityId", ActivityId);
            p[1] = new SqlParameter("@VillageId", VillageId);
            p[2] = new SqlParameter("@QuestionDescription", QuestionDescription);
            p[3] = new SqlParameter("@MemberId", MemberId);
            
            p[4] = new SqlParameter("@OutMsg", SqlDbType.VarChar,100);
            p[4].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "sp_MemberActivityQuestionraiseMaster_Insert", p);
            return p[4].Value.ToString();
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}
