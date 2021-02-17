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
/// Summary description for Cls_MemberQuestionAnswers
/// </summary>
public class Cls_MemberQuestionAnswers
{

    private int answerId;
    private int questionId;
    private string answersProvided;
    private int activityId;
    private string questionDescription;
    // constructor
    public Cls_MemberQuestionAnswers()
    {
    }
    public int ActivityId { get { return activityId; } set { activityId = value; } }
    public int AnswerId { get { return answerId; } set { answerId = value; } }
    public int QuestionId { get { return questionId; } set { questionId = value; } }
    public string AnswersProvided { get { return answersProvided; } set { answersProvided = value; } }
    public string QuestionDescription { get { return questionDescription; } set { questionDescription = value; } }
    public int InsertActivityQuestionMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@ActivityId", ActivityId);
            p[1] = new SqlParameter("@questionDescription", QuestionDescription);
            return SqlHelper.ExecuteNonQuery(Connection.con , CommandType.StoredProcedure, "sp_ActivityQuestionMaster_Insert", p);
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

    public int InsertActivityQuestionAnswerMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@ActivityId", ActivityId);
            p[1] = new SqlParameter("@questionDescription", questionDescription);
            return 0;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}